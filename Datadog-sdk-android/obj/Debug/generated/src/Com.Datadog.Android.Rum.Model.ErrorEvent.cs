using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Android.Rum.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent']"
	[global::Android.Runtime.Register ("com/datadog/android/rum/model/ErrorEvent", DoNotGenerateAcw=true)]
	public sealed partial class ErrorEvent : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Action']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ErrorEvent$Action", DoNotGenerateAcw=true)]
		public sealed partial class Action : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Action.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ErrorEvent$Action$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ErrorEvent$Action$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Action.Companion']/constructor[@name='ErrorEvent.Action.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Action.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Action;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Action FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Action;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Action> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ErrorEvent$Action", typeof (Action));

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

			internal Action (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Action']/constructor[@name='ErrorEvent.Action' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;)V", "")]
			public unsafe Action (string id) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_id = JNIEnv.NewString (id);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_id);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_id);
				}
			}

			public unsafe string Id {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Action']/method[@name='getId' and count(parameter)=0]"
				[Register ("getId", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getId.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Action']/method[@name='component1' and count(parameter)=0]"
			[Register ("component1", "()Ljava/lang/String;", "")]
			public unsafe string Component1 ()
			{
				const string __id = "component1.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Action']/method[@name='copy' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("copy", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Action;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Action Copy (string id)
			{
				const string __id = "copy.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Action;";
				IntPtr native_id = JNIEnv.NewString (id);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_id);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Action> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_id);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Action']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Action;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Action FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Action;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Action> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Application']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ErrorEvent$Application", DoNotGenerateAcw=true)]
		public sealed partial class Application : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Application.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ErrorEvent$Application$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ErrorEvent$Application$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Application.Companion']/constructor[@name='ErrorEvent.Application.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Application.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Application;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Application FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Application;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Application> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ErrorEvent$Application", typeof (Application));

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

			internal Application (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Application']/constructor[@name='ErrorEvent.Application' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;)V", "")]
			public unsafe Application (string id) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_id = JNIEnv.NewString (id);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_id);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_id);
				}
			}

			public unsafe string Id {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Application']/method[@name='getId' and count(parameter)=0]"
				[Register ("getId", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getId.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Application']/method[@name='component1' and count(parameter)=0]"
			[Register ("component1", "()Ljava/lang/String;", "")]
			public unsafe string Component1 ()
			{
				const string __id = "component1.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Application']/method[@name='copy' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("copy", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Application;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Application Copy (string id)
			{
				const string __id = "copy.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Application;";
				IntPtr native_id = JNIEnv.NewString (id);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_id);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Application> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_id);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Application']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Application;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Application FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Application;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Application> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Cellular']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ErrorEvent$Cellular", DoNotGenerateAcw=true)]
		public sealed partial class Cellular : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Cellular.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ErrorEvent$Cellular$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ErrorEvent$Cellular$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Cellular.Companion']/constructor[@name='ErrorEvent.Cellular.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Cellular.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Cellular;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Cellular FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Cellular;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Cellular> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ErrorEvent$Cellular", typeof (Cellular));

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

			internal Cellular (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Cellular']/constructor[@name='ErrorEvent.Cellular' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Cellular () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Cellular']/constructor[@name='ErrorEvent.Cellular' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
			public unsafe Cellular (string technology, string carrierName) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;Ljava/lang/String;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_technology = JNIEnv.NewString (technology);
				IntPtr native_carrierName = JNIEnv.NewString (carrierName);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_technology);
					__args [1] = new JniArgumentValue (native_carrierName);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_technology);
					JNIEnv.DeleteLocalRef (native_carrierName);
				}
			}

			public unsafe string CarrierName {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Cellular']/method[@name='getCarrierName' and count(parameter)=0]"
				[Register ("getCarrierName", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getCarrierName.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe string Technology {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Cellular']/method[@name='getTechnology' and count(parameter)=0]"
				[Register ("getTechnology", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getTechnology.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Cellular']/method[@name='component1' and count(parameter)=0]"
			[Register ("component1", "()Ljava/lang/String;", "")]
			public unsafe string Component1 ()
			{
				const string __id = "component1.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Cellular']/method[@name='component2' and count(parameter)=0]"
			[Register ("component2", "()Ljava/lang/String;", "")]
			public unsafe string Component2 ()
			{
				const string __id = "component2.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Cellular']/method[@name='copy' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("copy", "(Ljava/lang/String;Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Cellular;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Cellular Copy (string technology, string carrierName)
			{
				const string __id = "copy.(Ljava/lang/String;Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Cellular;";
				IntPtr native_technology = JNIEnv.NewString (technology);
				IntPtr native_carrierName = JNIEnv.NewString (carrierName);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_technology);
					__args [1] = new JniArgumentValue (native_carrierName);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Cellular> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_technology);
					JNIEnv.DeleteLocalRef (native_carrierName);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Cellular']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Cellular;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Cellular FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Cellular;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Cellular> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Companion']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ErrorEvent$Companion", DoNotGenerateAcw=true)]
		public sealed partial class Companion : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ErrorEvent$Companion", typeof (Companion));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Companion']/constructor[@name='ErrorEvent.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Connectivity']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ErrorEvent$Connectivity", DoNotGenerateAcw=true)]
		public sealed partial class Connectivity : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Connectivity.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ErrorEvent$Connectivity$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ErrorEvent$Connectivity$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Connectivity.Companion']/constructor[@name='ErrorEvent.Connectivity.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Connectivity.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Connectivity;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Connectivity FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Connectivity;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Connectivity> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ErrorEvent$Connectivity", typeof (Connectivity));

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

			internal Connectivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Connectivity']/constructor[@name='ErrorEvent.Connectivity' and count(parameter)=3 and parameter[1][@type='com.datadog.android.rum.model.ErrorEvent.Status'] and parameter[2][@type='java.util.List&lt;? extends com.datadog.android.rum.model.ErrorEvent.Interface&gt;'] and parameter[3][@type='com.datadog.android.rum.model.ErrorEvent.Cellular']]"
			[Register (".ctor", "(Lcom/datadog/android/rum/model/ErrorEvent$Status;Ljava/util/List;Lcom/datadog/android/rum/model/ErrorEvent$Cellular;)V", "")]
			public unsafe Connectivity (global::Com.Datadog.Android.Rum.Model.ErrorEvent.Status status, global::System.Collections.Generic.IList<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Interface> interfaces, global::Com.Datadog.Android.Rum.Model.ErrorEvent.Cellular cellular) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lcom/datadog/android/rum/model/ErrorEvent$Status;Ljava/util/List;Lcom/datadog/android/rum/model/ErrorEvent$Cellular;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_interfaces = global::Android.Runtime.JavaList<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Interface>.ToLocalJniHandle (interfaces);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue ((status == null) ? IntPtr.Zero : ((global::Java.Lang.Object) status).Handle);
					__args [1] = new JniArgumentValue (native_interfaces);
					__args [2] = new JniArgumentValue ((cellular == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cellular).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_interfaces);
					global::System.GC.KeepAlive (status);
					global::System.GC.KeepAlive (interfaces);
					global::System.GC.KeepAlive (cellular);
				}
			}

			public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Cellular Cellular {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Connectivity']/method[@name='getCellular' and count(parameter)=0]"
				[Register ("getCellular", "()Lcom/datadog/android/rum/model/ErrorEvent$Cellular;", "")]
				get {
					const string __id = "getCellular.()Lcom/datadog/android/rum/model/ErrorEvent$Cellular;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Cellular> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::System.Collections.Generic.IList<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Interface> Interfaces {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Connectivity']/method[@name='getInterfaces' and count(parameter)=0]"
				[Register ("getInterfaces", "()Ljava/util/List;", "")]
				get {
					const string __id = "getInterfaces.()Ljava/util/List;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Android.Runtime.JavaList<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Interface>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Status Status {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Connectivity']/method[@name='getStatus' and count(parameter)=0]"
				[Register ("getStatus", "()Lcom/datadog/android/rum/model/ErrorEvent$Status;", "")]
				get {
					const string __id = "getStatus.()Lcom/datadog/android/rum/model/ErrorEvent$Status;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Status> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Connectivity']/method[@name='component1' and count(parameter)=0]"
			[Register ("component1", "()Lcom/datadog/android/rum/model/ErrorEvent$Status;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Status Component1 ()
			{
				const string __id = "component1.()Lcom/datadog/android/rum/model/ErrorEvent$Status;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Status> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Connectivity']/method[@name='component2' and count(parameter)=0]"
			[Register ("component2", "()Ljava/util/List;", "")]
			public unsafe global::System.Collections.Generic.IList<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Interface> Component2 ()
			{
				const string __id = "component2.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Interface>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Connectivity']/method[@name='component3' and count(parameter)=0]"
			[Register ("component3", "()Lcom/datadog/android/rum/model/ErrorEvent$Cellular;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Cellular Component3 ()
			{
				const string __id = "component3.()Lcom/datadog/android/rum/model/ErrorEvent$Cellular;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Cellular> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Connectivity']/method[@name='copy' and count(parameter)=3 and parameter[1][@type='com.datadog.android.rum.model.ErrorEvent.Status'] and parameter[2][@type='java.util.List&lt;? extends com.datadog.android.rum.model.ErrorEvent.Interface&gt;'] and parameter[3][@type='com.datadog.android.rum.model.ErrorEvent.Cellular']]"
			[Register ("copy", "(Lcom/datadog/android/rum/model/ErrorEvent$Status;Ljava/util/List;Lcom/datadog/android/rum/model/ErrorEvent$Cellular;)Lcom/datadog/android/rum/model/ErrorEvent$Connectivity;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Connectivity Copy (global::Com.Datadog.Android.Rum.Model.ErrorEvent.Status status, global::System.Collections.Generic.IList<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Interface> interfaces, global::Com.Datadog.Android.Rum.Model.ErrorEvent.Cellular cellular)
			{
				const string __id = "copy.(Lcom/datadog/android/rum/model/ErrorEvent$Status;Ljava/util/List;Lcom/datadog/android/rum/model/ErrorEvent$Cellular;)Lcom/datadog/android/rum/model/ErrorEvent$Connectivity;";
				IntPtr native_interfaces = global::Android.Runtime.JavaList<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Interface>.ToLocalJniHandle (interfaces);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue ((status == null) ? IntPtr.Zero : ((global::Java.Lang.Object) status).Handle);
					__args [1] = new JniArgumentValue (native_interfaces);
					__args [2] = new JniArgumentValue ((cellular == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cellular).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Connectivity> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_interfaces);
					global::System.GC.KeepAlive (status);
					global::System.GC.KeepAlive (interfaces);
					global::System.GC.KeepAlive (cellular);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Connectivity']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Connectivity;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Connectivity FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Connectivity;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Connectivity> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Dd']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ErrorEvent$Dd", DoNotGenerateAcw=true)]
		public sealed partial class Dd : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Dd.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ErrorEvent$Dd$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ErrorEvent$Dd$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Dd.Companion']/constructor[@name='ErrorEvent.Dd.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Dd.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Dd;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Dd FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Dd;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Dd> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ErrorEvent$Dd", typeof (Dd));

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

			internal Dd (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Dd']/constructor[@name='ErrorEvent.Dd' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Dd () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			public unsafe long FormatVersion {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Dd']/method[@name='getFormatVersion' and count(parameter)=0]"
				[Register ("getFormatVersion", "()J", "")]
				get {
					const string __id = "getFormatVersion.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Dd']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Dd;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Dd FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Dd;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Dd> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Error']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ErrorEvent$Error", DoNotGenerateAcw=true)]
		public sealed partial class Error : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Error.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ErrorEvent$Error$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ErrorEvent$Error$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Error.Companion']/constructor[@name='ErrorEvent.Error.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Error.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Error;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Error FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Error;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Error> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ErrorEvent$Error", typeof (Error));

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

			internal Error (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Error']/constructor[@name='ErrorEvent.Error' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.datadog.android.rum.model.ErrorEvent.Source'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Boolean'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='com.datadog.android.rum.model.ErrorEvent.Resource']]"
			[Register (".ctor", "(Ljava/lang/String;Lcom/datadog/android/rum/model/ErrorEvent$Source;Ljava/lang/String;Ljava/lang/Boolean;Ljava/lang/String;Lcom/datadog/android/rum/model/ErrorEvent$Resource;)V", "")]
			public unsafe Error (string message, global::Com.Datadog.Android.Rum.Model.ErrorEvent.Source source, string stack, global::Java.Lang.Boolean isCrash, string type, global::Com.Datadog.Android.Rum.Model.ErrorEvent.Resource resource) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;Lcom/datadog/android/rum/model/ErrorEvent$Source;Ljava/lang/String;Ljava/lang/Boolean;Ljava/lang/String;Lcom/datadog/android/rum/model/ErrorEvent$Resource;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_message = JNIEnv.NewString (message);
				IntPtr native_stack = JNIEnv.NewString (stack);
				IntPtr native_type = JNIEnv.NewString (type);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [6];
					__args [0] = new JniArgumentValue (native_message);
					__args [1] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
					__args [2] = new JniArgumentValue (native_stack);
					__args [3] = new JniArgumentValue ((isCrash == null) ? IntPtr.Zero : ((global::Java.Lang.Object) isCrash).Handle);
					__args [4] = new JniArgumentValue (native_type);
					__args [5] = new JniArgumentValue ((resource == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resource).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_message);
					JNIEnv.DeleteLocalRef (native_stack);
					JNIEnv.DeleteLocalRef (native_type);
					global::System.GC.KeepAlive (source);
					global::System.GC.KeepAlive (isCrash);
					global::System.GC.KeepAlive (resource);
				}
			}

			public unsafe string Message {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Error']/method[@name='getMessage' and count(parameter)=0]"
				[Register ("getMessage", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getMessage.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Error']/method[@name='setMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setMessage", "(Ljava/lang/String;)V", "")]
				set {
					const string __id = "setMessage.(Ljava/lang/String;)V";
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_value);
						_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Resource Resource {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Error']/method[@name='getResource' and count(parameter)=0]"
				[Register ("getResource", "()Lcom/datadog/android/rum/model/ErrorEvent$Resource;", "")]
				get {
					const string __id = "getResource.()Lcom/datadog/android/rum/model/ErrorEvent$Resource;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Resource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Source Source {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Error']/method[@name='getSource' and count(parameter)=0]"
				[Register ("getSource", "()Lcom/datadog/android/rum/model/ErrorEvent$Source;", "")]
				get {
					const string __id = "getSource.()Lcom/datadog/android/rum/model/ErrorEvent$Source;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Source> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe string Stack {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Error']/method[@name='getStack' and count(parameter)=0]"
				[Register ("getStack", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getStack.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Error']/method[@name='setStack' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setStack", "(Ljava/lang/String;)V", "")]
				set {
					const string __id = "setStack.(Ljava/lang/String;)V";
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_value);
						_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			public unsafe string Type {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Error']/method[@name='getType' and count(parameter)=0]"
				[Register ("getType", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getType.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Error']/method[@name='component1' and count(parameter)=0]"
			[Register ("component1", "()Ljava/lang/String;", "")]
			public unsafe string Component1 ()
			{
				const string __id = "component1.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Error']/method[@name='component2' and count(parameter)=0]"
			[Register ("component2", "()Lcom/datadog/android/rum/model/ErrorEvent$Source;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Source Component2 ()
			{
				const string __id = "component2.()Lcom/datadog/android/rum/model/ErrorEvent$Source;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Source> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Error']/method[@name='component3' and count(parameter)=0]"
			[Register ("component3", "()Ljava/lang/String;", "")]
			public unsafe string Component3 ()
			{
				const string __id = "component3.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Error']/method[@name='component4' and count(parameter)=0]"
			[Register ("component4", "()Ljava/lang/Boolean;", "")]
			public unsafe global::Java.Lang.Boolean Component4 ()
			{
				const string __id = "component4.()Ljava/lang/Boolean;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Error']/method[@name='component5' and count(parameter)=0]"
			[Register ("component5", "()Ljava/lang/String;", "")]
			public unsafe string Component5 ()
			{
				const string __id = "component5.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Error']/method[@name='component6' and count(parameter)=0]"
			[Register ("component6", "()Lcom/datadog/android/rum/model/ErrorEvent$Resource;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Resource Component6 ()
			{
				const string __id = "component6.()Lcom/datadog/android/rum/model/ErrorEvent$Resource;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Resource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Error']/method[@name='copy' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.datadog.android.rum.model.ErrorEvent.Source'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Boolean'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='com.datadog.android.rum.model.ErrorEvent.Resource']]"
			[Register ("copy", "(Ljava/lang/String;Lcom/datadog/android/rum/model/ErrorEvent$Source;Ljava/lang/String;Ljava/lang/Boolean;Ljava/lang/String;Lcom/datadog/android/rum/model/ErrorEvent$Resource;)Lcom/datadog/android/rum/model/ErrorEvent$Error;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Error Copy (string message, global::Com.Datadog.Android.Rum.Model.ErrorEvent.Source source, string stack, global::Java.Lang.Boolean isCrash, string type, global::Com.Datadog.Android.Rum.Model.ErrorEvent.Resource resource)
			{
				const string __id = "copy.(Ljava/lang/String;Lcom/datadog/android/rum/model/ErrorEvent$Source;Ljava/lang/String;Ljava/lang/Boolean;Ljava/lang/String;Lcom/datadog/android/rum/model/ErrorEvent$Resource;)Lcom/datadog/android/rum/model/ErrorEvent$Error;";
				IntPtr native_message = JNIEnv.NewString (message);
				IntPtr native_stack = JNIEnv.NewString (stack);
				IntPtr native_type = JNIEnv.NewString (type);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [6];
					__args [0] = new JniArgumentValue (native_message);
					__args [1] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
					__args [2] = new JniArgumentValue (native_stack);
					__args [3] = new JniArgumentValue ((isCrash == null) ? IntPtr.Zero : ((global::Java.Lang.Object) isCrash).Handle);
					__args [4] = new JniArgumentValue (native_type);
					__args [5] = new JniArgumentValue ((resource == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resource).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Error> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_message);
					JNIEnv.DeleteLocalRef (native_stack);
					JNIEnv.DeleteLocalRef (native_type);
					global::System.GC.KeepAlive (source);
					global::System.GC.KeepAlive (isCrash);
					global::System.GC.KeepAlive (resource);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Error']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Error;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Error FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Error;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Error> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Error']/method[@name='isCrash' and count(parameter)=0]"
			[Register ("isCrash", "()Ljava/lang/Boolean;", "")]
			public unsafe global::Java.Lang.Boolean IsCrash ()
			{
				const string __id = "isCrash.()Ljava/lang/Boolean;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Interface']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ErrorEvent$Interface", DoNotGenerateAcw=true)]
		public sealed partial class Interface : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Interface']/field[@name='BLUETOOTH']"
			[Register ("BLUETOOTH")]
			public static global::Com.Datadog.Android.Rum.Model.ErrorEvent.Interface Bluetooth {
				get {
					const string __id = "BLUETOOTH.Lcom/datadog/android/rum/model/ErrorEvent$Interface;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Interface> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Interface']/field[@name='CELLULAR']"
			[Register ("CELLULAR")]
			public static global::Com.Datadog.Android.Rum.Model.ErrorEvent.Interface Cellular {
				get {
					const string __id = "CELLULAR.Lcom/datadog/android/rum/model/ErrorEvent$Interface;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Interface> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Interface']/field[@name='ETHERNET']"
			[Register ("ETHERNET")]
			public static global::Com.Datadog.Android.Rum.Model.ErrorEvent.Interface Ethernet {
				get {
					const string __id = "ETHERNET.Lcom/datadog/android/rum/model/ErrorEvent$Interface;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Interface> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Interface']/field[@name='MIXED']"
			[Register ("MIXED")]
			public static global::Com.Datadog.Android.Rum.Model.ErrorEvent.Interface Mixed {
				get {
					const string __id = "MIXED.Lcom/datadog/android/rum/model/ErrorEvent$Interface;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Interface> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Interface']/field[@name='NONE']"
			[Register ("NONE")]
			public static global::Com.Datadog.Android.Rum.Model.ErrorEvent.Interface None {
				get {
					const string __id = "NONE.Lcom/datadog/android/rum/model/ErrorEvent$Interface;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Interface> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Interface']/field[@name='OTHER']"
			[Register ("OTHER")]
			public static global::Com.Datadog.Android.Rum.Model.ErrorEvent.Interface Other {
				get {
					const string __id = "OTHER.Lcom/datadog/android/rum/model/ErrorEvent$Interface;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Interface> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Interface']/field[@name='UNKNOWN']"
			[Register ("UNKNOWN")]
			public static global::Com.Datadog.Android.Rum.Model.ErrorEvent.Interface Unknown {
				get {
					const string __id = "UNKNOWN.Lcom/datadog/android/rum/model/ErrorEvent$Interface;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Interface> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Interface']/field[@name='WIFI']"
			[Register ("WIFI")]
			public static global::Com.Datadog.Android.Rum.Model.ErrorEvent.Interface Wifi {
				get {
					const string __id = "WIFI.Lcom/datadog/android/rum/model/ErrorEvent$Interface;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Interface> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Interface']/field[@name='WIMAX']"
			[Register ("WIMAX")]
			public static global::Com.Datadog.Android.Rum.Model.ErrorEvent.Interface Wimax {
				get {
					const string __id = "WIMAX.Lcom/datadog/android/rum/model/ErrorEvent$Interface;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Interface> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Interface.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ErrorEvent$Interface$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ErrorEvent$Interface$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Interface.Companion']/constructor[@name='ErrorEvent.Interface.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Interface.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Interface;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Interface FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Interface;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Interface> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ErrorEvent$Interface", typeof (Interface));

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

			internal Interface (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Interface']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Interface;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Interface FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Interface;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Interface> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Interface']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Interface;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Interface ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Interface;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Interface> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Interface']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/datadog/android/rum/model/ErrorEvent$Interface;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Interface[] Values ()
			{
				const string __id = "values.()[Lcom/datadog/android/rum/model/ErrorEvent$Interface;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Datadog.Android.Rum.Model.ErrorEvent.Interface[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Datadog.Android.Rum.Model.ErrorEvent.Interface));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Method']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ErrorEvent$Method", DoNotGenerateAcw=true)]
		public sealed partial class Method : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Method']/field[@name='DELETE']"
			[Register ("DELETE")]
			public static global::Com.Datadog.Android.Rum.Model.ErrorEvent.Method Delete {
				get {
					const string __id = "DELETE.Lcom/datadog/android/rum/model/ErrorEvent$Method;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Method> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Method']/field[@name='GET']"
			[Register ("GET")]
			public static global::Com.Datadog.Android.Rum.Model.ErrorEvent.Method Get {
				get {
					const string __id = "GET.Lcom/datadog/android/rum/model/ErrorEvent$Method;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Method> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Method']/field[@name='HEAD']"
			[Register ("HEAD")]
			public static global::Com.Datadog.Android.Rum.Model.ErrorEvent.Method Head {
				get {
					const string __id = "HEAD.Lcom/datadog/android/rum/model/ErrorEvent$Method;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Method> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Method']/field[@name='PATCH']"
			[Register ("PATCH")]
			public static global::Com.Datadog.Android.Rum.Model.ErrorEvent.Method Patch {
				get {
					const string __id = "PATCH.Lcom/datadog/android/rum/model/ErrorEvent$Method;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Method> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Method']/field[@name='POST']"
			[Register ("POST")]
			public static global::Com.Datadog.Android.Rum.Model.ErrorEvent.Method Post {
				get {
					const string __id = "POST.Lcom/datadog/android/rum/model/ErrorEvent$Method;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Method> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Method']/field[@name='PUT']"
			[Register ("PUT")]
			public static global::Com.Datadog.Android.Rum.Model.ErrorEvent.Method Put {
				get {
					const string __id = "PUT.Lcom/datadog/android/rum/model/ErrorEvent$Method;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Method> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Method.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ErrorEvent$Method$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ErrorEvent$Method$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Method.Companion']/constructor[@name='ErrorEvent.Method.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Method.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Method;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Method FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Method;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Method> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ErrorEvent$Method", typeof (Method));

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

			internal Method (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Method']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Method;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Method FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Method;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Method> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Method']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Method;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Method ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Method;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Method> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Method']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/datadog/android/rum/model/ErrorEvent$Method;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Method[] Values ()
			{
				const string __id = "values.()[Lcom/datadog/android/rum/model/ErrorEvent$Method;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Datadog.Android.Rum.Model.ErrorEvent.Method[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Datadog.Android.Rum.Model.ErrorEvent.Method));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Provider']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ErrorEvent$Provider", DoNotGenerateAcw=true)]
		public sealed partial class Provider : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Provider.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ErrorEvent$Provider$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ErrorEvent$Provider$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Provider.Companion']/constructor[@name='ErrorEvent.Provider.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Provider.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Provider;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Provider FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Provider;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Provider> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ErrorEvent$Provider", typeof (Provider));

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

			internal Provider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Provider']/constructor[@name='ErrorEvent.Provider' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Provider () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Provider']/constructor[@name='ErrorEvent.Provider' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.datadog.android.rum.model.ErrorEvent.ProviderType']]"
			[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Lcom/datadog/android/rum/model/ErrorEvent$ProviderType;)V", "")]
			public unsafe Provider (string domain, string name, global::Com.Datadog.Android.Rum.Model.ErrorEvent.ProviderType type) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;Ljava/lang/String;Lcom/datadog/android/rum/model/ErrorEvent$ProviderType;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_domain = JNIEnv.NewString (domain);
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_domain);
					__args [1] = new JniArgumentValue (native_name);
					__args [2] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_domain);
					JNIEnv.DeleteLocalRef (native_name);
					global::System.GC.KeepAlive (type);
				}
			}

			public unsafe string Domain {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Provider']/method[@name='getDomain' and count(parameter)=0]"
				[Register ("getDomain", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getDomain.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe string Name {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Provider']/method[@name='getName' and count(parameter)=0]"
				[Register ("getName", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getName.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.ProviderType Type {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Provider']/method[@name='getType' and count(parameter)=0]"
				[Register ("getType", "()Lcom/datadog/android/rum/model/ErrorEvent$ProviderType;", "")]
				get {
					const string __id = "getType.()Lcom/datadog/android/rum/model/ErrorEvent$ProviderType;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.ProviderType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Provider']/method[@name='component1' and count(parameter)=0]"
			[Register ("component1", "()Ljava/lang/String;", "")]
			public unsafe string Component1 ()
			{
				const string __id = "component1.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Provider']/method[@name='component2' and count(parameter)=0]"
			[Register ("component2", "()Ljava/lang/String;", "")]
			public unsafe string Component2 ()
			{
				const string __id = "component2.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Provider']/method[@name='component3' and count(parameter)=0]"
			[Register ("component3", "()Lcom/datadog/android/rum/model/ErrorEvent$ProviderType;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.ProviderType Component3 ()
			{
				const string __id = "component3.()Lcom/datadog/android/rum/model/ErrorEvent$ProviderType;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.ProviderType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Provider']/method[@name='copy' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.datadog.android.rum.model.ErrorEvent.ProviderType']]"
			[Register ("copy", "(Ljava/lang/String;Ljava/lang/String;Lcom/datadog/android/rum/model/ErrorEvent$ProviderType;)Lcom/datadog/android/rum/model/ErrorEvent$Provider;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Provider Copy (string domain, string name, global::Com.Datadog.Android.Rum.Model.ErrorEvent.ProviderType type)
			{
				const string __id = "copy.(Ljava/lang/String;Ljava/lang/String;Lcom/datadog/android/rum/model/ErrorEvent$ProviderType;)Lcom/datadog/android/rum/model/ErrorEvent$Provider;";
				IntPtr native_domain = JNIEnv.NewString (domain);
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_domain);
					__args [1] = new JniArgumentValue (native_name);
					__args [2] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Provider> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_domain);
					JNIEnv.DeleteLocalRef (native_name);
					global::System.GC.KeepAlive (type);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Provider']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Provider;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Provider FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Provider;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Provider> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.ProviderType']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ErrorEvent$ProviderType", DoNotGenerateAcw=true)]
		public sealed partial class ProviderType : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.ProviderType']/field[@name='AD']"
			[Register ("AD")]
			public static global::Com.Datadog.Android.Rum.Model.ErrorEvent.ProviderType Ad {
				get {
					const string __id = "AD.Lcom/datadog/android/rum/model/ErrorEvent$ProviderType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.ProviderType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.ProviderType']/field[@name='ADVERTISING']"
			[Register ("ADVERTISING")]
			public static global::Com.Datadog.Android.Rum.Model.ErrorEvent.ProviderType Advertising {
				get {
					const string __id = "ADVERTISING.Lcom/datadog/android/rum/model/ErrorEvent$ProviderType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.ProviderType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.ProviderType']/field[@name='ANALYTICS']"
			[Register ("ANALYTICS")]
			public static global::Com.Datadog.Android.Rum.Model.ErrorEvent.ProviderType Analytics {
				get {
					const string __id = "ANALYTICS.Lcom/datadog/android/rum/model/ErrorEvent$ProviderType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.ProviderType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.ProviderType']/field[@name='CDN']"
			[Register ("CDN")]
			public static global::Com.Datadog.Android.Rum.Model.ErrorEvent.ProviderType Cdn {
				get {
					const string __id = "CDN.Lcom/datadog/android/rum/model/ErrorEvent$ProviderType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.ProviderType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.ProviderType']/field[@name='CONTENT']"
			[Register ("CONTENT")]
			public static global::Com.Datadog.Android.Rum.Model.ErrorEvent.ProviderType Content {
				get {
					const string __id = "CONTENT.Lcom/datadog/android/rum/model/ErrorEvent$ProviderType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.ProviderType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.ProviderType']/field[@name='CUSTOMER_SUCCESS']"
			[Register ("CUSTOMER_SUCCESS")]
			public static global::Com.Datadog.Android.Rum.Model.ErrorEvent.ProviderType CustomerSuccess {
				get {
					const string __id = "CUSTOMER_SUCCESS.Lcom/datadog/android/rum/model/ErrorEvent$ProviderType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.ProviderType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.ProviderType']/field[@name='FIRST_PARTY']"
			[Register ("FIRST_PARTY")]
			public static global::Com.Datadog.Android.Rum.Model.ErrorEvent.ProviderType FirstParty {
				get {
					const string __id = "FIRST_PARTY.Lcom/datadog/android/rum/model/ErrorEvent$ProviderType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.ProviderType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.ProviderType']/field[@name='HOSTING']"
			[Register ("HOSTING")]
			public static global::Com.Datadog.Android.Rum.Model.ErrorEvent.ProviderType Hosting {
				get {
					const string __id = "HOSTING.Lcom/datadog/android/rum/model/ErrorEvent$ProviderType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.ProviderType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.ProviderType']/field[@name='MARKETING']"
			[Register ("MARKETING")]
			public static global::Com.Datadog.Android.Rum.Model.ErrorEvent.ProviderType Marketing {
				get {
					const string __id = "MARKETING.Lcom/datadog/android/rum/model/ErrorEvent$ProviderType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.ProviderType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.ProviderType']/field[@name='OTHER']"
			[Register ("OTHER")]
			public static global::Com.Datadog.Android.Rum.Model.ErrorEvent.ProviderType Other {
				get {
					const string __id = "OTHER.Lcom/datadog/android/rum/model/ErrorEvent$ProviderType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.ProviderType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.ProviderType']/field[@name='SOCIAL']"
			[Register ("SOCIAL")]
			public static global::Com.Datadog.Android.Rum.Model.ErrorEvent.ProviderType Social {
				get {
					const string __id = "SOCIAL.Lcom/datadog/android/rum/model/ErrorEvent$ProviderType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.ProviderType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.ProviderType']/field[@name='TAG_MANAGER']"
			[Register ("TAG_MANAGER")]
			public static global::Com.Datadog.Android.Rum.Model.ErrorEvent.ProviderType TagManager {
				get {
					const string __id = "TAG_MANAGER.Lcom/datadog/android/rum/model/ErrorEvent$ProviderType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.ProviderType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.ProviderType']/field[@name='UTILITY']"
			[Register ("UTILITY")]
			public static global::Com.Datadog.Android.Rum.Model.ErrorEvent.ProviderType Utility {
				get {
					const string __id = "UTILITY.Lcom/datadog/android/rum/model/ErrorEvent$ProviderType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.ProviderType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.ProviderType']/field[@name='VIDEO']"
			[Register ("VIDEO")]
			public static global::Com.Datadog.Android.Rum.Model.ErrorEvent.ProviderType Video {
				get {
					const string __id = "VIDEO.Lcom/datadog/android/rum/model/ErrorEvent$ProviderType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.ProviderType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.ProviderType.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ErrorEvent$ProviderType$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ErrorEvent$ProviderType$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.ProviderType.Companion']/constructor[@name='ErrorEvent.ProviderType.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.ProviderType.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$ProviderType;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.ProviderType FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$ProviderType;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.ProviderType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ErrorEvent$ProviderType", typeof (ProviderType));

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

			internal ProviderType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.ProviderType']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$ProviderType;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.ProviderType FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$ProviderType;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.ProviderType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.ProviderType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$ProviderType;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.ProviderType ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$ProviderType;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.ProviderType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.ProviderType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/datadog/android/rum/model/ErrorEvent$ProviderType;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.ProviderType[] Values ()
			{
				const string __id = "values.()[Lcom/datadog/android/rum/model/ErrorEvent$ProviderType;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Datadog.Android.Rum.Model.ErrorEvent.ProviderType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Datadog.Android.Rum.Model.ErrorEvent.ProviderType));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Resource']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ErrorEvent$Resource", DoNotGenerateAcw=true)]
		public sealed partial class Resource : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Resource.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ErrorEvent$Resource$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ErrorEvent$Resource$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Resource.Companion']/constructor[@name='ErrorEvent.Resource.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Resource.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Resource;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Resource FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Resource;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Resource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ErrorEvent$Resource", typeof (Resource));

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

			internal Resource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Resource']/constructor[@name='ErrorEvent.Resource' and count(parameter)=4 and parameter[1][@type='com.datadog.android.rum.model.ErrorEvent.Method'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.datadog.android.rum.model.ErrorEvent.Provider']]"
			[Register (".ctor", "(Lcom/datadog/android/rum/model/ErrorEvent$Method;JLjava/lang/String;Lcom/datadog/android/rum/model/ErrorEvent$Provider;)V", "")]
			public unsafe Resource (global::Com.Datadog.Android.Rum.Model.ErrorEvent.Method method, long statusCode, string url, global::Com.Datadog.Android.Rum.Model.ErrorEvent.Provider provider) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lcom/datadog/android/rum/model/ErrorEvent$Method;JLjava/lang/String;Lcom/datadog/android/rum/model/ErrorEvent$Provider;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_url = JNIEnv.NewString (url);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue ((method == null) ? IntPtr.Zero : ((global::Java.Lang.Object) method).Handle);
					__args [1] = new JniArgumentValue (statusCode);
					__args [2] = new JniArgumentValue (native_url);
					__args [3] = new JniArgumentValue ((provider == null) ? IntPtr.Zero : ((global::Java.Lang.Object) provider).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_url);
					global::System.GC.KeepAlive (method);
					global::System.GC.KeepAlive (provider);
				}
			}

			public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Method Method {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Resource']/method[@name='getMethod' and count(parameter)=0]"
				[Register ("getMethod", "()Lcom/datadog/android/rum/model/ErrorEvent$Method;", "")]
				get {
					const string __id = "getMethod.()Lcom/datadog/android/rum/model/ErrorEvent$Method;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Method> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Provider Provider {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Resource']/method[@name='getProvider' and count(parameter)=0]"
				[Register ("getProvider", "()Lcom/datadog/android/rum/model/ErrorEvent$Provider;", "")]
				get {
					const string __id = "getProvider.()Lcom/datadog/android/rum/model/ErrorEvent$Provider;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Provider> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe long StatusCode {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Resource']/method[@name='getStatusCode' and count(parameter)=0]"
				[Register ("getStatusCode", "()J", "")]
				get {
					const string __id = "getStatusCode.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe string Url {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Resource']/method[@name='getUrl' and count(parameter)=0]"
				[Register ("getUrl", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getUrl.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Resource']/method[@name='setUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setUrl", "(Ljava/lang/String;)V", "")]
				set {
					const string __id = "setUrl.(Ljava/lang/String;)V";
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_value);
						_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Resource']/method[@name='component1' and count(parameter)=0]"
			[Register ("component1", "()Lcom/datadog/android/rum/model/ErrorEvent$Method;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Method Component1 ()
			{
				const string __id = "component1.()Lcom/datadog/android/rum/model/ErrorEvent$Method;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Method> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Resource']/method[@name='component2' and count(parameter)=0]"
			[Register ("component2", "()J", "")]
			public unsafe long Component2 ()
			{
				const string __id = "component2.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Resource']/method[@name='component3' and count(parameter)=0]"
			[Register ("component3", "()Ljava/lang/String;", "")]
			public unsafe string Component3 ()
			{
				const string __id = "component3.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Resource']/method[@name='component4' and count(parameter)=0]"
			[Register ("component4", "()Lcom/datadog/android/rum/model/ErrorEvent$Provider;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Provider Component4 ()
			{
				const string __id = "component4.()Lcom/datadog/android/rum/model/ErrorEvent$Provider;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Provider> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Resource']/method[@name='copy' and count(parameter)=4 and parameter[1][@type='com.datadog.android.rum.model.ErrorEvent.Method'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.datadog.android.rum.model.ErrorEvent.Provider']]"
			[Register ("copy", "(Lcom/datadog/android/rum/model/ErrorEvent$Method;JLjava/lang/String;Lcom/datadog/android/rum/model/ErrorEvent$Provider;)Lcom/datadog/android/rum/model/ErrorEvent$Resource;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Resource Copy (global::Com.Datadog.Android.Rum.Model.ErrorEvent.Method method, long statusCode, string url, global::Com.Datadog.Android.Rum.Model.ErrorEvent.Provider provider)
			{
				const string __id = "copy.(Lcom/datadog/android/rum/model/ErrorEvent$Method;JLjava/lang/String;Lcom/datadog/android/rum/model/ErrorEvent$Provider;)Lcom/datadog/android/rum/model/ErrorEvent$Resource;";
				IntPtr native_url = JNIEnv.NewString (url);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue ((method == null) ? IntPtr.Zero : ((global::Java.Lang.Object) method).Handle);
					__args [1] = new JniArgumentValue (statusCode);
					__args [2] = new JniArgumentValue (native_url);
					__args [3] = new JniArgumentValue ((provider == null) ? IntPtr.Zero : ((global::Java.Lang.Object) provider).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Resource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_url);
					global::System.GC.KeepAlive (method);
					global::System.GC.KeepAlive (provider);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Resource']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Resource;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Resource FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Resource;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Resource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Session']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ErrorEvent$Session", DoNotGenerateAcw=true)]
		public sealed partial class Session : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Session.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ErrorEvent$Session$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ErrorEvent$Session$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Session.Companion']/constructor[@name='ErrorEvent.Session.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Session.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Session;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Session FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Session;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Session> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ErrorEvent$Session", typeof (Session));

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

			internal Session (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Session']/constructor[@name='ErrorEvent.Session' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.datadog.android.rum.model.ErrorEvent.SessionType'] and parameter[3][@type='java.lang.Boolean']]"
			[Register (".ctor", "(Ljava/lang/String;Lcom/datadog/android/rum/model/ErrorEvent$SessionType;Ljava/lang/Boolean;)V", "")]
			public unsafe Session (string id, global::Com.Datadog.Android.Rum.Model.ErrorEvent.SessionType type, global::Java.Lang.Boolean hasReplay) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;Lcom/datadog/android/rum/model/ErrorEvent$SessionType;Ljava/lang/Boolean;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_id = JNIEnv.NewString (id);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_id);
					__args [1] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
					__args [2] = new JniArgumentValue ((hasReplay == null) ? IntPtr.Zero : ((global::Java.Lang.Object) hasReplay).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_id);
					global::System.GC.KeepAlive (type);
					global::System.GC.KeepAlive (hasReplay);
				}
			}

			public unsafe global::Java.Lang.Boolean HasReplay {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Session']/method[@name='getHasReplay' and count(parameter)=0]"
				[Register ("getHasReplay", "()Ljava/lang/Boolean;", "")]
				get {
					const string __id = "getHasReplay.()Ljava/lang/Boolean;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe string Id {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Session']/method[@name='getId' and count(parameter)=0]"
				[Register ("getId", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getId.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.SessionType Type {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Session']/method[@name='getType' and count(parameter)=0]"
				[Register ("getType", "()Lcom/datadog/android/rum/model/ErrorEvent$SessionType;", "")]
				get {
					const string __id = "getType.()Lcom/datadog/android/rum/model/ErrorEvent$SessionType;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.SessionType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Session']/method[@name='component1' and count(parameter)=0]"
			[Register ("component1", "()Ljava/lang/String;", "")]
			public unsafe string Component1 ()
			{
				const string __id = "component1.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Session']/method[@name='component2' and count(parameter)=0]"
			[Register ("component2", "()Lcom/datadog/android/rum/model/ErrorEvent$SessionType;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.SessionType Component2 ()
			{
				const string __id = "component2.()Lcom/datadog/android/rum/model/ErrorEvent$SessionType;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.SessionType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Session']/method[@name='component3' and count(parameter)=0]"
			[Register ("component3", "()Ljava/lang/Boolean;", "")]
			public unsafe global::Java.Lang.Boolean Component3 ()
			{
				const string __id = "component3.()Ljava/lang/Boolean;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Session']/method[@name='copy' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.datadog.android.rum.model.ErrorEvent.SessionType'] and parameter[3][@type='java.lang.Boolean']]"
			[Register ("copy", "(Ljava/lang/String;Lcom/datadog/android/rum/model/ErrorEvent$SessionType;Ljava/lang/Boolean;)Lcom/datadog/android/rum/model/ErrorEvent$Session;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Session Copy (string id, global::Com.Datadog.Android.Rum.Model.ErrorEvent.SessionType type, global::Java.Lang.Boolean hasReplay)
			{
				const string __id = "copy.(Ljava/lang/String;Lcom/datadog/android/rum/model/ErrorEvent$SessionType;Ljava/lang/Boolean;)Lcom/datadog/android/rum/model/ErrorEvent$Session;";
				IntPtr native_id = JNIEnv.NewString (id);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_id);
					__args [1] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
					__args [2] = new JniArgumentValue ((hasReplay == null) ? IntPtr.Zero : ((global::Java.Lang.Object) hasReplay).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Session> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_id);
					global::System.GC.KeepAlive (type);
					global::System.GC.KeepAlive (hasReplay);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Session']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Session;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Session FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Session;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Session> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.SessionType']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ErrorEvent$SessionType", DoNotGenerateAcw=true)]
		public sealed partial class SessionType : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.SessionType']/field[@name='SYNTHETICS']"
			[Register ("SYNTHETICS")]
			public static global::Com.Datadog.Android.Rum.Model.ErrorEvent.SessionType Synthetics {
				get {
					const string __id = "SYNTHETICS.Lcom/datadog/android/rum/model/ErrorEvent$SessionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.SessionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.SessionType']/field[@name='USER']"
			[Register ("USER")]
			public static global::Com.Datadog.Android.Rum.Model.ErrorEvent.SessionType User {
				get {
					const string __id = "USER.Lcom/datadog/android/rum/model/ErrorEvent$SessionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.SessionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.SessionType.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ErrorEvent$SessionType$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ErrorEvent$SessionType$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.SessionType.Companion']/constructor[@name='ErrorEvent.SessionType.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.SessionType.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$SessionType;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.SessionType FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$SessionType;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.SessionType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ErrorEvent$SessionType", typeof (SessionType));

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

			internal SessionType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.SessionType']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$SessionType;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.SessionType FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$SessionType;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.SessionType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.SessionType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$SessionType;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.SessionType ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$SessionType;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.SessionType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.SessionType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/datadog/android/rum/model/ErrorEvent$SessionType;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.SessionType[] Values ()
			{
				const string __id = "values.()[Lcom/datadog/android/rum/model/ErrorEvent$SessionType;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Datadog.Android.Rum.Model.ErrorEvent.SessionType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Datadog.Android.Rum.Model.ErrorEvent.SessionType));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Source']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ErrorEvent$Source", DoNotGenerateAcw=true)]
		public sealed partial class Source : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Source']/field[@name='AGENT']"
			[Register ("AGENT")]
			public static global::Com.Datadog.Android.Rum.Model.ErrorEvent.Source Agent {
				get {
					const string __id = "AGENT.Lcom/datadog/android/rum/model/ErrorEvent$Source;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Source> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Source']/field[@name='CONSOLE']"
			[Register ("CONSOLE")]
			public static global::Com.Datadog.Android.Rum.Model.ErrorEvent.Source Console {
				get {
					const string __id = "CONSOLE.Lcom/datadog/android/rum/model/ErrorEvent$Source;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Source> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Source']/field[@name='CUSTOM']"
			[Register ("CUSTOM")]
			public static global::Com.Datadog.Android.Rum.Model.ErrorEvent.Source Custom {
				get {
					const string __id = "CUSTOM.Lcom/datadog/android/rum/model/ErrorEvent$Source;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Source> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Source']/field[@name='LOGGER']"
			[Register ("LOGGER")]
			public static global::Com.Datadog.Android.Rum.Model.ErrorEvent.Source Logger {
				get {
					const string __id = "LOGGER.Lcom/datadog/android/rum/model/ErrorEvent$Source;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Source> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Source']/field[@name='NETWORK']"
			[Register ("NETWORK")]
			public static global::Com.Datadog.Android.Rum.Model.ErrorEvent.Source Network {
				get {
					const string __id = "NETWORK.Lcom/datadog/android/rum/model/ErrorEvent$Source;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Source> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Source']/field[@name='SOURCE']"
			[Register ("SOURCE")]
			public static global::Com.Datadog.Android.Rum.Model.ErrorEvent.Source ErrorSource {
				get {
					const string __id = "SOURCE.Lcom/datadog/android/rum/model/ErrorEvent$Source;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Source> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Source']/field[@name='WEBVIEW']"
			[Register ("WEBVIEW")]
			public static global::Com.Datadog.Android.Rum.Model.ErrorEvent.Source Webview {
				get {
					const string __id = "WEBVIEW.Lcom/datadog/android/rum/model/ErrorEvent$Source;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Source> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Source.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ErrorEvent$Source$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ErrorEvent$Source$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Source.Companion']/constructor[@name='ErrorEvent.Source.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Source.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Source;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Source FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Source;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Source> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ErrorEvent$Source", typeof (Source));

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

			internal Source (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Source']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Source;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Source FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Source;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Source> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Source']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Source;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Source ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Source;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Source> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Source']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/datadog/android/rum/model/ErrorEvent$Source;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Source[] Values ()
			{
				const string __id = "values.()[Lcom/datadog/android/rum/model/ErrorEvent$Source;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Datadog.Android.Rum.Model.ErrorEvent.Source[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Datadog.Android.Rum.Model.ErrorEvent.Source));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Status']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ErrorEvent$Status", DoNotGenerateAcw=true)]
		public sealed partial class Status : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Status']/field[@name='CONNECTED']"
			[Register ("CONNECTED")]
			public static global::Com.Datadog.Android.Rum.Model.ErrorEvent.Status Connected {
				get {
					const string __id = "CONNECTED.Lcom/datadog/android/rum/model/ErrorEvent$Status;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Status> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Status']/field[@name='MAYBE']"
			[Register ("MAYBE")]
			public static global::Com.Datadog.Android.Rum.Model.ErrorEvent.Status Maybe {
				get {
					const string __id = "MAYBE.Lcom/datadog/android/rum/model/ErrorEvent$Status;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Status> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Status']/field[@name='NOT_CONNECTED']"
			[Register ("NOT_CONNECTED")]
			public static global::Com.Datadog.Android.Rum.Model.ErrorEvent.Status NotConnected {
				get {
					const string __id = "NOT_CONNECTED.Lcom/datadog/android/rum/model/ErrorEvent$Status;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Status> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Status.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ErrorEvent$Status$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ErrorEvent$Status$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Status.Companion']/constructor[@name='ErrorEvent.Status.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Status.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Status;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Status FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Status;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Status> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ErrorEvent$Status", typeof (Status));

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

			internal Status (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Status']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Status;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Status FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Status;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Status> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Status']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Status;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Status ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Status;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Status> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Status']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/datadog/android/rum/model/ErrorEvent$Status;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Status[] Values ()
			{
				const string __id = "values.()[Lcom/datadog/android/rum/model/ErrorEvent$Status;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Datadog.Android.Rum.Model.ErrorEvent.Status[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Datadog.Android.Rum.Model.ErrorEvent.Status));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Usr']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ErrorEvent$Usr", DoNotGenerateAcw=true)]
		public sealed partial class Usr : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Usr.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ErrorEvent$Usr$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ErrorEvent$Usr$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Usr.Companion']/constructor[@name='ErrorEvent.Usr.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Usr.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Usr;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Usr FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Usr;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Usr> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ErrorEvent$Usr", typeof (Usr));

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

			internal Usr (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Usr']/constructor[@name='ErrorEvent.Usr' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Usr () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Usr']/constructor[@name='ErrorEvent.Usr' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
			public unsafe Usr (string id, string name, string email) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_id = JNIEnv.NewString (id);
				IntPtr native_name = JNIEnv.NewString (name);
				IntPtr native_email = JNIEnv.NewString (email);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_id);
					__args [1] = new JniArgumentValue (native_name);
					__args [2] = new JniArgumentValue (native_email);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_id);
					JNIEnv.DeleteLocalRef (native_name);
					JNIEnv.DeleteLocalRef (native_email);
				}
			}

			public unsafe string Email {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Usr']/method[@name='getEmail' and count(parameter)=0]"
				[Register ("getEmail", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getEmail.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe string Id {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Usr']/method[@name='getId' and count(parameter)=0]"
				[Register ("getId", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getId.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe string Name {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Usr']/method[@name='getName' and count(parameter)=0]"
				[Register ("getName", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getName.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Usr']/method[@name='component1' and count(parameter)=0]"
			[Register ("component1", "()Ljava/lang/String;", "")]
			public unsafe string Component1 ()
			{
				const string __id = "component1.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Usr']/method[@name='component2' and count(parameter)=0]"
			[Register ("component2", "()Ljava/lang/String;", "")]
			public unsafe string Component2 ()
			{
				const string __id = "component2.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Usr']/method[@name='component3' and count(parameter)=0]"
			[Register ("component3", "()Ljava/lang/String;", "")]
			public unsafe string Component3 ()
			{
				const string __id = "component3.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Usr']/method[@name='copy' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register ("copy", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Usr;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Usr Copy (string id, string name, string email)
			{
				const string __id = "copy.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Usr;";
				IntPtr native_id = JNIEnv.NewString (id);
				IntPtr native_name = JNIEnv.NewString (name);
				IntPtr native_email = JNIEnv.NewString (email);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_id);
					__args [1] = new JniArgumentValue (native_name);
					__args [2] = new JniArgumentValue (native_email);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Usr> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_id);
					JNIEnv.DeleteLocalRef (native_name);
					JNIEnv.DeleteLocalRef (native_email);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.Usr']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Usr;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Usr FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$Usr;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Usr> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.View']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ErrorEvent$View", DoNotGenerateAcw=true)]
		public sealed partial class View : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.View.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ErrorEvent$View$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ErrorEvent$View$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.View.Companion']/constructor[@name='ErrorEvent.View.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.View.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$View;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.View FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$View;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ErrorEvent$View", typeof (View));

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

			internal View (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.View']/constructor[@name='ErrorEvent.View' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
			public unsafe View (string id, string referrer, string url) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_id = JNIEnv.NewString (id);
				IntPtr native_referrer = JNIEnv.NewString (referrer);
				IntPtr native_url = JNIEnv.NewString (url);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_id);
					__args [1] = new JniArgumentValue (native_referrer);
					__args [2] = new JniArgumentValue (native_url);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_id);
					JNIEnv.DeleteLocalRef (native_referrer);
					JNIEnv.DeleteLocalRef (native_url);
				}
			}

			public unsafe string Id {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.View']/method[@name='getId' and count(parameter)=0]"
				[Register ("getId", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getId.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe string Referrer {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.View']/method[@name='getReferrer' and count(parameter)=0]"
				[Register ("getReferrer", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getReferrer.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.View']/method[@name='setReferrer' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setReferrer", "(Ljava/lang/String;)V", "")]
				set {
					const string __id = "setReferrer.(Ljava/lang/String;)V";
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_value);
						_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			public unsafe string Url {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.View']/method[@name='getUrl' and count(parameter)=0]"
				[Register ("getUrl", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getUrl.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.View']/method[@name='setUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setUrl", "(Ljava/lang/String;)V", "")]
				set {
					const string __id = "setUrl.(Ljava/lang/String;)V";
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_value);
						_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.View']/method[@name='component1' and count(parameter)=0]"
			[Register ("component1", "()Ljava/lang/String;", "")]
			public unsafe string Component1 ()
			{
				const string __id = "component1.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.View']/method[@name='component2' and count(parameter)=0]"
			[Register ("component2", "()Ljava/lang/String;", "")]
			public unsafe string Component2 ()
			{
				const string __id = "component2.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.View']/method[@name='component3' and count(parameter)=0]"
			[Register ("component3", "()Ljava/lang/String;", "")]
			public unsafe string Component3 ()
			{
				const string __id = "component3.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.View']/method[@name='copy' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register ("copy", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$View;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.View Copy (string id, string referrer, string url)
			{
				const string __id = "copy.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$View;";
				IntPtr native_id = JNIEnv.NewString (id);
				IntPtr native_referrer = JNIEnv.NewString (referrer);
				IntPtr native_url = JNIEnv.NewString (url);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_id);
					__args [1] = new JniArgumentValue (native_referrer);
					__args [2] = new JniArgumentValue (native_url);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_id);
					JNIEnv.DeleteLocalRef (native_referrer);
					JNIEnv.DeleteLocalRef (native_url);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent.View']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$View;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.View FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent$View;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ErrorEvent", typeof (ErrorEvent));

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

		internal ErrorEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent']/constructor[@name='ErrorEvent' and count(parameter)=10 and parameter[1][@type='long'] and parameter[2][@type='com.datadog.android.rum.model.ErrorEvent.Application'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.datadog.android.rum.model.ErrorEvent.Session'] and parameter[5][@type='com.datadog.android.rum.model.ErrorEvent.View'] and parameter[6][@type='com.datadog.android.rum.model.ErrorEvent.Usr'] and parameter[7][@type='com.datadog.android.rum.model.ErrorEvent.Connectivity'] and parameter[8][@type='com.datadog.android.rum.model.ErrorEvent.Dd'] and parameter[9][@type='com.datadog.android.rum.model.ErrorEvent.Error'] and parameter[10][@type='com.datadog.android.rum.model.ErrorEvent.Action']]"
		[Register (".ctor", "(JLcom/datadog/android/rum/model/ErrorEvent$Application;Ljava/lang/String;Lcom/datadog/android/rum/model/ErrorEvent$Session;Lcom/datadog/android/rum/model/ErrorEvent$View;Lcom/datadog/android/rum/model/ErrorEvent$Usr;Lcom/datadog/android/rum/model/ErrorEvent$Connectivity;Lcom/datadog/android/rum/model/ErrorEvent$Dd;Lcom/datadog/android/rum/model/ErrorEvent$Error;Lcom/datadog/android/rum/model/ErrorEvent$Action;)V", "")]
		public unsafe ErrorEvent (long date, global::Com.Datadog.Android.Rum.Model.ErrorEvent.Application application, string service, global::Com.Datadog.Android.Rum.Model.ErrorEvent.Session session, global::Com.Datadog.Android.Rum.Model.ErrorEvent.View view, global::Com.Datadog.Android.Rum.Model.ErrorEvent.Usr usr, global::Com.Datadog.Android.Rum.Model.ErrorEvent.Connectivity connectivity, global::Com.Datadog.Android.Rum.Model.ErrorEvent.Dd dd, global::Com.Datadog.Android.Rum.Model.ErrorEvent.Error error, global::Com.Datadog.Android.Rum.Model.ErrorEvent.Action action) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(JLcom/datadog/android/rum/model/ErrorEvent$Application;Ljava/lang/String;Lcom/datadog/android/rum/model/ErrorEvent$Session;Lcom/datadog/android/rum/model/ErrorEvent$View;Lcom/datadog/android/rum/model/ErrorEvent$Usr;Lcom/datadog/android/rum/model/ErrorEvent$Connectivity;Lcom/datadog/android/rum/model/ErrorEvent$Dd;Lcom/datadog/android/rum/model/ErrorEvent$Error;Lcom/datadog/android/rum/model/ErrorEvent$Action;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_service = JNIEnv.NewString (service);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [10];
				__args [0] = new JniArgumentValue (date);
				__args [1] = new JniArgumentValue ((application == null) ? IntPtr.Zero : ((global::Java.Lang.Object) application).Handle);
				__args [2] = new JniArgumentValue (native_service);
				__args [3] = new JniArgumentValue ((session == null) ? IntPtr.Zero : ((global::Java.Lang.Object) session).Handle);
				__args [4] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [5] = new JniArgumentValue ((usr == null) ? IntPtr.Zero : ((global::Java.Lang.Object) usr).Handle);
				__args [6] = new JniArgumentValue ((connectivity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) connectivity).Handle);
				__args [7] = new JniArgumentValue ((dd == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dd).Handle);
				__args [8] = new JniArgumentValue ((error == null) ? IntPtr.Zero : ((global::Java.Lang.Object) error).Handle);
				__args [9] = new JniArgumentValue ((action == null) ? IntPtr.Zero : ((global::Java.Lang.Object) action).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_service);
				global::System.GC.KeepAlive (application);
				global::System.GC.KeepAlive (session);
				global::System.GC.KeepAlive (view);
				global::System.GC.KeepAlive (usr);
				global::System.GC.KeepAlive (connectivity);
				global::System.GC.KeepAlive (dd);
				global::System.GC.KeepAlive (error);
				global::System.GC.KeepAlive (action);
			}
		}

		public unsafe long Date {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent']/method[@name='getDate' and count(parameter)=0]"
			[Register ("getDate", "()J", "")]
			get {
				const string __id = "getDate.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe string Service {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent']/method[@name='getService' and count(parameter)=0]"
			[Register ("getService", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getService.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent']/method[@name='component1' and count(parameter)=0]"
		[Register ("component1", "()J", "")]
		public unsafe long Component1 ()
		{
			const string __id = "component1.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent']/method[@name='component10' and count(parameter)=0]"
		[Register ("component10", "()Lcom/datadog/android/rum/model/ErrorEvent$Action;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Action Component10 ()
		{
			const string __id = "component10.()Lcom/datadog/android/rum/model/ErrorEvent$Action;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Action> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent']/method[@name='component2' and count(parameter)=0]"
		[Register ("component2", "()Lcom/datadog/android/rum/model/ErrorEvent$Application;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Application Component2 ()
		{
			const string __id = "component2.()Lcom/datadog/android/rum/model/ErrorEvent$Application;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Application> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent']/method[@name='component3' and count(parameter)=0]"
		[Register ("component3", "()Ljava/lang/String;", "")]
		public unsafe string Component3 ()
		{
			const string __id = "component3.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent']/method[@name='component4' and count(parameter)=0]"
		[Register ("component4", "()Lcom/datadog/android/rum/model/ErrorEvent$Session;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Session Component4 ()
		{
			const string __id = "component4.()Lcom/datadog/android/rum/model/ErrorEvent$Session;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Session> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent']/method[@name='component5' and count(parameter)=0]"
		[Register ("component5", "()Lcom/datadog/android/rum/model/ErrorEvent$View;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.View Component5 ()
		{
			const string __id = "component5.()Lcom/datadog/android/rum/model/ErrorEvent$View;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent']/method[@name='component6' and count(parameter)=0]"
		[Register ("component6", "()Lcom/datadog/android/rum/model/ErrorEvent$Usr;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Usr Component6 ()
		{
			const string __id = "component6.()Lcom/datadog/android/rum/model/ErrorEvent$Usr;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Usr> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent']/method[@name='component7' and count(parameter)=0]"
		[Register ("component7", "()Lcom/datadog/android/rum/model/ErrorEvent$Connectivity;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Connectivity Component7 ()
		{
			const string __id = "component7.()Lcom/datadog/android/rum/model/ErrorEvent$Connectivity;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Connectivity> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent']/method[@name='component8' and count(parameter)=0]"
		[Register ("component8", "()Lcom/datadog/android/rum/model/ErrorEvent$Dd;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Dd Component8 ()
		{
			const string __id = "component8.()Lcom/datadog/android/rum/model/ErrorEvent$Dd;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Dd> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent']/method[@name='component9' and count(parameter)=0]"
		[Register ("component9", "()Lcom/datadog/android/rum/model/ErrorEvent$Error;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Error Component9 ()
		{
			const string __id = "component9.()Lcom/datadog/android/rum/model/ErrorEvent$Error;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Error> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent']/method[@name='copy' and count(parameter)=10 and parameter[1][@type='long'] and parameter[2][@type='com.datadog.android.rum.model.ErrorEvent.Application'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.datadog.android.rum.model.ErrorEvent.Session'] and parameter[5][@type='com.datadog.android.rum.model.ErrorEvent.View'] and parameter[6][@type='com.datadog.android.rum.model.ErrorEvent.Usr'] and parameter[7][@type='com.datadog.android.rum.model.ErrorEvent.Connectivity'] and parameter[8][@type='com.datadog.android.rum.model.ErrorEvent.Dd'] and parameter[9][@type='com.datadog.android.rum.model.ErrorEvent.Error'] and parameter[10][@type='com.datadog.android.rum.model.ErrorEvent.Action']]"
		[Register ("copy", "(JLcom/datadog/android/rum/model/ErrorEvent$Application;Ljava/lang/String;Lcom/datadog/android/rum/model/ErrorEvent$Session;Lcom/datadog/android/rum/model/ErrorEvent$View;Lcom/datadog/android/rum/model/ErrorEvent$Usr;Lcom/datadog/android/rum/model/ErrorEvent$Connectivity;Lcom/datadog/android/rum/model/ErrorEvent$Dd;Lcom/datadog/android/rum/model/ErrorEvent$Error;Lcom/datadog/android/rum/model/ErrorEvent$Action;)Lcom/datadog/android/rum/model/ErrorEvent;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent Copy (long date, global::Com.Datadog.Android.Rum.Model.ErrorEvent.Application application, string service, global::Com.Datadog.Android.Rum.Model.ErrorEvent.Session session, global::Com.Datadog.Android.Rum.Model.ErrorEvent.View view, global::Com.Datadog.Android.Rum.Model.ErrorEvent.Usr usr, global::Com.Datadog.Android.Rum.Model.ErrorEvent.Connectivity connectivity, global::Com.Datadog.Android.Rum.Model.ErrorEvent.Dd dd, global::Com.Datadog.Android.Rum.Model.ErrorEvent.Error error, global::Com.Datadog.Android.Rum.Model.ErrorEvent.Action action)
		{
			const string __id = "copy.(JLcom/datadog/android/rum/model/ErrorEvent$Application;Ljava/lang/String;Lcom/datadog/android/rum/model/ErrorEvent$Session;Lcom/datadog/android/rum/model/ErrorEvent$View;Lcom/datadog/android/rum/model/ErrorEvent$Usr;Lcom/datadog/android/rum/model/ErrorEvent$Connectivity;Lcom/datadog/android/rum/model/ErrorEvent$Dd;Lcom/datadog/android/rum/model/ErrorEvent$Error;Lcom/datadog/android/rum/model/ErrorEvent$Action;)Lcom/datadog/android/rum/model/ErrorEvent;";
			IntPtr native_service = JNIEnv.NewString (service);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [10];
				__args [0] = new JniArgumentValue (date);
				__args [1] = new JniArgumentValue ((application == null) ? IntPtr.Zero : ((global::Java.Lang.Object) application).Handle);
				__args [2] = new JniArgumentValue (native_service);
				__args [3] = new JniArgumentValue ((session == null) ? IntPtr.Zero : ((global::Java.Lang.Object) session).Handle);
				__args [4] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [5] = new JniArgumentValue ((usr == null) ? IntPtr.Zero : ((global::Java.Lang.Object) usr).Handle);
				__args [6] = new JniArgumentValue ((connectivity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) connectivity).Handle);
				__args [7] = new JniArgumentValue ((dd == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dd).Handle);
				__args [8] = new JniArgumentValue ((error == null) ? IntPtr.Zero : ((global::Java.Lang.Object) error).Handle);
				__args [9] = new JniArgumentValue ((action == null) ? IntPtr.Zero : ((global::Java.Lang.Object) action).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_service);
				global::System.GC.KeepAlive (application);
				global::System.GC.KeepAlive (session);
				global::System.GC.KeepAlive (view);
				global::System.GC.KeepAlive (usr);
				global::System.GC.KeepAlive (connectivity);
				global::System.GC.KeepAlive (dd);
				global::System.GC.KeepAlive (error);
				global::System.GC.KeepAlive (action);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent;", "")]
		public static unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent FromJson (string serializedObject)
		{
			const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ErrorEvent;";
			IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_serializedObject);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_serializedObject);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent']/method[@name='getAction' and count(parameter)=0]"
		[Register ("getAction", "()Lcom/datadog/android/rum/model/ErrorEvent$Action;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Action GetAction ()
		{
			const string __id = "getAction.()Lcom/datadog/android/rum/model/ErrorEvent$Action;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Action> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent']/method[@name='getApplication' and count(parameter)=0]"
		[Register ("getApplication", "()Lcom/datadog/android/rum/model/ErrorEvent$Application;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Application GetApplication ()
		{
			const string __id = "getApplication.()Lcom/datadog/android/rum/model/ErrorEvent$Application;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Application> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent']/method[@name='getConnectivity' and count(parameter)=0]"
		[Register ("getConnectivity", "()Lcom/datadog/android/rum/model/ErrorEvent$Connectivity;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Connectivity GetConnectivity ()
		{
			const string __id = "getConnectivity.()Lcom/datadog/android/rum/model/ErrorEvent$Connectivity;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Connectivity> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent']/method[@name='getDd' and count(parameter)=0]"
		[Register ("getDd", "()Lcom/datadog/android/rum/model/ErrorEvent$Dd;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Dd GetDd ()
		{
			const string __id = "getDd.()Lcom/datadog/android/rum/model/ErrorEvent$Dd;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Dd> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent']/method[@name='getError' and count(parameter)=0]"
		[Register ("getError", "()Lcom/datadog/android/rum/model/ErrorEvent$Error;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Error GetError ()
		{
			const string __id = "getError.()Lcom/datadog/android/rum/model/ErrorEvent$Error;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Error> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent']/method[@name='getSession' and count(parameter)=0]"
		[Register ("getSession", "()Lcom/datadog/android/rum/model/ErrorEvent$Session;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Session GetSession ()
		{
			const string __id = "getSession.()Lcom/datadog/android/rum/model/ErrorEvent$Session;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Session> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent']/method[@name='getUsr' and count(parameter)=0]"
		[Register ("getUsr", "()Lcom/datadog/android/rum/model/ErrorEvent$Usr;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.Usr GetUsr ()
		{
			const string __id = "getUsr.()Lcom/datadog/android/rum/model/ErrorEvent$Usr;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.Usr> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ErrorEvent']/method[@name='getView' and count(parameter)=0]"
		[Register ("getView", "()Lcom/datadog/android/rum/model/ErrorEvent$View;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ErrorEvent.View GetView ()
		{
			const string __id = "getView.()Lcom/datadog/android/rum/model/ErrorEvent$View;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ErrorEvent.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
