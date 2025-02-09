﻿using System;
using Emignatik.NxFileViewer.Models.TreeItems.Impl;
using Emignatik.NxFileViewer.Views.ObjectPropertyViewer;
using LibHac.Ns;

namespace Emignatik.NxFileViewer.Views.TreeItems.Impl;

public class NacpItemViewModel : DirectoryEntryItemViewModel
{
    private readonly NacpItem _nacpItem;

    public NacpItemViewModel(NacpItem nacpItem, IServiceProvider serviceProvider)
        : base(nacpItem, serviceProvider)
    {
        _nacpItem = nacpItem;
    }

    [PropertyView]
    public string DisplayVersion => _nacpItem.DisplayVersion;

    [PropertyView]
    public string AddOnContentBaseId => _nacpItem.AddOnContentBaseId;

    [PropertyView]
    public string Isbn => _nacpItem.Isbn;

    [PropertyView]
    public string ApplicationErrorCodeCategory => _nacpItem.ApplicationErrorCodeCategory;

    [PropertyView]
    public string BcatPassphrase => _nacpItem.BcatPassphrase;

    [PropertyView]
    public ApplicationControlProperty.ParentalControlFlagValue ParentalControl => _nacpItem.ParentalControl;
}