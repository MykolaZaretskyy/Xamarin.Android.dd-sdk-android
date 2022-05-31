using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Trace.Common.Sampling {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.trace.common.sampling']/class[@name='Sampler.Builder']"
	[global::Android.Runtime.Register ("com/datadog/trace/common/sampling/Sampler$Builder", DoNotGenerateAcw=true)]
	public sealed partial class SamplerBuilder : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/trace/common/sampling/Sampler$Builder", typeof (SamplerBuilder));

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

		internal SamplerBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.common.sampling']/class[@name='Sampler.Builder']/method[@name='forConfig' and count(parameter)=1 and parameter[1][@type='com.datadog.trace.api.Config']]"
		[Register ("forConfig", "(Lcom/datadog/trace/api/Config;)Lcom/datadog/trace/common/sampling/Sampler;", "")]
		public static unsafe global::Com.Datadog.Trace.Common.Sampling.ISampler ForConfig (global::Com.Datadog.Trace.Api.Config config)
		{
			const string __id = "forConfig.(Lcom/datadog/trace/api/Config;)Lcom/datadog/trace/common/sampling/Sampler;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((config == null) ? IntPtr.Zero : ((global::Java.Lang.Object) config).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Common.Sampling.ISampler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (config);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.common.sampling']/class[@name='Sampler.Builder']/method[@name='forConfig' and count(parameter)=1 and parameter[1][@type='java.util.Properties']]"
		[Register ("forConfig", "(Ljava/util/Properties;)Lcom/datadog/trace/common/sampling/Sampler;", "")]
		public static unsafe global::Com.Datadog.Trace.Common.Sampling.ISampler ForConfig (global::Java.Util.Properties config)
		{
			const string __id = "forConfig.(Ljava/util/Properties;)Lcom/datadog/trace/common/sampling/Sampler;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((config == null) ? IntPtr.Zero : ((global::Java.Lang.Object) config).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Common.Sampling.ISampler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (config);
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.datadog.trace.common.sampling']/interface[@name='Sampler']"
	[Register ("com/datadog/trace/common/sampling/Sampler", "", "Com.Datadog.Trace.Common.Sampling.ISamplerInvoker")]
	public partial interface ISampler : IJavaObject, IJavaPeerable {
	}

	[global::Android.Runtime.Register ("com/datadog/trace/common/sampling/Sampler", DoNotGenerateAcw=true)]
	internal partial class ISamplerInvoker : global::Java.Lang.Object, ISampler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/trace/common/sampling/Sampler", typeof (ISamplerInvoker));

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

		public static ISampler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISampler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.datadog.trace.common.sampling.Sampler'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISamplerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}
}
