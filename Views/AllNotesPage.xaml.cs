namespace Notes.Views;

public partial class AllNotesPage : ContentPage
{
    private void ContentPage_NavigatedTo(object sender, NavigatedToEventArgs e)
    {
        notesCollection.SelectedItem = null;
    }
}