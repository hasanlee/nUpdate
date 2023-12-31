﻿// ProgressReporterService.cs, 10.06.2019
// Copyright (C) Dominic Beger 17.06.2019

using System;
using nUpdate.UpdateInstaller.UI.Dialogs;
using nUpdate.UpdateInstaller.UIBase;

namespace nUpdate.UpdateInstaller
{
    public class ProgressReporterService : IProgressReporter
    {
        private readonly MainForm _mainForm;

        public ProgressReporterService()
        {
            _mainForm = new MainForm();
        }

        public void Fail(Exception ex)
        {
            _mainForm.Fail(ex);
        }

        public void Initialize()
        {
            _mainForm.Initialize();
        }

        public void InitializingFail(Exception ex)
        {
            _mainForm.InitializingFail(ex);
        }

        public void ReportOperationProgress(float progress, string currentOperation)
        {
            _mainForm.ReportOperationProgress(progress, currentOperation);
        }

        public void ReportUnpackingProgress(float progress, string currentFile)
        {
            _mainForm.ReportUnpackingProgress(progress, currentFile);
        }

        public void Terminate()
        {
            _mainForm.Terminate();
        }
    }
}