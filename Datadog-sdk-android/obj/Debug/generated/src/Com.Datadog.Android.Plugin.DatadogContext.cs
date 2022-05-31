using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Android.Plugin {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.plugin']/class[@name='DatadogContext']"
	[global::Android.Runtime.Register ("com/datadog/android/plugin/DatadogContext", DoNotGenerateAcw=true)]
	public sealed partial class DatadogContext : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/plugin/DatadogContext", typeof (DatadogContext));

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

		internal DatadogContext (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.plugin']/class[@name='DatadogContext']/constructor[@name='DatadogContext' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DatadogContext () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.plugin']/class[@name='DatadogContext']/constructor[@name='DatadogContext' and count(parameter)=1 and parameter[1][@type='com.datadog.android.plugin.DatadogRumContext']]"
		[Register (".ctor", "(Lcom/datadog/android/plugin/DatadogRumContext;)V", "")]
		public unsafe DatadogContext (global::Com.Datadog.Android.Plugin.DatadogRumContext rum) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/datadog/android/plugin/DatadogRumContext;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((rum == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rum).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (rum);
			}
		}

		public unsafe global::Com.Datadog.Android.Plugin.DatadogRumContext Rum {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.plugin']/class[@name='DatadogContext']/method[@name='getRum' and count(parameter)=0]"
			[Register ("getRum", "()Lcom/datadog/android/plugin/DatadogRumContext;", "")]
			get {
				const string __id = "getRum.()Lcom/datadog/android/plugin/DatadogRumContext;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Plugin.DatadogRumContext> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.plugin']/class[@name='DatadogContext']/method[@name='component1' and count(parameter)=0]"
		[Register ("component1", "()Lcom/datadog/android/plugin/DatadogRumContext;", "")]
		public unsafe global::Com.Datadog.Android.Plugin.DatadogRumContext Component1 ()
		{
			const string __id = "component1.()Lcom/datadog/android/plugin/DatadogRumContext;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Plugin.DatadogRumContext> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.plugin']/class[@name='DatadogContext']/method[@name='copy' and count(parameter)=1 and parameter[1][@type='com.datadog.android.plugin.DatadogRumContext']]"
		[Register ("copy", "(Lcom/datadog/android/plugin/DatadogRumContext;)Lcom/datadog/android/plugin/DatadogContext;", "")]
		public unsafe global::Com.Datadog.Android.Plugin.DatadogContext Copy (global::Com.Datadog.Android.Plugin.DatadogRumContext rum)
		{
			const string __id = "copy.(Lcom/datadog/android/plugin/DatadogRumContext;)Lcom/datadog/android/plugin/DatadogContext;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((rum == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rum).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Plugin.DatadogContext> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (rum);
			}
		}

	}
}
