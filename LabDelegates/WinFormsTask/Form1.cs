using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsTask
{
	public partial class Form1 : Form
	{
		public delegate void ButtonsCallBack();
		private ButtonsCallBack buttonClickEvent;

		public Form1()
		{
			InitializeComponent();		
		}

		//супермегакнопка
		private void button4_Click(object sender, EventArgs e)
		{
			MessageBox.Show("я супермегакнопка, \nі мене цього не позбавиш!");
		}

		//кнопка прозорості
		private void button1_Click(object sender, EventArgs e)
		{
			buttonClickEvent = ChangeFormOpacity;
			buttonClickEvent();
		}

		private void ChangeFormOpacity()
		{
			this.Opacity = this.Opacity == 1 ? 0.70 : 1;
		}

		//колір тла
		private void button2_Click(object sender, EventArgs e)
		{
			buttonClickEvent = ChangeFormColor;
			buttonClickEvent();
		}

		private void ChangeFormColor()
		{
			this.BackColor = this.BackColor != Color.Yellow ? Color.Yellow : Color.Gray;
		}

		//hello world
		private void button3_Click(object sender, EventArgs e)
		{
			buttonClickEvent = ShowMessageBox;
			buttonClickEvent();
		}

		private void ShowMessageBox()
		{
			MessageBox.Show("hello world!");
		}

		//поглинання кнопки "Прозорість"
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked) button4.Click += OpacityEvent;
			else button4.Click -= OpacityEvent;
		}

		private void OpacityEvent (object sender, EventArgs e)
		{
			buttonClickEvent = ChangeFormOpacity;
			buttonClickEvent();
		}


		//Поглинання кнопки "Колір тла"
		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox2.Checked) button4.Click += ColorEvent;
			else button4.Click -= ColorEvent;
		}

		private void ColorEvent(object sender, EventArgs e)
		{
			buttonClickEvent = ChangeFormColor;
			buttonClickEvent();
		}


		//поглинання кнопки Hello world
		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox3.Checked) button4.Click += MessageEvent;
			else button4.Click -= MessageEvent;
		}

		private void MessageEvent(object sender, EventArgs e)
		{
			buttonClickEvent = ShowMessageBox;
			buttonClickEvent();
		}	
	}
}
