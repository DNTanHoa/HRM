namespace HRM.Spa
{
    partial class HRMSpaApplication
    {
        private DevExpress.ExpressApp.SystemModule.SystemModule module1;
        private DevExpress.ExpressApp.Spa.SystemModule.SystemSpaModule module2;
        private HRM.Module.HRMModule module3;
        private HRM.Module.Spa.HRMSpaModule module4;
        private DevExpress.ExpressApp.Validation.ValidationModule validationModule;

        private void InitializeComponent()
        {
            this.module1 = new DevExpress.ExpressApp.SystemModule.SystemModule();
            this.module2 = new DevExpress.ExpressApp.Spa.SystemModule.SystemSpaModule();
            this.module3 = new HRM.Module.HRMModule();
            this.module4 = new HRM.Module.Spa.HRMSpaModule();
            this.validationModule = new DevExpress.ExpressApp.Validation.ValidationModule();

            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();


            // 
            // HRMSpaApplication
            // 
            this.ApplicationName = "HRM";
            this.Modules.Add(this.module1);
            this.Modules.Add(this.module2);
            this.Modules.Add(this.module3);
            this.Modules.Add(this.module4);
            this.Modules.Add(this.validationModule);
            this.DatabaseVersionMismatch += new System.EventHandler<DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs>(this.HRMSpaApplication_DatabaseVersionMismatch);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

    }
}