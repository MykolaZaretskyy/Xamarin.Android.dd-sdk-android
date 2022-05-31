using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Android.Rum {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumActionType']"
	[global::Android.Runtime.Register ("com/datadog/android/rum/RumActionType", DoNotGenerateAcw=true)]
	public sealed partial class RumActionType : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumActionType']/field[@name='CLICK']"
		[Register ("CLICK")]
		public static global::Com.Datadog.Android.Rum.RumActionType Click {
			get {
				const string __id = "CLICK.Lcom/datadog/android/rum/RumActionType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.RumActionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumActionType']/field[@name='CUSTOM']"
		[Register ("CUSTOM")]
		public static global::Com.Datadog.Android.Rum.RumActionType Custom {
			get {
				const string __id = "CUSTOM.Lcom/datadog/android/rum/RumActionType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.RumActionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumActionType']/field[@name='SCROLL']"
		[Register ("SCROLL")]
		public static global::Com.Datadog.Android.Rum.RumActionType Scroll {
			get {
				const string __id = "SCROLL.Lcom/datadog/android/rum/RumActionType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.RumActionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumActionType']/field[@name='SWIPE']"
		[Register ("SWIPE")]
		public static global::Com.Datadog.Android.Rum.RumActionType Swipe {
			get {
				const string __id = "SWIPE.Lcom/datadog/android/rum/RumActionType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.RumActionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumActionType']/field[@name='TAP']"
		[Register ("TAP")]
		public static global::Com.Datadog.Android.Rum.RumActionType Tap {
			get {
				const string __id = "TAP.Lcom/datadog/android/rum/RumActionType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.RumActionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/RumActionType", typeof (RumActionType));

		internal static IntPtr class_ref {
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
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		internal RumActionType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumActionType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/datadog/android/rum/RumActionType;", "")]
		public static unsafe global::Com.Datadog.Android.Rum.RumActionType ValueOf (string p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/datadog/android/rum/RumActionType;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.RumActionType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumActionType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/datadog/android/rum/RumActionType;", "")]
		public static unsafe global::Com.Datadog.Android.Rum.RumActionType[] Values ()
		{
			const string __id = "values.()[Lcom/datadog/android/rum/RumActionType;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Datadog.Android.Rum.RumActionType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Datadog.Android.Rum.RumActionType));
			} finally {
			}
		}

	}
}
