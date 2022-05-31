using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Trace.Api.Interceptor {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.datadog.trace.api.interceptor']/interface[@name='TraceInterceptor']"
	[Register ("com/datadog/trace/api/interceptor/TraceInterceptor", "", "Com.Datadog.Trace.Api.Interceptor.ITraceInterceptorInvoker")]
	public partial interface ITraceInterceptor : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api.interceptor']/interface[@name='TraceInterceptor']/method[@name='onTraceComplete' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;? extends com.datadog.trace.api.interceptor.MutableSpan&gt;']]"
		[Register ("onTraceComplete", "(Ljava/util/Collection;)Ljava/util/Collection;", "GetOnTraceComplete_Ljava_util_Collection_Handler:Com.Datadog.Trace.Api.Interceptor.ITraceInterceptorInvoker, Datadog_sdk_android")]
		global::System.Collections.Generic.ICollection<global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan> OnTraceComplete (global::System.Collections.Generic.ICollection<global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan> p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api.interceptor']/interface[@name='TraceInterceptor']/method[@name='priority' and count(parameter)=0]"
		[Register ("priority", "()I", "GetPriorityHandler:Com.Datadog.Trace.Api.Interceptor.ITraceInterceptorInvoker, Datadog_sdk_android")]
		int Priority ();

	}

	[global::Android.Runtime.Register ("com/datadog/trace/api/interceptor/TraceInterceptor", DoNotGenerateAcw=true)]
	internal partial class ITraceInterceptorInvoker : global::Java.Lang.Object, ITraceInterceptor {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/trace/api/interceptor/TraceInterceptor", typeof (ITraceInterceptorInvoker));

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

		public static ITraceInterceptor GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITraceInterceptor> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.datadog.trace.api.interceptor.TraceInterceptor'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITraceInterceptorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onTraceComplete_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetOnTraceComplete_Ljava_util_Collection_Handler ()
		{
			if (cb_onTraceComplete_Ljava_util_Collection_ == null)
				cb_onTraceComplete_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_OnTraceComplete_Ljava_util_Collection_);
			return cb_onTraceComplete_Ljava_util_Collection_;
		}

		static IntPtr n_OnTraceComplete_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Interceptor.ITraceInterceptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaCollection<global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaCollection<global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan>.ToLocalJniHandle (__this.OnTraceComplete (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_onTraceComplete_Ljava_util_Collection_;
		public unsafe global::System.Collections.Generic.ICollection<global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan> OnTraceComplete (global::System.Collections.Generic.ICollection<global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan> p0)
		{
			if (id_onTraceComplete_Ljava_util_Collection_ == IntPtr.Zero)
				id_onTraceComplete_Ljava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "onTraceComplete", "(Ljava/util/Collection;)Ljava/util/Collection;");
			IntPtr native_p0 = global::Android.Runtime.JavaCollection<global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Android.Runtime.JavaCollection<global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onTraceComplete_Ljava_util_Collection_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_priority;
#pragma warning disable 0169
		static Delegate GetPriorityHandler ()
		{
			if (cb_priority == null)
				cb_priority = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_Priority);
			return cb_priority;
		}

		static int n_Priority (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Interceptor.ITraceInterceptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Priority ();
		}
#pragma warning restore 0169

		IntPtr id_priority;
		public unsafe int Priority ()
		{
			if (id_priority == IntPtr.Zero)
				id_priority = JNIEnv.GetMethodID (class_ref, "priority", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_priority);
		}

	}
}
