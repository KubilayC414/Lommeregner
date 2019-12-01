using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnBtnPlusClicked(object sender, EventArgs e) //Når man trykker på BtnPlus
    {
        string entry1AsaString = entry1.Text; //Laver vi teksten i entry 1 om til variablen entry1AsaString
        string entry2AsaString = entry2.Text; //Laver vi teksten i entry 2 om til variablen entry2AsaString

        bool isEntry1ANumber = double.TryParse(entry1AsaString, out double nummer1); //Vi bryger TryParse til at convertere vores string til en double nummer 1 og tjekker om det er true via bool.
        bool isEntry2ANumber = double.TryParse(entry2AsaString, out double nummer2); //-II- nummer 2

        if (isEntry1ANumber == true && isEntry2ANumber == true) //Hvis begge entry variabler er true
        {
            double Resultat = nummer1 + nummer2; //Gemmer vi nummer1 + nummer2 i Resultat
            entry3.Text = Resultat.ToString(); //Og outputter i entry3.text efter at vi konverterer til string
        }
        else {
            entry3.Text = "Entries has to be a number."; // Skriver fejlbesked, hvis if er false
        }
    }

    protected void OnBtnMinusClicked(object sender, EventArgs e)
    {
        string entry1AsaString = entry1.Text;
        string entry2AsaString = entry2.Text;
        bool isEntry1ANumber = double.TryParse(entry1AsaString, out double nummer1);
        bool isEntry2ANumber = double.TryParse(entry2AsaString, out double nummer2);

        if (isEntry1ANumber == true && isEntry2ANumber == true)
        {
            double Resultat = nummer1 - nummer2;
            entry3.Text = Resultat.ToString();
        }
        else
        {
            entry3.Text = "Entries has to be a number."; // Skriver fejlbesked, hvis if er false
        }
    }

    protected void OnBtnMultiplyClicked(object sender, EventArgs e)
    {
        string entry1AsaString = entry1.Text;
        string entry2AsaString = entry2.Text;
        bool isEntry1ANumber = double.TryParse(entry1AsaString, out double nummer1);
        bool isEntry2ANumber = double.TryParse(entry2AsaString, out double nummer2);

        if (isEntry1ANumber == true && isEntry2ANumber == true)
        {
            double Resultat = nummer1 * nummer2;
            entry3.Text = Resultat.ToString();
        }
        else
        {
            entry3.Text = "Entries has to be a number."; // Skriver fejlbesked, hvis if er false
        }
    }

    protected void OnBtnDivideClicked(object sender, EventArgs e)
    {
        string entry1AsaString = entry1.Text;
        string entry2AsaString = entry2.Text;
        bool isEntry1ANumber = double.TryParse(entry1AsaString, out double nummer1);
        bool isEntry2ANumber = double.TryParse(entry2AsaString, out double nummer2);

        if (isEntry1ANumber == true && isEntry2ANumber == true)
        {
            double Resultat = nummer1 / nummer2;
            entry3.Text = Resultat.ToString();
        }
        else
        {
            entry3.Text = "Entries has to be a number."; // Skriver fejlbesked, hvis if er false
        }
    }

    protected void OnBtnClearClicked(object sender, EventArgs e) //Når clear knappen bliver trykket
    {
        entry1.Text = String.Empty; //Teksten i entry1 skal være empty
        entry2.Text = String.Empty; //Teksten i entry1 skal være empty
        entry3.Text = String.Empty; //Teksten i entry1 skal være empty
    }
}