using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Trace.Api.Interceptor {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.datadog.trace.api.interceptor']/interface[@name='MutableSpan']"
	[Register ("com/datadog/trace/api/interceptor/MutableSpan", "", "Com.Datadog.Trace.Api.Interceptor.IMutableSpanInvoker")]
	public partial interface IMutableSpan : IJavaObject, IJavaPeerable {
		long DurationNano {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api.interceptor']/interface[@name='MutableSpan']/method[@name='getDurationNano' and count(parameter)=0]"
			[Register ("getDurationNano", "()J", "GetGetDurationNanoHandler:Com.Datadog.Trace.Api.Interceptor.IMutableSpanInvoker, Datadog_sdk_android")]
			get; 
		}

		global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan LocalRootSpan {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api.interceptor']/interface[@name='MutableSpan']/method[@name='getLocalRootSpan' and count(parameter)=0]"
			[Register ("getLocalRootSpan", "()Lcom/datadog/trace/api/interceptor/MutableSpan;", "GetGetLocalRootSpanHandler:Com.Datadog.Trace.Api.Interceptor.IMutableSpanInvoker, Datadog_sdk_android")]
			get; 
		}

		string OperationName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api.interceptor']/interface[@name='MutableSpan']/method[@name='getOperationName' and count(parameter)=0]"
			[Register ("getOperationName", "()Ljava/lang/String;", "GetGetOperationNameHandler:Com.Datadog.Trace.Api.Interceptor.IMutableSpanInvoker, Datadog_sdk_android")]
			get; 
		}

		string ResourceName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api.interceptor']/interface[@name='MutableSpan']/method[@name='getResourceName' and count(parameter)=0]"
			[Register ("getResourceName", "()Ljava/lang/String;", "GetGetResourceNameHandler:Com.Datadog.Trace.Api.Interceptor.IMutableSpanInvoker, Datadog_sdk_android")]
			get; 
		}

		global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan RootSpan {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api.interceptor']/interface[@name='MutableSpan']/method[@name='getRootSpan' and count(parameter)=0]"
			[Register ("getRootSpan", "()Lcom/datadog/trace/api/interceptor/MutableSpan;", "GetGetRootSpanHandler:Com.Datadog.Trace.Api.Interceptor.IMutableSpanInvoker, Datadog_sdk_android")]
			get; 
		}

		global::Java.Lang.Integer SamplingPriority {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api.interceptor']/interface[@name='MutableSpan']/method[@name='getSamplingPriority' and count(parameter)=0]"
			[Register ("getSamplingPriority", "()Ljava/lang/Integer;", "GetGetSamplingPriorityHandler:Com.Datadog.Trace.Api.Interceptor.IMutableSpanInvoker, Datadog_sdk_android")]
			get; 
		}

		string ServiceName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api.interceptor']/interface[@name='MutableSpan']/method[@name='getServiceName' and count(parameter)=0]"
			[Register ("getServiceName", "()Ljava/lang/String;", "GetGetServiceNameHandler:Com.Datadog.Trace.Api.Interceptor.IMutableSpanInvoker, Datadog_sdk_android")]
			get; 
		}

		string SpanType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api.interceptor']/interface[@name='MutableSpan']/method[@name='getSpanType' and count(parameter)=0]"
			[Register ("getSpanType", "()Ljava/lang/String;", "GetGetSpanTypeHandler:Com.Datadog.Trace.Api.Interceptor.IMutableSpanInvoker, Datadog_sdk_android")]
			get; 
		}

		long StartTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api.interceptor']/interface[@name='MutableSpan']/method[@name='getStartTime' and count(parameter)=0]"
			[Register ("getStartTime", "()J", "GetGetStartTimeHandler:Com.Datadog.Trace.Api.Interceptor.IMutableSpanInvoker, Datadog_sdk_android")]
			get; 
		}

		global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> Tags {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api.interceptor']/interface[@name='MutableSpan']/method[@name='getTags' and count(parameter)=0]"
			[Register ("getTags", "()Ljava/util/Map;", "GetGetTagsHandler:Com.Datadog.Trace.Api.Interceptor.IMutableSpanInvoker, Datadog_sdk_android")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api.interceptor']/interface[@name='MutableSpan']/method[@name='isError' and count(parameter)=0]"
		[Register ("isError", "()Ljava/lang/Boolean;", "GetIsErrorHandler:Com.Datadog.Trace.Api.Interceptor.IMutableSpanInvoker, Datadog_sdk_android")]
		global::Java.Lang.Boolean IsError ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api.interceptor']/interface[@name='MutableSpan']/method[@name='setError' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setError", "(Z)Lcom/datadog/trace/api/interceptor/MutableSpan;", "GetSetError_ZHandler:Com.Datadog.Trace.Api.Interceptor.IMutableSpanInvoker, Datadog_sdk_android")]
		global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan SetError (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api.interceptor']/interface[@name='MutableSpan']/method[@name='setOperationName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setOperationName", "(Ljava/lang/String;)Lcom/datadog/trace/api/interceptor/MutableSpan;", "GetSetOperationName_Ljava_lang_String_Handler:Com.Datadog.Trace.Api.Interceptor.IMutableSpanInvoker, Datadog_sdk_android")]
		global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan SetOperationName (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api.interceptor']/interface[@name='MutableSpan']/method[@name='setResourceName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setResourceName", "(Ljava/lang/String;)Lcom/datadog/trace/api/interceptor/MutableSpan;", "GetSetResourceName_Ljava_lang_String_Handler:Com.Datadog.Trace.Api.Interceptor.IMutableSpanInvoker, Datadog_sdk_android")]
		global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan SetResourceName (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api.interceptor']/interface[@name='MutableSpan']/method[@name='setSamplingPriority' and count(parameter)=1 and parameter[1][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("setSamplingPriority", "(I)Lcom/datadog/trace/api/interceptor/MutableSpan;", "GetSetSamplingPriority_IHandler:Com.Datadog.Trace.Api.Interceptor.IMutableSpanInvoker, Datadog_sdk_android")]
		global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan SetSamplingPriority (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api.interceptor']/interface[@name='MutableSpan']/method[@name='setServiceName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setServiceName", "(Ljava/lang/String;)Lcom/datadog/trace/api/interceptor/MutableSpan;", "GetSetServiceName_Ljava_lang_String_Handler:Com.Datadog.Trace.Api.Interceptor.IMutableSpanInvoker, Datadog_sdk_android")]
		global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan SetServiceName (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api.interceptor']/interface[@name='MutableSpan']/method[@name='setSpanType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setSpanType", "(Ljava/lang/String;)Lcom/datadog/trace/api/interceptor/MutableSpan;", "GetSetSpanType_Ljava_lang_String_Handler:Com.Datadog.Trace.Api.Interceptor.IMutableSpanInvoker, Datadog_sdk_android")]
		global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan SetSpanType (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api.interceptor']/interface[@name='MutableSpan']/method[@name='setTag' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("setTag", "(Ljava/lang/String;Z)Lcom/datadog/trace/api/interceptor/MutableSpan;", "GetSetTag_Ljava_lang_String_ZHandler:Com.Datadog.Trace.Api.Interceptor.IMutableSpanInvoker, Datadog_sdk_android")]
		global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan SetTag (string p0, bool p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api.interceptor']/interface[@name='MutableSpan']/method[@name='setTag' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Number']]"
		[Register ("setTag", "(Ljava/lang/String;Ljava/lang/Number;)Lcom/datadog/trace/api/interceptor/MutableSpan;", "GetSetTag_Ljava_lang_String_Ljava_lang_Number_Handler:Com.Datadog.Trace.Api.Interceptor.IMutableSpanInvoker, Datadog_sdk_android")]
		global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan SetTag (string p0, global::Java.Lang.Number p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api.interceptor']/interface[@name='MutableSpan']/method[@name='setTag' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setTag", "(Ljava/lang/String;Ljava/lang/String;)Lcom/datadog/trace/api/interceptor/MutableSpan;", "GetSetTag_Ljava_lang_String_Ljava_lang_String_Handler:Com.Datadog.Trace.Api.Interceptor.IMutableSpanInvoker, Datadog_sdk_android")]
		global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan SetTag (string p0, string p1);

	}

	[global::Android.Runtime.Register ("com/datadog/trace/api/interceptor/MutableSpan", DoNotGenerateAcw=true)]
	internal partial class IMutableSpanInvoker : global::Java.Lang.Object, IMutableSpan {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/trace/api/interceptor/MutableSpan", typeof (IMutableSpanInvoker));

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

		public static IMutableSpan GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMutableSpan> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.datadog.trace.api.interceptor.MutableSpan'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMutableSpanInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getDurationNano;
#pragma warning disable 0169
		static Delegate GetGetDurationNanoHandler ()
		{
			if (cb_getDurationNano == null)
				cb_getDurationNano = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetDurationNano);
			return cb_getDurationNano;
		}

		static long n_GetDurationNano (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DurationNano;
		}
#pragma warning restore 0169

		IntPtr id_getDurationNano;
		public unsafe long DurationNano {
			get {
				if (id_getDurationNano == IntPtr.Zero)
					id_getDurationNano = JNIEnv.GetMethodID (class_ref, "getDurationNano", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getDurationNano);
			}
		}

		static Delegate cb_getLocalRootSpan;
#pragma warning disable 0169
		static Delegate GetGetLocalRootSpanHandler ()
		{
			if (cb_getLocalRootSpan == null)
				cb_getLocalRootSpan = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLocalRootSpan);
			return cb_getLocalRootSpan;
		}

		static IntPtr n_GetLocalRootSpan (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LocalRootSpan);
		}
#pragma warning restore 0169

		IntPtr id_getLocalRootSpan;
		public unsafe global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan LocalRootSpan {
			get {
				if (id_getLocalRootSpan == IntPtr.Zero)
					id_getLocalRootSpan = JNIEnv.GetMethodID (class_ref, "getLocalRootSpan", "()Lcom/datadog/trace/api/interceptor/MutableSpan;");
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLocalRootSpan), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getOperationName;
#pragma warning disable 0169
		static Delegate GetGetOperationNameHandler ()
		{
			if (cb_getOperationName == null)
				cb_getOperationName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOperationName);
			return cb_getOperationName;
		}

		static IntPtr n_GetOperationName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OperationName);
		}
#pragma warning restore 0169

		IntPtr id_getOperationName;
		public unsafe string OperationName {
			get {
				if (id_getOperationName == IntPtr.Zero)
					id_getOperationName = JNIEnv.GetMethodID (class_ref, "getOperationName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOperationName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getResourceName;
#pragma warning disable 0169
		static Delegate GetGetResourceNameHandler ()
		{
			if (cb_getResourceName == null)
				cb_getResourceName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetResourceName);
			return cb_getResourceName;
		}

		static IntPtr n_GetResourceName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ResourceName);
		}
#pragma warning restore 0169

		IntPtr id_getResourceName;
		public unsafe string ResourceName {
			get {
				if (id_getResourceName == IntPtr.Zero)
					id_getResourceName = JNIEnv.GetMethodID (class_ref, "getResourceName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResourceName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getRootSpan;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetGetRootSpanHandler ()
		{
			if (cb_getRootSpan == null)
				cb_getRootSpan = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRootSpan);
			return cb_getRootSpan;
		}

		[Obsolete]
		static IntPtr n_GetRootSpan (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RootSpan);
		}
#pragma warning restore 0169

		IntPtr id_getRootSpan;
		public unsafe global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan RootSpan {
			get {
				if (id_getRootSpan == IntPtr.Zero)
					id_getRootSpan = JNIEnv.GetMethodID (class_ref, "getRootSpan", "()Lcom/datadog/trace/api/interceptor/MutableSpan;");
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRootSpan), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSamplingPriority;
#pragma warning disable 0169
		static Delegate GetGetSamplingPriorityHandler ()
		{
			if (cb_getSamplingPriority == null)
				cb_getSamplingPriority = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSamplingPriority);
			return cb_getSamplingPriority;
		}

		static IntPtr n_GetSamplingPriority (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SamplingPriority);
		}
#pragma warning restore 0169

		IntPtr id_getSamplingPriority;
		public unsafe global::Java.Lang.Integer SamplingPriority {
			get {
				if (id_getSamplingPriority == IntPtr.Zero)
					id_getSamplingPriority = JNIEnv.GetMethodID (class_ref, "getSamplingPriority", "()Ljava/lang/Integer;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSamplingPriority), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getServiceName;
#pragma warning disable 0169
		static Delegate GetGetServiceNameHandler ()
		{
			if (cb_getServiceName == null)
				cb_getServiceName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetServiceName);
			return cb_getServiceName;
		}

		static IntPtr n_GetServiceName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ServiceName);
		}
#pragma warning restore 0169

		IntPtr id_getServiceName;
		public unsafe string ServiceName {
			get {
				if (id_getServiceName == IntPtr.Zero)
					id_getServiceName = JNIEnv.GetMethodID (class_ref, "getServiceName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getServiceName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSpanType;
#pragma warning disable 0169
		static Delegate GetGetSpanTypeHandler ()
		{
			if (cb_getSpanType == null)
				cb_getSpanType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSpanType);
			return cb_getSpanType;
		}

		static IntPtr n_GetSpanType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SpanType);
		}
#pragma warning restore 0169

		IntPtr id_getSpanType;
		public unsafe string SpanType {
			get {
				if (id_getSpanType == IntPtr.Zero)
					id_getSpanType = JNIEnv.GetMethodID (class_ref, "getSpanType", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSpanType), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getStartTime;
#pragma warning disable 0169
		static Delegate GetGetStartTimeHandler ()
		{
			if (cb_getStartTime == null)
				cb_getStartTime = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetStartTime);
			return cb_getStartTime;
		}

		static long n_GetStartTime (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StartTime;
		}
#pragma warning restore 0169

		IntPtr id_getStartTime;
		public unsafe long StartTime {
			get {
				if (id_getStartTime == IntPtr.Zero)
					id_getStartTime = JNIEnv.GetMethodID (class_ref, "getStartTime", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getStartTime);
			}
		}

		static Delegate cb_getTags;
#pragma warning disable 0169
		static Delegate GetGetTagsHandler ()
		{
			if (cb_getTags == null)
				cb_getTags = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTags);
			return cb_getTags;
		}

		static IntPtr n_GetTags (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.Tags);
		}
#pragma warning restore 0169

		IntPtr id_getTags;
		public unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> Tags {
			get {
				if (id_getTags == IntPtr.Zero)
					id_getTags = JNIEnv.GetMethodID (class_ref, "getTags", "()Ljava/util/Map;");
				return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTags), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isError;
#pragma warning disable 0169
		static Delegate GetIsErrorHandler ()
		{
			if (cb_isError == null)
				cb_isError = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_IsError);
			return cb_isError;
		}

		static IntPtr n_IsError (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IsError ());
		}
#pragma warning restore 0169

		IntPtr id_isError;
		public unsafe global::Java.Lang.Boolean IsError ()
		{
			if (id_isError == IntPtr.Zero)
				id_isError = JNIEnv.GetMethodID (class_ref, "isError", "()Ljava/lang/Boolean;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_isError), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setError_Z;
#pragma warning disable 0169
		static Delegate GetSetError_ZHandler ()
		{
			if (cb_setError_Z == null)
				cb_setError_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetError_Z);
			return cb_setError_Z;
		}

		static IntPtr n_SetError_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetError (p0));
		}
#pragma warning restore 0169

		IntPtr id_setError_Z;
		public unsafe global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan SetError (bool p0)
		{
			if (id_setError_Z == IntPtr.Zero)
				id_setError_Z = JNIEnv.GetMethodID (class_ref, "setError", "(Z)Lcom/datadog/trace/api/interceptor/MutableSpan;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setError_Z, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setOperationName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetOperationName_Ljava_lang_String_Handler ()
		{
			if (cb_setOperationName_Ljava_lang_String_ == null)
				cb_setOperationName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetOperationName_Ljava_lang_String_);
			return cb_setOperationName_Ljava_lang_String_;
		}

		static IntPtr n_SetOperationName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetOperationName (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setOperationName_Ljava_lang_String_;
		public unsafe global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan SetOperationName (string p0)
		{
			if (id_setOperationName_Ljava_lang_String_ == IntPtr.Zero)
				id_setOperationName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setOperationName", "(Ljava/lang/String;)Lcom/datadog/trace/api/interceptor/MutableSpan;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setOperationName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setResourceName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetResourceName_Ljava_lang_String_Handler ()
		{
			if (cb_setResourceName_Ljava_lang_String_ == null)
				cb_setResourceName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetResourceName_Ljava_lang_String_);
			return cb_setResourceName_Ljava_lang_String_;
		}

		static IntPtr n_SetResourceName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetResourceName (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setResourceName_Ljava_lang_String_;
		public unsafe global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan SetResourceName (string p0)
		{
			if (id_setResourceName_Ljava_lang_String_ == IntPtr.Zero)
				id_setResourceName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setResourceName", "(Ljava/lang/String;)Lcom/datadog/trace/api/interceptor/MutableSpan;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setResourceName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setSamplingPriority_I;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSetSamplingPriority_IHandler ()
		{
			if (cb_setSamplingPriority_I == null)
				cb_setSamplingPriority_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetSamplingPriority_I);
			return cb_setSamplingPriority_I;
		}

		[Obsolete]
		static IntPtr n_SetSamplingPriority_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetSamplingPriority (p0));
		}
#pragma warning restore 0169

		IntPtr id_setSamplingPriority_I;
		public unsafe global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan SetSamplingPriority (int p0)
		{
			if (id_setSamplingPriority_I == IntPtr.Zero)
				id_setSamplingPriority_I = JNIEnv.GetMethodID (class_ref, "setSamplingPriority", "(I)Lcom/datadog/trace/api/interceptor/MutableSpan;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setSamplingPriority_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setServiceName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetServiceName_Ljava_lang_String_Handler ()
		{
			if (cb_setServiceName_Ljava_lang_String_ == null)
				cb_setServiceName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetServiceName_Ljava_lang_String_);
			return cb_setServiceName_Ljava_lang_String_;
		}

		static IntPtr n_SetServiceName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetServiceName (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setServiceName_Ljava_lang_String_;
		public unsafe global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan SetServiceName (string p0)
		{
			if (id_setServiceName_Ljava_lang_String_ == IntPtr.Zero)
				id_setServiceName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setServiceName", "(Ljava/lang/String;)Lcom/datadog/trace/api/interceptor/MutableSpan;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setServiceName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setSpanType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSpanType_Ljava_lang_String_Handler ()
		{
			if (cb_setSpanType_Ljava_lang_String_ == null)
				cb_setSpanType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetSpanType_Ljava_lang_String_);
			return cb_setSpanType_Ljava_lang_String_;
		}

		static IntPtr n_SetSpanType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetSpanType (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setSpanType_Ljava_lang_String_;
		public unsafe global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan SetSpanType (string p0)
		{
			if (id_setSpanType_Ljava_lang_String_ == IntPtr.Zero)
				id_setSpanType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSpanType", "(Ljava/lang/String;)Lcom/datadog/trace/api/interceptor/MutableSpan;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setSpanType_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setTag_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetSetTag_Ljava_lang_String_ZHandler ()
		{
			if (cb_setTag_Ljava_lang_String_Z == null)
				cb_setTag_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_L) n_SetTag_Ljava_lang_String_Z);
			return cb_setTag_Ljava_lang_String_Z;
		}

		static IntPtr n_SetTag_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTag (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setTag_Ljava_lang_String_Z;
		public unsafe global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan SetTag (string p0, bool p1)
		{
			if (id_setTag_Ljava_lang_String_Z == IntPtr.Zero)
				id_setTag_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "setTag", "(Ljava/lang/String;Z)Lcom/datadog/trace/api/interceptor/MutableSpan;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setTag_Ljava_lang_String_Z, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setTag_Ljava_lang_String_Ljava_lang_Number_;
#pragma warning disable 0169
		static Delegate GetSetTag_Ljava_lang_String_Ljava_lang_Number_Handler ()
		{
			if (cb_setTag_Ljava_lang_String_Ljava_lang_Number_ == null)
				cb_setTag_Ljava_lang_String_Ljava_lang_Number_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_SetTag_Ljava_lang_String_Ljava_lang_Number_);
			return cb_setTag_Ljava_lang_String_Ljava_lang_Number_;
		}

		static IntPtr n_SetTag_Ljava_lang_String_Ljava_lang_Number_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Number> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTag (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setTag_Ljava_lang_String_Ljava_lang_Number_;
		public unsafe global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan SetTag (string p0, global::Java.Lang.Number p1)
		{
			if (id_setTag_Ljava_lang_String_Ljava_lang_Number_ == IntPtr.Zero)
				id_setTag_Ljava_lang_String_Ljava_lang_Number_ = JNIEnv.GetMethodID (class_ref, "setTag", "(Ljava/lang/String;Ljava/lang/Number;)Lcom/datadog/trace/api/interceptor/MutableSpan;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setTag_Ljava_lang_String_Ljava_lang_Number_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setTag_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTag_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setTag_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setTag_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_SetTag_Ljava_lang_String_Ljava_lang_String_);
			return cb_setTag_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_SetTag_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTag (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setTag_Ljava_lang_String_Ljava_lang_String_;
		public unsafe global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan SetTag (string p0, string p1)
		{
			if (id_setTag_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setTag_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTag", "(Ljava/lang/String;Ljava/lang/String;)Lcom/datadog/trace/api/interceptor/MutableSpan;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Interceptor.IMutableSpan> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setTag_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}
}
