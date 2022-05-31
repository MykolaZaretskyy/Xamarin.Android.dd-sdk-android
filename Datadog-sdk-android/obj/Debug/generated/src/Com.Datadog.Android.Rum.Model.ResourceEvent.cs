using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Android.Rum.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent']"
	[global::Android.Runtime.Register ("com/datadog/android/rum/model/ResourceEvent", DoNotGenerateAcw=true)]
	public sealed partial class ResourceEvent : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Action']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ResourceEvent$Action", DoNotGenerateAcw=true)]
		public sealed partial class Action : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Action.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ResourceEvent$Action$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ResourceEvent$Action$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Action.Companion']/constructor[@name='ResourceEvent.Action.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Action.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Action;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Action FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Action;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Action> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ResourceEvent$Action", typeof (Action));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Action']/constructor[@name='ResourceEvent.Action' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Action']/method[@name='getId' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Action']/method[@name='component1' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Action']/method[@name='copy' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("copy", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Action;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Action Copy (string id)
			{
				const string __id = "copy.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Action;";
				IntPtr native_id = JNIEnv.NewString (id);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_id);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Action> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_id);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Action']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Action;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Action FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Action;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Action> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Application']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ResourceEvent$Application", DoNotGenerateAcw=true)]
		public sealed partial class Application : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Application.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ResourceEvent$Application$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ResourceEvent$Application$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Application.Companion']/constructor[@name='ResourceEvent.Application.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Application.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Application;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Application FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Application;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Application> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ResourceEvent$Application", typeof (Application));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Application']/constructor[@name='ResourceEvent.Application' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Application']/method[@name='getId' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Application']/method[@name='component1' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Application']/method[@name='copy' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("copy", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Application;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Application Copy (string id)
			{
				const string __id = "copy.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Application;";
				IntPtr native_id = JNIEnv.NewString (id);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_id);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Application> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_id);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Application']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Application;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Application FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Application;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Application> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Cellular']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ResourceEvent$Cellular", DoNotGenerateAcw=true)]
		public sealed partial class Cellular : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Cellular.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ResourceEvent$Cellular$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ResourceEvent$Cellular$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Cellular.Companion']/constructor[@name='ResourceEvent.Cellular.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Cellular.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Cellular;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Cellular FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Cellular;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Cellular> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ResourceEvent$Cellular", typeof (Cellular));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Cellular']/constructor[@name='ResourceEvent.Cellular' and count(parameter)=0]"
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Cellular']/constructor[@name='ResourceEvent.Cellular' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
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
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Cellular']/method[@name='getCarrierName' and count(parameter)=0]"
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
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Cellular']/method[@name='getTechnology' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Cellular']/method[@name='component1' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Cellular']/method[@name='component2' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Cellular']/method[@name='copy' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("copy", "(Ljava/lang/String;Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Cellular;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Cellular Copy (string technology, string carrierName)
			{
				const string __id = "copy.(Ljava/lang/String;Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Cellular;";
				IntPtr native_technology = JNIEnv.NewString (technology);
				IntPtr native_carrierName = JNIEnv.NewString (carrierName);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_technology);
					__args [1] = new JniArgumentValue (native_carrierName);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Cellular> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_technology);
					JNIEnv.DeleteLocalRef (native_carrierName);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Cellular']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Cellular;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Cellular FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Cellular;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Cellular> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Companion']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ResourceEvent$Companion", DoNotGenerateAcw=true)]
		public sealed partial class Companion : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ResourceEvent$Companion", typeof (Companion));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Companion']/constructor[@name='ResourceEvent.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Connect']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ResourceEvent$Connect", DoNotGenerateAcw=true)]
		public sealed partial class Connect : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Connect.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ResourceEvent$Connect$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ResourceEvent$Connect$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Connect.Companion']/constructor[@name='ResourceEvent.Connect.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Connect.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Connect;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Connect FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Connect;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Connect> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ResourceEvent$Connect", typeof (Connect));

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

			internal Connect (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Connect']/constructor[@name='ResourceEvent.Connect' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
			[Register (".ctor", "(JJ)V", "")]
			public unsafe Connect (long duration, long start) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(JJ)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (duration);
					__args [1] = new JniArgumentValue (start);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			public unsafe long Duration {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Connect']/method[@name='getDuration' and count(parameter)=0]"
				[Register ("getDuration", "()J", "")]
				get {
					const string __id = "getDuration.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe long Start {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Connect']/method[@name='getStart' and count(parameter)=0]"
				[Register ("getStart", "()J", "")]
				get {
					const string __id = "getStart.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Connect']/method[@name='component1' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Connect']/method[@name='component2' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Connect']/method[@name='copy' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
			[Register ("copy", "(JJ)Lcom/datadog/android/rum/model/ResourceEvent$Connect;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Connect Copy (long duration, long start)
			{
				const string __id = "copy.(JJ)Lcom/datadog/android/rum/model/ResourceEvent$Connect;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (duration);
					__args [1] = new JniArgumentValue (start);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Connect> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Connect']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Connect;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Connect FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Connect;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Connect> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Connectivity']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ResourceEvent$Connectivity", DoNotGenerateAcw=true)]
		public sealed partial class Connectivity : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Connectivity.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ResourceEvent$Connectivity$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ResourceEvent$Connectivity$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Connectivity.Companion']/constructor[@name='ResourceEvent.Connectivity.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Connectivity.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Connectivity;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Connectivity FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Connectivity;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Connectivity> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ResourceEvent$Connectivity", typeof (Connectivity));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Connectivity']/constructor[@name='ResourceEvent.Connectivity' and count(parameter)=3 and parameter[1][@type='com.datadog.android.rum.model.ResourceEvent.Status'] and parameter[2][@type='java.util.List&lt;? extends com.datadog.android.rum.model.ResourceEvent.Interface&gt;'] and parameter[3][@type='com.datadog.android.rum.model.ResourceEvent.Cellular']]"
			[Register (".ctor", "(Lcom/datadog/android/rum/model/ResourceEvent$Status;Ljava/util/List;Lcom/datadog/android/rum/model/ResourceEvent$Cellular;)V", "")]
			public unsafe Connectivity (global::Com.Datadog.Android.Rum.Model.ResourceEvent.Status status, global::System.Collections.Generic.IList<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Interface> interfaces, global::Com.Datadog.Android.Rum.Model.ResourceEvent.Cellular cellular) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lcom/datadog/android/rum/model/ResourceEvent$Status;Ljava/util/List;Lcom/datadog/android/rum/model/ResourceEvent$Cellular;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_interfaces = global::Android.Runtime.JavaList<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Interface>.ToLocalJniHandle (interfaces);
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

			public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Cellular Cellular {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Connectivity']/method[@name='getCellular' and count(parameter)=0]"
				[Register ("getCellular", "()Lcom/datadog/android/rum/model/ResourceEvent$Cellular;", "")]
				get {
					const string __id = "getCellular.()Lcom/datadog/android/rum/model/ResourceEvent$Cellular;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Cellular> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::System.Collections.Generic.IList<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Interface> Interfaces {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Connectivity']/method[@name='getInterfaces' and count(parameter)=0]"
				[Register ("getInterfaces", "()Ljava/util/List;", "")]
				get {
					const string __id = "getInterfaces.()Ljava/util/List;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Android.Runtime.JavaList<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Interface>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Status Status {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Connectivity']/method[@name='getStatus' and count(parameter)=0]"
				[Register ("getStatus", "()Lcom/datadog/android/rum/model/ResourceEvent$Status;", "")]
				get {
					const string __id = "getStatus.()Lcom/datadog/android/rum/model/ResourceEvent$Status;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Status> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Connectivity']/method[@name='component1' and count(parameter)=0]"
			[Register ("component1", "()Lcom/datadog/android/rum/model/ResourceEvent$Status;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Status Component1 ()
			{
				const string __id = "component1.()Lcom/datadog/android/rum/model/ResourceEvent$Status;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Status> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Connectivity']/method[@name='component2' and count(parameter)=0]"
			[Register ("component2", "()Ljava/util/List;", "")]
			public unsafe global::System.Collections.Generic.IList<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Interface> Component2 ()
			{
				const string __id = "component2.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Interface>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Connectivity']/method[@name='component3' and count(parameter)=0]"
			[Register ("component3", "()Lcom/datadog/android/rum/model/ResourceEvent$Cellular;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Cellular Component3 ()
			{
				const string __id = "component3.()Lcom/datadog/android/rum/model/ResourceEvent$Cellular;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Cellular> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Connectivity']/method[@name='copy' and count(parameter)=3 and parameter[1][@type='com.datadog.android.rum.model.ResourceEvent.Status'] and parameter[2][@type='java.util.List&lt;? extends com.datadog.android.rum.model.ResourceEvent.Interface&gt;'] and parameter[3][@type='com.datadog.android.rum.model.ResourceEvent.Cellular']]"
			[Register ("copy", "(Lcom/datadog/android/rum/model/ResourceEvent$Status;Ljava/util/List;Lcom/datadog/android/rum/model/ResourceEvent$Cellular;)Lcom/datadog/android/rum/model/ResourceEvent$Connectivity;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Connectivity Copy (global::Com.Datadog.Android.Rum.Model.ResourceEvent.Status status, global::System.Collections.Generic.IList<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Interface> interfaces, global::Com.Datadog.Android.Rum.Model.ResourceEvent.Cellular cellular)
			{
				const string __id = "copy.(Lcom/datadog/android/rum/model/ResourceEvent$Status;Ljava/util/List;Lcom/datadog/android/rum/model/ResourceEvent$Cellular;)Lcom/datadog/android/rum/model/ResourceEvent$Connectivity;";
				IntPtr native_interfaces = global::Android.Runtime.JavaList<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Interface>.ToLocalJniHandle (interfaces);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue ((status == null) ? IntPtr.Zero : ((global::Java.Lang.Object) status).Handle);
					__args [1] = new JniArgumentValue (native_interfaces);
					__args [2] = new JniArgumentValue ((cellular == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cellular).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Connectivity> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_interfaces);
					global::System.GC.KeepAlive (status);
					global::System.GC.KeepAlive (interfaces);
					global::System.GC.KeepAlive (cellular);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Connectivity']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Connectivity;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Connectivity FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Connectivity;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Connectivity> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Dd']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ResourceEvent$Dd", DoNotGenerateAcw=true)]
		public sealed partial class Dd : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Dd.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ResourceEvent$Dd$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ResourceEvent$Dd$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Dd.Companion']/constructor[@name='ResourceEvent.Dd.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Dd.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Dd;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Dd FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Dd;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Dd> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ResourceEvent$Dd", typeof (Dd));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Dd']/constructor[@name='ResourceEvent.Dd' and count(parameter)=0]"
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Dd']/constructor[@name='ResourceEvent.Dd' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
			public unsafe Dd (string spanId, string traceId) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;Ljava/lang/String;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_spanId = JNIEnv.NewString (spanId);
				IntPtr native_traceId = JNIEnv.NewString (traceId);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_spanId);
					__args [1] = new JniArgumentValue (native_traceId);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_spanId);
					JNIEnv.DeleteLocalRef (native_traceId);
				}
			}

			public unsafe long FormatVersion {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Dd']/method[@name='getFormatVersion' and count(parameter)=0]"
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

			public unsafe string SpanId {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Dd']/method[@name='getSpanId' and count(parameter)=0]"
				[Register ("getSpanId", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getSpanId.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe string TraceId {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Dd']/method[@name='getTraceId' and count(parameter)=0]"
				[Register ("getTraceId", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getTraceId.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Dd']/method[@name='component1' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Dd']/method[@name='component2' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Dd']/method[@name='copy' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("copy", "(Ljava/lang/String;Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Dd;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Dd Copy (string spanId, string traceId)
			{
				const string __id = "copy.(Ljava/lang/String;Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Dd;";
				IntPtr native_spanId = JNIEnv.NewString (spanId);
				IntPtr native_traceId = JNIEnv.NewString (traceId);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_spanId);
					__args [1] = new JniArgumentValue (native_traceId);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Dd> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_spanId);
					JNIEnv.DeleteLocalRef (native_traceId);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Dd']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Dd;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Dd FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Dd;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Dd> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Dns']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ResourceEvent$Dns", DoNotGenerateAcw=true)]
		public sealed partial class Dns : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Dns.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ResourceEvent$Dns$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ResourceEvent$Dns$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Dns.Companion']/constructor[@name='ResourceEvent.Dns.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Dns.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Dns;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Dns FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Dns;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Dns> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ResourceEvent$Dns", typeof (Dns));

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

			internal Dns (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Dns']/constructor[@name='ResourceEvent.Dns' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
			[Register (".ctor", "(JJ)V", "")]
			public unsafe Dns (long duration, long start) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(JJ)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (duration);
					__args [1] = new JniArgumentValue (start);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			public unsafe long Duration {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Dns']/method[@name='getDuration' and count(parameter)=0]"
				[Register ("getDuration", "()J", "")]
				get {
					const string __id = "getDuration.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe long Start {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Dns']/method[@name='getStart' and count(parameter)=0]"
				[Register ("getStart", "()J", "")]
				get {
					const string __id = "getStart.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Dns']/method[@name='component1' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Dns']/method[@name='component2' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Dns']/method[@name='copy' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
			[Register ("copy", "(JJ)Lcom/datadog/android/rum/model/ResourceEvent$Dns;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Dns Copy (long duration, long start)
			{
				const string __id = "copy.(JJ)Lcom/datadog/android/rum/model/ResourceEvent$Dns;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (duration);
					__args [1] = new JniArgumentValue (start);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Dns> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Dns']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Dns;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Dns FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Dns;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Dns> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Download']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ResourceEvent$Download", DoNotGenerateAcw=true)]
		public sealed partial class Download : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Download.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ResourceEvent$Download$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ResourceEvent$Download$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Download.Companion']/constructor[@name='ResourceEvent.Download.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Download.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Download;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Download FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Download;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Download> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ResourceEvent$Download", typeof (Download));

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

			internal Download (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Download']/constructor[@name='ResourceEvent.Download' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
			[Register (".ctor", "(JJ)V", "")]
			public unsafe Download (long duration, long start) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(JJ)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (duration);
					__args [1] = new JniArgumentValue (start);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			public unsafe long Duration {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Download']/method[@name='getDuration' and count(parameter)=0]"
				[Register ("getDuration", "()J", "")]
				get {
					const string __id = "getDuration.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe long Start {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Download']/method[@name='getStart' and count(parameter)=0]"
				[Register ("getStart", "()J", "")]
				get {
					const string __id = "getStart.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Download']/method[@name='component1' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Download']/method[@name='component2' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Download']/method[@name='copy' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
			[Register ("copy", "(JJ)Lcom/datadog/android/rum/model/ResourceEvent$Download;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Download Copy (long duration, long start)
			{
				const string __id = "copy.(JJ)Lcom/datadog/android/rum/model/ResourceEvent$Download;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (duration);
					__args [1] = new JniArgumentValue (start);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Download> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Download']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Download;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Download FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Download;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Download> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.FirstByte']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ResourceEvent$FirstByte", DoNotGenerateAcw=true)]
		public sealed partial class FirstByte : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.FirstByte.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ResourceEvent$FirstByte$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ResourceEvent$FirstByte$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.FirstByte.Companion']/constructor[@name='ResourceEvent.FirstByte.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.FirstByte.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$FirstByte;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.FirstByte FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$FirstByte;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.FirstByte> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ResourceEvent$FirstByte", typeof (FirstByte));

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

			internal FirstByte (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.FirstByte']/constructor[@name='ResourceEvent.FirstByte' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
			[Register (".ctor", "(JJ)V", "")]
			public unsafe FirstByte (long duration, long start) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(JJ)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (duration);
					__args [1] = new JniArgumentValue (start);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			public unsafe long Duration {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.FirstByte']/method[@name='getDuration' and count(parameter)=0]"
				[Register ("getDuration", "()J", "")]
				get {
					const string __id = "getDuration.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe long Start {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.FirstByte']/method[@name='getStart' and count(parameter)=0]"
				[Register ("getStart", "()J", "")]
				get {
					const string __id = "getStart.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.FirstByte']/method[@name='component1' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.FirstByte']/method[@name='component2' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.FirstByte']/method[@name='copy' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
			[Register ("copy", "(JJ)Lcom/datadog/android/rum/model/ResourceEvent$FirstByte;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.FirstByte Copy (long duration, long start)
			{
				const string __id = "copy.(JJ)Lcom/datadog/android/rum/model/ResourceEvent$FirstByte;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (duration);
					__args [1] = new JniArgumentValue (start);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.FirstByte> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.FirstByte']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$FirstByte;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.FirstByte FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$FirstByte;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.FirstByte> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Interface']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ResourceEvent$Interface", DoNotGenerateAcw=true)]
		public sealed partial class Interface : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Interface']/field[@name='BLUETOOTH']"
			[Register ("BLUETOOTH")]
			public static global::Com.Datadog.Android.Rum.Model.ResourceEvent.Interface Bluetooth {
				get {
					const string __id = "BLUETOOTH.Lcom/datadog/android/rum/model/ResourceEvent$Interface;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Interface> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Interface']/field[@name='CELLULAR']"
			[Register ("CELLULAR")]
			public static global::Com.Datadog.Android.Rum.Model.ResourceEvent.Interface Cellular {
				get {
					const string __id = "CELLULAR.Lcom/datadog/android/rum/model/ResourceEvent$Interface;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Interface> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Interface']/field[@name='ETHERNET']"
			[Register ("ETHERNET")]
			public static global::Com.Datadog.Android.Rum.Model.ResourceEvent.Interface Ethernet {
				get {
					const string __id = "ETHERNET.Lcom/datadog/android/rum/model/ResourceEvent$Interface;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Interface> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Interface']/field[@name='MIXED']"
			[Register ("MIXED")]
			public static global::Com.Datadog.Android.Rum.Model.ResourceEvent.Interface Mixed {
				get {
					const string __id = "MIXED.Lcom/datadog/android/rum/model/ResourceEvent$Interface;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Interface> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Interface']/field[@name='NONE']"
			[Register ("NONE")]
			public static global::Com.Datadog.Android.Rum.Model.ResourceEvent.Interface None {
				get {
					const string __id = "NONE.Lcom/datadog/android/rum/model/ResourceEvent$Interface;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Interface> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Interface']/field[@name='OTHER']"
			[Register ("OTHER")]
			public static global::Com.Datadog.Android.Rum.Model.ResourceEvent.Interface Other {
				get {
					const string __id = "OTHER.Lcom/datadog/android/rum/model/ResourceEvent$Interface;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Interface> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Interface']/field[@name='UNKNOWN']"
			[Register ("UNKNOWN")]
			public static global::Com.Datadog.Android.Rum.Model.ResourceEvent.Interface Unknown {
				get {
					const string __id = "UNKNOWN.Lcom/datadog/android/rum/model/ResourceEvent$Interface;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Interface> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Interface']/field[@name='WIFI']"
			[Register ("WIFI")]
			public static global::Com.Datadog.Android.Rum.Model.ResourceEvent.Interface Wifi {
				get {
					const string __id = "WIFI.Lcom/datadog/android/rum/model/ResourceEvent$Interface;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Interface> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Interface']/field[@name='WIMAX']"
			[Register ("WIMAX")]
			public static global::Com.Datadog.Android.Rum.Model.ResourceEvent.Interface Wimax {
				get {
					const string __id = "WIMAX.Lcom/datadog/android/rum/model/ResourceEvent$Interface;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Interface> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Interface.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ResourceEvent$Interface$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ResourceEvent$Interface$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Interface.Companion']/constructor[@name='ResourceEvent.Interface.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Interface.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Interface;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Interface FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Interface;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Interface> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ResourceEvent$Interface", typeof (Interface));

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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Interface']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Interface;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Interface FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Interface;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Interface> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Interface']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Interface;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Interface ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Interface;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Interface> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Interface']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/datadog/android/rum/model/ResourceEvent$Interface;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Interface[] Values ()
			{
				const string __id = "values.()[Lcom/datadog/android/rum/model/ResourceEvent$Interface;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Datadog.Android.Rum.Model.ResourceEvent.Interface[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Datadog.Android.Rum.Model.ResourceEvent.Interface));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Method']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ResourceEvent$Method", DoNotGenerateAcw=true)]
		public sealed partial class Method : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Method']/field[@name='DELETE']"
			[Register ("DELETE")]
			public static global::Com.Datadog.Android.Rum.Model.ResourceEvent.Method Delete {
				get {
					const string __id = "DELETE.Lcom/datadog/android/rum/model/ResourceEvent$Method;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Method> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Method']/field[@name='GET']"
			[Register ("GET")]
			public static global::Com.Datadog.Android.Rum.Model.ResourceEvent.Method Get {
				get {
					const string __id = "GET.Lcom/datadog/android/rum/model/ResourceEvent$Method;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Method> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Method']/field[@name='HEAD']"
			[Register ("HEAD")]
			public static global::Com.Datadog.Android.Rum.Model.ResourceEvent.Method Head {
				get {
					const string __id = "HEAD.Lcom/datadog/android/rum/model/ResourceEvent$Method;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Method> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Method']/field[@name='PATCH']"
			[Register ("PATCH")]
			public static global::Com.Datadog.Android.Rum.Model.ResourceEvent.Method Patch {
				get {
					const string __id = "PATCH.Lcom/datadog/android/rum/model/ResourceEvent$Method;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Method> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Method']/field[@name='POST']"
			[Register ("POST")]
			public static global::Com.Datadog.Android.Rum.Model.ResourceEvent.Method Post {
				get {
					const string __id = "POST.Lcom/datadog/android/rum/model/ResourceEvent$Method;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Method> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Method']/field[@name='PUT']"
			[Register ("PUT")]
			public static global::Com.Datadog.Android.Rum.Model.ResourceEvent.Method Put {
				get {
					const string __id = "PUT.Lcom/datadog/android/rum/model/ResourceEvent$Method;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Method> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Method.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ResourceEvent$Method$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ResourceEvent$Method$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Method.Companion']/constructor[@name='ResourceEvent.Method.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Method.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Method;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Method FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Method;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Method> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ResourceEvent$Method", typeof (Method));

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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Method']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Method;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Method FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Method;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Method> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Method']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Method;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Method ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Method;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Method> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Method']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/datadog/android/rum/model/ResourceEvent$Method;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Method[] Values ()
			{
				const string __id = "values.()[Lcom/datadog/android/rum/model/ResourceEvent$Method;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Datadog.Android.Rum.Model.ResourceEvent.Method[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Datadog.Android.Rum.Model.ResourceEvent.Method));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Provider']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ResourceEvent$Provider", DoNotGenerateAcw=true)]
		public sealed partial class Provider : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Provider.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ResourceEvent$Provider$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ResourceEvent$Provider$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Provider.Companion']/constructor[@name='ResourceEvent.Provider.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Provider.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Provider;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Provider FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Provider;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Provider> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ResourceEvent$Provider", typeof (Provider));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Provider']/constructor[@name='ResourceEvent.Provider' and count(parameter)=0]"
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Provider']/constructor[@name='ResourceEvent.Provider' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.datadog.android.rum.model.ResourceEvent.ProviderType']]"
			[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Lcom/datadog/android/rum/model/ResourceEvent$ProviderType;)V", "")]
			public unsafe Provider (string domain, string name, global::Com.Datadog.Android.Rum.Model.ResourceEvent.ProviderType type) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;Ljava/lang/String;Lcom/datadog/android/rum/model/ResourceEvent$ProviderType;)V";

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
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Provider']/method[@name='getDomain' and count(parameter)=0]"
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
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Provider']/method[@name='getName' and count(parameter)=0]"
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

			public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.ProviderType Type {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Provider']/method[@name='getType' and count(parameter)=0]"
				[Register ("getType", "()Lcom/datadog/android/rum/model/ResourceEvent$ProviderType;", "")]
				get {
					const string __id = "getType.()Lcom/datadog/android/rum/model/ResourceEvent$ProviderType;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.ProviderType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Provider']/method[@name='component1' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Provider']/method[@name='component2' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Provider']/method[@name='component3' and count(parameter)=0]"
			[Register ("component3", "()Lcom/datadog/android/rum/model/ResourceEvent$ProviderType;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.ProviderType Component3 ()
			{
				const string __id = "component3.()Lcom/datadog/android/rum/model/ResourceEvent$ProviderType;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.ProviderType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Provider']/method[@name='copy' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.datadog.android.rum.model.ResourceEvent.ProviderType']]"
			[Register ("copy", "(Ljava/lang/String;Ljava/lang/String;Lcom/datadog/android/rum/model/ResourceEvent$ProviderType;)Lcom/datadog/android/rum/model/ResourceEvent$Provider;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Provider Copy (string domain, string name, global::Com.Datadog.Android.Rum.Model.ResourceEvent.ProviderType type)
			{
				const string __id = "copy.(Ljava/lang/String;Ljava/lang/String;Lcom/datadog/android/rum/model/ResourceEvent$ProviderType;)Lcom/datadog/android/rum/model/ResourceEvent$Provider;";
				IntPtr native_domain = JNIEnv.NewString (domain);
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_domain);
					__args [1] = new JniArgumentValue (native_name);
					__args [2] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Provider> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_domain);
					JNIEnv.DeleteLocalRef (native_name);
					global::System.GC.KeepAlive (type);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Provider']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Provider;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Provider FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Provider;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Provider> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.ProviderType']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ResourceEvent$ProviderType", DoNotGenerateAcw=true)]
		public sealed partial class ProviderType : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.ProviderType']/field[@name='AD']"
			[Register ("AD")]
			public static global::Com.Datadog.Android.Rum.Model.ResourceEvent.ProviderType Ad {
				get {
					const string __id = "AD.Lcom/datadog/android/rum/model/ResourceEvent$ProviderType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.ProviderType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.ProviderType']/field[@name='ADVERTISING']"
			[Register ("ADVERTISING")]
			public static global::Com.Datadog.Android.Rum.Model.ResourceEvent.ProviderType Advertising {
				get {
					const string __id = "ADVERTISING.Lcom/datadog/android/rum/model/ResourceEvent$ProviderType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.ProviderType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.ProviderType']/field[@name='ANALYTICS']"
			[Register ("ANALYTICS")]
			public static global::Com.Datadog.Android.Rum.Model.ResourceEvent.ProviderType Analytics {
				get {
					const string __id = "ANALYTICS.Lcom/datadog/android/rum/model/ResourceEvent$ProviderType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.ProviderType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.ProviderType']/field[@name='CDN']"
			[Register ("CDN")]
			public static global::Com.Datadog.Android.Rum.Model.ResourceEvent.ProviderType Cdn {
				get {
					const string __id = "CDN.Lcom/datadog/android/rum/model/ResourceEvent$ProviderType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.ProviderType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.ProviderType']/field[@name='CONTENT']"
			[Register ("CONTENT")]
			public static global::Com.Datadog.Android.Rum.Model.ResourceEvent.ProviderType Content {
				get {
					const string __id = "CONTENT.Lcom/datadog/android/rum/model/ResourceEvent$ProviderType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.ProviderType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.ProviderType']/field[@name='CUSTOMER_SUCCESS']"
			[Register ("CUSTOMER_SUCCESS")]
			public static global::Com.Datadog.Android.Rum.Model.ResourceEvent.ProviderType CustomerSuccess {
				get {
					const string __id = "CUSTOMER_SUCCESS.Lcom/datadog/android/rum/model/ResourceEvent$ProviderType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.ProviderType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.ProviderType']/field[@name='FIRST_PARTY']"
			[Register ("FIRST_PARTY")]
			public static global::Com.Datadog.Android.Rum.Model.ResourceEvent.ProviderType FirstParty {
				get {
					const string __id = "FIRST_PARTY.Lcom/datadog/android/rum/model/ResourceEvent$ProviderType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.ProviderType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.ProviderType']/field[@name='HOSTING']"
			[Register ("HOSTING")]
			public static global::Com.Datadog.Android.Rum.Model.ResourceEvent.ProviderType Hosting {
				get {
					const string __id = "HOSTING.Lcom/datadog/android/rum/model/ResourceEvent$ProviderType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.ProviderType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.ProviderType']/field[@name='MARKETING']"
			[Register ("MARKETING")]
			public static global::Com.Datadog.Android.Rum.Model.ResourceEvent.ProviderType Marketing {
				get {
					const string __id = "MARKETING.Lcom/datadog/android/rum/model/ResourceEvent$ProviderType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.ProviderType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.ProviderType']/field[@name='OTHER']"
			[Register ("OTHER")]
			public static global::Com.Datadog.Android.Rum.Model.ResourceEvent.ProviderType Other {
				get {
					const string __id = "OTHER.Lcom/datadog/android/rum/model/ResourceEvent$ProviderType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.ProviderType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.ProviderType']/field[@name='SOCIAL']"
			[Register ("SOCIAL")]
			public static global::Com.Datadog.Android.Rum.Model.ResourceEvent.ProviderType Social {
				get {
					const string __id = "SOCIAL.Lcom/datadog/android/rum/model/ResourceEvent$ProviderType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.ProviderType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.ProviderType']/field[@name='TAG_MANAGER']"
			[Register ("TAG_MANAGER")]
			public static global::Com.Datadog.Android.Rum.Model.ResourceEvent.ProviderType TagManager {
				get {
					const string __id = "TAG_MANAGER.Lcom/datadog/android/rum/model/ResourceEvent$ProviderType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.ProviderType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.ProviderType']/field[@name='UTILITY']"
			[Register ("UTILITY")]
			public static global::Com.Datadog.Android.Rum.Model.ResourceEvent.ProviderType Utility {
				get {
					const string __id = "UTILITY.Lcom/datadog/android/rum/model/ResourceEvent$ProviderType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.ProviderType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.ProviderType']/field[@name='VIDEO']"
			[Register ("VIDEO")]
			public static global::Com.Datadog.Android.Rum.Model.ResourceEvent.ProviderType Video {
				get {
					const string __id = "VIDEO.Lcom/datadog/android/rum/model/ResourceEvent$ProviderType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.ProviderType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.ProviderType.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ResourceEvent$ProviderType$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ResourceEvent$ProviderType$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.ProviderType.Companion']/constructor[@name='ResourceEvent.ProviderType.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.ProviderType.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$ProviderType;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.ProviderType FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$ProviderType;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.ProviderType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ResourceEvent$ProviderType", typeof (ProviderType));

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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.ProviderType']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$ProviderType;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.ProviderType FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$ProviderType;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.ProviderType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.ProviderType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$ProviderType;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.ProviderType ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$ProviderType;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.ProviderType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.ProviderType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/datadog/android/rum/model/ResourceEvent$ProviderType;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.ProviderType[] Values ()
			{
				const string __id = "values.()[Lcom/datadog/android/rum/model/ResourceEvent$ProviderType;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Datadog.Android.Rum.Model.ResourceEvent.ProviderType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Datadog.Android.Rum.Model.ResourceEvent.ProviderType));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Redirect']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ResourceEvent$Redirect", DoNotGenerateAcw=true)]
		public sealed partial class Redirect : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Redirect.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ResourceEvent$Redirect$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ResourceEvent$Redirect$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Redirect.Companion']/constructor[@name='ResourceEvent.Redirect.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Redirect.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Redirect;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Redirect FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Redirect;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Redirect> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ResourceEvent$Redirect", typeof (Redirect));

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

			internal Redirect (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Redirect']/constructor[@name='ResourceEvent.Redirect' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
			[Register (".ctor", "(JJ)V", "")]
			public unsafe Redirect (long duration, long start) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(JJ)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (duration);
					__args [1] = new JniArgumentValue (start);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			public unsafe long Duration {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Redirect']/method[@name='getDuration' and count(parameter)=0]"
				[Register ("getDuration", "()J", "")]
				get {
					const string __id = "getDuration.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe long Start {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Redirect']/method[@name='getStart' and count(parameter)=0]"
				[Register ("getStart", "()J", "")]
				get {
					const string __id = "getStart.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Redirect']/method[@name='component1' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Redirect']/method[@name='component2' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Redirect']/method[@name='copy' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
			[Register ("copy", "(JJ)Lcom/datadog/android/rum/model/ResourceEvent$Redirect;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Redirect Copy (long duration, long start)
			{
				const string __id = "copy.(JJ)Lcom/datadog/android/rum/model/ResourceEvent$Redirect;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (duration);
					__args [1] = new JniArgumentValue (start);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Redirect> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Redirect']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Redirect;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Redirect FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Redirect;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Redirect> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Resource']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ResourceEvent$Resource", DoNotGenerateAcw=true)]
		public sealed partial class Resource : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Resource.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ResourceEvent$Resource$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ResourceEvent$Resource$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Resource.Companion']/constructor[@name='ResourceEvent.Resource.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Resource.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Resource;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Resource FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Resource;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Resource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ResourceEvent$Resource", typeof (Resource));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Resource']/constructor[@name='ResourceEvent.Resource' and count(parameter)=14 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.datadog.android.rum.model.ResourceEvent.ResourceType'] and parameter[3][@type='com.datadog.android.rum.model.ResourceEvent.Method'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.Long'] and parameter[6][@type='long'] and parameter[7][@type='java.lang.Long'] and parameter[8][@type='com.datadog.android.rum.model.ResourceEvent.Redirect'] and parameter[9][@type='com.datadog.android.rum.model.ResourceEvent.Dns'] and parameter[10][@type='com.datadog.android.rum.model.ResourceEvent.Connect'] and parameter[11][@type='com.datadog.android.rum.model.ResourceEvent.Ssl'] and parameter[12][@type='com.datadog.android.rum.model.ResourceEvent.FirstByte'] and parameter[13][@type='com.datadog.android.rum.model.ResourceEvent.Download'] and parameter[14][@type='com.datadog.android.rum.model.ResourceEvent.Provider']]"
			[Register (".ctor", "(Ljava/lang/String;Lcom/datadog/android/rum/model/ResourceEvent$ResourceType;Lcom/datadog/android/rum/model/ResourceEvent$Method;Ljava/lang/String;Ljava/lang/Long;JLjava/lang/Long;Lcom/datadog/android/rum/model/ResourceEvent$Redirect;Lcom/datadog/android/rum/model/ResourceEvent$Dns;Lcom/datadog/android/rum/model/ResourceEvent$Connect;Lcom/datadog/android/rum/model/ResourceEvent$Ssl;Lcom/datadog/android/rum/model/ResourceEvent$FirstByte;Lcom/datadog/android/rum/model/ResourceEvent$Download;Lcom/datadog/android/rum/model/ResourceEvent$Provider;)V", "")]
			public unsafe Resource (string id, global::Com.Datadog.Android.Rum.Model.ResourceEvent.ResourceType type, global::Com.Datadog.Android.Rum.Model.ResourceEvent.Method method, string url, global::Java.Lang.Long statusCode, long duration, global::Java.Lang.Long size, global::Com.Datadog.Android.Rum.Model.ResourceEvent.Redirect redirect, global::Com.Datadog.Android.Rum.Model.ResourceEvent.Dns dns, global::Com.Datadog.Android.Rum.Model.ResourceEvent.Connect connect, global::Com.Datadog.Android.Rum.Model.ResourceEvent.Ssl ssl, global::Com.Datadog.Android.Rum.Model.ResourceEvent.FirstByte firstByte, global::Com.Datadog.Android.Rum.Model.ResourceEvent.Download download, global::Com.Datadog.Android.Rum.Model.ResourceEvent.Provider provider) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;Lcom/datadog/android/rum/model/ResourceEvent$ResourceType;Lcom/datadog/android/rum/model/ResourceEvent$Method;Ljava/lang/String;Ljava/lang/Long;JLjava/lang/Long;Lcom/datadog/android/rum/model/ResourceEvent$Redirect;Lcom/datadog/android/rum/model/ResourceEvent$Dns;Lcom/datadog/android/rum/model/ResourceEvent$Connect;Lcom/datadog/android/rum/model/ResourceEvent$Ssl;Lcom/datadog/android/rum/model/ResourceEvent$FirstByte;Lcom/datadog/android/rum/model/ResourceEvent$Download;Lcom/datadog/android/rum/model/ResourceEvent$Provider;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_id = JNIEnv.NewString (id);
				IntPtr native_url = JNIEnv.NewString (url);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [14];
					__args [0] = new JniArgumentValue (native_id);
					__args [1] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
					__args [2] = new JniArgumentValue ((method == null) ? IntPtr.Zero : ((global::Java.Lang.Object) method).Handle);
					__args [3] = new JniArgumentValue (native_url);
					__args [4] = new JniArgumentValue ((statusCode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) statusCode).Handle);
					__args [5] = new JniArgumentValue (duration);
					__args [6] = new JniArgumentValue ((size == null) ? IntPtr.Zero : ((global::Java.Lang.Object) size).Handle);
					__args [7] = new JniArgumentValue ((redirect == null) ? IntPtr.Zero : ((global::Java.Lang.Object) redirect).Handle);
					__args [8] = new JniArgumentValue ((dns == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dns).Handle);
					__args [9] = new JniArgumentValue ((connect == null) ? IntPtr.Zero : ((global::Java.Lang.Object) connect).Handle);
					__args [10] = new JniArgumentValue ((ssl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ssl).Handle);
					__args [11] = new JniArgumentValue ((firstByte == null) ? IntPtr.Zero : ((global::Java.Lang.Object) firstByte).Handle);
					__args [12] = new JniArgumentValue ((download == null) ? IntPtr.Zero : ((global::Java.Lang.Object) download).Handle);
					__args [13] = new JniArgumentValue ((provider == null) ? IntPtr.Zero : ((global::Java.Lang.Object) provider).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_id);
					JNIEnv.DeleteLocalRef (native_url);
					global::System.GC.KeepAlive (type);
					global::System.GC.KeepAlive (method);
					global::System.GC.KeepAlive (statusCode);
					global::System.GC.KeepAlive (size);
					global::System.GC.KeepAlive (redirect);
					global::System.GC.KeepAlive (dns);
					global::System.GC.KeepAlive (connect);
					global::System.GC.KeepAlive (ssl);
					global::System.GC.KeepAlive (firstByte);
					global::System.GC.KeepAlive (download);
					global::System.GC.KeepAlive (provider);
				}
			}

			public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Connect Connect {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Resource']/method[@name='getConnect' and count(parameter)=0]"
				[Register ("getConnect", "()Lcom/datadog/android/rum/model/ResourceEvent$Connect;", "")]
				get {
					const string __id = "getConnect.()Lcom/datadog/android/rum/model/ResourceEvent$Connect;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Connect> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Dns Dns {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Resource']/method[@name='getDns' and count(parameter)=0]"
				[Register ("getDns", "()Lcom/datadog/android/rum/model/ResourceEvent$Dns;", "")]
				get {
					const string __id = "getDns.()Lcom/datadog/android/rum/model/ResourceEvent$Dns;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Dns> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Download Download {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Resource']/method[@name='getDownload' and count(parameter)=0]"
				[Register ("getDownload", "()Lcom/datadog/android/rum/model/ResourceEvent$Download;", "")]
				get {
					const string __id = "getDownload.()Lcom/datadog/android/rum/model/ResourceEvent$Download;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Download> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe long Duration {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Resource']/method[@name='getDuration' and count(parameter)=0]"
				[Register ("getDuration", "()J", "")]
				get {
					const string __id = "getDuration.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.FirstByte FirstByte {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Resource']/method[@name='getFirstByte' and count(parameter)=0]"
				[Register ("getFirstByte", "()Lcom/datadog/android/rum/model/ResourceEvent$FirstByte;", "")]
				get {
					const string __id = "getFirstByte.()Lcom/datadog/android/rum/model/ResourceEvent$FirstByte;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.FirstByte> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe string Id {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Resource']/method[@name='getId' and count(parameter)=0]"
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

			public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Method Method {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Resource']/method[@name='getMethod' and count(parameter)=0]"
				[Register ("getMethod", "()Lcom/datadog/android/rum/model/ResourceEvent$Method;", "")]
				get {
					const string __id = "getMethod.()Lcom/datadog/android/rum/model/ResourceEvent$Method;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Method> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Provider Provider {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Resource']/method[@name='getProvider' and count(parameter)=0]"
				[Register ("getProvider", "()Lcom/datadog/android/rum/model/ResourceEvent$Provider;", "")]
				get {
					const string __id = "getProvider.()Lcom/datadog/android/rum/model/ResourceEvent$Provider;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Provider> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Redirect Redirect {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Resource']/method[@name='getRedirect' and count(parameter)=0]"
				[Register ("getRedirect", "()Lcom/datadog/android/rum/model/ResourceEvent$Redirect;", "")]
				get {
					const string __id = "getRedirect.()Lcom/datadog/android/rum/model/ResourceEvent$Redirect;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Redirect> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Java.Lang.Long Size {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Resource']/method[@name='getSize' and count(parameter)=0]"
				[Register ("getSize", "()Ljava/lang/Long;", "")]
				get {
					const string __id = "getSize.()Ljava/lang/Long;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Ssl Ssl {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Resource']/method[@name='getSsl' and count(parameter)=0]"
				[Register ("getSsl", "()Lcom/datadog/android/rum/model/ResourceEvent$Ssl;", "")]
				get {
					const string __id = "getSsl.()Lcom/datadog/android/rum/model/ResourceEvent$Ssl;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Ssl> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Java.Lang.Long StatusCode {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Resource']/method[@name='getStatusCode' and count(parameter)=0]"
				[Register ("getStatusCode", "()Ljava/lang/Long;", "")]
				get {
					const string __id = "getStatusCode.()Ljava/lang/Long;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.ResourceType Type {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Resource']/method[@name='getType' and count(parameter)=0]"
				[Register ("getType", "()Lcom/datadog/android/rum/model/ResourceEvent$ResourceType;", "")]
				get {
					const string __id = "getType.()Lcom/datadog/android/rum/model/ResourceEvent$ResourceType;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.ResourceType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe string Url {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Resource']/method[@name='getUrl' and count(parameter)=0]"
				[Register ("getUrl", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getUrl.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Resource']/method[@name='setUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Resource']/method[@name='component1' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Resource']/method[@name='component10' and count(parameter)=0]"
			[Register ("component10", "()Lcom/datadog/android/rum/model/ResourceEvent$Connect;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Connect Component10 ()
			{
				const string __id = "component10.()Lcom/datadog/android/rum/model/ResourceEvent$Connect;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Connect> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Resource']/method[@name='component11' and count(parameter)=0]"
			[Register ("component11", "()Lcom/datadog/android/rum/model/ResourceEvent$Ssl;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Ssl Component11 ()
			{
				const string __id = "component11.()Lcom/datadog/android/rum/model/ResourceEvent$Ssl;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Ssl> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Resource']/method[@name='component12' and count(parameter)=0]"
			[Register ("component12", "()Lcom/datadog/android/rum/model/ResourceEvent$FirstByte;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.FirstByte Component12 ()
			{
				const string __id = "component12.()Lcom/datadog/android/rum/model/ResourceEvent$FirstByte;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.FirstByte> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Resource']/method[@name='component13' and count(parameter)=0]"
			[Register ("component13", "()Lcom/datadog/android/rum/model/ResourceEvent$Download;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Download Component13 ()
			{
				const string __id = "component13.()Lcom/datadog/android/rum/model/ResourceEvent$Download;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Download> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Resource']/method[@name='component14' and count(parameter)=0]"
			[Register ("component14", "()Lcom/datadog/android/rum/model/ResourceEvent$Provider;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Provider Component14 ()
			{
				const string __id = "component14.()Lcom/datadog/android/rum/model/ResourceEvent$Provider;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Provider> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Resource']/method[@name='component2' and count(parameter)=0]"
			[Register ("component2", "()Lcom/datadog/android/rum/model/ResourceEvent$ResourceType;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.ResourceType Component2 ()
			{
				const string __id = "component2.()Lcom/datadog/android/rum/model/ResourceEvent$ResourceType;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.ResourceType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Resource']/method[@name='component3' and count(parameter)=0]"
			[Register ("component3", "()Lcom/datadog/android/rum/model/ResourceEvent$Method;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Method Component3 ()
			{
				const string __id = "component3.()Lcom/datadog/android/rum/model/ResourceEvent$Method;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Method> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Resource']/method[@name='component4' and count(parameter)=0]"
			[Register ("component4", "()Ljava/lang/String;", "")]
			public unsafe string Component4 ()
			{
				const string __id = "component4.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Resource']/method[@name='component5' and count(parameter)=0]"
			[Register ("component5", "()Ljava/lang/Long;", "")]
			public unsafe global::Java.Lang.Long Component5 ()
			{
				const string __id = "component5.()Ljava/lang/Long;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Resource']/method[@name='component6' and count(parameter)=0]"
			[Register ("component6", "()J", "")]
			public unsafe long Component6 ()
			{
				const string __id = "component6.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Resource']/method[@name='component7' and count(parameter)=0]"
			[Register ("component7", "()Ljava/lang/Long;", "")]
			public unsafe global::Java.Lang.Long Component7 ()
			{
				const string __id = "component7.()Ljava/lang/Long;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Resource']/method[@name='component8' and count(parameter)=0]"
			[Register ("component8", "()Lcom/datadog/android/rum/model/ResourceEvent$Redirect;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Redirect Component8 ()
			{
				const string __id = "component8.()Lcom/datadog/android/rum/model/ResourceEvent$Redirect;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Redirect> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Resource']/method[@name='component9' and count(parameter)=0]"
			[Register ("component9", "()Lcom/datadog/android/rum/model/ResourceEvent$Dns;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Dns Component9 ()
			{
				const string __id = "component9.()Lcom/datadog/android/rum/model/ResourceEvent$Dns;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Dns> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Resource']/method[@name='copy' and count(parameter)=14 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.datadog.android.rum.model.ResourceEvent.ResourceType'] and parameter[3][@type='com.datadog.android.rum.model.ResourceEvent.Method'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.Long'] and parameter[6][@type='long'] and parameter[7][@type='java.lang.Long'] and parameter[8][@type='com.datadog.android.rum.model.ResourceEvent.Redirect'] and parameter[9][@type='com.datadog.android.rum.model.ResourceEvent.Dns'] and parameter[10][@type='com.datadog.android.rum.model.ResourceEvent.Connect'] and parameter[11][@type='com.datadog.android.rum.model.ResourceEvent.Ssl'] and parameter[12][@type='com.datadog.android.rum.model.ResourceEvent.FirstByte'] and parameter[13][@type='com.datadog.android.rum.model.ResourceEvent.Download'] and parameter[14][@type='com.datadog.android.rum.model.ResourceEvent.Provider']]"
			[Register ("copy", "(Ljava/lang/String;Lcom/datadog/android/rum/model/ResourceEvent$ResourceType;Lcom/datadog/android/rum/model/ResourceEvent$Method;Ljava/lang/String;Ljava/lang/Long;JLjava/lang/Long;Lcom/datadog/android/rum/model/ResourceEvent$Redirect;Lcom/datadog/android/rum/model/ResourceEvent$Dns;Lcom/datadog/android/rum/model/ResourceEvent$Connect;Lcom/datadog/android/rum/model/ResourceEvent$Ssl;Lcom/datadog/android/rum/model/ResourceEvent$FirstByte;Lcom/datadog/android/rum/model/ResourceEvent$Download;Lcom/datadog/android/rum/model/ResourceEvent$Provider;)Lcom/datadog/android/rum/model/ResourceEvent$Resource;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Resource Copy (string id, global::Com.Datadog.Android.Rum.Model.ResourceEvent.ResourceType type, global::Com.Datadog.Android.Rum.Model.ResourceEvent.Method method, string url, global::Java.Lang.Long statusCode, long duration, global::Java.Lang.Long size, global::Com.Datadog.Android.Rum.Model.ResourceEvent.Redirect redirect, global::Com.Datadog.Android.Rum.Model.ResourceEvent.Dns dns, global::Com.Datadog.Android.Rum.Model.ResourceEvent.Connect connect, global::Com.Datadog.Android.Rum.Model.ResourceEvent.Ssl ssl, global::Com.Datadog.Android.Rum.Model.ResourceEvent.FirstByte firstByte, global::Com.Datadog.Android.Rum.Model.ResourceEvent.Download download, global::Com.Datadog.Android.Rum.Model.ResourceEvent.Provider provider)
			{
				const string __id = "copy.(Ljava/lang/String;Lcom/datadog/android/rum/model/ResourceEvent$ResourceType;Lcom/datadog/android/rum/model/ResourceEvent$Method;Ljava/lang/String;Ljava/lang/Long;JLjava/lang/Long;Lcom/datadog/android/rum/model/ResourceEvent$Redirect;Lcom/datadog/android/rum/model/ResourceEvent$Dns;Lcom/datadog/android/rum/model/ResourceEvent$Connect;Lcom/datadog/android/rum/model/ResourceEvent$Ssl;Lcom/datadog/android/rum/model/ResourceEvent$FirstByte;Lcom/datadog/android/rum/model/ResourceEvent$Download;Lcom/datadog/android/rum/model/ResourceEvent$Provider;)Lcom/datadog/android/rum/model/ResourceEvent$Resource;";
				IntPtr native_id = JNIEnv.NewString (id);
				IntPtr native_url = JNIEnv.NewString (url);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [14];
					__args [0] = new JniArgumentValue (native_id);
					__args [1] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
					__args [2] = new JniArgumentValue ((method == null) ? IntPtr.Zero : ((global::Java.Lang.Object) method).Handle);
					__args [3] = new JniArgumentValue (native_url);
					__args [4] = new JniArgumentValue ((statusCode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) statusCode).Handle);
					__args [5] = new JniArgumentValue (duration);
					__args [6] = new JniArgumentValue ((size == null) ? IntPtr.Zero : ((global::Java.Lang.Object) size).Handle);
					__args [7] = new JniArgumentValue ((redirect == null) ? IntPtr.Zero : ((global::Java.Lang.Object) redirect).Handle);
					__args [8] = new JniArgumentValue ((dns == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dns).Handle);
					__args [9] = new JniArgumentValue ((connect == null) ? IntPtr.Zero : ((global::Java.Lang.Object) connect).Handle);
					__args [10] = new JniArgumentValue ((ssl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ssl).Handle);
					__args [11] = new JniArgumentValue ((firstByte == null) ? IntPtr.Zero : ((global::Java.Lang.Object) firstByte).Handle);
					__args [12] = new JniArgumentValue ((download == null) ? IntPtr.Zero : ((global::Java.Lang.Object) download).Handle);
					__args [13] = new JniArgumentValue ((provider == null) ? IntPtr.Zero : ((global::Java.Lang.Object) provider).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Resource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_id);
					JNIEnv.DeleteLocalRef (native_url);
					global::System.GC.KeepAlive (type);
					global::System.GC.KeepAlive (method);
					global::System.GC.KeepAlive (statusCode);
					global::System.GC.KeepAlive (size);
					global::System.GC.KeepAlive (redirect);
					global::System.GC.KeepAlive (dns);
					global::System.GC.KeepAlive (connect);
					global::System.GC.KeepAlive (ssl);
					global::System.GC.KeepAlive (firstByte);
					global::System.GC.KeepAlive (download);
					global::System.GC.KeepAlive (provider);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Resource']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Resource;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Resource FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Resource;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Resource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.ResourceType']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ResourceEvent$ResourceType", DoNotGenerateAcw=true)]
		public sealed partial class ResourceType : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.ResourceType']/field[@name='BEACON']"
			[Register ("BEACON")]
			public static global::Com.Datadog.Android.Rum.Model.ResourceEvent.ResourceType Beacon {
				get {
					const string __id = "BEACON.Lcom/datadog/android/rum/model/ResourceEvent$ResourceType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.ResourceType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.ResourceType']/field[@name='CSS']"
			[Register ("CSS")]
			public static global::Com.Datadog.Android.Rum.Model.ResourceEvent.ResourceType Css {
				get {
					const string __id = "CSS.Lcom/datadog/android/rum/model/ResourceEvent$ResourceType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.ResourceType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.ResourceType']/field[@name='DOCUMENT']"
			[Register ("DOCUMENT")]
			public static global::Com.Datadog.Android.Rum.Model.ResourceEvent.ResourceType Document {
				get {
					const string __id = "DOCUMENT.Lcom/datadog/android/rum/model/ResourceEvent$ResourceType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.ResourceType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.ResourceType']/field[@name='FETCH']"
			[Register ("FETCH")]
			public static global::Com.Datadog.Android.Rum.Model.ResourceEvent.ResourceType Fetch {
				get {
					const string __id = "FETCH.Lcom/datadog/android/rum/model/ResourceEvent$ResourceType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.ResourceType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.ResourceType']/field[@name='FONT']"
			[Register ("FONT")]
			public static global::Com.Datadog.Android.Rum.Model.ResourceEvent.ResourceType Font {
				get {
					const string __id = "FONT.Lcom/datadog/android/rum/model/ResourceEvent$ResourceType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.ResourceType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.ResourceType']/field[@name='IMAGE']"
			[Register ("IMAGE")]
			public static global::Com.Datadog.Android.Rum.Model.ResourceEvent.ResourceType Image {
				get {
					const string __id = "IMAGE.Lcom/datadog/android/rum/model/ResourceEvent$ResourceType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.ResourceType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.ResourceType']/field[@name='JS']"
			[Register ("JS")]
			public static global::Com.Datadog.Android.Rum.Model.ResourceEvent.ResourceType Js {
				get {
					const string __id = "JS.Lcom/datadog/android/rum/model/ResourceEvent$ResourceType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.ResourceType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.ResourceType']/field[@name='MEDIA']"
			[Register ("MEDIA")]
			public static global::Com.Datadog.Android.Rum.Model.ResourceEvent.ResourceType Media {
				get {
					const string __id = "MEDIA.Lcom/datadog/android/rum/model/ResourceEvent$ResourceType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.ResourceType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.ResourceType']/field[@name='OTHER']"
			[Register ("OTHER")]
			public static global::Com.Datadog.Android.Rum.Model.ResourceEvent.ResourceType Other {
				get {
					const string __id = "OTHER.Lcom/datadog/android/rum/model/ResourceEvent$ResourceType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.ResourceType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.ResourceType']/field[@name='XHR']"
			[Register ("XHR")]
			public static global::Com.Datadog.Android.Rum.Model.ResourceEvent.ResourceType Xhr {
				get {
					const string __id = "XHR.Lcom/datadog/android/rum/model/ResourceEvent$ResourceType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.ResourceType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.ResourceType.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ResourceEvent$ResourceType$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ResourceEvent$ResourceType$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.ResourceType.Companion']/constructor[@name='ResourceEvent.ResourceType.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.ResourceType.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$ResourceType;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.ResourceType FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$ResourceType;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.ResourceType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ResourceEvent$ResourceType", typeof (ResourceType));

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

			internal ResourceType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.ResourceType']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$ResourceType;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.ResourceType FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$ResourceType;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.ResourceType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.ResourceType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$ResourceType;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.ResourceType ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$ResourceType;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.ResourceType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.ResourceType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/datadog/android/rum/model/ResourceEvent$ResourceType;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.ResourceType[] Values ()
			{
				const string __id = "values.()[Lcom/datadog/android/rum/model/ResourceEvent$ResourceType;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Datadog.Android.Rum.Model.ResourceEvent.ResourceType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Datadog.Android.Rum.Model.ResourceEvent.ResourceType));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Session']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ResourceEvent$Session", DoNotGenerateAcw=true)]
		public sealed partial class Session : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Session.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ResourceEvent$Session$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ResourceEvent$Session$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Session.Companion']/constructor[@name='ResourceEvent.Session.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Session.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Session;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Session FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Session;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Session> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ResourceEvent$Session", typeof (Session));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Session']/constructor[@name='ResourceEvent.Session' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.datadog.android.rum.model.ResourceEvent.SessionType'] and parameter[3][@type='java.lang.Boolean']]"
			[Register (".ctor", "(Ljava/lang/String;Lcom/datadog/android/rum/model/ResourceEvent$SessionType;Ljava/lang/Boolean;)V", "")]
			public unsafe Session (string id, global::Com.Datadog.Android.Rum.Model.ResourceEvent.SessionType type, global::Java.Lang.Boolean hasReplay) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;Lcom/datadog/android/rum/model/ResourceEvent$SessionType;Ljava/lang/Boolean;)V";

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
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Session']/method[@name='getHasReplay' and count(parameter)=0]"
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
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Session']/method[@name='getId' and count(parameter)=0]"
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

			public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.SessionType Type {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Session']/method[@name='getType' and count(parameter)=0]"
				[Register ("getType", "()Lcom/datadog/android/rum/model/ResourceEvent$SessionType;", "")]
				get {
					const string __id = "getType.()Lcom/datadog/android/rum/model/ResourceEvent$SessionType;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.SessionType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Session']/method[@name='component1' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Session']/method[@name='component2' and count(parameter)=0]"
			[Register ("component2", "()Lcom/datadog/android/rum/model/ResourceEvent$SessionType;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.SessionType Component2 ()
			{
				const string __id = "component2.()Lcom/datadog/android/rum/model/ResourceEvent$SessionType;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.SessionType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Session']/method[@name='component3' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Session']/method[@name='copy' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.datadog.android.rum.model.ResourceEvent.SessionType'] and parameter[3][@type='java.lang.Boolean']]"
			[Register ("copy", "(Ljava/lang/String;Lcom/datadog/android/rum/model/ResourceEvent$SessionType;Ljava/lang/Boolean;)Lcom/datadog/android/rum/model/ResourceEvent$Session;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Session Copy (string id, global::Com.Datadog.Android.Rum.Model.ResourceEvent.SessionType type, global::Java.Lang.Boolean hasReplay)
			{
				const string __id = "copy.(Ljava/lang/String;Lcom/datadog/android/rum/model/ResourceEvent$SessionType;Ljava/lang/Boolean;)Lcom/datadog/android/rum/model/ResourceEvent$Session;";
				IntPtr native_id = JNIEnv.NewString (id);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_id);
					__args [1] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
					__args [2] = new JniArgumentValue ((hasReplay == null) ? IntPtr.Zero : ((global::Java.Lang.Object) hasReplay).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Session> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_id);
					global::System.GC.KeepAlive (type);
					global::System.GC.KeepAlive (hasReplay);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Session']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Session;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Session FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Session;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Session> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.SessionType']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ResourceEvent$SessionType", DoNotGenerateAcw=true)]
		public sealed partial class SessionType : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.SessionType']/field[@name='SYNTHETICS']"
			[Register ("SYNTHETICS")]
			public static global::Com.Datadog.Android.Rum.Model.ResourceEvent.SessionType Synthetics {
				get {
					const string __id = "SYNTHETICS.Lcom/datadog/android/rum/model/ResourceEvent$SessionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.SessionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.SessionType']/field[@name='USER']"
			[Register ("USER")]
			public static global::Com.Datadog.Android.Rum.Model.ResourceEvent.SessionType User {
				get {
					const string __id = "USER.Lcom/datadog/android/rum/model/ResourceEvent$SessionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.SessionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.SessionType.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ResourceEvent$SessionType$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ResourceEvent$SessionType$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.SessionType.Companion']/constructor[@name='ResourceEvent.SessionType.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.SessionType.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$SessionType;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.SessionType FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$SessionType;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.SessionType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ResourceEvent$SessionType", typeof (SessionType));

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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.SessionType']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$SessionType;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.SessionType FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$SessionType;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.SessionType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.SessionType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$SessionType;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.SessionType ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$SessionType;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.SessionType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.SessionType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/datadog/android/rum/model/ResourceEvent$SessionType;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.SessionType[] Values ()
			{
				const string __id = "values.()[Lcom/datadog/android/rum/model/ResourceEvent$SessionType;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Datadog.Android.Rum.Model.ResourceEvent.SessionType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Datadog.Android.Rum.Model.ResourceEvent.SessionType));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Ssl']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ResourceEvent$Ssl", DoNotGenerateAcw=true)]
		public sealed partial class Ssl : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Ssl.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ResourceEvent$Ssl$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ResourceEvent$Ssl$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Ssl.Companion']/constructor[@name='ResourceEvent.Ssl.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Ssl.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Ssl;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Ssl FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Ssl;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Ssl> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ResourceEvent$Ssl", typeof (Ssl));

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

			internal Ssl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Ssl']/constructor[@name='ResourceEvent.Ssl' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
			[Register (".ctor", "(JJ)V", "")]
			public unsafe Ssl (long duration, long start) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(JJ)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (duration);
					__args [1] = new JniArgumentValue (start);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			public unsafe long Duration {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Ssl']/method[@name='getDuration' and count(parameter)=0]"
				[Register ("getDuration", "()J", "")]
				get {
					const string __id = "getDuration.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe long Start {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Ssl']/method[@name='getStart' and count(parameter)=0]"
				[Register ("getStart", "()J", "")]
				get {
					const string __id = "getStart.()J";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Ssl']/method[@name='component1' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Ssl']/method[@name='component2' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Ssl']/method[@name='copy' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
			[Register ("copy", "(JJ)Lcom/datadog/android/rum/model/ResourceEvent$Ssl;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Ssl Copy (long duration, long start)
			{
				const string __id = "copy.(JJ)Lcom/datadog/android/rum/model/ResourceEvent$Ssl;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (duration);
					__args [1] = new JniArgumentValue (start);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Ssl> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Ssl']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Ssl;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Ssl FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Ssl;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Ssl> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Status']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ResourceEvent$Status", DoNotGenerateAcw=true)]
		public sealed partial class Status : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Status']/field[@name='CONNECTED']"
			[Register ("CONNECTED")]
			public static global::Com.Datadog.Android.Rum.Model.ResourceEvent.Status Connected {
				get {
					const string __id = "CONNECTED.Lcom/datadog/android/rum/model/ResourceEvent$Status;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Status> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Status']/field[@name='MAYBE']"
			[Register ("MAYBE")]
			public static global::Com.Datadog.Android.Rum.Model.ResourceEvent.Status Maybe {
				get {
					const string __id = "MAYBE.Lcom/datadog/android/rum/model/ResourceEvent$Status;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Status> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Status']/field[@name='NOT_CONNECTED']"
			[Register ("NOT_CONNECTED")]
			public static global::Com.Datadog.Android.Rum.Model.ResourceEvent.Status NotConnected {
				get {
					const string __id = "NOT_CONNECTED.Lcom/datadog/android/rum/model/ResourceEvent$Status;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Status> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Status.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ResourceEvent$Status$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ResourceEvent$Status$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Status.Companion']/constructor[@name='ResourceEvent.Status.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Status.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Status;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Status FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Status;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Status> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ResourceEvent$Status", typeof (Status));

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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Status']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Status;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Status FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Status;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Status> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Status']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Status;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Status ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Status;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Status> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Status']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/datadog/android/rum/model/ResourceEvent$Status;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Status[] Values ()
			{
				const string __id = "values.()[Lcom/datadog/android/rum/model/ResourceEvent$Status;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Datadog.Android.Rum.Model.ResourceEvent.Status[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Datadog.Android.Rum.Model.ResourceEvent.Status));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Usr']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ResourceEvent$Usr", DoNotGenerateAcw=true)]
		public sealed partial class Usr : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Usr.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ResourceEvent$Usr$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ResourceEvent$Usr$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Usr.Companion']/constructor[@name='ResourceEvent.Usr.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Usr.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Usr;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Usr FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Usr;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Usr> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ResourceEvent$Usr", typeof (Usr));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Usr']/constructor[@name='ResourceEvent.Usr' and count(parameter)=0]"
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Usr']/constructor[@name='ResourceEvent.Usr' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
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
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Usr']/method[@name='getEmail' and count(parameter)=0]"
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
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Usr']/method[@name='getId' and count(parameter)=0]"
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
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Usr']/method[@name='getName' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Usr']/method[@name='component1' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Usr']/method[@name='component2' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Usr']/method[@name='component3' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Usr']/method[@name='copy' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register ("copy", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Usr;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Usr Copy (string id, string name, string email)
			{
				const string __id = "copy.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Usr;";
				IntPtr native_id = JNIEnv.NewString (id);
				IntPtr native_name = JNIEnv.NewString (name);
				IntPtr native_email = JNIEnv.NewString (email);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_id);
					__args [1] = new JniArgumentValue (native_name);
					__args [2] = new JniArgumentValue (native_email);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Usr> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_id);
					JNIEnv.DeleteLocalRef (native_name);
					JNIEnv.DeleteLocalRef (native_email);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.Usr']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Usr;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Usr FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$Usr;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Usr> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.View']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/model/ResourceEvent$View", DoNotGenerateAcw=true)]
		public sealed partial class View : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.View.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/rum/model/ResourceEvent$View$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ResourceEvent$View$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.View.Companion']/constructor[@name='ResourceEvent.View.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.View.Companion']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$View;", "")]
				public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.View FromJson (string serializedObject)
				{
					const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$View;";
					IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_serializedObject);
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_serializedObject);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ResourceEvent$View", typeof (View));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.View']/constructor[@name='ResourceEvent.View' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
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
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.View']/method[@name='getId' and count(parameter)=0]"
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
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.View']/method[@name='getReferrer' and count(parameter)=0]"
				[Register ("getReferrer", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getReferrer.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.View']/method[@name='setReferrer' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.View']/method[@name='getUrl' and count(parameter)=0]"
				[Register ("getUrl", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getUrl.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.View']/method[@name='setUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.View']/method[@name='component1' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.View']/method[@name='component2' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.View']/method[@name='component3' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.View']/method[@name='copy' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register ("copy", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$View;", "")]
			public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.View Copy (string id, string referrer, string url)
			{
				const string __id = "copy.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$View;";
				IntPtr native_id = JNIEnv.NewString (id);
				IntPtr native_referrer = JNIEnv.NewString (referrer);
				IntPtr native_url = JNIEnv.NewString (url);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_id);
					__args [1] = new JniArgumentValue (native_referrer);
					__args [2] = new JniArgumentValue (native_url);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_id);
					JNIEnv.DeleteLocalRef (native_referrer);
					JNIEnv.DeleteLocalRef (native_url);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent.View']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$View;", "")]
			public static unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.View FromJson (string serializedObject)
			{
				const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent$View;";
				IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serializedObject);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serializedObject);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/model/ResourceEvent", typeof (ResourceEvent));

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

		internal ResourceEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent']/constructor[@name='ResourceEvent' and count(parameter)=10 and parameter[1][@type='long'] and parameter[2][@type='com.datadog.android.rum.model.ResourceEvent.Application'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.datadog.android.rum.model.ResourceEvent.Session'] and parameter[5][@type='com.datadog.android.rum.model.ResourceEvent.View'] and parameter[6][@type='com.datadog.android.rum.model.ResourceEvent.Usr'] and parameter[7][@type='com.datadog.android.rum.model.ResourceEvent.Connectivity'] and parameter[8][@type='com.datadog.android.rum.model.ResourceEvent.Dd'] and parameter[9][@type='com.datadog.android.rum.model.ResourceEvent.Resource'] and parameter[10][@type='com.datadog.android.rum.model.ResourceEvent.Action']]"
		[Register (".ctor", "(JLcom/datadog/android/rum/model/ResourceEvent$Application;Ljava/lang/String;Lcom/datadog/android/rum/model/ResourceEvent$Session;Lcom/datadog/android/rum/model/ResourceEvent$View;Lcom/datadog/android/rum/model/ResourceEvent$Usr;Lcom/datadog/android/rum/model/ResourceEvent$Connectivity;Lcom/datadog/android/rum/model/ResourceEvent$Dd;Lcom/datadog/android/rum/model/ResourceEvent$Resource;Lcom/datadog/android/rum/model/ResourceEvent$Action;)V", "")]
		public unsafe ResourceEvent (long date, global::Com.Datadog.Android.Rum.Model.ResourceEvent.Application application, string service, global::Com.Datadog.Android.Rum.Model.ResourceEvent.Session session, global::Com.Datadog.Android.Rum.Model.ResourceEvent.View view, global::Com.Datadog.Android.Rum.Model.ResourceEvent.Usr usr, global::Com.Datadog.Android.Rum.Model.ResourceEvent.Connectivity connectivity, global::Com.Datadog.Android.Rum.Model.ResourceEvent.Dd dd, global::Com.Datadog.Android.Rum.Model.ResourceEvent.Resource resource, global::Com.Datadog.Android.Rum.Model.ResourceEvent.Action action) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(JLcom/datadog/android/rum/model/ResourceEvent$Application;Ljava/lang/String;Lcom/datadog/android/rum/model/ResourceEvent$Session;Lcom/datadog/android/rum/model/ResourceEvent$View;Lcom/datadog/android/rum/model/ResourceEvent$Usr;Lcom/datadog/android/rum/model/ResourceEvent$Connectivity;Lcom/datadog/android/rum/model/ResourceEvent$Dd;Lcom/datadog/android/rum/model/ResourceEvent$Resource;Lcom/datadog/android/rum/model/ResourceEvent$Action;)V";

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
				__args [8] = new JniArgumentValue ((resource == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resource).Handle);
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
				global::System.GC.KeepAlive (resource);
				global::System.GC.KeepAlive (action);
			}
		}

		public unsafe long Date {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent']/method[@name='getDate' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent']/method[@name='getService' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent']/method[@name='getType' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent']/method[@name='component1' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent']/method[@name='component10' and count(parameter)=0]"
		[Register ("component10", "()Lcom/datadog/android/rum/model/ResourceEvent$Action;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Action Component10 ()
		{
			const string __id = "component10.()Lcom/datadog/android/rum/model/ResourceEvent$Action;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Action> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent']/method[@name='component2' and count(parameter)=0]"
		[Register ("component2", "()Lcom/datadog/android/rum/model/ResourceEvent$Application;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Application Component2 ()
		{
			const string __id = "component2.()Lcom/datadog/android/rum/model/ResourceEvent$Application;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Application> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent']/method[@name='component3' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent']/method[@name='component4' and count(parameter)=0]"
		[Register ("component4", "()Lcom/datadog/android/rum/model/ResourceEvent$Session;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Session Component4 ()
		{
			const string __id = "component4.()Lcom/datadog/android/rum/model/ResourceEvent$Session;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Session> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent']/method[@name='component5' and count(parameter)=0]"
		[Register ("component5", "()Lcom/datadog/android/rum/model/ResourceEvent$View;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.View Component5 ()
		{
			const string __id = "component5.()Lcom/datadog/android/rum/model/ResourceEvent$View;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent']/method[@name='component6' and count(parameter)=0]"
		[Register ("component6", "()Lcom/datadog/android/rum/model/ResourceEvent$Usr;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Usr Component6 ()
		{
			const string __id = "component6.()Lcom/datadog/android/rum/model/ResourceEvent$Usr;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Usr> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent']/method[@name='component7' and count(parameter)=0]"
		[Register ("component7", "()Lcom/datadog/android/rum/model/ResourceEvent$Connectivity;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Connectivity Component7 ()
		{
			const string __id = "component7.()Lcom/datadog/android/rum/model/ResourceEvent$Connectivity;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Connectivity> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent']/method[@name='component8' and count(parameter)=0]"
		[Register ("component8", "()Lcom/datadog/android/rum/model/ResourceEvent$Dd;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Dd Component8 ()
		{
			const string __id = "component8.()Lcom/datadog/android/rum/model/ResourceEvent$Dd;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Dd> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent']/method[@name='component9' and count(parameter)=0]"
		[Register ("component9", "()Lcom/datadog/android/rum/model/ResourceEvent$Resource;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Resource Component9 ()
		{
			const string __id = "component9.()Lcom/datadog/android/rum/model/ResourceEvent$Resource;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Resource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent']/method[@name='copy' and count(parameter)=10 and parameter[1][@type='long'] and parameter[2][@type='com.datadog.android.rum.model.ResourceEvent.Application'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.datadog.android.rum.model.ResourceEvent.Session'] and parameter[5][@type='com.datadog.android.rum.model.ResourceEvent.View'] and parameter[6][@type='com.datadog.android.rum.model.ResourceEvent.Usr'] and parameter[7][@type='com.datadog.android.rum.model.ResourceEvent.Connectivity'] and parameter[8][@type='com.datadog.android.rum.model.ResourceEvent.Dd'] and parameter[9][@type='com.datadog.android.rum.model.ResourceEvent.Resource'] and parameter[10][@type='com.datadog.android.rum.model.ResourceEvent.Action']]"
		[Register ("copy", "(JLcom/datadog/android/rum/model/ResourceEvent$Application;Ljava/lang/String;Lcom/datadog/android/rum/model/ResourceEvent$Session;Lcom/datadog/android/rum/model/ResourceEvent$View;Lcom/datadog/android/rum/model/ResourceEvent$Usr;Lcom/datadog/android/rum/model/ResourceEvent$Connectivity;Lcom/datadog/android/rum/model/ResourceEvent$Dd;Lcom/datadog/android/rum/model/ResourceEvent$Resource;Lcom/datadog/android/rum/model/ResourceEvent$Action;)Lcom/datadog/android/rum/model/ResourceEvent;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent Copy (long date, global::Com.Datadog.Android.Rum.Model.ResourceEvent.Application application, string service, global::Com.Datadog.Android.Rum.Model.ResourceEvent.Session session, global::Com.Datadog.Android.Rum.Model.ResourceEvent.View view, global::Com.Datadog.Android.Rum.Model.ResourceEvent.Usr usr, global::Com.Datadog.Android.Rum.Model.ResourceEvent.Connectivity connectivity, global::Com.Datadog.Android.Rum.Model.ResourceEvent.Dd dd, global::Com.Datadog.Android.Rum.Model.ResourceEvent.Resource resource, global::Com.Datadog.Android.Rum.Model.ResourceEvent.Action action)
		{
			const string __id = "copy.(JLcom/datadog/android/rum/model/ResourceEvent$Application;Ljava/lang/String;Lcom/datadog/android/rum/model/ResourceEvent$Session;Lcom/datadog/android/rum/model/ResourceEvent$View;Lcom/datadog/android/rum/model/ResourceEvent$Usr;Lcom/datadog/android/rum/model/ResourceEvent$Connectivity;Lcom/datadog/android/rum/model/ResourceEvent$Dd;Lcom/datadog/android/rum/model/ResourceEvent$Resource;Lcom/datadog/android/rum/model/ResourceEvent$Action;)Lcom/datadog/android/rum/model/ResourceEvent;";
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
				__args [8] = new JniArgumentValue ((resource == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resource).Handle);
				__args [9] = new JniArgumentValue ((action == null) ? IntPtr.Zero : ((global::Java.Lang.Object) action).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_service);
				global::System.GC.KeepAlive (application);
				global::System.GC.KeepAlive (session);
				global::System.GC.KeepAlive (view);
				global::System.GC.KeepAlive (usr);
				global::System.GC.KeepAlive (connectivity);
				global::System.GC.KeepAlive (dd);
				global::System.GC.KeepAlive (resource);
				global::System.GC.KeepAlive (action);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromJson", "(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent;", "")]
		public static unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent FromJson (string serializedObject)
		{
			const string __id = "fromJson.(Ljava/lang/String;)Lcom/datadog/android/rum/model/ResourceEvent;";
			IntPtr native_serializedObject = JNIEnv.NewString (serializedObject);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_serializedObject);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_serializedObject);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent']/method[@name='getAction' and count(parameter)=0]"
		[Register ("getAction", "()Lcom/datadog/android/rum/model/ResourceEvent$Action;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Action GetAction ()
		{
			const string __id = "getAction.()Lcom/datadog/android/rum/model/ResourceEvent$Action;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Action> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent']/method[@name='getApplication' and count(parameter)=0]"
		[Register ("getApplication", "()Lcom/datadog/android/rum/model/ResourceEvent$Application;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Application GetApplication ()
		{
			const string __id = "getApplication.()Lcom/datadog/android/rum/model/ResourceEvent$Application;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Application> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent']/method[@name='getConnectivity' and count(parameter)=0]"
		[Register ("getConnectivity", "()Lcom/datadog/android/rum/model/ResourceEvent$Connectivity;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Connectivity GetConnectivity ()
		{
			const string __id = "getConnectivity.()Lcom/datadog/android/rum/model/ResourceEvent$Connectivity;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Connectivity> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent']/method[@name='getDd' and count(parameter)=0]"
		[Register ("getDd", "()Lcom/datadog/android/rum/model/ResourceEvent$Dd;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Dd GetDd ()
		{
			const string __id = "getDd.()Lcom/datadog/android/rum/model/ResourceEvent$Dd;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Dd> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent']/method[@name='getResource' and count(parameter)=0]"
		[Register ("getResource", "()Lcom/datadog/android/rum/model/ResourceEvent$Resource;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Resource GetResource ()
		{
			const string __id = "getResource.()Lcom/datadog/android/rum/model/ResourceEvent$Resource;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Resource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent']/method[@name='getSession' and count(parameter)=0]"
		[Register ("getSession", "()Lcom/datadog/android/rum/model/ResourceEvent$Session;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Session GetSession ()
		{
			const string __id = "getSession.()Lcom/datadog/android/rum/model/ResourceEvent$Session;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Session> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent']/method[@name='getUsr' and count(parameter)=0]"
		[Register ("getUsr", "()Lcom/datadog/android/rum/model/ResourceEvent$Usr;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.Usr GetUsr ()
		{
			const string __id = "getUsr.()Lcom/datadog/android/rum/model/ResourceEvent$Usr;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.Usr> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.model']/class[@name='ResourceEvent']/method[@name='getView' and count(parameter)=0]"
		[Register ("getView", "()Lcom/datadog/android/rum/model/ResourceEvent$View;", "")]
		public unsafe global::Com.Datadog.Android.Rum.Model.ResourceEvent.View GetView ()
		{
			const string __id = "getView.()Lcom/datadog/android/rum/model/ResourceEvent$View;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Model.ResourceEvent.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
