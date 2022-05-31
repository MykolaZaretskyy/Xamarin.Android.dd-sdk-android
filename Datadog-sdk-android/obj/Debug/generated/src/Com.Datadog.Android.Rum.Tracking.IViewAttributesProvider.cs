using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Android.Rum.Tracking {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.datadog.android.rum.tracking']/interface[@name='ViewAttributesProvider']"
	[Register ("com/datadog/android/rum/tracking/ViewAttributesProvider", "", "Com.Datadog.Android.Rum.Tracking.IViewAttributesProviderInvoker")]
	public partial interface IViewAttributesProvider : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.tracking']/interface[@name='ViewAttributesProvider']/method[@name='extractAttributes' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("extractAttributes", "(Landroid/view/View;Ljava/util/Map;)V", "GetExtractAttributes_Landroid_view_View_Ljava_util_Map_Handler:Com.Datadog.Android.Rum.Tracking.IViewAttributesProviderInvoker, Datadog_sdk_android")]
		void ExtractAttributes (global::Android.Views.View view, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> attributes);

	}

	[global::Android.Runtime.Register ("com/datadog/android/rum/tracking/ViewAttributesProvider", DoNotGenerateAcw=true)]
	internal partial class IViewAttributesProviderInvoker : global::Java.Lang.Object, IViewAttributesProvider {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/tracking/ViewAttributesProvider", typeof (IViewAttributesProviderInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IViewAttributesProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IViewAttributesProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.datadog.android.rum.tracking.ViewAttributesProvider'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IViewAttributesProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_extractAttributes_Landroid_view_View_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetExtractAttributes_Landroid_view_View_Ljava_util_Map_Handler ()
		{
			if (cb_extractAttributes_Landroid_view_View_Ljava_util_Map_ == null)
				cb_extractAttributes_Landroid_view_View_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_ExtractAttributes_Landroid_view_View_Ljava_util_Map_);
			return cb_extractAttributes_Landroid_view_View_Ljava_util_Map_;
		}

		static void n_ExtractAttributes_Landroid_view_View_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view, IntPtr native_attributes)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Tracking.IViewAttributesProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
			var attributes = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_attributes, JniHandleOwnership.DoNotTransfer);
			__this.ExtractAttributes (view, attributes);
		}
#pragma warning restore 0169

		IntPtr id_extractAttributes_Landroid_view_View_Ljava_util_Map_;
		public unsafe void ExtractAttributes (global::Android.Views.View view, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> attributes)
		{
			if (id_extractAttributes_Landroid_view_View_Ljava_util_Map_ == IntPtr.Zero)
				id_extractAttributes_Landroid_view_View_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "extractAttributes", "(Landroid/view/View;Ljava/util/Map;)V");
			IntPtr native_attributes = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (attributes);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
			__args [1] = new JValue (native_attributes);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_extractAttributes_Landroid_view_View_Ljava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_attributes);
		}

	}
}
