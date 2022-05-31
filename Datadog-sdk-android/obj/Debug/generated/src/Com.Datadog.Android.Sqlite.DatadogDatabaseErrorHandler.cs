using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Android.Sqlite {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.sqlite']/class[@name='DatadogDatabaseErrorHandler']"
	[global::Android.Runtime.Register ("com/datadog/android/sqlite/DatadogDatabaseErrorHandler", DoNotGenerateAcw=true)]
	public sealed partial class DatadogDatabaseErrorHandler : global::Java.Lang.Object, global::Android.Database.IDatabaseErrorHandler {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.sqlite']/class[@name='DatadogDatabaseErrorHandler']/field[@name='DATABASE_CORRUPTION_ERROR_MESSAGE']"
		[Register ("DATABASE_CORRUPTION_ERROR_MESSAGE")]
		public const string DatabaseCorruptionErrorMessage = (string) "Corruption reported by sqlite database: %s";

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.sqlite']/class[@name='DatadogDatabaseErrorHandler.Companion']"
		[global::Android.Runtime.Register ("com/datadog/android/sqlite/DatadogDatabaseErrorHandler$Companion", DoNotGenerateAcw=true)]
		public sealed partial class Companion : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/sqlite/DatadogDatabaseErrorHandler$Companion", typeof (Companion));

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

			internal Companion (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.sqlite']/class[@name='DatadogDatabaseErrorHandler.Companion']/constructor[@name='DatadogDatabaseErrorHandler.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
			[Register (".ctor", "(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", "")]
			public unsafe Companion (global::Kotlin.Jvm.Internal.DefaultConstructorMarker _constructor_marker) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lkotlin/jvm/internal/DefaultConstructorMarker;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((_constructor_marker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _constructor_marker).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (_constructor_marker);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/sqlite/DatadogDatabaseErrorHandler", typeof (DatadogDatabaseErrorHandler));

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

		internal DatadogDatabaseErrorHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.sqlite']/class[@name='DatadogDatabaseErrorHandler']/constructor[@name='DatadogDatabaseErrorHandler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DatadogDatabaseErrorHandler () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.sqlite']/class[@name='DatadogDatabaseErrorHandler']/constructor[@name='DatadogDatabaseErrorHandler' and count(parameter)=1 and parameter[1][@type='android.database.DatabaseErrorHandler']]"
		[Register (".ctor", "(Landroid/database/DatabaseErrorHandler;)V", "")]
		public unsafe DatadogDatabaseErrorHandler (global::Android.Database.IDatabaseErrorHandler defaultErrorHandler) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/database/DatabaseErrorHandler;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((defaultErrorHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) defaultErrorHandler).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (defaultErrorHandler);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.sqlite']/class[@name='DatadogDatabaseErrorHandler']/method[@name='onCorruption' and count(parameter)=1 and parameter[1][@type='android.database.sqlite.SQLiteDatabase']]"
		[Register ("onCorruption", "(Landroid/database/sqlite/SQLiteDatabase;)V", "")]
		public unsafe void OnCorruption (global::Android.Database.Sqlite.SQLiteDatabase dbObj)
		{
			const string __id = "onCorruption.(Landroid/database/sqlite/SQLiteDatabase;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((dbObj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dbObj).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (dbObj);
			}
		}

	}
}
