using Android.App;
using Cirrious.MvvmCross.Droid.Fragging;

namespace FragmentSample.UI.Droid.Views
{
    [Activity]
    public class DetailView
        : MvxFragmentActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.Page_DetailView);
            SetDetailFragmentDataContext();
        }

        private void SetDetailFragmentDataContext()
        {
            var fragment = (DetailFragment) SupportFragmentManager.FindFragmentById(Resource.Id.detail_fragment);
            fragment.ViewModel = ViewModel;
        }
    }
}