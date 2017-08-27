using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfStepByStep1
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			this.InitializeComponent();			

			//	Add some contacts.
			ViewModel.Contacts.Add(new Contact() {Name = "James", Email = "james@mail.com", PhoneNumber = "01234 111111"} );
			ViewModel.Contacts.Add(new Contact() {Name = "Bob", Email = "bob@mail.com", PhoneNumber = "01234 222222"} );
			ViewModel.Contacts.Add(new Contact() {Name = "Emma", Email = "emma@mail.com", PhoneNumber = "01234 333333"} );
		}

		private void Window_Loaded(object sender, System.Windows.RoutedEventArgs e)
		{
			//	Set the 'SelectedContact' of the view model to the first contact.
			ViewModel.SelectedContact = ViewModel.Contacts[0];
		}

		private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			//	Create a new contact.
			Contact contact = new Contact() {Name = "New Contact"};
			
			//	Add it to the list.
			ViewModel.Contacts.Add(contact);
			
			//	Set it as the selected contact.
			ViewModel.SelectedContact = contact;
		}
	}
}