using System.Management.Automation;
using Avalonia.Controls;
using System.Collections;
using System;
using System.Collections.Generic;

namespace PSAvalonia
{
    [Cmdlet(VerbsData.ConvertTo, "AvaloniaWindow")]
    public class ConvertToAvaloniaWindow : PSCmdlet {
        [Parameter(Mandatory = true)]
        public string Xaml { get; set; }

        protected override void ProcessRecord() {
            var window = AvaloniaBootstrapper.Load(Xaml);
            WriteObject(window);
        }
    }

    [Cmdlet(VerbsCommon.Find, "AvaloniaControl")]
    public class FindAvaloniaControl : PSCmdlet
    {
        [Parameter(Mandatory = true)]
        public Window Window { get; set; }
        [Parameter(Mandatory = true)]
        public string Name { get; set; }

        protected override void ProcessRecord()
        {
            WriteObject(Window.FindControl<IControl>(Name));
        }
    }

    [Cmdlet(VerbsCommon.Show, "AvaloniaWindow")]
    public class ShowAvaloniaWindow : PSCmdlet {
        [Parameter(Mandatory = true)]
        public Window Window { get; set; }

        protected override void ProcessRecord() {
            AvaloniaBootstrapper.Start(Window);
        }
    }

    // [Cmdlet(VerbsData.Out, "GridViewCore")]
    // public class OutGridViewCore : PSCmdlet
    // {
    //     private List<PSObject> _objects = new List<PSObject>();

    //     [Parameter(ValueFromPipeline = true, Mandatory = true)]
    //     public PSObject InputObject { get; set; }

    //     protected override void ProcessRecord()
    //     {
    //         _objects.Add(InputObject);
    //     }

    //     protected override void EndProcessing()
    //     {
    //         var window = new OutGridView.OutGridViewWindow(_objects);
    //         AvaloniaBootstrapper.Start(window);
    //     }
    // }
}