using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Trace.Common.Sampling {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.trace.common.sampling']/class[@name='DeterministicSampler']"
	[global::Android.Runtime.Register ("com/datadog/trace/common/sampling/DeterministicSampler", DoNotGenerateAcw=true)]
	public partial class DeterministicSampler : global::Java.Lang.Object, global::Com.Datadog.Trace.Common.Sampling.IRateSampler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/trace/common/sampling/DeterministicSampler", typeof (DeterministicSampler));

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

		protected DeterministicSampler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.trace.common.sampling']/class[@name='DeterministicSampler']/constructor[@name='DeterministicSampler' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register (".ctor", "(D)V", "")]
		public unsafe DeterministicSampler (double rate) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(D)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (rate);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Common.Sampling.DeterministicSampler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SampleRate;
		}
#pragma warning restore 0169

		public virtual unsafe double SampleRate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.common.sampling']/class[@name='DeterministicSampler']/method[@name='getSampleRate' and count(parameter)=0]"
			[Register ("getSampleRate", "()D", "GetGetSampleRateHandler")]
			get {
				const string __id = "getSampleRate.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
