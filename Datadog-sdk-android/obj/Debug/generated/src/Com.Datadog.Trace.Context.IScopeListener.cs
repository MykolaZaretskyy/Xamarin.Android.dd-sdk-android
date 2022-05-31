using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Trace.Context {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.datadog.trace.context']/interface[@name='ScopeListener']"
	[Register ("com/datadog/trace/context/ScopeListener", "", "Com.Datadog.Trace.Context.IScopeListenerInvoker")]
	public partial interface IScopeListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.context']/interface[@name='ScopeListener']/method[@name='afterScopeActivated' and count(parameter)=0]"
		[Register ("afterScopeActivated", "()V", "GetAfterScopeActivatedHandler:Com.Datadog.Trace.Context.IScopeListenerInvoker, Datadog_sdk_android")]
		void AfterScopeActivated ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.context']/interface[@name='ScopeListener']/method[@name='afterScopeClosed' and count(parameter)=0]"
		[Register ("afterScopeClosed", "()V", "GetAfterScopeClosedHandler:Com.Datadog.Trace.Context.IScopeListenerInvoker, Datadog_sdk_android")]
		void AfterScopeClosed ();

	}

	[global::Android.Runtime.Register ("com/datadog/trace/context/ScopeListener", DoNotGenerateAcw=true)]
	internal partial class IScopeListenerInvoker : global::Java.Lang.Object, IScopeListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/trace/context/ScopeListener", typeof (IScopeListenerInvoker));

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

		public static IScopeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IScopeListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.datadog.trace.context.ScopeListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IScopeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_afterScopeActivated;
#pragma warning disable 0169
		static Delegate GetAfterScopeActivatedHandler ()
		{
			if (cb_afterScopeActivated == null)
				cb_afterScopeActivated = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_AfterScopeActivated);
			return cb_afterScopeActivated;
		}

		static void n_AfterScopeActivated (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Context.IScopeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AfterScopeActivated ();
		}
#pragma warning restore 0169

		IntPtr id_afterScopeActivated;
		public unsafe void AfterScopeActivated ()
		{
			if (id_afterScopeActivated == IntPtr.Zero)
				id_afterScopeActivated = JNIEnv.GetMethodID (class_ref, "afterScopeActivated", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_afterScopeActivated);
		}

		static Delegate cb_afterScopeClosed;
#pragma warning disable 0169
		static Delegate GetAfterScopeClosedHandler ()
		{
			if (cb_afterScopeClosed == null)
				cb_afterScopeClosed = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_AfterScopeClosed);
			return cb_afterScopeClosed;
		}

		static void n_AfterScopeClosed (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Context.IScopeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AfterScopeClosed ();
		}
#pragma warning restore 0169

		IntPtr id_afterScopeClosed;
		public unsafe void AfterScopeClosed ()
		{
			if (id_afterScopeClosed == IntPtr.Zero)
				id_afterScopeClosed = JNIEnv.GetMethodID (class_ref, "afterScopeClosed", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_afterScopeClosed);
		}

	}

	[global::Android.Runtime.Register ("mono/com/datadog/trace/context/ScopeListenerImplementor")]
	internal sealed partial class IScopeListenerImplementor : global::Java.Lang.Object, IScopeListener {

		object sender;

		public IScopeListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/datadog/trace/context/ScopeListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

		#pragma warning disable 0649
		public EventHandler AfterScopeActivatedHandler;
		#pragma warning restore 0649

		public void AfterScopeActivated ()
		{
			var __h = AfterScopeActivatedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		#pragma warning disable 0649
		public EventHandler AfterScopeClosedHandler;
		#pragma warning restore 0649

		public void AfterScopeClosed ()
		{
			var __h = AfterScopeClosedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IScopeListenerImplementor value)
		{
			return value.AfterScopeActivatedHandler == null && value.AfterScopeClosedHandler == null;
		}

	}
}
