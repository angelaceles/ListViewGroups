using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace ListViewGroups.ViewModel
{
    public class ListViewCode : ContentPage
    {
        private ObservableCollection<GroupModel> grouped { get; set; }

        public ListViewCode()
        {
            var lstView = new ListView();
            grouped = new ObservableCollection<GroupModel>();

            var displayGroup = new GroupModel() { LongIdentity = "Code", 
                                                  ShortIdentity = "Name" };
            var dataGroup = new GroupModel() { LongIdentity = "LastName", 
                                               ShortIdentity = "Salary" };
            displayGroup.Add(new Employee() { Code = "1", Name = "Rob" });
            displayGroup.Add(new Employee() { Code = "2", Name = "Bill" });
            displayGroup.Add(new Employee() { Code = "3", Name = "Dr. Geri-Beth" });
            displayGroup.Add(new Employee() { Code = "4", Name = "Dr. Keith" });
            displayGroup.Add(new Employee() { Code = "5", Name = "Sheri" });
            displayGroup.Add(new Employee() { Code = "6", Name = "Burt" });
            dataGroup.Add(new Employee() { LastName = "Finnerty", Salary = 354.74 });
            dataGroup.Add(new Employee() { LastName = "Wrestler", Salary = 373.13 });
            dataGroup.Add(new Employee() { LastName = "Hooper", Salary = 746.32 });
            dataGroup.Add(new Employee() { LastName = "Joyce-Purdy", Salary = 474.34 });
            dataGroup.Add(new Employee() { LastName = "Spruce", Salary = 4746.23 });
            dataGroup.Add(new Employee() { LastName = "indybrick", Salary = 842.45 });

            grouped.Add(displayGroup);
            grouped.Add(dataGroup);

            lstView.ItemsSource = grouped;
            lstView.IsGroupingEnabled = true;
            lstView.GroupDisplayBinding = new Binding("displayGroup");
            lstView.GroupShortNameBinding = new Binding("dataGroup");

            lstView.ItemTemplate = new DataTemplate(typeof(TextCell));
            lstView.ItemTemplate.SetBinding(TextCell.TextProperty, "Code");
            lstView.ItemTemplate.SetBinding(TextCell.TextProperty, "LastName");
            Content = lstView;
        }
    }
}
