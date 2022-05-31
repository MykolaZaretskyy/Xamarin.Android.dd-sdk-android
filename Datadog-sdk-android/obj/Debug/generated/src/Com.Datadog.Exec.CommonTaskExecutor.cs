using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Exec {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.exec']/class[@name='CommonTaskExecutor']"
	[global::Android.Runtime.Register ("com/datadog/exec/CommonTaskExecutor", DoNotGenerateAcw=true)]
	public sealed partial class CommonTaskExecutor : global::Java.Util.Concurrent.AbstractExecutorService {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.exec']/class[@name='CommonTaskExecutor']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Com.Datadog.Exec.CommonTaskExecutor Instance {
			get {
				const string __id = "INSTANCE.Lcom/datadog/exec/CommonTaskExecutor;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Exec.CommonTaskExecutor> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.datadog.exec']/interface[@name='CommonTaskExecutor.Task']"
		[Register ("com/datadog/exec/CommonTaskExecutor$Task", "", "Com.Datadog.Exec.CommonTaskExecutor/ITaskInvoker")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public partial interface ITask : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.exec']/interface[@name='CommonTaskExecutor.Task']/method[@name='run' and count(parameter)=1 and parameter[1][@type='T']]"
			[Register ("run", "(Ljava/lang/Object;)V", "GetRun_Ljava_lang_Object_Handler:Com.Datadog.Exec.CommonTaskExecutor/ITaskInvoker, Datadog_sdk_android")]
			void Run (global::Java.Lang.Object p0);

		}

		[global::Android.Runtime.Register ("com/datadog/exec/CommonTaskExecutor$Task", DoNotGenerateAcw=true)]
		internal partial class ITaskInvoker : global::Java.Lang.Object, ITask {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/exec/CommonTaskExecutor$Task", typeof (ITaskInvoker));

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

			public static ITask GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ITask> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.datadog.exec.CommonTaskExecutor.Task'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ITaskInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_run_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetRun_Ljava_lang_Object_Handler ()
			{
				if (cb_run_Ljava_lang_Object_ == null)
					cb_run_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Run_Ljava_lang_Object_);
				return cb_run_Ljava_lang_Object_;
			}

			static void n_Run_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Exec.CommonTaskExecutor.ITask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Run (p0);
			}
#pragma warning restore 0169

			IntPtr id_run_Ljava_lang_Object_;
			public unsafe void Run (global::Java.Lang.Object p0)
			{
				if (id_run_Ljava_lang_Object_ == IntPtr.Zero)
					id_run_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "run", "(Ljava/lang/Object;)V");
				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_run_Ljava_lang_Object_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/exec/CommonTaskExecutor", typeof (CommonTaskExecutor));

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

		internal CommonTaskExecutor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public override unsafe bool IsShutdown {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.exec']/class[@name='CommonTaskExecutor']/method[@name='isShutdown' and count(parameter)=0]"
			[Register ("isShutdown", "()Z", "")]
			get {
				const string __id = "isShutdown.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe bool IsTerminated {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.exec']/class[@name='CommonTaskExecutor']/method[@name='isTerminated' and count(parameter)=0]"
			[Register ("isTerminated", "()Z", "")]
			get {
				const string __id = "isTerminated.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.exec']/class[@name='CommonTaskExecutor']/method[@name='awaitTermination' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("awaitTermination", "(JLjava/util/concurrent/TimeUnit;)Z", "")]
		public override unsafe bool AwaitTermination (long timeout, global::Java.Util.Concurrent.TimeUnit unit)
		{
			const string __id = "awaitTermination.(JLjava/util/concurrent/TimeUnit;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (timeout);
				__args [1] = new JniArgumentValue ((unit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) unit).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (unit);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.exec']/class[@name='CommonTaskExecutor']/method[@name='execute' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("execute", "(Ljava/lang/Runnable;)V", "")]
		public override unsafe void Execute (global::Java.Lang.IRunnable command)
		{
			const string __id = "execute.(Ljava/lang/Runnable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((command == null) ? IntPtr.Zero : ((global::Java.Lang.Object) command).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (command);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.exec']/class[@name='CommonTaskExecutor']/method[@name='scheduleAtFixedRate' and count(parameter)=6 and parameter[1][@type='com.datadog.exec.CommonTaskExecutor.Task&lt;T&gt;'] and parameter[2][@type='T'] and parameter[3][@type='long'] and parameter[4][@type='long'] and parameter[5][@type='java.util.concurrent.TimeUnit'] and parameter[6][@type='java.lang.String']]"
		[Register ("scheduleAtFixedRate", "(Lcom/datadog/exec/CommonTaskExecutor$Task;Ljava/lang/Object;JJLjava/util/concurrent/TimeUnit;Ljava/lang/String;)Ljava/util/concurrent/ScheduledFuture;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Java.Util.Concurrent.IScheduledFuture ScheduleAtFixedRate (global::Com.Datadog.Exec.CommonTaskExecutor.ITask task, global::Java.Lang.Object target, long initialDelay, long period, global::Java.Util.Concurrent.TimeUnit unit, string name)
		{
			const string __id = "scheduleAtFixedRate.(Lcom/datadog/exec/CommonTaskExecutor$Task;Ljava/lang/Object;JJLjava/util/concurrent/TimeUnit;Ljava/lang/String;)Ljava/util/concurrent/ScheduledFuture;";
			IntPtr native_target = JNIEnv.ToLocalJniHandle (target);
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((task == null) ? IntPtr.Zero : ((global::Java.Lang.Object) task).Handle);
				__args [1] = new JniArgumentValue (native_target);
				__args [2] = new JniArgumentValue (initialDelay);
				__args [3] = new JniArgumentValue (period);
				__args [4] = new JniArgumentValue ((unit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) unit).Handle);
				__args [5] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IScheduledFuture> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_target);
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (task);
				global::System.GC.KeepAlive (target);
				global::System.GC.KeepAlive (unit);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.exec']/class[@name='CommonTaskExecutor']/method[@name='shutdown' and count(parameter)=0]"
		[Register ("shutdown", "()V", "")]
		public override unsafe void Shutdown ()
		{
			const string __id = "shutdown.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.exec']/class[@name='CommonTaskExecutor']/method[@name='shutdownNow' and count(parameter)=0]"
		[Register ("shutdownNow", "()Ljava/util/List;", "")]
		public override unsafe global::System.Collections.Generic.IList<global::Java.Lang.IRunnable> ShutdownNow ()
		{
			const string __id = "shutdownNow.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::Java.Lang.IRunnable>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
