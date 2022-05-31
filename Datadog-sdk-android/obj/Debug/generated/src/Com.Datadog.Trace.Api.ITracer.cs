using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Trace.Api {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.datadog.trace.api']/interface[@name='Tracer']"
	[Register ("com/datadog/trace/api/Tracer", "", "Com.Datadog.Trace.Api.ITracerInvoker")]
	public partial interface ITracer : IJavaObject, IJavaPeerable {
		string SpanId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/interface[@name='Tracer']/method[@name='getSpanId' and count(parameter)=0]"
			[Register ("getSpanId", "()Ljava/lang/String;", "GetGetSpanIdHandler:Com.Datadog.Trace.Api.ITracerInvoker, Datadog_sdk_android")]
			get; 
		}

		string TraceId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/interface[@name='Tracer']/method[@name='getTraceId' and count(parameter)=0]"
			[Register ("getTraceId", "()Ljava/lang/String;", "GetGetTraceIdHandler:Com.Datadog.Trace.Api.ITracerInvoker, Datadog_sdk_android")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/interface[@name='Tracer']/method[@name='addScopeListener' and count(parameter)=1 and parameter[1][@type='com.datadog.trace.context.ScopeListener']]"
		[Register ("addScopeListener", "(Lcom/datadog/trace/context/ScopeListener;)V", "GetAddScopeListener_Lcom_datadog_trace_context_ScopeListener_Handler:Com.Datadog.Trace.Api.ITracerInvoker, Datadog_sdk_android")]
		void AddScopeListener (global::Com.Datadog.Trace.Context.IScopeListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/interface[@name='Tracer']/method[@name='addTraceInterceptor' and count(parameter)=1 and parameter[1][@type='com.datadog.trace.api.interceptor.TraceInterceptor']]"
		[Register ("addTraceInterceptor", "(Lcom/datadog/trace/api/interceptor/TraceInterceptor;)Z", "GetAddTraceInterceptor_Lcom_datadog_trace_api_interceptor_TraceInterceptor_Handler:Com.Datadog.Trace.Api.ITracerInvoker, Datadog_sdk_android")]
		bool AddTraceInterceptor (global::Com.Datadog.Trace.Api.Interceptor.ITraceInterceptor p0);

	}

	[global::Android.Runtime.Register ("com/datadog/trace/api/Tracer", DoNotGenerateAcw=true)]
	internal partial class ITracerInvoker : global::Java.Lang.Object, ITracer {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/trace/api/Tracer", typeof (ITracerInvoker));

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

		public static ITracer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITracer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.datadog.trace.api.Tracer'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITracerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getSpanId;
#pragma warning disable 0169
		static Delegate GetGetSpanIdHandler ()
		{
			if (cb_getSpanId == null)
				cb_getSpanId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSpanId);
			return cb_getSpanId;
		}

		static IntPtr n_GetSpanId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.ITracer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SpanId);
		}
#pragma warning restore 0169

		IntPtr id_getSpanId;
		public unsafe string SpanId {
			get {
				if (id_getSpanId == IntPtr.Zero)
					id_getSpanId = JNIEnv.GetMethodID (class_ref, "getSpanId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSpanId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getTraceId;
#pragma warning disable 0169
		static Delegate GetGetTraceIdHandler ()
		{
			if (cb_getTraceId == null)
				cb_getTraceId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTraceId);
			return cb_getTraceId;
		}

		static IntPtr n_GetTraceId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.ITracer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TraceId);
		}
#pragma warning restore 0169

		IntPtr id_getTraceId;
		public unsafe string TraceId {
			get {
				if (id_getTraceId == IntPtr.Zero)
					id_getTraceId = JNIEnv.GetMethodID (class_ref, "getTraceId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTraceId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_addScopeListener_Lcom_datadog_trace_context_ScopeListener_;
#pragma warning disable 0169
		static Delegate GetAddScopeListener_Lcom_datadog_trace_context_ScopeListener_Handler ()
		{
			if (cb_addScopeListener_Lcom_datadog_trace_context_ScopeListener_ == null)
				cb_addScopeListener_Lcom_datadog_trace_context_ScopeListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AddScopeListener_Lcom_datadog_trace_context_ScopeListener_);
			return cb_addScopeListener_Lcom_datadog_trace_context_ScopeListener_;
		}

		static void n_AddScopeListener_Lcom_datadog_trace_context_ScopeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.ITracer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Datadog.Trace.Context.IScopeListener)global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Context.IScopeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddScopeListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_addScopeListener_Lcom_datadog_trace_context_ScopeListener_;
		public unsafe void AddScopeListener (global::Com.Datadog.Trace.Context.IScopeListener p0)
		{
			if (id_addScopeListener_Lcom_datadog_trace_context_ScopeListener_ == IntPtr.Zero)
				id_addScopeListener_Lcom_datadog_trace_context_ScopeListener_ = JNIEnv.GetMethodID (class_ref, "addScopeListener", "(Lcom/datadog/trace/context/ScopeListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addScopeListener_Lcom_datadog_trace_context_ScopeListener_, __args);
		}

		static Delegate cb_addTraceInterceptor_Lcom_datadog_trace_api_interceptor_TraceInterceptor_;
#pragma warning disable 0169
		static Delegate GetAddTraceInterceptor_Lcom_datadog_trace_api_interceptor_TraceInterceptor_Handler ()
		{
			if (cb_addTraceInterceptor_Lcom_datadog_trace_api_interceptor_TraceInterceptor_ == null)
				cb_addTraceInterceptor_Lcom_datadog_trace_api_interceptor_TraceInterceptor_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_AddTraceInterceptor_Lcom_datadog_trace_api_interceptor_TraceInterceptor_);
			return cb_addTraceInterceptor_Lcom_datadog_trace_api_interceptor_TraceInterceptor_;
		}

		static bool n_AddTraceInterceptor_Lcom_datadog_trace_api_interceptor_TraceInterceptor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.ITracer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Datadog.Trace.Api.Interceptor.ITraceInterceptor)global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Interceptor.ITraceInterceptor> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddTraceInterceptor (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_addTraceInterceptor_Lcom_datadog_trace_api_interceptor_TraceInterceptor_;
		public unsafe bool AddTraceInterceptor (global::Com.Datadog.Trace.Api.Interceptor.ITraceInterceptor p0)
		{
			if (id_addTraceInterceptor_Lcom_datadog_trace_api_interceptor_TraceInterceptor_ == IntPtr.Zero)
				id_addTraceInterceptor_Lcom_datadog_trace_api_interceptor_TraceInterceptor_ = JNIEnv.GetMethodID (class_ref, "addTraceInterceptor", "(Lcom/datadog/trace/api/interceptor/TraceInterceptor;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_addTraceInterceptor_Lcom_datadog_trace_api_interceptor_TraceInterceptor_, __args);
			return __ret;
		}

	}
}
