using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Trace.Common.Sampling {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.trace.common.sampling']/class[@name='RateByServiceSampler']"
	[global::Android.Runtime.Register ("com/datadog/trace/common/sampling/RateByServiceSampler", DoNotGenerateAcw=true)]
	public partial class RateByServiceSampler : global::Java.Lang.Object, global::Com.Datadog.Trace.Common.Sampling.IPrioritySampler, global::Com.Datadog.Trace.Common.Sampling.ISampler {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.common.sampling']/class[@name='RateByServiceSampler']/field[@name='SAMPLING_AGENT_RATE']"
		[Register ("SAMPLING_AGENT_RATE")]
		public const string SamplingAgentRate = (string) "_dd.agent_psr";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/trace/common/sampling/RateByServiceSampler", typeof (RateByServiceSampler));

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

		protected RateByServiceSampler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.trace.common.sampling']/class[@name='RateByServiceSampler']/constructor[@name='RateByServiceSampler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RateByServiceSampler () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

	}
}
