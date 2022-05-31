using System;

namespace Com.Datadog.Trace.Api {

	[global::Android.Runtime.Annotation ("com.datadog.trace.api.Trace")]
	public partial class TraceAttribute : Attribute
	{
		[global::Android.Runtime.Register ("operationName")]
		public string OperationName { get; set; }

		[global::Android.Runtime.Register ("resourceName")]
		public string ResourceName { get; set; }

	}
}
