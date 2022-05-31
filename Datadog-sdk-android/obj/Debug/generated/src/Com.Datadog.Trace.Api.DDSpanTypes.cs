using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Trace.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='DDSpanTypes']"
	[global::Android.Runtime.Register ("com/datadog/trace/api/DDSpanTypes", DoNotGenerateAcw=true)]
	public partial class DDSpanTypes : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='DDSpanTypes']/field[@name='CACHE']"
		[Register ("CACHE")]
		public const string Cache = (string) "cache";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='DDSpanTypes']/field[@name='CASSANDRA']"
		[Register ("CASSANDRA")]
		public const string Cassandra = (string) "cassandra";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='DDSpanTypes']/field[@name='COUCHBASE']"
		[Register ("COUCHBASE")]
		public const string Couchbase = (string) "db";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='DDSpanTypes']/field[@name='ELASTICSEARCH']"
		[Register ("ELASTICSEARCH")]
		public const string Elasticsearch = (string) "elasticsearch";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='DDSpanTypes']/field[@name='HIBERNATE']"
		[Register ("HIBERNATE")]
		public const string Hibernate = (string) "hibernate";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='DDSpanTypes']/field[@name='HTTP_CLIENT']"
		[Register ("HTTP_CLIENT")]
		public const string HttpClient = (string) "http";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='DDSpanTypes']/field[@name='HTTP_SERVER']"
		[Register ("HTTP_SERVER")]
		public const string HttpServer = (string) "web";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='DDSpanTypes']/field[@name='MEMCACHED']"
		[Register ("MEMCACHED")]
		public const string Memcached = (string) "memcached";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='DDSpanTypes']/field[@name='MESSAGE_CLIENT']"
		[Register ("MESSAGE_CLIENT")]
		public const string MessageClient = (string) "queue";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='DDSpanTypes']/field[@name='MESSAGE_CONSUMER']"
		[Register ("MESSAGE_CONSUMER")]
		public const string MessageConsumer = (string) "queue";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='DDSpanTypes']/field[@name='MESSAGE_PRODUCER']"
		[Register ("MESSAGE_PRODUCER")]
		public const string MessageProducer = (string) "queue";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='DDSpanTypes']/field[@name='MONGO']"
		[Register ("MONGO")]
		public const string Mongo = (string) "mongodb";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='DDSpanTypes']/field[@name='REDIS']"
		[Register ("REDIS")]
		public const string Redis = (string) "redis";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='DDSpanTypes']/field[@name='RPC']"
		[Register ("RPC")]
		public const string Rpc = (string) "rpc";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='DDSpanTypes']/field[@name='SQL']"
		[Register ("SQL")]
		public const string Sql = (string) "sql";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='DDSpanTypes']/field[@name='WEB_SERVLET']"
		[Register ("WEB_SERVLET")]
		[Obsolete ("deprecated")]
		public const string WebServlet = (string) "web";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/trace/api/DDSpanTypes", typeof (DDSpanTypes));

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

		protected DDSpanTypes (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='DDSpanTypes']/constructor[@name='DDSpanTypes' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DDSpanTypes () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
