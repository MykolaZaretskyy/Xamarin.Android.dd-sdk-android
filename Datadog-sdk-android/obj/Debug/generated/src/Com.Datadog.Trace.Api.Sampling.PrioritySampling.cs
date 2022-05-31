using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Trace.Api.Sampling {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.trace.api.sampling']/class[@name='PrioritySampling']"
	[global::Android.Runtime.Register ("com/datadog/trace/api/sampling/PrioritySampling", DoNotGenerateAcw=true)]
	public partial class PrioritySampling : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api.sampling']/class[@name='PrioritySampling']/field[@name='SAMPLER_DROP']"
		[Register ("SAMPLER_DROP")]
		public const int SamplerDrop = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api.sampling']/class[@name='PrioritySampling']/field[@name='SAMPLER_KEEP']"
		[Register ("SAMPLER_KEEP")]
		public const int SamplerKeep = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api.sampling']/class[@name='PrioritySampling']/field[@name='UNSET']"
		[Register ("UNSET")]
		public const int Unset = (int) -2147483648;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api.sampling']/class[@name='PrioritySampling']/field[@name='USER_DROP']"
		[Register ("USER_DROP")]
		public const int UserDrop = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api.sampling']/class[@name='PrioritySampling']/field[@name='USER_KEEP']"
		[Register ("USER_KEEP")]
		public const int UserKeep = (int) 2;

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/trace/api/sampling/PrioritySampling", typeof (PrioritySampling));

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

		protected PrioritySampling (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

	}
}
