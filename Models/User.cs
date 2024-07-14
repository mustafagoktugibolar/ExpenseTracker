
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTracker.Models
{
    public class User : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private int id;
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged(nameof(Id));
            }
        }
        [Required]
        [MaxLength(50)]
        private string username;
        public string Username
        {
            get { return username; }
            set
            {
                username = value;
                OnPropertyChanged(nameof(Username));
            }
        }
        [EmailAddress]
        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                OnPropertyChanged(nameof(Email));
            }
        }
        [DataType(DataType.Password)]
        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged(nameof(Password));
            }
        }
        [DataType(DataType.PhoneNumber)]
        private string phoneNumber;
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                phoneNumber = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }

        private ObservableCollection<Expense> Expenses;
        public ObservableCollection<Expense> expenses
        {
            get { return Expenses; }
            set
            {
                Expenses = value;
                OnPropertyChanged(nameof(expenses));
            }
        }

        private ObservableCollection<Income> Incomes;
        public ObservableCollection<Income> incomes
        {
            get { return Incomes; }
            set
            {
                Incomes = value;
                OnPropertyChanged(nameof(incomes));
            }
        }
    }
}
