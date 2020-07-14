﻿using Amadeus.InterfacesForModels;
using Amadeus.InterfacesForViews;

namespace Amadeus.Presenters
{
    class ProxyPresenter
    {
        private IProxyMod _model;
        private IProxyPres _view;

        public ProxyPresenter(IProxyMod model, IProxyPres view)
        {
            _model = model;
            _view = view;
        }
    }
}
