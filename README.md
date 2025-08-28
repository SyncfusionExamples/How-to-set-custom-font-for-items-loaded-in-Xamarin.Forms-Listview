# How-to-set-custom-font-for-items-loaded-in-Xamarin.Forms-Listview?

This example demonstrates how to set custom font for items loaded in Xamarin.Forms Listview.

## Sample

```xaml
<Grid RowSpacing="0">
    <syncfusion:SfListView x:Name="listView" BackgroundColor="AliceBlue"
                           AllowGroupExpandCollapse="True"
                           ItemSpacing="3" ItemSize="70"
                           ItemsSource="{Binding ContactsGrouped}">
        <syncfusion:SfListView.GroupHeaderTemplate>
            <DataTemplate x:Name="GroupHeaderTemplate">
                <ViewCell>
                    <ViewCell.View>
                        <Grid>
                            <Grid.ColumnDefinitions>
                                <ColumnDefinition Width="30" />
                                <ColumnDefinition Width="*" />
                            </Grid.ColumnDefinitions>
                            <Image x:Name="NormalImage" Grid.Column="0" HorizontalOptions="Center"
                                   Source="{Binding IsExpand, Converter={StaticResource BoolToImageConverter}}"
                                   VerticalOptions="Center"/>
                            <Label Text="{Binding Key}" Grid.Column="1"
                                   FontFamily="{StaticResource Pacifico-Font}" />
                        </Grid>
                    </ViewCell.View>
                </ViewCell>
            </DataTemplate>
        </syncfusion:SfListView.GroupHeaderTemplate>

        <syncfusion:SfListView.ItemTemplate>
            <DataTemplate>
                <ViewCell>
                    <ViewCell.View>
                        <Grid x:Name="grid" RowSpacing="1">
                            <Grid.RowDefinitions>
                                <RowDefinition Height="*" />
                                <RowDefinition Height="1" />
                            </Grid.RowDefinitions>
                            <Grid RowSpacing="1">
                                <Grid.ColumnDefinitions>
                                    <ColumnDefinition Width="50" />
                                    <ColumnDefinition Width="*" />
                                    <ColumnDefinition Width="70" />
                                </Grid.ColumnDefinitions>

                                <Grid>
                                    <Image Source="{Binding ContactImage}"
                                           VerticalOptions="Center                                
                                </Grid>
                            </Grid>
                            <StackLayout Grid.Row="1" BackgroundColor="Gray" HeightRequest="1"/>
                        </Grid>
                    </ViewCell.View>
                </ViewCell>
            </DataTemplate>
        </syncfusion:SfListView.ItemTemplate>
    </syncfusion:SfListView>
</Grid>

ViewModel.cs
public ObservableCollection<GroupResult> ContactsGrouped { get; set; }

public ContactsViewModel()
{
    var contactsInfo = new ObservableCollection<Contacts>();
    Random r = new Random();

    foreach (var cusName in CustomerNames)
    {
        var contact = new Contacts(cusName, r.Next(720, 799).ToString() + " - " + r.Next(3010, 3999).ToString());
        contact.ContactColor = Color.FromRgb(r.Next(40, 255), r.Next(40, 255), r.NextInfo.Add(contact));
    }

    var groupedContacts = contactsInfo
        .GroupBy(c => c.ContactName[0].ToString())
        .Select(g => new GroupResult(g.Key, g.ToList()))
        .ToList();

    ContactsGrouped = new ObservableCollection<GroupResult>(groupedContacts);
}
```

See [How-to-set-custom-font-for-items-loaded-in-Xamarin.Forms-Listview?](https://www.syncfusion.com/kb/9733/how-to-set-custom-font-for-items-loaded-in-xamarin-forms-listview) for more details

## Requirements to run the demo

* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/).
* Xamarin add-ons for Visual Studio (available via the Visual Studio installer).

## Troubleshooting

### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
