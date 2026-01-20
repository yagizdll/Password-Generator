using System.Numerics;
using System.Security;

namespace Password_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GnrtBttn_Click(object sender, EventArgs e)
        {
            string allCharacters = "";
            string newPassword = "";
            List<char> lowerList = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'];
            List<char> upperList = ['A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'];
            List<char> numbersList = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9'];
            List<char> symbolsList = ['!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '+'];
            int total = 0;



            if (chckLL.Checked) { total += 1; }
            if (chckUL.Checked) { total += 1; }
            if (chckN.Checked) { total += 1; }
            if (chckS.Checked) { total += 1; }

            try
            {
                int passwordLength = Convert.ToInt32(textBox1.Text);
                Random rastgele = new Random();
                

                if(passwordLength < 5 || passwordLength > 30 )
                {
                    throw new ArgumentException("Lütfen 5 ile 30 arasýnda bir deðer giriniz!");
                }

                if(chckLL.Checked == false && chckN.Checked == false && chckS.Checked == false && chckUL.Checked == false)
                {
                    throw new InvalidOperationException("Devam etmek için lütfen en az bir kutucuðu iþaretleyiniz!");
                }
                
                int chckTotal = passwordLength / total;

                if (chckLL.Checked)
                {
                    for (int i = 0; i < chckTotal; i++)
                    {
                        int rastgeleIndex = rastgele.Next(0, lowerList.Count);
                        allCharacters += lowerList[rastgeleIndex];
                        lowerList.RemoveAt(rastgeleIndex);
                    }
                }

                if (chckUL.Checked)
                {
                    for (int i = 0; i < chckTotal; i++)
                    {
                        int rastgeleIndex = rastgele.Next(0, upperList.Count);
                        allCharacters += upperList[rastgeleIndex];
                        upperList.RemoveAt(rastgeleIndex);
                    }
                }

                if (chckN.Checked)
                {
                    for (int i = 0; i < chckTotal; i++)
                    {
                        int rastgeleIndex = rastgele.Next(0, numbersList.Count);
                        allCharacters += numbersList[rastgeleIndex];
                        numbersList.RemoveAt(rastgeleIndex);
                    }
                }

                if (chckS.Checked)
                {
                    for (int i = 0; i < chckTotal; i++)
                    {
                        int rastgeleIndex = rastgele.Next(0, symbolsList.Count);
                        allCharacters += symbolsList[rastgeleIndex];
                        symbolsList.RemoveAt(rastgeleIndex);
                    }
                }

                if(passwordLength - (total * chckTotal) !=0)
                {
                    if(chckLL.Checked && passwordLength - (total * chckTotal) != 0)
                    {
                        int rastgeleIndex = rastgele.Next(0, lowerList.Count);
                        allCharacters += lowerList[rastgeleIndex];
                        passwordLength--;
                    }

                if (chckN.Checked && passwordLength - (total * chckTotal) != 0)
                    {
                        int rastgeleIndex = rastgele.Next(0, numbersList.Count);
                        allCharacters += numbersList[rastgeleIndex];
                        passwordLength--;
                    }

                    if (chckS.Checked && passwordLength - (total * chckTotal) != 0)
                    {
                        int rastgeleIndex = rastgele.Next(0, symbolsList.Count);
                        allCharacters += symbolsList[rastgeleIndex];
                        passwordLength--;
                    }

                }

                List<char> allCharactersList = allCharacters.ToList();

                while (allCharactersList.Count > 0)
                {                 
                    int rastgeleIndex = rastgele.Next(0, allCharactersList.Count);
                    newPassword += allCharactersList[rastgeleIndex];
                    allCharactersList.RemoveAt(rastgeleIndex);                  
                }

                pswrd.Text = newPassword;

            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen Sayý Giriniz!", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Lütfen 5 ile 30 arasýnda bir deðer giriniz!","Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void pswrd_Click(object sender, EventArgs e)
        {
            if (pswrd.Text != "")
            {
                Clipboard.SetText(pswrd.Text);
                lblCopied.Visible = true;
                lblCopied.Text = "Kopyalandý";
                timer1.Stop();
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblCopied.Visible = false;
            timer1.Stop();

        }

      
    }
}

