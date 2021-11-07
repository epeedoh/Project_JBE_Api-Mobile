using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using StepProgressBarSample.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Android.Widget.Button), typeof(CustomButton))]
namespace StepProgressBarSample.Droid
{
	public class CustomButton : ButtonRenderer
	{
		//protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
		//{
		//	base.OnElementChanged(e);

		//	if (Control != null)
		//	{

		//	}
		//}
	}
}
