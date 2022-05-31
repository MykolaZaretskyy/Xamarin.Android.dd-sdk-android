using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Exec {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.exec']/class[@name='DaemonThreadFactory']"
	[global::Android.Runtime.Register ("com/datadog/exec/DaemonThreadFactory", DoNotGenerateAcw=true)]
	public sealed partial class DaemonThreadFactory : global::Java.Lang.Object, global::Java.Util.Concurrent.IThreadFactory {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.exec']/class[@name='DaemonThreadFactory']/field[@name='TASK_SCHEDULER']"
		[Register ("TASK_SCHEDULER")]
		public static global::Com.Datadog.Exec.DaemonThreadFactory TaskScheduler {
			get {
				const string __id = "TASK_SCHEDULER.Lcom/datadog/exec/DaemonThreadFactory;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Exec.DaemonThreadFactory> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.exec']/class[@name='DaemonThreadFactory']/field[@name='TRACE_PROCESSOR']"
		[Register ("TRACE_PROCESSOR")]
		public static global::Com.Datadog.Exec.DaemonThreadFactory TraceProcessor {
			get {
				const string __id = "TRACE_PROCESSOR.Lcom/datadog/exec/DaemonThreadFactory;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Exec.DaemonThreadFactory> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.exec']/class[@name='DaemonThreadFactory']/field[@name='TRACE_WRITER']"
		[Register ("TRACE_WRITER")]
		public static global::Com.Datadog.Exec.DaemonThreadFactory TraceWriter {
			get {
				const string __id = "TRACE_WRITER.Lcom/datadog/exec/DaemonThreadFactory;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Exec.DaemonThreadFactory> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/exec/DaemonThreadFactory", typeof (DaemonThreadFactory));

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

		internal DaemonThreadFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.exec']/class[@name='DaemonThreadFactory']/constructor[@name='DaemonThreadFactory' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe DaemonThreadFactory (string threadName) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_threadName = JNIEnv.NewString (threadName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_threadName);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_threadName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.exec']/class[@name='DaemonThreadFactory']/method[@name='newThread' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("newThread", "(Ljava/lang/Runnable;)Ljava/lang/Thread;", "")]
		public unsafe global::Java.Lang.Thread NewThread (global::Java.Lang.IRunnable r)
		{
			const string __id = "newThread.(Ljava/lang/Runnable;)Ljava/lang/Thread;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((r == null) ? IntPtr.Zero : ((global::Java.Lang.Object) r).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (r);
			}
		}

	}
}
