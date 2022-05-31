using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Trace.Context {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.datadog.trace.context']/interface[@name='TraceScope.Continuation']"
	[Register ("com/datadog/trace/context/TraceScope$Continuation", "", "Com.Datadog.Trace.Context.ITraceScopeContinuationInvoker")]
	public partial interface ITraceScopeContinuation : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.context']/interface[@name='TraceScope.Continuation']/method[@name='activate' and count(parameter)=0]"
		[Register ("activate", "()Lcom/datadog/trace/context/TraceScope;", "GetActivateHandler:Com.Datadog.Trace.Context.ITraceScopeContinuationInvoker, Datadog_sdk_android")]
		global::Com.Datadog.Trace.Context.ITraceScope Activate ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.context']/interface[@name='TraceScope.Continuation']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler:Com.Datadog.Trace.Context.ITraceScopeContinuationInvoker, Datadog_sdk_android")]
		void Close ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.context']/interface[@name='TraceScope.Continuation']/method[@name='close' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("close", "(Z)V", "GetClose_ZHandler:Com.Datadog.Trace.Context.ITraceScopeContinuationInvoker, Datadog_sdk_android")]
		void Close (bool p0);

	}

	[global::Android.Runtime.Register ("com/datadog/trace/context/TraceScope$Continuation", DoNotGenerateAcw=true)]
	internal partial class ITraceScopeContinuationInvoker : global::Java.Lang.Object, ITraceScopeContinuation {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/trace/context/TraceScope$Continuation", typeof (ITraceScopeContinuationInvoker));

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

		public static ITraceScopeContinuation GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITraceScopeContinuation> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.datadog.trace.context.TraceScope.Continuation'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITraceScopeContinuationInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_activate;
#pragma warning disable 0169
		static Delegate GetActivateHandler ()
		{
			if (cb_activate == null)
				cb_activate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Activate);
			return cb_activate;
		}

		static IntPtr n_Activate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Context.ITraceScopeContinuation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Activate ());
		}
#pragma warning restore 0169

		IntPtr id_activate;
		public unsafe global::Com.Datadog.Trace.Context.ITraceScope Activate ()
		{
			if (id_activate == IntPtr.Zero)
				id_activate = JNIEnv.GetMethodID (class_ref, "activate", "()Lcom/datadog/trace/context/TraceScope;");
			return global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Context.ITraceScope> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_activate), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Context.ITraceScopeContinuation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		IntPtr id_close;
		public unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
		}

		static Delegate cb_close_Z;
#pragma warning disable 0169
		static Delegate GetClose_ZHandler ()
		{
			if (cb_close_Z == null)
				cb_close_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_Close_Z);
			return cb_close_Z;
		}

		static void n_Close_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Context.ITraceScopeContinuation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close (p0);
		}
#pragma warning restore 0169

		IntPtr id_close_Z;
		public unsafe void Close (bool p0)
		{
			if (id_close_Z == IntPtr.Zero)
				id_close_Z = JNIEnv.GetMethodID (class_ref, "close", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close_Z, __args);
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.datadog.trace.context']/interface[@name='TraceScope']"
	[Register ("com/datadog/trace/context/TraceScope", "", "Com.Datadog.Trace.Context.ITraceScopeInvoker")]
	public partial interface ITraceScope : global::Java.IO.ICloseable {
		bool IsAsyncPropagating {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.context']/interface[@name='TraceScope']/method[@name='isAsyncPropagating' and count(parameter)=0]"
			[Register ("isAsyncPropagating", "()Z", "GetIsAsyncPropagatingHandler:Com.Datadog.Trace.Context.ITraceScopeInvoker, Datadog_sdk_android")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.context']/interface[@name='TraceScope']/method[@name='capture' and count(parameter)=0]"
		[Register ("capture", "()Lcom/datadog/trace/context/TraceScope$Continuation;", "GetCaptureHandler:Com.Datadog.Trace.Context.ITraceScopeInvoker, Datadog_sdk_android")]
		global::Com.Datadog.Trace.Context.ITraceScopeContinuation Capture ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.context']/interface[@name='TraceScope']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler:Com.Datadog.Trace.Context.ITraceScopeInvoker, Datadog_sdk_android")]
		void Close ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.context']/interface[@name='TraceScope']/method[@name='setAsyncPropagation' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAsyncPropagation", "(Z)V", "GetSetAsyncPropagation_ZHandler:Com.Datadog.Trace.Context.ITraceScopeInvoker, Datadog_sdk_android")]
		void SetAsyncPropagation (bool p0);

	}

	[global::Android.Runtime.Register ("com/datadog/trace/context/TraceScope", DoNotGenerateAcw=true)]
	internal partial class ITraceScopeInvoker : global::Java.Lang.Object, ITraceScope {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/trace/context/TraceScope", typeof (ITraceScopeInvoker));

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

		public static ITraceScope GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITraceScope> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.datadog.trace.context.TraceScope'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITraceScopeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isAsyncPropagating;
#pragma warning disable 0169
		static Delegate GetIsAsyncPropagatingHandler ()
		{
			if (cb_isAsyncPropagating == null)
				cb_isAsyncPropagating = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsAsyncPropagating);
			return cb_isAsyncPropagating;
		}

		static bool n_IsAsyncPropagating (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Context.ITraceScope> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAsyncPropagating;
		}
#pragma warning restore 0169

		IntPtr id_isAsyncPropagating;
		public unsafe bool IsAsyncPropagating {
			get {
				if (id_isAsyncPropagating == IntPtr.Zero)
					id_isAsyncPropagating = JNIEnv.GetMethodID (class_ref, "isAsyncPropagating", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAsyncPropagating);
			}
		}

		static Delegate cb_capture;
#pragma warning disable 0169
		static Delegate GetCaptureHandler ()
		{
			if (cb_capture == null)
				cb_capture = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Capture);
			return cb_capture;
		}

		static IntPtr n_Capture (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Context.ITraceScope> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Capture ());
		}
#pragma warning restore 0169

		IntPtr id_capture;
		public unsafe global::Com.Datadog.Trace.Context.ITraceScopeContinuation Capture ()
		{
			if (id_capture == IntPtr.Zero)
				id_capture = JNIEnv.GetMethodID (class_ref, "capture", "()Lcom/datadog/trace/context/TraceScope$Continuation;");
			return global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Context.ITraceScopeContinuation> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_capture), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Context.ITraceScope> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		IntPtr id_close;
		public unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
		}

		static Delegate cb_setAsyncPropagation_Z;
#pragma warning disable 0169
		static Delegate GetSetAsyncPropagation_ZHandler ()
		{
			if (cb_setAsyncPropagation_Z == null)
				cb_setAsyncPropagation_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetAsyncPropagation_Z);
			return cb_setAsyncPropagation_Z;
		}

		static void n_SetAsyncPropagation_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Context.ITraceScope> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAsyncPropagation (p0);
		}
#pragma warning restore 0169

		IntPtr id_setAsyncPropagation_Z;
		public unsafe void SetAsyncPropagation (bool p0)
		{
			if (id_setAsyncPropagation_Z == IntPtr.Zero)
				id_setAsyncPropagation_Z = JNIEnv.GetMethodID (class_ref, "setAsyncPropagation", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAsyncPropagation_Z, __args);
		}

	}
}
