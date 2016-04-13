﻿using System;
using System.Collections.Generic;
using System.Xml.XPath;
using Umbraco.Core.Models;
using Umbraco.Core.Xml;
using Umbraco.Web;
using Umbraco.Web.PublishedCache;

namespace Our.Umbraco.Ditto.Tests.Mocks
{
    public class MockPublishedMediaCache : IPublishedMediaCache
    {
        public bool XPathNavigatorIsNavigable
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerable<IPublishedContent> GetAtRoot(UmbracoContext umbracoContext, bool preview)
        {
            throw new NotImplementedException();
        }

        public IPublishedContent GetById(UmbracoContext umbracoContext, bool preview, int contentId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IPublishedContent> GetByXPath(UmbracoContext umbracoContext, bool preview, XPathExpression xpath, XPathVariable[] vars)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IPublishedContent> GetByXPath(UmbracoContext umbracoContext, bool preview, string xpath, XPathVariable[] vars)
        {
            throw new NotImplementedException();
        }

        public IPublishedContent GetSingleByXPath(UmbracoContext umbracoContext, bool preview, XPathExpression xpath, XPathVariable[] vars)
        {
            throw new NotImplementedException();
        }

        public IPublishedContent GetSingleByXPath(UmbracoContext umbracoContext, bool preview, string xpath, XPathVariable[] vars)
        {
            throw new NotImplementedException();
        }

        public XPathNavigator GetXPathNavigator(UmbracoContext umbracoContext, bool preview)
        {
            throw new NotImplementedException();
        }

        public bool HasContent(UmbracoContext umbracoContext, bool preview)
        {
            throw new NotImplementedException();
        }
    }
}