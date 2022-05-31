using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Android.Event {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.datadog.android.event']/interface[@name='EventMapper']"
	[Register ("com/datadog/android/event/EventMapper", "", "Com.Datadog.Android.Event.IEventMapperInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IEventMapper : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.event']/interface[@name='EventMapper']/method[@name='map' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("map", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetMap_Ljava_lang_Object_Handler:Com.Datadog.Android.Event.IEventMapperInvoker, Datadog_sdk_android")]
		global::Java.Lang.Object Map (global::Java.Lang.Object e);

	}

	[global::Android.Runtime.Register ("com/datadog/android/event/EventMapper", DoNotGenerateAcw=true)]
	internal partial class IEventMapperInvoker : global::Java.Lang.Object, IEventMapper {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/event/EventMapper", typeof (IEventMapperInvoker));

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

		public static IEventMapper GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEventMapper> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.datadog.android.event.EventMapper'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEventMapperInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_map_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetMap_Ljava_lang_Object_Handler ()
		{
			if (cb_map_Ljava_lang_Object_ == null)
				cb_map_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Map_Ljava_lang_Object_);
			return cb_map_Ljava_lang_Object_;
		}

		static IntPtr n_Map_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Event.IEventMapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var e = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_e, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Map (e));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_map_Ljava_lang_Object_;
		public unsafe global::Java.Lang.Object Map (global::Java.Lang.Object e)
		{
			if (id_map_Ljava_lang_Object_ == IntPtr.Zero)
				id_map_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "map", "(Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_e = JNIEnv.ToLocalJniHandle (e);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_e);
			var __ret = (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_map_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_e);
			return __ret;
		}

	}
}
