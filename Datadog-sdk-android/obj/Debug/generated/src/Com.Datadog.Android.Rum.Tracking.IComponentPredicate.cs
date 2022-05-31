using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Android.Rum.Tracking {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.datadog.android.rum.tracking']/interface[@name='ComponentPredicate']"
	[Register ("com/datadog/android/rum/tracking/ComponentPredicate", "", "Com.Datadog.Android.Rum.Tracking.IComponentPredicateInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IComponentPredicate : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.tracking']/interface[@name='ComponentPredicate']/method[@name='accept' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("accept", "(Ljava/lang/Object;)Z", "GetAccept_Ljava_lang_Object_Handler:Com.Datadog.Android.Rum.Tracking.IComponentPredicateInvoker, Datadog_sdk_android")]
		bool Accept (global::Java.Lang.Object component);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.tracking']/interface[@name='ComponentPredicate']/method[@name='getViewName' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("getViewName", "(Ljava/lang/Object;)Ljava/lang/String;", "GetGetViewName_Ljava_lang_Object_Handler:Com.Datadog.Android.Rum.Tracking.IComponentPredicateInvoker, Datadog_sdk_android")]
		string GetViewName (global::Java.Lang.Object component);

	}

	[global::Android.Runtime.Register ("com/datadog/android/rum/tracking/ComponentPredicate", DoNotGenerateAcw=true)]
	internal partial class IComponentPredicateInvoker : global::Java.Lang.Object, IComponentPredicate {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/tracking/ComponentPredicate", typeof (IComponentPredicateInvoker));

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

		public static IComponentPredicate GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IComponentPredicate> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.datadog.android.rum.tracking.ComponentPredicate'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IComponentPredicateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_accept_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAccept_Ljava_lang_Object_Handler ()
		{
			if (cb_accept_Ljava_lang_Object_ == null)
				cb_accept_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Accept_Ljava_lang_Object_);
			return cb_accept_Ljava_lang_Object_;
		}

		static bool n_Accept_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_component)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Tracking.IComponentPredicate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var component = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_component, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Accept (component);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_accept_Ljava_lang_Object_;
		public unsafe bool Accept (global::Java.Lang.Object component)
		{
			if (id_accept_Ljava_lang_Object_ == IntPtr.Zero)
				id_accept_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "accept", "(Ljava/lang/Object;)Z");
			IntPtr native_component = JNIEnv.ToLocalJniHandle (component);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_component);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_accept_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_component);
			return __ret;
		}

		static Delegate cb_getViewName_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetViewName_Ljava_lang_Object_Handler ()
		{
			if (cb_getViewName_Ljava_lang_Object_ == null)
				cb_getViewName_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetViewName_Ljava_lang_Object_);
			return cb_getViewName_Ljava_lang_Object_;
		}

		static IntPtr n_GetViewName_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_component)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Tracking.IComponentPredicate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var component = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_component, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetViewName (component));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getViewName_Ljava_lang_Object_;
		public unsafe string GetViewName (global::Java.Lang.Object component)
		{
			if (id_getViewName_Ljava_lang_Object_ == IntPtr.Zero)
				id_getViewName_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getViewName", "(Ljava/lang/Object;)Ljava/lang/String;");
			IntPtr native_component = JNIEnv.ToLocalJniHandle (component);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_component);
			var __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getViewName_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_component);
			return __ret;
		}

	}
}
