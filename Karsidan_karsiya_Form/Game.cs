using DevExpress.Utils.Extensions;
using Karsidan_karsiya_Form.Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace Karsidan_karsiya_Form {
    public partial class FrmGame : DevExpress.XtraEditors.XtraForm {
        SqlConnection baglanti = new SqlConnection( "Server=DESKTOP-QJ144O6\\SQLEXPRESS;database=KurtKuzu;integrated security=true;" );
        int denemesayısı=0;
        #region Tanımlamalar
        bool secimKurt = false;
        bool secimKuzu = false;
        bool secimOt = false;
        int i;
        Report report = new Report();
        string buttonText = "";
        int sayac = 0;
        DialogResult result;
        bool sonuc = false;
        int sagSol = 0; //%2=0 sag
        Oyun oyun = new Oyun();
        Main main = new Main();
        Score1 score1 = new Score1();
        #endregion

        public FrmGame() {
            InitializeComponent();
        }
        private void FrmGame_Load( object sender, EventArgs e ) {
            this.Show();
            result = main.ShowDialog();
            if ( result == DialogResult.OK ) {
                MessageBox.Show( "Kuzu Kurt ve Ot Olmak Üzere 3 Karakter vardır.\n1 Kişilik yeriniz olan bot ile tek tek karakterleri karşıya geçireceksiniz.\nKurallar\n1-Kurt ile kuzu yan yana kalmayacaktır\n2-Kuzu ile de ot baş başa kalmayacaktır\n3-Sıra ile bu karakterleri karşıya geçiriniz \n" );
                oyun.OyunaBasla();
                timer1.Enabled = true;
            }
            else {
                Application.Exit();
            }
        }
        private void pictureEdit1_Click( object sender, EventArgs e ) {
            secimKurt = false;
            secimKuzu = false;
            secimOt = false;
            if ( sagSol % 2 == 0 ) {
                kontrolLista();
                if ( buttonText != string.Empty ) {
                    switch ( buttonText ) {
                        case "Kuzu": panelSol.AddControl( btnSheep ); break;
                        case "Kurt": panelSol.AddControl( btnWolf ); break;
                        case "Ot": panelSol.AddControl( btnStack ); break;
                    }
                }
            }
            else {
                kontrolListb();
                if ( buttonText != string.Empty ) {
                    switch ( buttonText ) {
                        case "Kuzu": panelSag.AddControl( btnSheep ); break;
                        case "Kurt": panelSag.AddControl( btnWolf ); break;
                        case "Ot": panelSag.AddControl( btnStack ); break;
                    }
                }
            }
            Kontrol();
            buttonText = string.Empty;
            sagdaSeciliMi();
        }

        private void btnSheep_Click( object sender, EventArgs e ) {
            if ( !secimKuzu ) {
                buttonText = btnSheep.Text;
                if ( !btnSound.Checked ) {
                    string dosyaYolu = @"C:\Users\ilker\Desktop\Games\Sound\KuzuSesleri.wav";
                    SoundPlayer player = new SoundPlayer( dosyaYolu );
                    player.Play();
                }
                secimKuzu = true;
                secimOt = false;
                secimKurt = false;
            }
            else {
                buttonText = string.Empty;
                secimKuzu = false;

            }
            sagdaSeciliMi();
        }
        private void btnStack_Click( object sender, EventArgs e ) {
            if ( !secimOt ) {
                buttonText = btnStack.Text;
                secimOt = true;
                secimKuzu = false;
                secimKurt = false;
            }
            else {
                buttonText = string.Empty;
                secimOt = false;
            }
            sagdaSeciliMi();

        }

        private void btnWolf_Click( object sender, EventArgs e ) {
            if ( !secimKurt ) {
                buttonText = btnWolf.Text;
                if ( !btnSound.Checked ) {
                    SoundPlayer player = new SoundPlayer( @"C:\\Users\\ilker\\Desktop\\Games\\Sound\kurthırlaması.wav" );
                    player.Play();
                }
                secimKurt = true; secimKuzu = false;
                secimOt = false;
            }
            else {
                buttonText = string.Empty;
                secimKurt = false;

            }
            sagdaSeciliMi();
        }

        private void timer1_Tick_1( object sender, EventArgs e ) {
            sayac++;
            lblHalfTime.Text = sayac.ToString();
        }


        #region Kontroller
        public bool kontrolLista() {
            int index = 0;
            foreach ( var item in StaticLists.Anoktasındakiler ) {
                if ( item.GetType().Name.ToString() == buttonText ) {
                    break;
                }
                index++;
            }
            if ( buttonText != string.Empty ) {

                StaticLists.LstAdanBye( StaticLists.Anoktasındakiler.ElementAt( index ) );
            }


            if ( StaticLists.Anoktasındakiler.Count >= 2 ) {
                if ( StaticLists.Anoktasındakiler.First().YemeyiDene( StaticLists.Anoktasındakiler.Last(), out string sonuc1 ) ) {
                    MessageBox.Show( sonuc1 ); sonuc = true;
                }
                else if ( StaticLists.Anoktasındakiler.Last().YemeyiDene( StaticLists.Anoktasındakiler.First(), out string sonuc2 ) ) {
                    MessageBox.Show( sonuc2 ); sonuc = true;
                }
            }
            if ( !sonuc ) {
                pictureEdit1.Location = new System.Drawing.Point( 330, 198 );
                panelSag.Enabled = false;
                panelSol.Enabled = true;
                panelSol.AddControl( btnHuman );
                Image img = pictureEdit1.Image;
                img.RotateFlip( RotateFlipType.Rotate180FlipNone );
                pictureEdit1.Image = img;
                pictureEdit1.Refresh();
                sagSol++;
                sagdaSeciliMi();

            }
            return sonuc;
        }
        public bool kontrolListb() {
            int index = 0;
            foreach ( var item in StaticLists.Bnoktasındakiler ) {
                if ( item.GetType().Name.ToString() == buttonText ) {
                    break;
                }
                index++;
            }

            if ( buttonText != string.Empty ) {
                StaticLists.LstBdenAya( StaticLists.Bnoktasındakiler.ElementAt( index ) );
            }
            if ( StaticLists.Bnoktasındakiler.Count == 2 ) {
                if ( StaticLists.Bnoktasındakiler.First().YemeyiDene( StaticLists.Bnoktasındakiler.Last(), out string sonuc3 ) ) {
                    MessageBox.Show( sonuc3 ); sonuc = true;
                }
                else if ( StaticLists.Bnoktasındakiler.Last().YemeyiDene( StaticLists.Bnoktasındakiler.First(), out string sonuc4 ) ) {
                    MessageBox.Show( sonuc4 ); sonuc = true;
                }
            }
            if ( !sonuc ) {
                pictureEdit1.Location = new System.Drawing.Point( 400, 198 );

                panelSag.Enabled = true;
                panelSol.Enabled = false;
                panelSag.AddControl( btnHuman ); Image img = pictureEdit1.Image;
                img.RotateFlip( RotateFlipType.Rotate180FlipNone );
                pictureEdit1.Image = img;
                pictureEdit1.Refresh();
                sagSol++;
                sagdaSeciliMi();
            }
            return sonuc;
        }
        void Kontrol() {
            string errMessage;
            if ( sonuc ) {
                errMessage = oyun.Durum( sonuc );
                timer1.Stop();

                report.labelControl1.Text = errMessage;
                result = report.ShowDialog();
                if ( result == DialogResult.OK ) {
                    BasaDon();denemesayısı++;
                }
                else {
                    Application.Exit();
                }
            }
            else if ( !sonuc && StaticLists.Bnoktasındakiler.Count == 3 ) {
                timer1.Stop();
                i++;
                ///ado net balanatıstr
                if ( baglanti.State != ConnectionState.Open )
                    baglanti.Open();
                SqlCommand cmd = new SqlCommand( $"insert into Games(Sure, KullaniciAdi, Tarih, DenemeSayısı) values('{int.Parse( lblHalfTime.Text )}', '{main.textEdit1.Text} {i}', '{DateTime.Now.ToString( "yyyy-MM-dd HH:mm:ss" )}', '{denemesayısı}')", baglanti );
                cmd.ExecuteNonQuery();

                if ( baglanti.State != ConnectionState.Closed )
                    baglanti.Close();

                //score1.adSkor.Add( $"{main.textEdit1.Text} {i}", int.Parse( lblHalfTime.Text ) );
                result = score1.ShowDialog();
                if ( DialogResult.OK == result ) {
                    BasaDon();
                }
                else {
                    Application.Exit();
                }
            }
      

        }
        void BasaDon() {
            if ( sagSol % 2 == 1 ) {
                Image img = pictureEdit1.Image;
                img.RotateFlip( RotateFlipType.Rotate180FlipNone );
                pictureEdit1.Image = img;
                pictureEdit1.Refresh();
            }
            oyun.OyunaBasla();
            sonuc = false;
            sayac = 0;
            sagSol = 0;
            timer1.Start();
            panelSag.Enabled = true;
            panelSol.Enabled = false;
            panelSag.AddControl( btnHuman );
            panelSag.AddControl( btnSheep );
            panelSag.AddControl( btnStack );
            panelSag.AddControl( btnWolf );
            buttonText = string.Empty;
            pictureEdit1.Location = new System.Drawing.Point( 400, 198 );
        }
        void sagdaSeciliMi() {
            if ( sagSol % 2 == 0 && buttonText != string.Empty && ( secimKurt || secimKuzu || secimOt ) ) {
                pictureEdit1.Enabled = true;
            }
            else if ( sagSol % 2 == 1 ) {
                pictureEdit1.Enabled = true;
            }
            else {
                pictureEdit1.Enabled = false;
            }

        }
        #endregion

        private void btnHuman_Click( object sender, EventArgs e ) {
            buttonText = string.Empty;
        }
    }
}