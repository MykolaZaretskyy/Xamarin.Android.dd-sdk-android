using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Trace.Common.Sampling {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.datadog.trace.common.sampling']/interface[@name='RateSampler']"
	[Register ("com/datadog/trace/common/sampling/RateSampler", "", "Com.Datadog.Trace.Common.Sampling.IRateSamplerInvoker")]
	public partial interface IRateSampler : global::Com.Datadog.Trace.Common.Sampling.ISampler {
		double SampleRate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.common.sampling']/interface[@name='RateSampler']/method[@name='getSampleRate' and count(parameter)=0]"
			[Register ("getSampleRate", "()D", "GetGetSampleRateHandler:Com.Datadog.Trace.Common.Sampling.IRateSamplerInvoker, Datadog_sdk_android")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("com/datadog/trace/common/sampling/RateSampler", DoNotGenerateAcw=true)]
	internal partial class IRateSamplerInvoker : global::Java.Lang.Object, IRateSampler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/trace/common/sampling/RateSampler", typeof (IRateSamplerInvoker));

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

		public static IRateSampler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRateSampler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.datadog.trace.common.sampling.RateSampler'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRateSamplerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getSampleRate;
#pragma warning disable 0169
		static Delegate GetGetSampleRateHandler ()
		{
			if (cb_getSampleRate == null)
				cb_getSampleRate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_D) n_GetSampleRate);
			return cb_getSampleRate;
		}

		static double n_GetSampleRate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Common.Sampling.IRateSampler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SampleRate;
		}
#pragma warning restore 0169

		IntPtr id_getSampleRate;
		public unsafe double SampleRate {
			get {
				if (id_getSampleRate == IntPtr.Zero)
					id_getSampleRate = JNIEnv.GetMethodID (class_ref, "getSampleRate", "()D");
				return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getSampleRate);
			}
		}

	}
}
