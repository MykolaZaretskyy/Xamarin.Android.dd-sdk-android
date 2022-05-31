using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Android.Tracing {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.datadog.android.tracing']/interface[@name='TracedRequestListener']"
	[Register ("com/datadog/android/tracing/TracedRequestListener", "", "Com.Datadog.Android.Tracing.ITracedRequestListenerInvoker")]
	public partial interface ITracedRequestListener : IJavaObject, IJavaPeerable {
	}

	[global::Android.Runtime.Register ("com/datadog/android/tracing/TracedRequestListener", DoNotGenerateAcw=true)]
	internal partial class ITracedRequestListenerInvoker : global::Java.Lang.Object, ITracedRequestListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/tracing/TracedRequestListener", typeof (ITracedRequestListenerInvoker));

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

		public static ITracedRequestListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITracedRequestListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.datadog.android.tracing.TracedRequestListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITracedRequestListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}

	[global::Android.Runtime.Register ("mono/com/datadog/android/tracing/TracedRequestListenerImplementor")]
	internal sealed partial class ITracedRequestListenerImplementor : global::Java.Lang.Object, ITracedRequestListener {
		public ITracedRequestListenerImplementor () : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/datadog/android/tracing/TracedRequestListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
		}

		internal static bool __IsEmpty (ITracedRequestListenerImplementor value)
		{
			return true;
		}

	}
}
