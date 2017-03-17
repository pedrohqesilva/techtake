using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace techtake
{	
	public partial class FadeInicial : Form
	{
		bool Fade = false, splatTime = false;
        public static string idLogado, nomeLogado, tipoLogado;

		public FadeInicial()
		{
			InitializeComponent();
			this.Opacity = 0;
			
			fadeTime.Start();
		}

		void FadeTimer(string tipo)
		{
			switch(tipo)
			{
				case "In":
					this.Opacity += 0.1;
					
					if(this.Opacity == 1)
					{
						Fade = true;
						splatTime = true;
					}
					break;
					
				case "Out":
					if(splatTime == true)
					{
						fadeTime.Interval = 1500;
						splatTime = false;
					}
					else
					{
						fadeTime.Interval = 25;
						this.Opacity -= 0.1;
					}
					
					if(this.Opacity == 0)
					{
						Fade = false;
						fadeTime.Stop();
						this.Hide();

                        frmLogin Login = new frmLogin();
                        Login.Show();
                    }
					break;
			}
		}
		
		void FadeTimeTick(object sender, EventArgs e)
		{
			if(Fade)
				FadeTimer("Out");
			else
				FadeTimer("In");
		}
	}
}
