using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Trace.Common.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.trace.common.util']/class[@name='Clock']"
	[global::Android.Runtime.Register ("com/datadog/trace/common/util/Clock", DoNotGenerateAcw=true)]
	public partial class Clock : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/trace/common/util/Clock", typeof (Clock));

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

		protected Clock (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.trace.common.util']/class[@name='Clock']/constructor[@name='Clock' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Clock () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.common.util']/class[@name='Clock']/method[@name='currentMicroTime' and count(parameter)=0]"
		[Register ("currentMicroTime", "()J", "")]
		public static unsafe long CurrentMicroTime ()
		{
			const string __id = "currentMicroTime.()J";
			try {
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.common.util']/class[@name='Clock']/method[@name='currentNanoTicks' and count(parameter)=0]"
		[Register ("currentNanoTicks", "()J", "")]
		public static unsafe long CurrentNanoTicks ()
		{
			const string __id = "currentNanoTicks.()J";
			try {
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.common.util']/class[@name='Clock']/method[@name='currentNanoTime' and count(parameter)=0]"
		[Register ("currentNanoTime", "()J", "")]
		public static unsafe long CurrentNanoTime ()
		{
			const string __id = "currentNanoTime.()J";
			try {
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, null);
				return __rm;
			} finally {
			}
		}

	}
}
