//######################################################################
//# DESCRIPTION:
//#
//# AUTHOR:		Mohammad Saiful Alam (Jewel)
//# POSITION:	Senior General Manager
//# E-MAIL:		saiful_vonair@yahoo.com
//# CREATE DATE: 
//#
//# Copyright: Free to use
//######################################################################

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ViewSwitcher
{
    public class ControllerView
    {
        public static ControllerView Instance
        {
            get
            {
                if (mInstance == null)
                    mInstance = new ControllerView();

                return mInstance;
            }
        }

        public ControllerView()
        {
            mViewList = new Dictionary<string, Control>();
        }

        private string mCurrPage = "";
        private string mPrevPage = "";

        public string PrevPage { get { return mPrevPage; } set { mPrevPage = value; } }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewName"></param>
        /// <returns></returns>
        public Control getView(String viewName)
        {
            Control view = null;

            if (mViewList.ContainsKey(viewName))
                view = mViewList[viewName];

            if (view == null)
            {
                view = FactoryView.createView(viewName);
                mViewList[viewName] = view;
            }

            return view;
        }

        public void changeView(string name)
        {
            loadPage(getView(name), getView("FormMain"));
            mCurrPage = name;
        }

        private void loadPage(Control page, Control parent)
        {
            if (page != null)
            {
                parent.Controls.Clear();
                if (parent != page)
                {
                    parent.Controls.Add(page);
                    //IF PARENT SAMLL NEED TO MAKE AS CHILD...
                    if (parent.Size.Width < page.Size.Width)
                    {
                        parent.Size = page.Size;
                    }
                }
                parent.Refresh();
            }
        }

        private static ControllerView mInstance = null;
        private Dictionary<String, Control> mViewList;
    }
}
