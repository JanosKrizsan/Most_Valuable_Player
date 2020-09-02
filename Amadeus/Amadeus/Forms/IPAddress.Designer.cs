﻿using Amadeus.CustomControls;
using System.ComponentModel;

namespace Amadeus.Forms
{
    partial class IPAddress
    {
        private readonly ComponentResourceManager _res = new ComponentResourceManager(typeof(SysLanguage));

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            staticPnl = new BasePanel();
            dynamicPnl = new BasePanel();
            adapterIpsListBox = new BaseListBox();
            selectedAdapterData = new BaseRichTextBox();
            gatewayTxtBox = new BaseTextBox();
            ipAddTxtBox = new BaseTextBox();
            maskTxtBox = new BaseTextBox();
            dnsTxtBox = new BaseTextBox();
            dnsLbl = new BaseLabel();
            gatewayLbl = new BaseLabel();
            maskLbl = new BaseLabel();
            ipaddressLbl = new BaseLabel();
            staticAddLbl = new BaseLabel();
            currNetAdDataLbl = new BaseLabel();
            DynamicAddLbl = new BaseLabel();
            adapterListLbl = new BaseLabel();
            ipAddressesHlpBtn = new BaseLabel();
            setDynamicIPBtn = new BaseLabel();
            setStaticIPBtn = new BaseLabel();



            SuspendLayout();
            InitIPAddress();

        }

        private void InitIPAddress()
        {
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(616, 522);
            ControlBox = false;
            Controls.Add(ipAddressesHlpBtn);
            Controls.Add(adapterListLbl);
            Controls.Add(adapterIpsListBox);
            Controls.Add(dynamicPnl);
            Controls.Add(staticPnl);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "IPAddress";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "IPAddress";
            staticPnl.ResumeLayout(false);
            staticPnl.PerformLayout();
            dynamicPnl.ResumeLayout(false);
            dynamicPnl.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void InitipAddressesHlpBtn()
        {
            ipAddressesHlpBtn.Location = new System.Drawing.Point(564, 329);
            ipAddressesHlpBtn.Name = "ipAddressesHlpBtn";
            ipAddressesHlpBtn.Size = new System.Drawing.Size(40, 23);
            ipAddressesHlpBtn.TabIndex = 10;
            ipAddressesHlpBtn.Text = "Help!";
            ipAddressesHlpBtn.UseVisualStyleBackColor = true;
        }

        private void InitadapterListLbl()
        {
            adapterListLbl.AutoSize = true;
            adapterListLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            adapterListLbl.Location = new System.Drawing.Point(12, 329);
            adapterListLbl.Name = "adapterListLbl";
            adapterListLbl.Size = new System.Drawing.Size(112, 17);
            adapterListLbl.TabIndex = 9;
            adapterListLbl.Text = "Apaters and IPs:";
        }

        private void InitadapterIpsListBox()
        {
            adapterIpsListBox.BackColor = System.Drawing.SystemColors.MenuText;
            adapterIpsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            adapterIpsListBox.ForeColor = System.Drawing.Color.YellowGreen;
            adapterIpsListBox.FormattingEnabled = true;
            adapterIpsListBox.ItemHeight = 16;
            adapterIpsListBox.Location = new System.Drawing.Point(13, 358);
            adapterIpsListBox.Name = "adapterIpsListBox";
            adapterIpsListBox.Size = new System.Drawing.Size(591, 148);
            adapterIpsListBox.TabIndex = 2;
        }

        private void InitDynamicAddLbl()
        {
            DynamicAddLbl.AutoSize = true;
            DynamicAddLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DynamicAddLbl.Location = new System.Drawing.Point(3, 11);
            DynamicAddLbl.Name = "DynamicAddLbl";
            DynamicAddLbl.Size = new System.Drawing.Size(133, 20);
            DynamicAddLbl.TabIndex = 1;
            DynamicAddLbl.Text = "Dynamic Address";
        }

        private void InitsetDynamicIPBtn()
        {
            setDynamicIPBtn.Location = new System.Drawing.Point(7, 244);
            setDynamicIPBtn.Name = "setDynamicIPBtn";
            setDynamicIPBtn.Size = new System.Drawing.Size(75, 23);
            setDynamicIPBtn.TabIndex = 6;
            setDynamicIPBtn.Text = "Do Magic";
            setDynamicIPBtn.UseVisualStyleBackColor = true;
        }

        private void InitselectedAdapterData()
        {
            selectedAdapterData.BackColor = System.Drawing.SystemColors.MenuText;
            selectedAdapterData.ForeColor = System.Drawing.Color.YellowGreen;
            selectedAdapterData.Location = new System.Drawing.Point(3, 95);
            selectedAdapterData.Name = "selectedAdapterData";
            selectedAdapterData.Size = new System.Drawing.Size(259, 131);
            selectedAdapterData.TabIndex = 7;
            selectedAdapterData.Text = "";
        }

        private void InitcurrNetAdDataLbl()
        {
            currNetAdDataLbl.AutoSize = true;
            currNetAdDataLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            currNetAdDataLbl.Location = new System.Drawing.Point(4, 75);
            currNetAdDataLbl.Name = "currNetAdDataLbl";
            currNetAdDataLbl.Size = new System.Drawing.Size(169, 17);
            currNetAdDataLbl.TabIndex = 8;
            currNetAdDataLbl.Text = "Current NetAdapter Data:";
        }

        private void InitdynamicPnl()
        {
            dynamicPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dynamicPnl.Controls.Add(currNetAdDataLbl);
            dynamicPnl.Controls.Add(selectedAdapterData);
            dynamicPnl.Controls.Add(setDynamicIPBtn);
            dynamicPnl.Controls.Add(DynamicAddLbl);
            dynamicPnl.Location = new System.Drawing.Point(322, 17);
            dynamicPnl.Name = "dynamicPnl";
            dynamicPnl.Size = new System.Drawing.Size(282, 289);
            dynamicPnl.TabIndex = 1;
        }

        private void InitstaticAddLbl()
        {
            staticAddLbl.AutoSize = true;
            staticAddLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            staticAddLbl.Location = new System.Drawing.Point(3, 11);
            staticAddLbl.Name = "staticAddLbl";
            staticAddLbl.Size = new System.Drawing.Size(113, 20);
            staticAddLbl.TabIndex = 0;
            staticAddLbl.Text = "Static Address";
        }

        private void InitipaddressLbl()
        {
            ipaddressLbl.AutoSize = true;
            ipaddressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ipaddressLbl.Location = new System.Drawing.Point(4, 75);
            ipaddressLbl.Name = "ipaddressLbl";
            ipaddressLbl.Size = new System.Drawing.Size(80, 17);
            ipaddressLbl.TabIndex = 1;
            ipaddressLbl.Text = "IP Address:";
        }

        private void InitmaskLbl()
        {
            maskLbl.AutoSize = true;
            maskLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maskLbl.Location = new System.Drawing.Point(155, 75);
            maskLbl.Name = "maskLbl";
            maskLbl.Size = new System.Drawing.Size(45, 17);
            maskLbl.TabIndex = 2;
            maskLbl.Text = "Mask:";
        }

        private void InitgatewayLbl()
        {
            gatewayLbl.AutoSize = true;
            gatewayLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gatewayLbl.Location = new System.Drawing.Point(4, 151);
            gatewayLbl.Name = "gatewayLbl";
            gatewayLbl.Size = new System.Drawing.Size(67, 17);
            gatewayLbl.TabIndex = 3;
            gatewayLbl.Text = "Gateway:";
        }

        private void InitdnsLbl()
        {
            dnsLbl.AutoSize = true;
            dnsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dnsLbl.Location = new System.Drawing.Point(155, 151);
            dnsLbl.Name = "dnsLbl";
            dnsLbl.Size = new System.Drawing.Size(41, 17);
            dnsLbl.TabIndex = 4;
            dnsLbl.Text = "DNS:";
        }

        private void InitsetStaticIPBtn()
        {
            setStaticIPBtn.Location = new System.Drawing.Point(7, 244);
            setStaticIPBtn.Name = "setStaticIPBtn";
            setStaticIPBtn.Size = new System.Drawing.Size(75, 23);
            setStaticIPBtn.TabIndex = 5;
            setStaticIPBtn.Text = "Set Address";
            setStaticIPBtn.UseVisualStyleBackColor = true;
        }

        private void InitdnsTxtBox()
        {
            dnsTxtBox.Location = new System.Drawing.Point(158, 171);
            dnsTxtBox.Name = "dnsTxtBox";
            dnsTxtBox.Size = new System.Drawing.Size(100, 20);
            dnsTxtBox.TabIndex = 6;
        }

        private void InitmaskTxtBox()
        {
            maskTxtBox.Location = new System.Drawing.Point(158, 95);
            maskTxtBox.Name = "maskTxtBox";
            maskTxtBox.Size = new System.Drawing.Size(100, 20);
            maskTxtBox.TabIndex = 7;
        }

        private void InitipAddTxtBox()
        {
            ipAddTxtBox.Location = new System.Drawing.Point(7, 95);
            ipAddTxtBox.Name = "ipAddTxtBox";
            ipAddTxtBox.Size = new System.Drawing.Size(100, 20);
            ipAddTxtBox.TabIndex = 8;
        }

        private void InitgatewayTxtBox()
        {
            gatewayTxtBox.Location = new System.Drawing.Point(7, 171);
            gatewayTxtBox.Name = "gatewayTxtBox";
            gatewayTxtBox.Size = new System.Drawing.Size(100, 20);
            gatewayTxtBox.TabIndex = 9;
        }

        private void InitstaticPnl()
        {
            staticPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            staticPnl.Controls.Add(gatewayTxtBox);
            staticPnl.Controls.Add(ipAddTxtBox);
            staticPnl.Controls.Add(maskTxtBox);
            staticPnl.Controls.Add(dnsTxtBox);
            staticPnl.Controls.Add(setStaticIPBtn);
            staticPnl.Controls.Add(dnsLbl);
            staticPnl.Controls.Add(gatewayLbl);
            staticPnl.Controls.Add(maskLbl);
            staticPnl.Controls.Add(ipaddressLbl);
            staticPnl.Controls.Add(staticAddLbl);
            staticPnl.Location = new System.Drawing.Point(13, 17);
            staticPnl.Name = "staticPnl";
            staticPnl.Size = new System.Drawing.Size(282, 289);
            staticPnl.TabIndex = 0;
        }

        #endregion

        private System.Windows.Forms.Panel staticPnl;
        private System.Windows.Forms.Label staticAddLbl;
        private System.Windows.Forms.Panel dynamicPnl;
        private System.Windows.Forms.Label DynamicAddLbl;
        private System.Windows.Forms.TextBox gatewayTxtBox;
        private System.Windows.Forms.TextBox ipAddTxtBox;
        private System.Windows.Forms.TextBox maskTxtBox;
        private System.Windows.Forms.TextBox dnsTxtBox;
        private System.Windows.Forms.Button setStaticIPBtn;
        private System.Windows.Forms.Label dnsLbl;
        private System.Windows.Forms.Label gatewayLbl;
        private System.Windows.Forms.Label maskLbl;
        private System.Windows.Forms.Label ipaddressLbl;
        private System.Windows.Forms.Button setDynamicIPBtn;
        private System.Windows.Forms.Label currNetAdDataLbl;
        private System.Windows.Forms.RichTextBox selectedAdapterData;
        private System.Windows.Forms.ListBox adapterIpsListBox;
        private System.Windows.Forms.Label adapterListLbl;
        private System.Windows.Forms.Button ipAddressesHlpBtn;
    }
}