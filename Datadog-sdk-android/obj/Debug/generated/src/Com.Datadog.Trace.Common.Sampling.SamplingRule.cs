using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Trace.Common.Sampling {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.trace.common.sampling']/class[@name='SamplingRule']"
	[global::Android.Runtime.Register ("com/datadog/trace/common/sampling/SamplingRule", DoNotGenerateAcw=true)]
	public abstract partial class SamplingRule : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.trace.common.sampling']/class[@name='SamplingRule.AlwaysMatchesSamplingRule']"
		[global::Android.Runtime.Register ("com/datadog/trace/common/sampling/SamplingRule$AlwaysMatchesSamplingRule", DoNotGenerateAcw=true)]
		public partial class AlwaysMatchesSamplingRule : global::Com.Datadog.Trace.Common.Sampling.SamplingRule {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/trace/common/sampling/SamplingRule$AlwaysMatchesSamplingRule", typeof (AlwaysMatchesSamplingRule));

			internal static new IntPtr class_ref {
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

			protected AlwaysMatchesSamplingRule (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.trace.common.sampling']/class[@name='SamplingRule.AlwaysMatchesSamplingRule']/constructor[@name='SamplingRule.AlwaysMatchesSamplingRule' and count(parameter)=1 and parameter[1][@type='com.datadog.trace.common.sampling.RateSampler']]"
			[Register (".ctor", "(Lcom/datadog/trace/common/sampling/RateSampler;)V", "")]
			public unsafe AlwaysMatchesSamplingRule (global::Com.Datadog.Trace.Common.Sampling.IRateSampler sampler) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lcom/datadog/trace/common/sampling/RateSampler;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((sampler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sampler).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (sampler);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.trace.common.sampling']/class[@name='SamplingRule.OperationSamplingRule']"
		[global::Android.Runtime.Register ("com/datadog/trace/common/sampling/SamplingRule$OperationSamplingRule", DoNotGenerateAcw=true)]
		public partial class OperationSamplingRule : global::Com.Datadog.Trace.Common.Sampling.SamplingRule.PatternMatchSamplingRule {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/trace/common/sampling/SamplingRule$OperationSamplingRule", typeof (OperationSamplingRule));

			internal static new IntPtr class_ref {
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

			protected OperationSamplingRule (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.trace.common.sampling']/class[@name='SamplingRule.OperationSamplingRule']/constructor[@name='SamplingRule.OperationSamplingRule' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.datadog.trace.common.sampling.RateSampler']]"
			[Register (".ctor", "(Ljava/lang/String;Lcom/datadog/trace/common/sampling/RateSampler;)V", "")]
			public unsafe OperationSamplingRule (string regex, global::Com.Datadog.Trace.Common.Sampling.IRateSampler sampler) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;Lcom/datadog/trace/common/sampling/RateSampler;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_regex = JNIEnv.NewString (regex);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_regex);
					__args [1] = new JniArgumentValue ((sampler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sampler).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_regex);
					global::System.GC.KeepAlive (sampler);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.trace.common.sampling']/class[@name='SamplingRule.PatternMatchSamplingRule']"
		[global::Android.Runtime.Register ("com/datadog/trace/common/sampling/SamplingRule$PatternMatchSamplingRule", DoNotGenerateAcw=true)]
		public abstract partial class PatternMatchSamplingRule : global::Com.Datadog.Trace.Common.Sampling.SamplingRule {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/trace/common/sampling/SamplingRule$PatternMatchSamplingRule", typeof (PatternMatchSamplingRule));

			internal static new IntPtr class_ref {
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

			protected PatternMatchSamplingRule (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.trace.common.sampling']/class[@name='SamplingRule.PatternMatchSamplingRule']/constructor[@name='SamplingRule.PatternMatchSamplingRule' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.datadog.trace.common.sampling.RateSampler']]"
			[Register (".ctor", "(Ljava/lang/String;Lcom/datadog/trace/common/sampling/RateSampler;)V", "")]
			public unsafe PatternMatchSamplingRule (string regex, global::Com.Datadog.Trace.Common.Sampling.IRateSampler sampler) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;Lcom/datadog/trace/common/sampling/RateSampler;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_regex = JNIEnv.NewString (regex);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_regex);
					__args [1] = new JniArgumentValue ((sampler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sampler).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_regex);
					global::System.GC.KeepAlive (sampler);
				}
			}

		}

		[global::Android.Runtime.Register ("com/datadog/trace/common/sampling/SamplingRule$PatternMatchSamplingRule", DoNotGenerateAcw=true)]
		internal partial class PatternMatchSamplingRuleInvoker : PatternMatchSamplingRule {
			public PatternMatchSamplingRuleInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/trace/common/sampling/SamplingRule$PatternMatchSamplingRule", typeof (PatternMatchSamplingRuleInvoker));

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.trace.common.sampling']/class[@name='SamplingRule.ServiceSamplingRule']"
		[global::Android.Runtime.Register ("com/datadog/trace/common/sampling/SamplingRule$ServiceSamplingRule", DoNotGenerateAcw=true)]
		public partial class ServiceSamplingRule : global::Com.Datadog.Trace.Common.Sampling.SamplingRule.PatternMatchSamplingRule {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/trace/common/sampling/SamplingRule$ServiceSamplingRule", typeof (ServiceSamplingRule));

			internal static new IntPtr class_ref {
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

			protected ServiceSamplingRule (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.trace.common.sampling']/class[@name='SamplingRule.ServiceSamplingRule']/constructor[@name='SamplingRule.ServiceSamplingRule' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.datadog.trace.common.sampling.RateSampler']]"
			[Register (".ctor", "(Ljava/lang/String;Lcom/datadog/trace/common/sampling/RateSampler;)V", "")]
			public unsafe ServiceSamplingRule (string regex, global::Com.Datadog.Trace.Common.Sampling.IRateSampler sampler) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;Lcom/datadog/trace/common/sampling/RateSampler;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_regex = JNIEnv.NewString (regex);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_regex);
					__args [1] = new JniArgumentValue ((sampler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sampler).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_regex);
					global::System.GC.KeepAlive (sampler);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/trace/common/sampling/SamplingRule", typeof (SamplingRule));

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

		protected SamplingRule (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.trace.common.sampling']/class[@name='SamplingRule']/constructor[@name='SamplingRule' and count(parameter)=1 and parameter[1][@type='com.datadog.trace.common.sampling.RateSampler']]"
		[Register (".ctor", "(Lcom/datadog/trace/common/sampling/RateSampler;)V", "")]
		public unsafe SamplingRule (global::Com.Datadog.Trace.Common.Sampling.IRateSampler sampler) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/datadog/trace/common/sampling/RateSampler;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((sampler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sampler).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (sampler);
			}
		}

		static Delegate cb_getSampler;
#pragma warning disable 0169
		static Delegate GetGetSamplerHandler ()
		{
			if (cb_getSampler == null)
				cb_getSampler = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSampler);
			return cb_getSampler;
		}

		static IntPtr n_GetSampler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Common.Sampling.SamplingRule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Sampler);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Datadog.Trace.Common.Sampling.IRateSampler Sampler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.common.sampling']/class[@name='SamplingRule']/method[@name='getSampler' and count(parameter)=0]"
			[Register ("getSampler", "()Lcom/datadog/trace/common/sampling/RateSampler;", "GetGetSamplerHandler")]
			get {
				const string __id = "getSampler.()Lcom/datadog/trace/common/sampling/RateSampler;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Common.Sampling.IRateSampler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}

	[global::Android.Runtime.Register ("com/datadog/trace/common/sampling/SamplingRule", DoNotGenerateAcw=true)]
	internal partial class SamplingRuleInvoker : SamplingRule {
		public SamplingRuleInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/trace/common/sampling/SamplingRule", typeof (SamplingRuleInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}
}
