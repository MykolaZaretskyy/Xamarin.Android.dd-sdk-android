using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Trace.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='DDTags']"
	[global::Android.Runtime.Register ("com/datadog/trace/api/DDTags", DoNotGenerateAcw=true)]
	public partial class DDTags : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='DDTags']/field[@name='ANALYTICS_SAMPLE_RATE']"
		[Register ("ANALYTICS_SAMPLE_RATE")]
		public const string AnalyticsSampleRate = (string) "_dd1.sr.eausr";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='DDTags']/field[@name='DB_STATEMENT']"
		[Register ("DB_STATEMENT")]
		public const string DbStatement = (string) "sql.query";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='DDTags']/field[@name='ERROR_MSG']"
		[Register ("ERROR_MSG")]
		public const string ErrorMsg = (string) "error.msg";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='DDTags']/field[@name='ERROR_STACK']"
		[Register ("ERROR_STACK")]
		public const string ErrorStack = (string) "error.stack";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='DDTags']/field[@name='ERROR_TYPE']"
		[Register ("ERROR_TYPE")]
		public const string ErrorType = (string) "error.type";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='DDTags']/field[@name='EVENT_SAMPLE_RATE']"
		[Register ("EVENT_SAMPLE_RATE")]
		[Obsolete ("deprecated")]
		public const string EventSampleRate = (string) "_dd1.sr.eausr";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='DDTags']/field[@name='HTTP_FRAGMENT']"
		[Register ("HTTP_FRAGMENT")]
		public const string HttpFragment = (string) "http.fragment.string";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='DDTags']/field[@name='HTTP_QUERY']"
		[Register ("HTTP_QUERY")]
		public const string HttpQuery = (string) "http.query.string";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='DDTags']/field[@name='MANUAL_DROP']"
		[Register ("MANUAL_DROP")]
		public const string ManualDrop = (string) "manual.drop";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='DDTags']/field[@name='MANUAL_KEEP']"
		[Register ("MANUAL_KEEP")]
		public const string ManualKeep = (string) "manual.keep";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='DDTags']/field[@name='RESOURCE_NAME']"
		[Register ("RESOURCE_NAME")]
		public const string ResourceName = (string) "resource.name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='DDTags']/field[@name='SERVICE_NAME']"
		[Register ("SERVICE_NAME")]
		public const string ServiceName = (string) "service.name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='DDTags']/field[@name='SPAN_TYPE']"
		[Register ("SPAN_TYPE")]
		public const string SpanType = (string) "span.type";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='DDTags']/field[@name='THREAD_ID']"
		[Register ("THREAD_ID")]
		public const string ThreadId = (string) "thread.id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='DDTags']/field[@name='THREAD_NAME']"
		[Register ("THREAD_NAME")]
		public const string ThreadName = (string) "thread.name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='DDTags']/field[@name='USER_NAME']"
		[Register ("USER_NAME")]
		public const string UserName = (string) "user.principal";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/trace/api/DDTags", typeof (DDTags));

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

		protected DDTags (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='DDTags']/constructor[@name='DDTags' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DDTags () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

	}
}
