using System.Security.Cryptography;
using System.Text;

namespace ElGamal_Signature
{
    public partial class Main : Form
    {
        ElGamal elGamal = new ElGamal();
        public Main()
        {
            InitializeComponent();
        }

        private void signMessage(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxMessage.Text))
            {
                MessageBox.Show("Enter a message to sign!", "Sign message");
                return;
            }

            if (elGamal.IsEmptyKey())
            {
                MessageBox.Show("Cant sign message without public key!", "Sign message");
                return;
            }

            if (elGamal.GetKey().x == 0)
            {
                MessageBox.Show("Cant sign message without private key!", "Sign message");
                return;
            }

            // Compute message digest with md5 hash
            MD5 md5 = MD5.Create();
            byte[] message = Encoding.Default.GetBytes(textBoxMessage.Text);
            byte[] digest = md5.ComputeHash(message);
            textBoxDigest.Text = BitConverter.ToString(digest).Replace("-", " ");

            byte[] signature_bytes = elGamal.Sign(digest);

            // Output signature in hex format
            textBoxSignature.Text = BitConverter.ToString(signature_bytes).Replace("-", " ");
        }

        private void verifyMessage(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxMessage.Text))
            {
                MessageBox.Show("Enter a message to verify!", "Verify signature");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxSignature.Text))
            {
                MessageBox.Show("Enter a signature to verify!", "Verify signature");
                return;
            }

            if (elGamal.IsEmptyKey())
            {
                MessageBox.Show("Cant verify signature without public key!", "Verify signature");
                return;
            }

            MD5 md5 = MD5.Create();
            byte[] message = Encoding.Default.GetBytes(textBoxMessage.Text);
            byte[] digest = md5.ComputeHash(message);
            textBoxDigest.Text = BitConverter.ToString(digest).Replace("-", " ");
            if (elGamal.Verify(digest) == true) MessageBox.Show("Sign verified", "Verify signature");
            else MessageBox.Show("Sign not verified", "Verify signature");
        }

        private void btnPrivateKey_Click(object sender, EventArgs e)
        {
            if (textBoxX.UseSystemPasswordChar)
            {
                textBoxX.UseSystemPasswordChar = false;
                buttonPrivateKey.Text = "Hide";
            }
            else
            {
                textBoxX.UseSystemPasswordChar = true;
                buttonPrivateKey.Text = "Show";
            }
        }

        private void openFile(object sender, EventArgs e)
        {
            ofd.FileName = "";
            ofd.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.Cancel) return;

            textBoxMessage.Text = File.ReadAllText(ofd.FileName);
        }

        private void openSignature(object sender, EventArgs e)
        {
            ofd.FileName = "";
            ofd.Filter = "ElGamal signature(*.sign)|*.sign";
            if (ofd.ShowDialog() == DialogResult.Cancel) return;

            string[] signature = File.ReadAllLines(ofd.FileName);
            Signature sign = new Signature
            {
                r = new BigInteger(signature[0], 10),
                s = new BigInteger(signature[1], 10)
            };
            elGamal.SetSignature(sign);

            byte[] signature_bytes = elGamal.GetSignatureBytes();
            textBoxSignature.Text = BitConverter.ToString(signature_bytes).Replace("-", " ");
        }

        private void saveSignature(object sender, EventArgs e)
        {
            sfd.FileName = "";
            sfd.Filter = "ElGamal signature(*.sign)|*.sign";
            if (sfd.ShowDialog() == DialogResult.Cancel) return;

            Signature sign = elGamal.GetSignature();
            string[] signature = { sign.r.ToString(), sign.s.ToString() };
            File.WriteAllLines(sfd.FileName, signature);

            MessageBox.Show("Signature saved in " + sfd.FileName, "Save signature");
        }

        private void GenerateKey(object sender, EventArgs e)
        {
            elGamal.CreateKey();
            Key key = elGamal.GetKey();
            textBoxP.Text = key.p.ToString();
            textBoxG.Text = key.g.ToString();
            textBoxY.Text = key.y.ToString();
            textBoxX.Text = key.x.ToString();
        }

        private void importPublicKey(object sender, EventArgs e)
        {
            ofd.FileName = "";
            ofd.Filter = "ElGamal public key(*.pub)|*.pub";
            if (ofd.ShowDialog() == DialogResult.Cancel) return;

            string[] key_lines = File.ReadAllLines(ofd.FileName);
            textBoxP.Text = key_lines[0];
            textBoxG.Text = key_lines[1];
            textBoxY.Text = key_lines[2];

            Key key = new Key
            {
                p = new BigInteger(key_lines[0], 10),
                g = new BigInteger(key_lines[1], 10),
                y = new BigInteger(key_lines[2], 10),
                x = new BigInteger(0)
            };

            elGamal.SetKey(key);
        }

        private void exportPublicKey(object sender, EventArgs e)
        {
            sfd.FileName = "";
            sfd.Filter = "ElGamal public key(*.pub)|*.pub";
            if (sfd.ShowDialog() == DialogResult.Cancel) return;

            string[] key = { textBoxP.Text, textBoxG.Text, textBoxY.Text };
            File.WriteAllLines(sfd.FileName, key);
            MessageBox.Show("Public key saved in " + sfd.FileName, "Export public key");
        }

        private void importPrivateKey(object sender, EventArgs e)
        {
            ofd.FileName = "";
            ofd.Filter = "ElGamal private key(*.pk)|*.pk";
            if (ofd.ShowDialog() == DialogResult.Cancel) return;

            string key = File.ReadAllText(ofd.FileName);
            textBoxX.Text = key;
            elGamal.SetPrivateKey(new BigInteger(key, 10));
        }

        private void exportPrivateKey(object sender, EventArgs e)
        {
            sfd.FileName = "";
            sfd.Filter = "ElGamal private key(*.pk)|*.pk";
            if (sfd.ShowDialog() == DialogResult.Cancel) return;

            File.WriteAllText(sfd.FileName, textBoxX.Text);
            MessageBox.Show("Private key saved in " + sfd.FileName, "Export private key");
        }
    }
}
