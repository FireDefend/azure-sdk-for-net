// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> An object representing the task definition for an Extractive Summarization task. </summary>
    internal partial class ExtractiveSummarizationLROTask : AnalyzeTextLROTask
    {
        /// <summary> Initializes a new instance of ExtractiveSummarizationLROTask. </summary>
        public ExtractiveSummarizationLROTask()
        {
            Kind = AnalyzeTextLROTaskKind.ExtractiveSummarization;
        }

        /// <summary> Initializes a new instance of ExtractiveSummarizationLROTask. </summary>
        /// <param name="taskName"></param>
        /// <param name="kind"> Enumeration of supported long-running Text Analysis tasks. </param>
        /// <param name="parameters"> Supported parameters for an Extractive Summarization task. </param>
        internal ExtractiveSummarizationLROTask(string taskName, AnalyzeTextLROTaskKind kind, ExtractiveSummarizationTaskParameters parameters) : base(taskName, kind)
        {
            Parameters = parameters;
            Kind = kind;
        }

        /// <summary> Supported parameters for an Extractive Summarization task. </summary>
        public ExtractiveSummarizationTaskParameters Parameters { get; set; }
    }
}
