using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace App1.Views
{
    internal class AcceuilViewModel
    {
        //Commande de notre liste
        public ICommand AddDoctorCommand => new Command(AddDoctor);
        public ICommand RemoveDoctorCommand => new Command(RemoveDoctor);
        public ICommand UdapteDoctorCommand => new Command(UpdateDoctor);
        public ObservableCollection<string> Doctors { get; set; }
        public string DoctorName { get; set; }

        public string SelectedDoctor{ get; set; }
        
        //Creer une liste
        public AcceuilViewModel()
        {
           Doctors = new ObservableCollection<string>();
           
            Doctors.Add("Daniel Villeneuve");
            Doctors.Add("Beltane Moquin");
            Doctors.Add("Aimé Deslauriers");
            Doctors.Add("Gustave Aucoin");
            Doctors.Add("Chapin Ruais");
            Doctors.Add("Quennel Lebel");

        }
        //Ajoute des elements dans notre liste
        public void AddDoctor()
        {
            Doctors.Add(DoctorName);
        }
        //Supprime dess elements dans notre liste
        public void RemoveDoctor()
        {
            Doctors.Remove(SelectedDoctor);
        }
        //Met a jour des elements de notre liste
        public void UpdateDoctor()
        {
            int newIndex = Doctors.IndexOf(SelectedDoctor);
            Doctors.Remove(SelectedDoctor);

            Doctors.Add(DoctorName);
            int oldIndex = Doctors.IndexOf(DoctorName);

            Doctors.Move(oldIndex, newIndex);

        }
    }
}
