namespace PreTraining {
    
    #line 30 "C:\Users\DellPladema\Desktop\Nueva carpeta (2)\VFinal\WFFlagCollector\FlagCollector\PreTraining\PreTraining.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\DellPladema\Desktop\Nueva carpeta (2)\VFinal\WFFlagCollector\FlagCollector\PreTraining\PreTraining.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 31 "C:\Users\DellPladema\Desktop\Nueva carpeta (2)\VFinal\WFFlagCollector\FlagCollector\PreTraining\PreTraining.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\DellPladema\Desktop\Nueva carpeta (2)\VFinal\WFFlagCollector\FlagCollector\PreTraining\PreTraining.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\DellPladema\Desktop\Nueva carpeta (2)\VFinal\WFFlagCollector\FlagCollector\PreTraining\PreTraining.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\DellPladema\Desktop\Nueva carpeta (2)\VFinal\WFFlagCollector\FlagCollector\PreTraining\PreTraining.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 32 "C:\Users\DellPladema\Desktop\Nueva carpeta (2)\VFinal\WFFlagCollector\FlagCollector\PreTraining\PreTraining.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 33 "C:\Users\DellPladema\Desktop\Nueva carpeta (2)\VFinal\WFFlagCollector\FlagCollector\PreTraining\PreTraining.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 34 "C:\Users\DellPladema\Desktop\Nueva carpeta (2)\VFinal\WFFlagCollector\FlagCollector\PreTraining\PreTraining.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 35 "C:\Users\DellPladema\Desktop\Nueva carpeta (2)\VFinal\WFFlagCollector\FlagCollector\PreTraining\PreTraining.xaml"
    using System.Drawing;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\DellPladema\Desktop\Nueva carpeta (2)\VFinal\WFFlagCollector\FlagCollector\PreTraining\PreTraining.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class PreTraining : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
        private System.Activities.Activity rootActivity;
        
        private object dataContextActivities;
        
        private bool forImplementation = true;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public string GetLanguage() {
            return "C#";
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((this.dataContextActivities == null)) {
                this.dataContextActivities = PreTraining_TypedDataContext3_ForReadOnly.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PreTraining_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext3_ForReadOnly valDataContext0 = ((PreTraining_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PreTraining_TypedDataContext3(locations, activityContext, true);
                }
                PreTraining_TypedDataContext3 refDataContext1 = ((PreTraining_TypedDataContext3)(cachedCompiledDataContext[1]));
                return refDataContext1.GetLocation<System.Collections.Generic.List<string>>(refDataContext1.ValueType___Expr1Get, refDataContext1.ValueType___Expr1Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PreTraining_TypedDataContext3(locations, activityContext, true);
                }
                PreTraining_TypedDataContext3 refDataContext2 = ((PreTraining_TypedDataContext3)(cachedCompiledDataContext[1]));
                return refDataContext2.GetLocation<int>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PreTraining_TypedDataContext3(locations, activityContext, true);
                }
                PreTraining_TypedDataContext3 refDataContext3 = ((PreTraining_TypedDataContext3)(cachedCompiledDataContext[1]));
                return refDataContext3.GetLocation<int>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PreTraining_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext3_ForReadOnly valDataContext4 = ((PreTraining_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PreTraining_TypedDataContext3(locations, activityContext, true);
                }
                PreTraining_TypedDataContext3 refDataContext5 = ((PreTraining_TypedDataContext3)(cachedCompiledDataContext[1]));
                return refDataContext5.GetLocation<System.Drawing.PointF>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PreTraining_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext3_ForReadOnly valDataContext6 = ((PreTraining_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PreTraining_TypedDataContext3(locations, activityContext, true);
                }
                PreTraining_TypedDataContext3 refDataContext7 = ((PreTraining_TypedDataContext3)(cachedCompiledDataContext[1]));
                return refDataContext7.GetLocation<System.Collections.Generic.List<System.Drawing.PointF>>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PreTraining_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext3_ForReadOnly valDataContext8 = ((PreTraining_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PreTraining_TypedDataContext3(locations, activityContext, true);
                }
                PreTraining_TypedDataContext3 refDataContext9 = ((PreTraining_TypedDataContext3)(cachedCompiledDataContext[1]));
                return refDataContext9.GetLocation<int>(refDataContext9.ValueType___Expr9Get, refDataContext9.ValueType___Expr9Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PreTraining_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext3_ForReadOnly valDataContext10 = ((PreTraining_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PreTraining_TypedDataContext3(locations, activityContext, true);
                }
                PreTraining_TypedDataContext3 refDataContext11 = ((PreTraining_TypedDataContext3)(cachedCompiledDataContext[1]));
                return refDataContext11.GetLocation<System.Collections.Generic.List<int>>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PreTraining_TypedDataContext3(locations, activityContext, true);
                }
                PreTraining_TypedDataContext3 refDataContext12 = ((PreTraining_TypedDataContext3)(cachedCompiledDataContext[1]));
                return refDataContext12.GetLocation<string>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PreTraining_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext3_ForReadOnly valDataContext13 = ((PreTraining_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PreTraining_TypedDataContext3(locations, activityContext, true);
                }
                PreTraining_TypedDataContext3 refDataContext14 = ((PreTraining_TypedDataContext3)(cachedCompiledDataContext[1]));
                return refDataContext14.GetLocation<System.Drawing.PointF>(refDataContext14.ValueType___Expr14Get, refDataContext14.ValueType___Expr14Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 15)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PreTraining_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext3_ForReadOnly valDataContext15 = ((PreTraining_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PreTraining_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext3_ForReadOnly valDataContext16 = ((PreTraining_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new PreTraining_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext4_ForReadOnly valDataContext17 = ((PreTraining_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext17.ValueType___Expr17Get();
            }
            if ((expressionId == 18)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new PreTraining_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext4_ForReadOnly valDataContext18 = ((PreTraining_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext18.ValueType___Expr18Get();
            }
            if ((expressionId == 19)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new PreTraining_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext4_ForReadOnly valDataContext19 = ((PreTraining_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext19.ValueType___Expr19Get();
            }
            if ((expressionId == 20)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new PreTraining_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext4_ForReadOnly valDataContext20 = ((PreTraining_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new PreTraining_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext4_ForReadOnly valDataContext21 = ((PreTraining_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext21.ValueType___Expr21Get();
            }
            if ((expressionId == 22)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new PreTraining_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext4_ForReadOnly valDataContext22 = ((PreTraining_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new PreTraining_TypedDataContext4(locations, activityContext, true);
                }
                PreTraining_TypedDataContext4 refDataContext23 = ((PreTraining_TypedDataContext4)(cachedCompiledDataContext[3]));
                return refDataContext23.GetLocation<string>(refDataContext23.ValueType___Expr23Get, refDataContext23.ValueType___Expr23Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 24)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new PreTraining_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext4_ForReadOnly valDataContext24 = ((PreTraining_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext24.ValueType___Expr24Get();
            }
            if ((expressionId == 25)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new PreTraining_TypedDataContext4(locations, activityContext, true);
                }
                PreTraining_TypedDataContext4 refDataContext25 = ((PreTraining_TypedDataContext4)(cachedCompiledDataContext[3]));
                return refDataContext25.GetLocation<System.Drawing.PointF>(refDataContext25.ValueType___Expr25Get, refDataContext25.ValueType___Expr25Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 26)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new PreTraining_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext4_ForReadOnly valDataContext26 = ((PreTraining_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext26.ValueType___Expr26Get();
            }
            if ((expressionId == 27)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new PreTraining_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext5_ForReadOnly valDataContext27 = ((PreTraining_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext27.ValueType___Expr27Get();
            }
            if ((expressionId == 28)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new PreTraining_TypedDataContext5(locations, activityContext, true);
                }
                PreTraining_TypedDataContext5 refDataContext28 = ((PreTraining_TypedDataContext5)(cachedCompiledDataContext[5]));
                return refDataContext28.GetLocation<System.Random>(refDataContext28.ValueType___Expr28Get, refDataContext28.ValueType___Expr28Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 29)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new PreTraining_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext5_ForReadOnly valDataContext29 = ((PreTraining_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext29.ValueType___Expr29Get();
            }
            if ((expressionId == 30)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new PreTraining_TypedDataContext5(locations, activityContext, true);
                }
                PreTraining_TypedDataContext5 refDataContext30 = ((PreTraining_TypedDataContext5)(cachedCompiledDataContext[5]));
                return refDataContext30.GetLocation<int>(refDataContext30.ValueType___Expr30Get, refDataContext30.ValueType___Expr30Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 31)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new PreTraining_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext5_ForReadOnly valDataContext31 = ((PreTraining_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext31.ValueType___Expr31Get();
            }
            if ((expressionId == 32)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new PreTraining_TypedDataContext5(locations, activityContext, true);
                }
                PreTraining_TypedDataContext5 refDataContext32 = ((PreTraining_TypedDataContext5)(cachedCompiledDataContext[5]));
                return refDataContext32.GetLocation<int>(refDataContext32.ValueType___Expr32Get, refDataContext32.ValueType___Expr32Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 33)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new PreTraining_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext5_ForReadOnly valDataContext33 = ((PreTraining_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext33.ValueType___Expr33Get();
            }
            if ((expressionId == 34)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new PreTraining_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext5_ForReadOnly valDataContext34 = ((PreTraining_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext34.ValueType___Expr34Get();
            }
            if ((expressionId == 35)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new PreTraining_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext4_ForReadOnly valDataContext35 = ((PreTraining_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext35.ValueType___Expr35Get();
            }
            if ((expressionId == 36)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new PreTraining_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext6_ForReadOnly valDataContext36 = ((PreTraining_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext36.ValueType___Expr36Get();
            }
            if ((expressionId == 37)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new PreTraining_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext6_ForReadOnly valDataContext37 = ((PreTraining_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext37.ValueType___Expr37Get();
            }
            if ((expressionId == 38)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new PreTraining_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext6_ForReadOnly valDataContext38 = ((PreTraining_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext38.ValueType___Expr38Get();
            }
            if ((expressionId == 39)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new PreTraining_TypedDataContext6(locations, activityContext, true);
                }
                PreTraining_TypedDataContext6 refDataContext39 = ((PreTraining_TypedDataContext6)(cachedCompiledDataContext[7]));
                return refDataContext39.GetLocation<string>(refDataContext39.ValueType___Expr39Get, refDataContext39.ValueType___Expr39Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 40)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new PreTraining_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext6_ForReadOnly valDataContext40 = ((PreTraining_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext40.ValueType___Expr40Get();
            }
            if ((expressionId == 41)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new PreTraining_TypedDataContext6(locations, activityContext, true);
                }
                PreTraining_TypedDataContext6 refDataContext41 = ((PreTraining_TypedDataContext6)(cachedCompiledDataContext[7]));
                return refDataContext41.GetLocation<System.Drawing.PointF>(refDataContext41.ValueType___Expr41Get, refDataContext41.ValueType___Expr41Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 42)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new PreTraining_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext6_ForReadOnly valDataContext42 = ((PreTraining_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext42.ValueType___Expr42Get();
            }
            if ((expressionId == 43)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new PreTraining_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext6_ForReadOnly valDataContext43 = ((PreTraining_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext43.ValueType___Expr43Get();
            }
            if ((expressionId == 44)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new PreTraining_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext6_ForReadOnly valDataContext44 = ((PreTraining_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext44.ValueType___Expr44Get();
            }
            if ((expressionId == 45)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new PreTraining_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext6_ForReadOnly valDataContext45 = ((PreTraining_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext45.ValueType___Expr45Get();
            }
            if ((expressionId == 46)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new PreTraining_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext6_ForReadOnly valDataContext46 = ((PreTraining_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext46.ValueType___Expr46Get();
            }
            if ((expressionId == 47)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new PreTraining_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext6_ForReadOnly valDataContext47 = ((PreTraining_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext47.ValueType___Expr47Get();
            }
            if ((expressionId == 48)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new PreTraining_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext7_ForReadOnly valDataContext48 = ((PreTraining_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext48.ValueType___Expr48Get();
            }
            if ((expressionId == 49)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new PreTraining_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext7_ForReadOnly valDataContext49 = ((PreTraining_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext49.ValueType___Expr49Get();
            }
            if ((expressionId == 50)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new PreTraining_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext7_ForReadOnly valDataContext50 = ((PreTraining_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext50.ValueType___Expr50Get();
            }
            if ((expressionId == 51)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new PreTraining_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext7_ForReadOnly valDataContext51 = ((PreTraining_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext51.ValueType___Expr51Get();
            }
            if ((expressionId == 52)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new PreTraining_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext7_ForReadOnly valDataContext52 = ((PreTraining_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext52.ValueType___Expr52Get();
            }
            if ((expressionId == 53)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new PreTraining_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext8_ForReadOnly valDataContext53 = ((PreTraining_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext53.ValueType___Expr53Get();
            }
            if ((expressionId == 54)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new PreTraining_TypedDataContext8(locations, activityContext, true);
                }
                PreTraining_TypedDataContext8 refDataContext54 = ((PreTraining_TypedDataContext8)(cachedCompiledDataContext[10]));
                return refDataContext54.GetLocation<string>(refDataContext54.ValueType___Expr54Get, refDataContext54.ValueType___Expr54Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 55)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new PreTraining_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext8_ForReadOnly valDataContext55 = ((PreTraining_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext55.ValueType___Expr55Get();
            }
            if ((expressionId == 56)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new PreTraining_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext8_ForReadOnly valDataContext56 = ((PreTraining_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext56.ValueType___Expr56Get();
            }
            if ((expressionId == 57)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new PreTraining_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext8_ForReadOnly valDataContext57 = ((PreTraining_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext57.ValueType___Expr57Get();
            }
            if ((expressionId == 58)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new PreTraining_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext8_ForReadOnly valDataContext58 = ((PreTraining_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext58.ValueType___Expr58Get();
            }
            if ((expressionId == 59)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new PreTraining_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext8_ForReadOnly valDataContext59 = ((PreTraining_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext59.ValueType___Expr59Get();
            }
            if ((expressionId == 60)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new PreTraining_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext8_ForReadOnly valDataContext60 = ((PreTraining_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext60.ValueType___Expr60Get();
            }
            if ((expressionId == 61)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new PreTraining_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext8_ForReadOnly valDataContext61 = ((PreTraining_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext61.ValueType___Expr61Get();
            }
            if ((expressionId == 62)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new PreTraining_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext9_ForReadOnly valDataContext62 = ((PreTraining_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext62.ValueType___Expr62Get();
            }
            if ((expressionId == 63)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new PreTraining_TypedDataContext9(locations, activityContext, true);
                }
                PreTraining_TypedDataContext9 refDataContext63 = ((PreTraining_TypedDataContext9)(cachedCompiledDataContext[12]));
                return refDataContext63.GetLocation<System.Random>(refDataContext63.ValueType___Expr63Get, refDataContext63.ValueType___Expr63Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 64)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new PreTraining_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext9_ForReadOnly valDataContext64 = ((PreTraining_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext64.ValueType___Expr64Get();
            }
            if ((expressionId == 65)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new PreTraining_TypedDataContext9(locations, activityContext, true);
                }
                PreTraining_TypedDataContext9 refDataContext65 = ((PreTraining_TypedDataContext9)(cachedCompiledDataContext[12]));
                return refDataContext65.GetLocation<System.Random>(refDataContext65.ValueType___Expr65Get, refDataContext65.ValueType___Expr65Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 66)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new PreTraining_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext9_ForReadOnly valDataContext66 = ((PreTraining_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext66.ValueType___Expr66Get();
            }
            if ((expressionId == 67)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new PreTraining_TypedDataContext9(locations, activityContext, true);
                }
                PreTraining_TypedDataContext9 refDataContext67 = ((PreTraining_TypedDataContext9)(cachedCompiledDataContext[12]));
                return refDataContext67.GetLocation<int>(refDataContext67.ValueType___Expr67Get, refDataContext67.ValueType___Expr67Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 68)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new PreTraining_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext9_ForReadOnly valDataContext68 = ((PreTraining_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext68.ValueType___Expr68Get();
            }
            if ((expressionId == 69)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new PreTraining_TypedDataContext9(locations, activityContext, true);
                }
                PreTraining_TypedDataContext9 refDataContext69 = ((PreTraining_TypedDataContext9)(cachedCompiledDataContext[12]));
                return refDataContext69.GetLocation<int>(refDataContext69.ValueType___Expr69Get, refDataContext69.ValueType___Expr69Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 70)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new PreTraining_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext9_ForReadOnly valDataContext70 = ((PreTraining_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext70.ValueType___Expr70Get();
            }
            if ((expressionId == 71)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new PreTraining_TypedDataContext9(locations, activityContext, true);
                }
                PreTraining_TypedDataContext9 refDataContext71 = ((PreTraining_TypedDataContext9)(cachedCompiledDataContext[12]));
                return refDataContext71.GetLocation<int>(refDataContext71.ValueType___Expr71Get, refDataContext71.ValueType___Expr71Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 72)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new PreTraining_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext9_ForReadOnly valDataContext72 = ((PreTraining_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext72.ValueType___Expr72Get();
            }
            if ((expressionId == 73)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new PreTraining_TypedDataContext9(locations, activityContext, true);
                }
                PreTraining_TypedDataContext9 refDataContext73 = ((PreTraining_TypedDataContext9)(cachedCompiledDataContext[12]));
                return refDataContext73.GetLocation<int>(refDataContext73.ValueType___Expr73Get, refDataContext73.ValueType___Expr73Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 74)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new PreTraining_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext9_ForReadOnly valDataContext74 = ((PreTraining_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext74.ValueType___Expr74Get();
            }
            if ((expressionId == 75)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new PreTraining_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext9_ForReadOnly valDataContext75 = ((PreTraining_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext75.ValueType___Expr75Get();
            }
            if ((expressionId == 76)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new PreTraining_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext9_ForReadOnly valDataContext76 = ((PreTraining_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext76.ValueType___Expr76Get();
            }
            if ((expressionId == 77)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new PreTraining_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext9_ForReadOnly valDataContext77 = ((PreTraining_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext77.ValueType___Expr77Get();
            }
            if ((expressionId == 78)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new PreTraining_TypedDataContext9(locations, activityContext, true);
                }
                PreTraining_TypedDataContext9 refDataContext78 = ((PreTraining_TypedDataContext9)(cachedCompiledDataContext[12]));
                return refDataContext78.GetLocation<float>(refDataContext78.ValueType___Expr78Get, refDataContext78.ValueType___Expr78Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 79)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new PreTraining_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext9_ForReadOnly valDataContext79 = ((PreTraining_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext79.ValueType___Expr79Get();
            }
            if ((expressionId == 80)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new PreTraining_TypedDataContext9(locations, activityContext, true);
                }
                PreTraining_TypedDataContext9 refDataContext80 = ((PreTraining_TypedDataContext9)(cachedCompiledDataContext[12]));
                return refDataContext80.GetLocation<float>(refDataContext80.ValueType___Expr80Get, refDataContext80.ValueType___Expr80Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 81)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new PreTraining_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext8_ForReadOnly valDataContext81 = ((PreTraining_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext81.ValueType___Expr81Get();
            }
            if ((expressionId == 82)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new PreTraining_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext8_ForReadOnly valDataContext82 = ((PreTraining_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext82.ValueType___Expr82Get();
            }
            if ((expressionId == 83)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new PreTraining_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext8_ForReadOnly valDataContext83 = ((PreTraining_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext83.ValueType___Expr83Get();
            }
            if ((expressionId == 84)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new PreTraining_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext8_ForReadOnly valDataContext84 = ((PreTraining_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext84.ValueType___Expr84Get();
            }
            if ((expressionId == 85)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new PreTraining_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext8_ForReadOnly valDataContext85 = ((PreTraining_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext85.ValueType___Expr85Get();
            }
            if ((expressionId == 86)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new PreTraining_TypedDataContext8(locations, activityContext, true);
                }
                PreTraining_TypedDataContext8 refDataContext86 = ((PreTraining_TypedDataContext8)(cachedCompiledDataContext[10]));
                return refDataContext86.GetLocation<int>(refDataContext86.ValueType___Expr86Get, refDataContext86.ValueType___Expr86Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 87)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new PreTraining_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext8_ForReadOnly valDataContext87 = ((PreTraining_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext87.ValueType___Expr87Get();
            }
            if ((expressionId == 88)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new PreTraining_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext8_ForReadOnly valDataContext88 = ((PreTraining_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext88.ValueType___Expr88Get();
            }
            if ((expressionId == 89)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new PreTraining_TypedDataContext8(locations, activityContext, true);
                }
                PreTraining_TypedDataContext8 refDataContext89 = ((PreTraining_TypedDataContext8)(cachedCompiledDataContext[10]));
                return refDataContext89.GetLocation<int>(refDataContext89.ValueType___Expr89Get, refDataContext89.ValueType___Expr89Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 90)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new PreTraining_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext8_ForReadOnly valDataContext90 = ((PreTraining_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext90.ValueType___Expr90Get();
            }
            if ((expressionId == 91)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new PreTraining_TypedDataContext8(locations, activityContext, true);
                }
                PreTraining_TypedDataContext8 refDataContext91 = ((PreTraining_TypedDataContext8)(cachedCompiledDataContext[10]));
                return refDataContext91.GetLocation<int>(refDataContext91.ValueType___Expr91Get, refDataContext91.ValueType___Expr91Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 92)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext11.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new PreTraining_TypedDataContext11(locations, activityContext, true);
                }
                PreTraining_TypedDataContext11 refDataContext92 = ((PreTraining_TypedDataContext11)(cachedCompiledDataContext[13]));
                return refDataContext92.GetLocation<string>(refDataContext92.ValueType___Expr92Get, refDataContext92.ValueType___Expr92Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 93)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext11_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[14] == null)) {
                    cachedCompiledDataContext[14] = new PreTraining_TypedDataContext11_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext11_ForReadOnly valDataContext93 = ((PreTraining_TypedDataContext11_ForReadOnly)(cachedCompiledDataContext[14]));
                return valDataContext93.ValueType___Expr93Get();
            }
            if ((expressionId == 94)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext11_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[14] == null)) {
                    cachedCompiledDataContext[14] = new PreTraining_TypedDataContext11_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext11_ForReadOnly valDataContext94 = ((PreTraining_TypedDataContext11_ForReadOnly)(cachedCompiledDataContext[14]));
                return valDataContext94.ValueType___Expr94Get();
            }
            if ((expressionId == 95)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext11_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[14] == null)) {
                    cachedCompiledDataContext[14] = new PreTraining_TypedDataContext11_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext11_ForReadOnly valDataContext95 = ((PreTraining_TypedDataContext11_ForReadOnly)(cachedCompiledDataContext[14]));
                return valDataContext95.ValueType___Expr95Get();
            }
            if ((expressionId == 96)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext11_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[14] == null)) {
                    cachedCompiledDataContext[14] = new PreTraining_TypedDataContext11_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext11_ForReadOnly valDataContext96 = ((PreTraining_TypedDataContext11_ForReadOnly)(cachedCompiledDataContext[14]));
                return valDataContext96.ValueType___Expr96Get();
            }
            if ((expressionId == 97)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[15] == null)) {
                    cachedCompiledDataContext[15] = new PreTraining_TypedDataContext12_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext12_ForReadOnly valDataContext97 = ((PreTraining_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[15]));
                return valDataContext97.ValueType___Expr97Get();
            }
            if ((expressionId == 98)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[15] == null)) {
                    cachedCompiledDataContext[15] = new PreTraining_TypedDataContext12_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext12_ForReadOnly valDataContext98 = ((PreTraining_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[15]));
                return valDataContext98.ValueType___Expr98Get();
            }
            if ((expressionId == 99)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[15] == null)) {
                    cachedCompiledDataContext[15] = new PreTraining_TypedDataContext12_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext12_ForReadOnly valDataContext99 = ((PreTraining_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[15]));
                return valDataContext99.ValueType___Expr99Get();
            }
            if ((expressionId == 100)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new PreTraining_TypedDataContext12(locations, activityContext, true);
                }
                PreTraining_TypedDataContext12 refDataContext100 = ((PreTraining_TypedDataContext12)(cachedCompiledDataContext[16]));
                return refDataContext100.GetLocation<string>(refDataContext100.ValueType___Expr100Get, refDataContext100.ValueType___Expr100Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 101)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[15] == null)) {
                    cachedCompiledDataContext[15] = new PreTraining_TypedDataContext12_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext12_ForReadOnly valDataContext101 = ((PreTraining_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[15]));
                return valDataContext101.ValueType___Expr101Get();
            }
            if ((expressionId == 102)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new PreTraining_TypedDataContext12(locations, activityContext, true);
                }
                PreTraining_TypedDataContext12 refDataContext102 = ((PreTraining_TypedDataContext12)(cachedCompiledDataContext[16]));
                return refDataContext102.GetLocation<System.Drawing.PointF>(refDataContext102.ValueType___Expr102Get, refDataContext102.ValueType___Expr102Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 103)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[15] == null)) {
                    cachedCompiledDataContext[15] = new PreTraining_TypedDataContext12_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext12_ForReadOnly valDataContext103 = ((PreTraining_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[15]));
                return valDataContext103.ValueType___Expr103Get();
            }
            if ((expressionId == 104)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new PreTraining_TypedDataContext12(locations, activityContext, true);
                }
                PreTraining_TypedDataContext12 refDataContext104 = ((PreTraining_TypedDataContext12)(cachedCompiledDataContext[16]));
                return refDataContext104.GetLocation<int>(refDataContext104.ValueType___Expr104Get, refDataContext104.ValueType___Expr104Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 105)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[15] == null)) {
                    cachedCompiledDataContext[15] = new PreTraining_TypedDataContext12_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext12_ForReadOnly valDataContext105 = ((PreTraining_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[15]));
                return valDataContext105.ValueType___Expr105Get();
            }
            if ((expressionId == 106)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[15] == null)) {
                    cachedCompiledDataContext[15] = new PreTraining_TypedDataContext12_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext12_ForReadOnly valDataContext106 = ((PreTraining_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[15]));
                return valDataContext106.ValueType___Expr106Get();
            }
            if ((expressionId == 107)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[15] == null)) {
                    cachedCompiledDataContext[15] = new PreTraining_TypedDataContext12_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext12_ForReadOnly valDataContext107 = ((PreTraining_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[15]));
                return valDataContext107.ValueType___Expr107Get();
            }
            if ((expressionId == 108)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext13_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[17] == null)) {
                    cachedCompiledDataContext[17] = new PreTraining_TypedDataContext13_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext13_ForReadOnly valDataContext108 = ((PreTraining_TypedDataContext13_ForReadOnly)(cachedCompiledDataContext[17]));
                return valDataContext108.ValueType___Expr108Get();
            }
            if ((expressionId == 109)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext13_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[17] == null)) {
                    cachedCompiledDataContext[17] = new PreTraining_TypedDataContext13_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext13_ForReadOnly valDataContext109 = ((PreTraining_TypedDataContext13_ForReadOnly)(cachedCompiledDataContext[17]));
                return valDataContext109.ValueType___Expr109Get();
            }
            if ((expressionId == 110)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext13_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[17] == null)) {
                    cachedCompiledDataContext[17] = new PreTraining_TypedDataContext13_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext13_ForReadOnly valDataContext110 = ((PreTraining_TypedDataContext13_ForReadOnly)(cachedCompiledDataContext[17]));
                return valDataContext110.ValueType___Expr110Get();
            }
            if ((expressionId == 111)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext13.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[18] == null)) {
                    cachedCompiledDataContext[18] = new PreTraining_TypedDataContext13(locations, activityContext, true);
                }
                PreTraining_TypedDataContext13 refDataContext111 = ((PreTraining_TypedDataContext13)(cachedCompiledDataContext[18]));
                return refDataContext111.GetLocation<string>(refDataContext111.ValueType___Expr111Get, refDataContext111.ValueType___Expr111Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 112)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext13_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[17] == null)) {
                    cachedCompiledDataContext[17] = new PreTraining_TypedDataContext13_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext13_ForReadOnly valDataContext112 = ((PreTraining_TypedDataContext13_ForReadOnly)(cachedCompiledDataContext[17]));
                return valDataContext112.ValueType___Expr112Get();
            }
            if ((expressionId == 113)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext13.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[18] == null)) {
                    cachedCompiledDataContext[18] = new PreTraining_TypedDataContext13(locations, activityContext, true);
                }
                PreTraining_TypedDataContext13 refDataContext113 = ((PreTraining_TypedDataContext13)(cachedCompiledDataContext[18]));
                return refDataContext113.GetLocation<System.Drawing.PointF>(refDataContext113.ValueType___Expr113Get, refDataContext113.ValueType___Expr113Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 114)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext13_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[17] == null)) {
                    cachedCompiledDataContext[17] = new PreTraining_TypedDataContext13_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext13_ForReadOnly valDataContext114 = ((PreTraining_TypedDataContext13_ForReadOnly)(cachedCompiledDataContext[17]));
                return valDataContext114.ValueType___Expr114Get();
            }
            if ((expressionId == 115)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext13_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 19);
                if ((cachedCompiledDataContext[17] == null)) {
                    cachedCompiledDataContext[17] = new PreTraining_TypedDataContext13_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext13_ForReadOnly valDataContext115 = ((PreTraining_TypedDataContext13_ForReadOnly)(cachedCompiledDataContext[17]));
                return valDataContext115.ValueType___Expr115Get();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.Location> locations) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((expressionId == 0)) {
                PreTraining_TypedDataContext3_ForReadOnly valDataContext0 = new PreTraining_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                PreTraining_TypedDataContext3 refDataContext1 = new PreTraining_TypedDataContext3(locations, true);
                return refDataContext1.GetLocation<System.Collections.Generic.List<string>>(refDataContext1.ValueType___Expr1Get, refDataContext1.ValueType___Expr1Set);
            }
            if ((expressionId == 2)) {
                PreTraining_TypedDataContext3 refDataContext2 = new PreTraining_TypedDataContext3(locations, true);
                return refDataContext2.GetLocation<int>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set);
            }
            if ((expressionId == 3)) {
                PreTraining_TypedDataContext3 refDataContext3 = new PreTraining_TypedDataContext3(locations, true);
                return refDataContext3.GetLocation<int>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set);
            }
            if ((expressionId == 4)) {
                PreTraining_TypedDataContext3_ForReadOnly valDataContext4 = new PreTraining_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                PreTraining_TypedDataContext3 refDataContext5 = new PreTraining_TypedDataContext3(locations, true);
                return refDataContext5.GetLocation<System.Drawing.PointF>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set);
            }
            if ((expressionId == 6)) {
                PreTraining_TypedDataContext3_ForReadOnly valDataContext6 = new PreTraining_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                PreTraining_TypedDataContext3 refDataContext7 = new PreTraining_TypedDataContext3(locations, true);
                return refDataContext7.GetLocation<System.Collections.Generic.List<System.Drawing.PointF>>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set);
            }
            if ((expressionId == 8)) {
                PreTraining_TypedDataContext3_ForReadOnly valDataContext8 = new PreTraining_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                PreTraining_TypedDataContext3 refDataContext9 = new PreTraining_TypedDataContext3(locations, true);
                return refDataContext9.GetLocation<int>(refDataContext9.ValueType___Expr9Get, refDataContext9.ValueType___Expr9Set);
            }
            if ((expressionId == 10)) {
                PreTraining_TypedDataContext3_ForReadOnly valDataContext10 = new PreTraining_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                PreTraining_TypedDataContext3 refDataContext11 = new PreTraining_TypedDataContext3(locations, true);
                return refDataContext11.GetLocation<System.Collections.Generic.List<int>>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set);
            }
            if ((expressionId == 12)) {
                PreTraining_TypedDataContext3 refDataContext12 = new PreTraining_TypedDataContext3(locations, true);
                return refDataContext12.GetLocation<string>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set);
            }
            if ((expressionId == 13)) {
                PreTraining_TypedDataContext3_ForReadOnly valDataContext13 = new PreTraining_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                PreTraining_TypedDataContext3 refDataContext14 = new PreTraining_TypedDataContext3(locations, true);
                return refDataContext14.GetLocation<System.Drawing.PointF>(refDataContext14.ValueType___Expr14Get, refDataContext14.ValueType___Expr14Set);
            }
            if ((expressionId == 15)) {
                PreTraining_TypedDataContext3_ForReadOnly valDataContext15 = new PreTraining_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                PreTraining_TypedDataContext3_ForReadOnly valDataContext16 = new PreTraining_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                PreTraining_TypedDataContext4_ForReadOnly valDataContext17 = new PreTraining_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext17.ValueType___Expr17Get();
            }
            if ((expressionId == 18)) {
                PreTraining_TypedDataContext4_ForReadOnly valDataContext18 = new PreTraining_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext18.ValueType___Expr18Get();
            }
            if ((expressionId == 19)) {
                PreTraining_TypedDataContext4_ForReadOnly valDataContext19 = new PreTraining_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext19.ValueType___Expr19Get();
            }
            if ((expressionId == 20)) {
                PreTraining_TypedDataContext4_ForReadOnly valDataContext20 = new PreTraining_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                PreTraining_TypedDataContext4_ForReadOnly valDataContext21 = new PreTraining_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext21.ValueType___Expr21Get();
            }
            if ((expressionId == 22)) {
                PreTraining_TypedDataContext4_ForReadOnly valDataContext22 = new PreTraining_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                PreTraining_TypedDataContext4 refDataContext23 = new PreTraining_TypedDataContext4(locations, true);
                return refDataContext23.GetLocation<string>(refDataContext23.ValueType___Expr23Get, refDataContext23.ValueType___Expr23Set);
            }
            if ((expressionId == 24)) {
                PreTraining_TypedDataContext4_ForReadOnly valDataContext24 = new PreTraining_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext24.ValueType___Expr24Get();
            }
            if ((expressionId == 25)) {
                PreTraining_TypedDataContext4 refDataContext25 = new PreTraining_TypedDataContext4(locations, true);
                return refDataContext25.GetLocation<System.Drawing.PointF>(refDataContext25.ValueType___Expr25Get, refDataContext25.ValueType___Expr25Set);
            }
            if ((expressionId == 26)) {
                PreTraining_TypedDataContext4_ForReadOnly valDataContext26 = new PreTraining_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext26.ValueType___Expr26Get();
            }
            if ((expressionId == 27)) {
                PreTraining_TypedDataContext5_ForReadOnly valDataContext27 = new PreTraining_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext27.ValueType___Expr27Get();
            }
            if ((expressionId == 28)) {
                PreTraining_TypedDataContext5 refDataContext28 = new PreTraining_TypedDataContext5(locations, true);
                return refDataContext28.GetLocation<System.Random>(refDataContext28.ValueType___Expr28Get, refDataContext28.ValueType___Expr28Set);
            }
            if ((expressionId == 29)) {
                PreTraining_TypedDataContext5_ForReadOnly valDataContext29 = new PreTraining_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext29.ValueType___Expr29Get();
            }
            if ((expressionId == 30)) {
                PreTraining_TypedDataContext5 refDataContext30 = new PreTraining_TypedDataContext5(locations, true);
                return refDataContext30.GetLocation<int>(refDataContext30.ValueType___Expr30Get, refDataContext30.ValueType___Expr30Set);
            }
            if ((expressionId == 31)) {
                PreTraining_TypedDataContext5_ForReadOnly valDataContext31 = new PreTraining_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext31.ValueType___Expr31Get();
            }
            if ((expressionId == 32)) {
                PreTraining_TypedDataContext5 refDataContext32 = new PreTraining_TypedDataContext5(locations, true);
                return refDataContext32.GetLocation<int>(refDataContext32.ValueType___Expr32Get, refDataContext32.ValueType___Expr32Set);
            }
            if ((expressionId == 33)) {
                PreTraining_TypedDataContext5_ForReadOnly valDataContext33 = new PreTraining_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext33.ValueType___Expr33Get();
            }
            if ((expressionId == 34)) {
                PreTraining_TypedDataContext5_ForReadOnly valDataContext34 = new PreTraining_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext34.ValueType___Expr34Get();
            }
            if ((expressionId == 35)) {
                PreTraining_TypedDataContext4_ForReadOnly valDataContext35 = new PreTraining_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext35.ValueType___Expr35Get();
            }
            if ((expressionId == 36)) {
                PreTraining_TypedDataContext6_ForReadOnly valDataContext36 = new PreTraining_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext36.ValueType___Expr36Get();
            }
            if ((expressionId == 37)) {
                PreTraining_TypedDataContext6_ForReadOnly valDataContext37 = new PreTraining_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext37.ValueType___Expr37Get();
            }
            if ((expressionId == 38)) {
                PreTraining_TypedDataContext6_ForReadOnly valDataContext38 = new PreTraining_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext38.ValueType___Expr38Get();
            }
            if ((expressionId == 39)) {
                PreTraining_TypedDataContext6 refDataContext39 = new PreTraining_TypedDataContext6(locations, true);
                return refDataContext39.GetLocation<string>(refDataContext39.ValueType___Expr39Get, refDataContext39.ValueType___Expr39Set);
            }
            if ((expressionId == 40)) {
                PreTraining_TypedDataContext6_ForReadOnly valDataContext40 = new PreTraining_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext40.ValueType___Expr40Get();
            }
            if ((expressionId == 41)) {
                PreTraining_TypedDataContext6 refDataContext41 = new PreTraining_TypedDataContext6(locations, true);
                return refDataContext41.GetLocation<System.Drawing.PointF>(refDataContext41.ValueType___Expr41Get, refDataContext41.ValueType___Expr41Set);
            }
            if ((expressionId == 42)) {
                PreTraining_TypedDataContext6_ForReadOnly valDataContext42 = new PreTraining_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext42.ValueType___Expr42Get();
            }
            if ((expressionId == 43)) {
                PreTraining_TypedDataContext6_ForReadOnly valDataContext43 = new PreTraining_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext43.ValueType___Expr43Get();
            }
            if ((expressionId == 44)) {
                PreTraining_TypedDataContext6_ForReadOnly valDataContext44 = new PreTraining_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext44.ValueType___Expr44Get();
            }
            if ((expressionId == 45)) {
                PreTraining_TypedDataContext6_ForReadOnly valDataContext45 = new PreTraining_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext45.ValueType___Expr45Get();
            }
            if ((expressionId == 46)) {
                PreTraining_TypedDataContext6_ForReadOnly valDataContext46 = new PreTraining_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext46.ValueType___Expr46Get();
            }
            if ((expressionId == 47)) {
                PreTraining_TypedDataContext6_ForReadOnly valDataContext47 = new PreTraining_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext47.ValueType___Expr47Get();
            }
            if ((expressionId == 48)) {
                PreTraining_TypedDataContext7_ForReadOnly valDataContext48 = new PreTraining_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext48.ValueType___Expr48Get();
            }
            if ((expressionId == 49)) {
                PreTraining_TypedDataContext7_ForReadOnly valDataContext49 = new PreTraining_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext49.ValueType___Expr49Get();
            }
            if ((expressionId == 50)) {
                PreTraining_TypedDataContext7_ForReadOnly valDataContext50 = new PreTraining_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext50.ValueType___Expr50Get();
            }
            if ((expressionId == 51)) {
                PreTraining_TypedDataContext7_ForReadOnly valDataContext51 = new PreTraining_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext51.ValueType___Expr51Get();
            }
            if ((expressionId == 52)) {
                PreTraining_TypedDataContext7_ForReadOnly valDataContext52 = new PreTraining_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext52.ValueType___Expr52Get();
            }
            if ((expressionId == 53)) {
                PreTraining_TypedDataContext8_ForReadOnly valDataContext53 = new PreTraining_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext53.ValueType___Expr53Get();
            }
            if ((expressionId == 54)) {
                PreTraining_TypedDataContext8 refDataContext54 = new PreTraining_TypedDataContext8(locations, true);
                return refDataContext54.GetLocation<string>(refDataContext54.ValueType___Expr54Get, refDataContext54.ValueType___Expr54Set);
            }
            if ((expressionId == 55)) {
                PreTraining_TypedDataContext8_ForReadOnly valDataContext55 = new PreTraining_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext55.ValueType___Expr55Get();
            }
            if ((expressionId == 56)) {
                PreTraining_TypedDataContext8_ForReadOnly valDataContext56 = new PreTraining_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext56.ValueType___Expr56Get();
            }
            if ((expressionId == 57)) {
                PreTraining_TypedDataContext8_ForReadOnly valDataContext57 = new PreTraining_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext57.ValueType___Expr57Get();
            }
            if ((expressionId == 58)) {
                PreTraining_TypedDataContext8_ForReadOnly valDataContext58 = new PreTraining_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext58.ValueType___Expr58Get();
            }
            if ((expressionId == 59)) {
                PreTraining_TypedDataContext8_ForReadOnly valDataContext59 = new PreTraining_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext59.ValueType___Expr59Get();
            }
            if ((expressionId == 60)) {
                PreTraining_TypedDataContext8_ForReadOnly valDataContext60 = new PreTraining_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext60.ValueType___Expr60Get();
            }
            if ((expressionId == 61)) {
                PreTraining_TypedDataContext8_ForReadOnly valDataContext61 = new PreTraining_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext61.ValueType___Expr61Get();
            }
            if ((expressionId == 62)) {
                PreTraining_TypedDataContext9_ForReadOnly valDataContext62 = new PreTraining_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext62.ValueType___Expr62Get();
            }
            if ((expressionId == 63)) {
                PreTraining_TypedDataContext9 refDataContext63 = new PreTraining_TypedDataContext9(locations, true);
                return refDataContext63.GetLocation<System.Random>(refDataContext63.ValueType___Expr63Get, refDataContext63.ValueType___Expr63Set);
            }
            if ((expressionId == 64)) {
                PreTraining_TypedDataContext9_ForReadOnly valDataContext64 = new PreTraining_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext64.ValueType___Expr64Get();
            }
            if ((expressionId == 65)) {
                PreTraining_TypedDataContext9 refDataContext65 = new PreTraining_TypedDataContext9(locations, true);
                return refDataContext65.GetLocation<System.Random>(refDataContext65.ValueType___Expr65Get, refDataContext65.ValueType___Expr65Set);
            }
            if ((expressionId == 66)) {
                PreTraining_TypedDataContext9_ForReadOnly valDataContext66 = new PreTraining_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext66.ValueType___Expr66Get();
            }
            if ((expressionId == 67)) {
                PreTraining_TypedDataContext9 refDataContext67 = new PreTraining_TypedDataContext9(locations, true);
                return refDataContext67.GetLocation<int>(refDataContext67.ValueType___Expr67Get, refDataContext67.ValueType___Expr67Set);
            }
            if ((expressionId == 68)) {
                PreTraining_TypedDataContext9_ForReadOnly valDataContext68 = new PreTraining_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext68.ValueType___Expr68Get();
            }
            if ((expressionId == 69)) {
                PreTraining_TypedDataContext9 refDataContext69 = new PreTraining_TypedDataContext9(locations, true);
                return refDataContext69.GetLocation<int>(refDataContext69.ValueType___Expr69Get, refDataContext69.ValueType___Expr69Set);
            }
            if ((expressionId == 70)) {
                PreTraining_TypedDataContext9_ForReadOnly valDataContext70 = new PreTraining_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext70.ValueType___Expr70Get();
            }
            if ((expressionId == 71)) {
                PreTraining_TypedDataContext9 refDataContext71 = new PreTraining_TypedDataContext9(locations, true);
                return refDataContext71.GetLocation<int>(refDataContext71.ValueType___Expr71Get, refDataContext71.ValueType___Expr71Set);
            }
            if ((expressionId == 72)) {
                PreTraining_TypedDataContext9_ForReadOnly valDataContext72 = new PreTraining_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext72.ValueType___Expr72Get();
            }
            if ((expressionId == 73)) {
                PreTraining_TypedDataContext9 refDataContext73 = new PreTraining_TypedDataContext9(locations, true);
                return refDataContext73.GetLocation<int>(refDataContext73.ValueType___Expr73Get, refDataContext73.ValueType___Expr73Set);
            }
            if ((expressionId == 74)) {
                PreTraining_TypedDataContext9_ForReadOnly valDataContext74 = new PreTraining_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext74.ValueType___Expr74Get();
            }
            if ((expressionId == 75)) {
                PreTraining_TypedDataContext9_ForReadOnly valDataContext75 = new PreTraining_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext75.ValueType___Expr75Get();
            }
            if ((expressionId == 76)) {
                PreTraining_TypedDataContext9_ForReadOnly valDataContext76 = new PreTraining_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext76.ValueType___Expr76Get();
            }
            if ((expressionId == 77)) {
                PreTraining_TypedDataContext9_ForReadOnly valDataContext77 = new PreTraining_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext77.ValueType___Expr77Get();
            }
            if ((expressionId == 78)) {
                PreTraining_TypedDataContext9 refDataContext78 = new PreTraining_TypedDataContext9(locations, true);
                return refDataContext78.GetLocation<float>(refDataContext78.ValueType___Expr78Get, refDataContext78.ValueType___Expr78Set);
            }
            if ((expressionId == 79)) {
                PreTraining_TypedDataContext9_ForReadOnly valDataContext79 = new PreTraining_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext79.ValueType___Expr79Get();
            }
            if ((expressionId == 80)) {
                PreTraining_TypedDataContext9 refDataContext80 = new PreTraining_TypedDataContext9(locations, true);
                return refDataContext80.GetLocation<float>(refDataContext80.ValueType___Expr80Get, refDataContext80.ValueType___Expr80Set);
            }
            if ((expressionId == 81)) {
                PreTraining_TypedDataContext8_ForReadOnly valDataContext81 = new PreTraining_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext81.ValueType___Expr81Get();
            }
            if ((expressionId == 82)) {
                PreTraining_TypedDataContext8_ForReadOnly valDataContext82 = new PreTraining_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext82.ValueType___Expr82Get();
            }
            if ((expressionId == 83)) {
                PreTraining_TypedDataContext8_ForReadOnly valDataContext83 = new PreTraining_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext83.ValueType___Expr83Get();
            }
            if ((expressionId == 84)) {
                PreTraining_TypedDataContext8_ForReadOnly valDataContext84 = new PreTraining_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext84.ValueType___Expr84Get();
            }
            if ((expressionId == 85)) {
                PreTraining_TypedDataContext8_ForReadOnly valDataContext85 = new PreTraining_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext85.ValueType___Expr85Get();
            }
            if ((expressionId == 86)) {
                PreTraining_TypedDataContext8 refDataContext86 = new PreTraining_TypedDataContext8(locations, true);
                return refDataContext86.GetLocation<int>(refDataContext86.ValueType___Expr86Get, refDataContext86.ValueType___Expr86Set);
            }
            if ((expressionId == 87)) {
                PreTraining_TypedDataContext8_ForReadOnly valDataContext87 = new PreTraining_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext87.ValueType___Expr87Get();
            }
            if ((expressionId == 88)) {
                PreTraining_TypedDataContext8_ForReadOnly valDataContext88 = new PreTraining_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext88.ValueType___Expr88Get();
            }
            if ((expressionId == 89)) {
                PreTraining_TypedDataContext8 refDataContext89 = new PreTraining_TypedDataContext8(locations, true);
                return refDataContext89.GetLocation<int>(refDataContext89.ValueType___Expr89Get, refDataContext89.ValueType___Expr89Set);
            }
            if ((expressionId == 90)) {
                PreTraining_TypedDataContext8_ForReadOnly valDataContext90 = new PreTraining_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext90.ValueType___Expr90Get();
            }
            if ((expressionId == 91)) {
                PreTraining_TypedDataContext8 refDataContext91 = new PreTraining_TypedDataContext8(locations, true);
                return refDataContext91.GetLocation<int>(refDataContext91.ValueType___Expr91Get, refDataContext91.ValueType___Expr91Set);
            }
            if ((expressionId == 92)) {
                PreTraining_TypedDataContext11 refDataContext92 = new PreTraining_TypedDataContext11(locations, true);
                return refDataContext92.GetLocation<string>(refDataContext92.ValueType___Expr92Get, refDataContext92.ValueType___Expr92Set);
            }
            if ((expressionId == 93)) {
                PreTraining_TypedDataContext11_ForReadOnly valDataContext93 = new PreTraining_TypedDataContext11_ForReadOnly(locations, true);
                return valDataContext93.ValueType___Expr93Get();
            }
            if ((expressionId == 94)) {
                PreTraining_TypedDataContext11_ForReadOnly valDataContext94 = new PreTraining_TypedDataContext11_ForReadOnly(locations, true);
                return valDataContext94.ValueType___Expr94Get();
            }
            if ((expressionId == 95)) {
                PreTraining_TypedDataContext11_ForReadOnly valDataContext95 = new PreTraining_TypedDataContext11_ForReadOnly(locations, true);
                return valDataContext95.ValueType___Expr95Get();
            }
            if ((expressionId == 96)) {
                PreTraining_TypedDataContext11_ForReadOnly valDataContext96 = new PreTraining_TypedDataContext11_ForReadOnly(locations, true);
                return valDataContext96.ValueType___Expr96Get();
            }
            if ((expressionId == 97)) {
                PreTraining_TypedDataContext12_ForReadOnly valDataContext97 = new PreTraining_TypedDataContext12_ForReadOnly(locations, true);
                return valDataContext97.ValueType___Expr97Get();
            }
            if ((expressionId == 98)) {
                PreTraining_TypedDataContext12_ForReadOnly valDataContext98 = new PreTraining_TypedDataContext12_ForReadOnly(locations, true);
                return valDataContext98.ValueType___Expr98Get();
            }
            if ((expressionId == 99)) {
                PreTraining_TypedDataContext12_ForReadOnly valDataContext99 = new PreTraining_TypedDataContext12_ForReadOnly(locations, true);
                return valDataContext99.ValueType___Expr99Get();
            }
            if ((expressionId == 100)) {
                PreTraining_TypedDataContext12 refDataContext100 = new PreTraining_TypedDataContext12(locations, true);
                return refDataContext100.GetLocation<string>(refDataContext100.ValueType___Expr100Get, refDataContext100.ValueType___Expr100Set);
            }
            if ((expressionId == 101)) {
                PreTraining_TypedDataContext12_ForReadOnly valDataContext101 = new PreTraining_TypedDataContext12_ForReadOnly(locations, true);
                return valDataContext101.ValueType___Expr101Get();
            }
            if ((expressionId == 102)) {
                PreTraining_TypedDataContext12 refDataContext102 = new PreTraining_TypedDataContext12(locations, true);
                return refDataContext102.GetLocation<System.Drawing.PointF>(refDataContext102.ValueType___Expr102Get, refDataContext102.ValueType___Expr102Set);
            }
            if ((expressionId == 103)) {
                PreTraining_TypedDataContext12_ForReadOnly valDataContext103 = new PreTraining_TypedDataContext12_ForReadOnly(locations, true);
                return valDataContext103.ValueType___Expr103Get();
            }
            if ((expressionId == 104)) {
                PreTraining_TypedDataContext12 refDataContext104 = new PreTraining_TypedDataContext12(locations, true);
                return refDataContext104.GetLocation<int>(refDataContext104.ValueType___Expr104Get, refDataContext104.ValueType___Expr104Set);
            }
            if ((expressionId == 105)) {
                PreTraining_TypedDataContext12_ForReadOnly valDataContext105 = new PreTraining_TypedDataContext12_ForReadOnly(locations, true);
                return valDataContext105.ValueType___Expr105Get();
            }
            if ((expressionId == 106)) {
                PreTraining_TypedDataContext12_ForReadOnly valDataContext106 = new PreTraining_TypedDataContext12_ForReadOnly(locations, true);
                return valDataContext106.ValueType___Expr106Get();
            }
            if ((expressionId == 107)) {
                PreTraining_TypedDataContext12_ForReadOnly valDataContext107 = new PreTraining_TypedDataContext12_ForReadOnly(locations, true);
                return valDataContext107.ValueType___Expr107Get();
            }
            if ((expressionId == 108)) {
                PreTraining_TypedDataContext13_ForReadOnly valDataContext108 = new PreTraining_TypedDataContext13_ForReadOnly(locations, true);
                return valDataContext108.ValueType___Expr108Get();
            }
            if ((expressionId == 109)) {
                PreTraining_TypedDataContext13_ForReadOnly valDataContext109 = new PreTraining_TypedDataContext13_ForReadOnly(locations, true);
                return valDataContext109.ValueType___Expr109Get();
            }
            if ((expressionId == 110)) {
                PreTraining_TypedDataContext13_ForReadOnly valDataContext110 = new PreTraining_TypedDataContext13_ForReadOnly(locations, true);
                return valDataContext110.ValueType___Expr110Get();
            }
            if ((expressionId == 111)) {
                PreTraining_TypedDataContext13 refDataContext111 = new PreTraining_TypedDataContext13(locations, true);
                return refDataContext111.GetLocation<string>(refDataContext111.ValueType___Expr111Get, refDataContext111.ValueType___Expr111Set);
            }
            if ((expressionId == 112)) {
                PreTraining_TypedDataContext13_ForReadOnly valDataContext112 = new PreTraining_TypedDataContext13_ForReadOnly(locations, true);
                return valDataContext112.ValueType___Expr112Get();
            }
            if ((expressionId == 113)) {
                PreTraining_TypedDataContext13 refDataContext113 = new PreTraining_TypedDataContext13(locations, true);
                return refDataContext113.GetLocation<System.Drawing.PointF>(refDataContext113.ValueType___Expr113Get, refDataContext113.ValueType___Expr113Set);
            }
            if ((expressionId == 114)) {
                PreTraining_TypedDataContext13_ForReadOnly valDataContext114 = new PreTraining_TypedDataContext13_ForReadOnly(locations, true);
                return valDataContext114.ValueType___Expr114Get();
            }
            if ((expressionId == 115)) {
                PreTraining_TypedDataContext13_ForReadOnly valDataContext115 = new PreTraining_TypedDataContext13_ForReadOnly(locations, true);
                return valDataContext115.ValueType___Expr115Get();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == false) 
                        && ((expressionText == "new List<string>();") 
                        && (PreTraining_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Archivo") 
                        && (PreTraining_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Cercania") 
                        && (PreTraining_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Continuar") 
                        && (PreTraining_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new PointF(0,0)") 
                        && (PreTraining_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Cruz") 
                        && (PreTraining_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new List<PointF>()") 
                        && (PreTraining_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "PosicionCruz") 
                        && (PreTraining_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "360/Separacion") 
                        && (PreTraining_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TotalBanderas") 
                        && (PreTraining_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new List<Int32>()") 
                        && (PreTraining_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "BanderasAparecidas") 
                        && (PreTraining_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "RtaCave") 
                        && (PreTraining_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new PointF(Single.Parse(RtaCave.Split(\';\')[0].Replace(\".\", \",\")), Single.Parse(Rt" +
                            "aCave.Split(\';\')[1].Replace(\".\", \",\")))") 
                        && (PreTraining_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Coordenadas") 
                        && (PreTraining_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Agregar180") 
                        && (PreTraining_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 15;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"L{ \\\"id\\\":\\\"\"+Escenario+\"\\\" }\"") 
                        && (PreTraining_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 16;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Archivo") 
                        && (PreTraining_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 17;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DateTime.Now.ToString()+\";\"+\n                Coordenadas.X+\";\"+Coordenadas.Y\n    " +
                            "            +\";NULL;NULL;NULL;DET\"") 
                        && (PreTraining_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 18;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DateTime.Now.ToString() + \";\" +\n                Coordenadas.X + \";\" + Coordenadas" +
                            ".Y+ \";NULL;NULL;NULL;DET\"") 
                        && (PreTraining_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 19;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"X{ \\\"value\\\":\\\"rojo\\\" }\"") 
                        && (PreTraining_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 20;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TimeSpan.FromSeconds(2);") 
                        && (PreTraining_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 21;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"X{ \\\"value\\\":\\\"negro\\\" }\"") 
                        && (PreTraining_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 22;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "RtaCave") 
                        && (PreTraining_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 23;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new PointF(Single.Parse(RtaCave.Split(\';\')[0].Replace(\".\", \",\")), Single.Parse(Rt" +
                            "aCave.Split(\';\')[1].Replace(\".\", \",\")))") 
                        && (PreTraining_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 24;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Coordenadas") 
                        && (PreTraining_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 25;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Continuar>0") 
                        && (PreTraining_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 26;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new Random()") 
                        && (PreTraining_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 27;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Random") 
                        && (PreTraining_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 28;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Random.Next(0,BanderasCircunferencia.Count)") 
                        && (PreTraining_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 29;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "BanderaRandom") 
                        && (PreTraining_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 30;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Random.Next(0,TotalBanderas)") 
                        && (PreTraining_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 31;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "BanderaRandom") 
                        && (PreTraining_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 32;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "BanderasAparecidas.Contains(BanderaRandom)") 
                        && (PreTraining_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 33;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"H{ \\\"id\\\":\\\"\" + (int)(BanderaRandom) + \"\\\", \\\"visible\\\":\\\"true\\\" }\"") 
                        && (PreTraining_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 34;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Continuar<0") 
                        && (PreTraining_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 35;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Archivo") 
                        && (PreTraining_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 36;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DateTime.Now.ToString()+\";\"+Coordenadas.X+\";\"+Coordenadas.Y+\";\"+\"NULL;NULL;NULL;B" +
                            "US\"") 
                        && (PreTraining_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 37;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DateTime.Now.ToString() + \";\" + Coordenadas.X + \";\" + Coordenadas.Y + \";\" + \"NULL" +
                            ";NULL;NULL;BUS\"") 
                        && (PreTraining_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 38;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "RtaCave") 
                        && (PreTraining_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 39;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new PointF(Single.Parse(RtaCave.Split(\';\')[0].Replace(\".\", \",\")), Single.Parse(Rt" +
                            "aCave.Split(\';\')[1].Replace(\".\", \",\")))") 
                        && (PreTraining_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 40;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Coordenadas") 
                        && (PreTraining_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 41;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Sqrt((Math.Pow(Coordenadas.X - BanderasCircunferencia[BanderaRandom].X, 2)) " +
                            "+ Math.Pow(Coordenadas.Y - BanderasCircunferencia[BanderaRandom].Y, 2)) < Cercan" +
                            "ia") 
                        && (PreTraining_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 42;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"H{ \\\"id\\\":\\\"\" + (int)(BanderaRandom) + \"\\\", \\\"visible\\\":\\\"false\\\" }\"") 
                        && (PreTraining_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 43;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Archivo") 
                        && (PreTraining_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 44;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DateTime.Now.ToString() + \";\" + Coordenadas.X + \";\" + Coordenadas.Y + \";\" + Bande" +
                            "rasCircunferencia[BanderaRandom].X + \";\" + BanderasCircunferencia[BanderaRandom]" +
                            ".Y + \";\" + BanderaRandom+\";CAP\"") 
                        && (PreTraining_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 45;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DateTime.Now.ToString() + \";\" + Coordenadas.X + \";\" + Coordenadas.Y + \";\" + Bande" +
                            "rasCircunferencia[BanderaRandom].X + \";\" + BanderasCircunferencia[BanderaRandom]" +
                            ".Y + \";\" + BanderaRandom + \";CAP\"") 
                        && (PreTraining_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 46;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "!(Math.Sqrt((Math.Pow(Coordenadas.X - BanderasCircunferencia[BanderaRandom].X, 2)" +
                            ") + Math.Pow(Coordenadas.Y - BanderasCircunferencia[BanderaRandom].Y, 2)) < Cerc" +
                            "ania)") 
                        && (PreTraining_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 47;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Q{ \\\"text\\\":\\\"Fin del experimento\\\" }\"") 
                        && (PreTraining_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 48;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Archivo") 
                        && (PreTraining_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 49;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DateTime.Now.ToString()+\";\"+Coordenadas.X+\";\"+Coordenadas.Y+\";\"+\"NULL;NULL;NULL;F" +
                            "IN\"") 
                        && (PreTraining_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 50;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DateTime.Now.ToString() + \";\" + Coordenadas.X + \";\" + Coordenadas.Y + \";\" + \"NULL" +
                            ";NULL;NULL;FIN\"") 
                        && (PreTraining_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 51;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TimeSpan.FromSeconds(5)") 
                        && (PreTraining_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 52;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"C{ \\\"id\\\":\\\"\" + (int)(Cursor) + \"\\\", \\\"color\\\":\\\"\" + ColorSeleccion + \"\\\" }\"") 
                        && (PreTraining_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 53;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "RtaCave") 
                        && (PreTraining_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 54;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RtaCave.Equals(\"2\")") 
                        && (PreTraining_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 55;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Archivo") 
                        && (PreTraining_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 56;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DateTime.Now.ToString() + \";\" + Coordenadas.X + \";\" + Coordenadas.Y + \";\" + Bande" +
                            "rasCircunferencia.ElementAt(Cursor).X + \";\" + BanderasCircunferencia.ElementAt(C" +
                            "ursor).Y + \";\" + Cursor + \";SEL\"") 
                        && (PreTraining_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 57;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DateTime.Now.ToString() + \";\" + Coordenadas.X + \";\" + Coordenadas.Y + \";\" + Bande" +
                            "rasCircunferencia.ElementAt(Cursor).X + \";\" + BanderasCircunferencia.ElementAt(C" +
                            "ursor).Y + \";\" + Cursor + \";SEL\"") 
                        && (PreTraining_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 58;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Eligió la: \"+Cursor") 
                        && (PreTraining_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 59;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"C{ \\\"id\\\":\\\"\" + (int)(Cursor) + \"\\\", \\\"color\\\":\\\"\" + ColorBandera + \"\\\" }\"") 
                        && (PreTraining_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 60;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Mostrar180.Replace(\"true\", \"false\")") 
                        && (PreTraining_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 61;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new Random()") 
                        && (PreTraining_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 62;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "RandomX") 
                        && (PreTraining_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 63;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new Random()") 
                        && (PreTraining_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 64;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "RandomY") 
                        && (PreTraining_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 65;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RandomX.Next(-13,13)") 
                        && (PreTraining_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 66;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "CruzX") 
                        && (PreTraining_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 67;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RandomY.Next(-13, 13)") 
                        && (PreTraining_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 68;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "CruzY") 
                        && (PreTraining_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 69;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RandomX.Next(-13,13)") 
                        && (PreTraining_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 70;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "CruzX") 
                        && (PreTraining_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 71;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RandomY.Next(-13,13)") 
                        && (PreTraining_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 72;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "CruzY") 
                        && (PreTraining_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 73;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Math.Sqrt(Math.Pow(Cruz.X-CruzX,2)+Math.Pow(Cruz.Y-CruzY,2))<Cercania) || (Posic" +
                            "ionCruz.Contains(new PointF(CruzX,CruzY)))") 
                        && (PreTraining_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 74;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "PosicionCruz") 
                        && (PreTraining_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 75;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Cruz") 
                        && (PreTraining_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 76;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CruzX") 
                        && (PreTraining_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 77;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Cruz.X") 
                        && (PreTraining_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 78;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CruzY") 
                        && (PreTraining_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 79;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Cruz.Y") 
                        && (PreTraining_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 80;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Q{ \\\"text\\\":\\\"Terminar Experimento?\\\" }\"") 
                        && (PreTraining_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 81;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RtaCave.Equals(\"1\") || RtaCave.Equals(\"3\")") 
                        && (PreTraining_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 82;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"C{ \\\"id\\\":\\\"\" + (int)(Cursor) + \"\\\", \\\"color\\\":\\\"\" + ColorBandera + \"\\\" }\"") 
                        && (PreTraining_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 83;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RtaCave.Equals(\"1\")") 
                        && (PreTraining_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 84;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Cursor - 1) % BanderasCircunferencia.Count") 
                        && (PreTraining_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 85;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Cursor") 
                        && (PreTraining_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 86;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Cursor<0") 
                        && (PreTraining_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 87;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "BanderasCircunferencia.Count-1") 
                        && (PreTraining_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 88;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Cursor") 
                        && (PreTraining_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 89;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Cursor + 1) % BanderasCircunferencia.Count") 
                        && (PreTraining_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 90;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Cursor") 
                        && (PreTraining_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 91;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "RtaCave") 
                        && (PreTraining_TypedDataContext11.Validate(locations, true, 0) == true)))) {
                expressionId = 92;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RtaCave.Equals(\"2\")") 
                        && (PreTraining_TypedDataContext11_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 93;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "!RtaCave.Equals(\"1\") && !RtaCave.Equals(\"2\")") 
                        && (PreTraining_TypedDataContext11_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 94;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RtaCave.Equals(\"1\")") 
                        && (PreTraining_TypedDataContext11_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 95;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"M{ \\\"x\\\":\\\"\"+Cruz.X+\"\\\", \\\"y\\\":\\\"\"+Cruz.Y+\"\\\" }\"") 
                        && (PreTraining_TypedDataContext11_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 96;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Archivo") 
                        && (PreTraining_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 97;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DateTime.Now.ToString()+\";\"+Coordenadas.X+\";\"+Coordenadas.Y+\";\"+\"NULL;NULL;NULL;C" +
                            "EN\"") 
                        && (PreTraining_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 98;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DateTime.Now.ToString() + \";\" + Coordenadas.X + \";\" + Coordenadas.Y + \";\" + \"NULL" +
                            ";NULL;NULL;CEN\"") 
                        && (PreTraining_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 99;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "RtaCave") 
                        && (PreTraining_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 100;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new PointF(Single.Parse(RtaCave.Split(\';\')[0].Replace(\".\", \",\")), Single.Parse(Rt" +
                            "aCave.Split(\';\')[1].Replace(\".\", \",\")))") 
                        && (PreTraining_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 101;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Coordenadas") 
                        && (PreTraining_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 102;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Sqrt((Math.Pow(Coordenadas.X - Cruz.X, 2)) + Math.Pow(Coordenadas.Y - Cruz.Y" +
                            ", 2)) < Cercania") 
                        && (PreTraining_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 103;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Cursor") 
                        && (PreTraining_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 104;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Q{ \\\"text\\\":\\\"Marca la bandera que recolectaste.\\\" }\"") 
                        && (PreTraining_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 105;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Mostrar180") 
                        && (PreTraining_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 106;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "!(Math.Sqrt((Math.Pow(Coordenadas.X - Cruz.X, 2)) + Math.Pow(Coordenadas.Y - Cruz" +
                            ".Y, 2)) < Cercania)") 
                        && (PreTraining_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 107;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Archivo") 
                        && (PreTraining_TypedDataContext13_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 108;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DateTime.Now.ToString() + \";\" + Coordenadas.X + \";\" + Coordenadas.Y + \";\" + Bande" +
                            "rasCircunferencia.ElementAt(Cursor).X + \";\" + BanderasCircunferencia.ElementAt(C" +
                            "ursor).Y + \";\" + Cursor + \";CRUZ\"") 
                        && (PreTraining_TypedDataContext13_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 109;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DateTime.Now.ToString() + \";\" + Coordenadas.X + \";\" + Coordenadas.Y + \";\" + Bande" +
                            "rasCircunferencia.ElementAt(Cursor).X + \";\" + BanderasCircunferencia.ElementAt(C" +
                            "ursor).Y + \";\" + Cursor + \";CRUZ\"") 
                        && (PreTraining_TypedDataContext13_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 110;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "RtaCave") 
                        && (PreTraining_TypedDataContext13.Validate(locations, true, 0) == true)))) {
                expressionId = 111;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new PointF(Single.Parse(RtaCave.Split(\';\')[0].Replace(\".\", \",\")), Single.Parse(Rt" +
                            "aCave.Split(\';\')[1].Replace(\".\", \",\")))") 
                        && (PreTraining_TypedDataContext13_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 112;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Coordenadas") 
                        && (PreTraining_TypedDataContext13.Validate(locations, true, 0) == true)))) {
                expressionId = 113;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Sqrt((Math.Pow(Coordenadas.X - Cruz.X, 2)) + Math.Pow(Coordenadas.Y - Cruz.Y" +
                            ", 2)) < Cercania") 
                        && (PreTraining_TypedDataContext13_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 114;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "!(Math.Sqrt((Math.Pow(Coordenadas.X - Cruz.X, 2)) + Math.Pow(Coordenadas.Y - Cruz" +
                            ".Y, 2)) < Cercania)") 
                        && (PreTraining_TypedDataContext13_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 115;
                return true;
            }
            expressionId = -1;
            return false;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Collections.Generic.IList<string> GetRequiredLocations(int expressionId) {
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Linq.Expressions.Expression GetExpressionTreeForExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) {
            if ((expressionId == 0)) {
                return new PreTraining_TypedDataContext3_ForReadOnly(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new PreTraining_TypedDataContext3(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new PreTraining_TypedDataContext3(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new PreTraining_TypedDataContext3(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new PreTraining_TypedDataContext3_ForReadOnly(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new PreTraining_TypedDataContext3(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new PreTraining_TypedDataContext3_ForReadOnly(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new PreTraining_TypedDataContext3(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new PreTraining_TypedDataContext3_ForReadOnly(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new PreTraining_TypedDataContext3(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new PreTraining_TypedDataContext3_ForReadOnly(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new PreTraining_TypedDataContext3(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new PreTraining_TypedDataContext3(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new PreTraining_TypedDataContext3_ForReadOnly(locationReferences).@__Expr13GetTree();
            }
            if ((expressionId == 14)) {
                return new PreTraining_TypedDataContext3(locationReferences).@__Expr14GetTree();
            }
            if ((expressionId == 15)) {
                return new PreTraining_TypedDataContext3_ForReadOnly(locationReferences).@__Expr15GetTree();
            }
            if ((expressionId == 16)) {
                return new PreTraining_TypedDataContext3_ForReadOnly(locationReferences).@__Expr16GetTree();
            }
            if ((expressionId == 17)) {
                return new PreTraining_TypedDataContext4_ForReadOnly(locationReferences).@__Expr17GetTree();
            }
            if ((expressionId == 18)) {
                return new PreTraining_TypedDataContext4_ForReadOnly(locationReferences).@__Expr18GetTree();
            }
            if ((expressionId == 19)) {
                return new PreTraining_TypedDataContext4_ForReadOnly(locationReferences).@__Expr19GetTree();
            }
            if ((expressionId == 20)) {
                return new PreTraining_TypedDataContext4_ForReadOnly(locationReferences).@__Expr20GetTree();
            }
            if ((expressionId == 21)) {
                return new PreTraining_TypedDataContext4_ForReadOnly(locationReferences).@__Expr21GetTree();
            }
            if ((expressionId == 22)) {
                return new PreTraining_TypedDataContext4_ForReadOnly(locationReferences).@__Expr22GetTree();
            }
            if ((expressionId == 23)) {
                return new PreTraining_TypedDataContext4(locationReferences).@__Expr23GetTree();
            }
            if ((expressionId == 24)) {
                return new PreTraining_TypedDataContext4_ForReadOnly(locationReferences).@__Expr24GetTree();
            }
            if ((expressionId == 25)) {
                return new PreTraining_TypedDataContext4(locationReferences).@__Expr25GetTree();
            }
            if ((expressionId == 26)) {
                return new PreTraining_TypedDataContext4_ForReadOnly(locationReferences).@__Expr26GetTree();
            }
            if ((expressionId == 27)) {
                return new PreTraining_TypedDataContext5_ForReadOnly(locationReferences).@__Expr27GetTree();
            }
            if ((expressionId == 28)) {
                return new PreTraining_TypedDataContext5(locationReferences).@__Expr28GetTree();
            }
            if ((expressionId == 29)) {
                return new PreTraining_TypedDataContext5_ForReadOnly(locationReferences).@__Expr29GetTree();
            }
            if ((expressionId == 30)) {
                return new PreTraining_TypedDataContext5(locationReferences).@__Expr30GetTree();
            }
            if ((expressionId == 31)) {
                return new PreTraining_TypedDataContext5_ForReadOnly(locationReferences).@__Expr31GetTree();
            }
            if ((expressionId == 32)) {
                return new PreTraining_TypedDataContext5(locationReferences).@__Expr32GetTree();
            }
            if ((expressionId == 33)) {
                return new PreTraining_TypedDataContext5_ForReadOnly(locationReferences).@__Expr33GetTree();
            }
            if ((expressionId == 34)) {
                return new PreTraining_TypedDataContext5_ForReadOnly(locationReferences).@__Expr34GetTree();
            }
            if ((expressionId == 35)) {
                return new PreTraining_TypedDataContext4_ForReadOnly(locationReferences).@__Expr35GetTree();
            }
            if ((expressionId == 36)) {
                return new PreTraining_TypedDataContext6_ForReadOnly(locationReferences).@__Expr36GetTree();
            }
            if ((expressionId == 37)) {
                return new PreTraining_TypedDataContext6_ForReadOnly(locationReferences).@__Expr37GetTree();
            }
            if ((expressionId == 38)) {
                return new PreTraining_TypedDataContext6_ForReadOnly(locationReferences).@__Expr38GetTree();
            }
            if ((expressionId == 39)) {
                return new PreTraining_TypedDataContext6(locationReferences).@__Expr39GetTree();
            }
            if ((expressionId == 40)) {
                return new PreTraining_TypedDataContext6_ForReadOnly(locationReferences).@__Expr40GetTree();
            }
            if ((expressionId == 41)) {
                return new PreTraining_TypedDataContext6(locationReferences).@__Expr41GetTree();
            }
            if ((expressionId == 42)) {
                return new PreTraining_TypedDataContext6_ForReadOnly(locationReferences).@__Expr42GetTree();
            }
            if ((expressionId == 43)) {
                return new PreTraining_TypedDataContext6_ForReadOnly(locationReferences).@__Expr43GetTree();
            }
            if ((expressionId == 44)) {
                return new PreTraining_TypedDataContext6_ForReadOnly(locationReferences).@__Expr44GetTree();
            }
            if ((expressionId == 45)) {
                return new PreTraining_TypedDataContext6_ForReadOnly(locationReferences).@__Expr45GetTree();
            }
            if ((expressionId == 46)) {
                return new PreTraining_TypedDataContext6_ForReadOnly(locationReferences).@__Expr46GetTree();
            }
            if ((expressionId == 47)) {
                return new PreTraining_TypedDataContext6_ForReadOnly(locationReferences).@__Expr47GetTree();
            }
            if ((expressionId == 48)) {
                return new PreTraining_TypedDataContext7_ForReadOnly(locationReferences).@__Expr48GetTree();
            }
            if ((expressionId == 49)) {
                return new PreTraining_TypedDataContext7_ForReadOnly(locationReferences).@__Expr49GetTree();
            }
            if ((expressionId == 50)) {
                return new PreTraining_TypedDataContext7_ForReadOnly(locationReferences).@__Expr50GetTree();
            }
            if ((expressionId == 51)) {
                return new PreTraining_TypedDataContext7_ForReadOnly(locationReferences).@__Expr51GetTree();
            }
            if ((expressionId == 52)) {
                return new PreTraining_TypedDataContext7_ForReadOnly(locationReferences).@__Expr52GetTree();
            }
            if ((expressionId == 53)) {
                return new PreTraining_TypedDataContext8_ForReadOnly(locationReferences).@__Expr53GetTree();
            }
            if ((expressionId == 54)) {
                return new PreTraining_TypedDataContext8(locationReferences).@__Expr54GetTree();
            }
            if ((expressionId == 55)) {
                return new PreTraining_TypedDataContext8_ForReadOnly(locationReferences).@__Expr55GetTree();
            }
            if ((expressionId == 56)) {
                return new PreTraining_TypedDataContext8_ForReadOnly(locationReferences).@__Expr56GetTree();
            }
            if ((expressionId == 57)) {
                return new PreTraining_TypedDataContext8_ForReadOnly(locationReferences).@__Expr57GetTree();
            }
            if ((expressionId == 58)) {
                return new PreTraining_TypedDataContext8_ForReadOnly(locationReferences).@__Expr58GetTree();
            }
            if ((expressionId == 59)) {
                return new PreTraining_TypedDataContext8_ForReadOnly(locationReferences).@__Expr59GetTree();
            }
            if ((expressionId == 60)) {
                return new PreTraining_TypedDataContext8_ForReadOnly(locationReferences).@__Expr60GetTree();
            }
            if ((expressionId == 61)) {
                return new PreTraining_TypedDataContext8_ForReadOnly(locationReferences).@__Expr61GetTree();
            }
            if ((expressionId == 62)) {
                return new PreTraining_TypedDataContext9_ForReadOnly(locationReferences).@__Expr62GetTree();
            }
            if ((expressionId == 63)) {
                return new PreTraining_TypedDataContext9(locationReferences).@__Expr63GetTree();
            }
            if ((expressionId == 64)) {
                return new PreTraining_TypedDataContext9_ForReadOnly(locationReferences).@__Expr64GetTree();
            }
            if ((expressionId == 65)) {
                return new PreTraining_TypedDataContext9(locationReferences).@__Expr65GetTree();
            }
            if ((expressionId == 66)) {
                return new PreTraining_TypedDataContext9_ForReadOnly(locationReferences).@__Expr66GetTree();
            }
            if ((expressionId == 67)) {
                return new PreTraining_TypedDataContext9(locationReferences).@__Expr67GetTree();
            }
            if ((expressionId == 68)) {
                return new PreTraining_TypedDataContext9_ForReadOnly(locationReferences).@__Expr68GetTree();
            }
            if ((expressionId == 69)) {
                return new PreTraining_TypedDataContext9(locationReferences).@__Expr69GetTree();
            }
            if ((expressionId == 70)) {
                return new PreTraining_TypedDataContext9_ForReadOnly(locationReferences).@__Expr70GetTree();
            }
            if ((expressionId == 71)) {
                return new PreTraining_TypedDataContext9(locationReferences).@__Expr71GetTree();
            }
            if ((expressionId == 72)) {
                return new PreTraining_TypedDataContext9_ForReadOnly(locationReferences).@__Expr72GetTree();
            }
            if ((expressionId == 73)) {
                return new PreTraining_TypedDataContext9(locationReferences).@__Expr73GetTree();
            }
            if ((expressionId == 74)) {
                return new PreTraining_TypedDataContext9_ForReadOnly(locationReferences).@__Expr74GetTree();
            }
            if ((expressionId == 75)) {
                return new PreTraining_TypedDataContext9_ForReadOnly(locationReferences).@__Expr75GetTree();
            }
            if ((expressionId == 76)) {
                return new PreTraining_TypedDataContext9_ForReadOnly(locationReferences).@__Expr76GetTree();
            }
            if ((expressionId == 77)) {
                return new PreTraining_TypedDataContext9_ForReadOnly(locationReferences).@__Expr77GetTree();
            }
            if ((expressionId == 78)) {
                return new PreTraining_TypedDataContext9(locationReferences).@__Expr78GetTree();
            }
            if ((expressionId == 79)) {
                return new PreTraining_TypedDataContext9_ForReadOnly(locationReferences).@__Expr79GetTree();
            }
            if ((expressionId == 80)) {
                return new PreTraining_TypedDataContext9(locationReferences).@__Expr80GetTree();
            }
            if ((expressionId == 81)) {
                return new PreTraining_TypedDataContext8_ForReadOnly(locationReferences).@__Expr81GetTree();
            }
            if ((expressionId == 82)) {
                return new PreTraining_TypedDataContext8_ForReadOnly(locationReferences).@__Expr82GetTree();
            }
            if ((expressionId == 83)) {
                return new PreTraining_TypedDataContext8_ForReadOnly(locationReferences).@__Expr83GetTree();
            }
            if ((expressionId == 84)) {
                return new PreTraining_TypedDataContext8_ForReadOnly(locationReferences).@__Expr84GetTree();
            }
            if ((expressionId == 85)) {
                return new PreTraining_TypedDataContext8_ForReadOnly(locationReferences).@__Expr85GetTree();
            }
            if ((expressionId == 86)) {
                return new PreTraining_TypedDataContext8(locationReferences).@__Expr86GetTree();
            }
            if ((expressionId == 87)) {
                return new PreTraining_TypedDataContext8_ForReadOnly(locationReferences).@__Expr87GetTree();
            }
            if ((expressionId == 88)) {
                return new PreTraining_TypedDataContext8_ForReadOnly(locationReferences).@__Expr88GetTree();
            }
            if ((expressionId == 89)) {
                return new PreTraining_TypedDataContext8(locationReferences).@__Expr89GetTree();
            }
            if ((expressionId == 90)) {
                return new PreTraining_TypedDataContext8_ForReadOnly(locationReferences).@__Expr90GetTree();
            }
            if ((expressionId == 91)) {
                return new PreTraining_TypedDataContext8(locationReferences).@__Expr91GetTree();
            }
            if ((expressionId == 92)) {
                return new PreTraining_TypedDataContext11(locationReferences).@__Expr92GetTree();
            }
            if ((expressionId == 93)) {
                return new PreTraining_TypedDataContext11_ForReadOnly(locationReferences).@__Expr93GetTree();
            }
            if ((expressionId == 94)) {
                return new PreTraining_TypedDataContext11_ForReadOnly(locationReferences).@__Expr94GetTree();
            }
            if ((expressionId == 95)) {
                return new PreTraining_TypedDataContext11_ForReadOnly(locationReferences).@__Expr95GetTree();
            }
            if ((expressionId == 96)) {
                return new PreTraining_TypedDataContext11_ForReadOnly(locationReferences).@__Expr96GetTree();
            }
            if ((expressionId == 97)) {
                return new PreTraining_TypedDataContext12_ForReadOnly(locationReferences).@__Expr97GetTree();
            }
            if ((expressionId == 98)) {
                return new PreTraining_TypedDataContext12_ForReadOnly(locationReferences).@__Expr98GetTree();
            }
            if ((expressionId == 99)) {
                return new PreTraining_TypedDataContext12_ForReadOnly(locationReferences).@__Expr99GetTree();
            }
            if ((expressionId == 100)) {
                return new PreTraining_TypedDataContext12(locationReferences).@__Expr100GetTree();
            }
            if ((expressionId == 101)) {
                return new PreTraining_TypedDataContext12_ForReadOnly(locationReferences).@__Expr101GetTree();
            }
            if ((expressionId == 102)) {
                return new PreTraining_TypedDataContext12(locationReferences).@__Expr102GetTree();
            }
            if ((expressionId == 103)) {
                return new PreTraining_TypedDataContext12_ForReadOnly(locationReferences).@__Expr103GetTree();
            }
            if ((expressionId == 104)) {
                return new PreTraining_TypedDataContext12(locationReferences).@__Expr104GetTree();
            }
            if ((expressionId == 105)) {
                return new PreTraining_TypedDataContext12_ForReadOnly(locationReferences).@__Expr105GetTree();
            }
            if ((expressionId == 106)) {
                return new PreTraining_TypedDataContext12_ForReadOnly(locationReferences).@__Expr106GetTree();
            }
            if ((expressionId == 107)) {
                return new PreTraining_TypedDataContext12_ForReadOnly(locationReferences).@__Expr107GetTree();
            }
            if ((expressionId == 108)) {
                return new PreTraining_TypedDataContext13_ForReadOnly(locationReferences).@__Expr108GetTree();
            }
            if ((expressionId == 109)) {
                return new PreTraining_TypedDataContext13_ForReadOnly(locationReferences).@__Expr109GetTree();
            }
            if ((expressionId == 110)) {
                return new PreTraining_TypedDataContext13_ForReadOnly(locationReferences).@__Expr110GetTree();
            }
            if ((expressionId == 111)) {
                return new PreTraining_TypedDataContext13(locationReferences).@__Expr111GetTree();
            }
            if ((expressionId == 112)) {
                return new PreTraining_TypedDataContext13_ForReadOnly(locationReferences).@__Expr112GetTree();
            }
            if ((expressionId == 113)) {
                return new PreTraining_TypedDataContext13(locationReferences).@__Expr113GetTree();
            }
            if ((expressionId == 114)) {
                return new PreTraining_TypedDataContext13_ForReadOnly(locationReferences).@__Expr114GetTree();
            }
            if ((expressionId == 115)) {
                return new PreTraining_TypedDataContext13_ForReadOnly(locationReferences).@__Expr115GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class PreTraining_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public PreTraining_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class PreTraining_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public PreTraining_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class PreTraining_TypedDataContext1 : PreTraining_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int Separacion;
            
            protected int Radio;
            
            public PreTraining_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.Collections.Generic.List<System.Drawing.PointF> BanderasCircunferencia {
                get {
                    return ((System.Collections.Generic.List<System.Drawing.PointF>)(this.GetVariableValue((0 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((0 + locationsOffset), value);
                }
            }
            
            protected string Mostrar180 {
                get {
                    return ((string)(this.GetVariableValue((1 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((1 + locationsOffset), value);
                }
            }
            
            protected string Agregar180 {
                get {
                    return ((string)(this.GetVariableValue((2 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((2 + locationsOffset), value);
                }
            }
            
            protected string ColorBandera {
                get {
                    return ((string)(this.GetVariableValue((4 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((4 + locationsOffset), value);
                }
            }
            
            protected System.Collections.Generic.List<string> Archivo {
                get {
                    return ((System.Collections.Generic.List<string>)(this.GetVariableValue((5 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((5 + locationsOffset), value);
                }
            }
            
            protected string ColorSeleccion {
                get {
                    return ((string)(this.GetVariableValue((6 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((6 + locationsOffset), value);
                }
            }
            
            protected string Escenario {
                get {
                    return ((string)(this.GetVariableValue((8 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((8 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            protected override void GetValueTypeValues() {
                this.Separacion = ((int)(this.GetVariableValue((3 + locationsOffset))));
                this.Radio = ((int)(this.GetVariableValue((7 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((3 + locationsOffset), this.Separacion);
                this.SetVariableValue((7 + locationsOffset), this.Radio);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 9))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 9);
                }
                expectedLocationsCount = 9;
                if (((locationReferences[(offset + 0)].Name != "BanderasCircunferencia") 
                            || (locationReferences[(offset + 0)].Type != typeof(System.Collections.Generic.List<System.Drawing.PointF>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "Mostrar180") 
                            || (locationReferences[(offset + 1)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "Agregar180") 
                            || (locationReferences[(offset + 2)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "ColorBandera") 
                            || (locationReferences[(offset + 4)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "Archivo") 
                            || (locationReferences[(offset + 5)].Type != typeof(System.Collections.Generic.List<string>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "ColorSeleccion") 
                            || (locationReferences[(offset + 6)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "Escenario") 
                            || (locationReferences[(offset + 8)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "Separacion") 
                            || (locationReferences[(offset + 3)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "Radio") 
                            || (locationReferences[(offset + 7)].Type != typeof(int)))) {
                    return false;
                }
                return PreTraining_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class PreTraining_TypedDataContext1_ForReadOnly : PreTraining_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int Separacion;
            
            protected int Radio;
            
            public PreTraining_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.Collections.Generic.List<System.Drawing.PointF> BanderasCircunferencia {
                get {
                    return ((System.Collections.Generic.List<System.Drawing.PointF>)(this.GetVariableValue((0 + locationsOffset))));
                }
            }
            
            protected string Mostrar180 {
                get {
                    return ((string)(this.GetVariableValue((1 + locationsOffset))));
                }
            }
            
            protected string Agregar180 {
                get {
                    return ((string)(this.GetVariableValue((2 + locationsOffset))));
                }
            }
            
            protected string ColorBandera {
                get {
                    return ((string)(this.GetVariableValue((4 + locationsOffset))));
                }
            }
            
            protected System.Collections.Generic.List<string> Archivo {
                get {
                    return ((System.Collections.Generic.List<string>)(this.GetVariableValue((5 + locationsOffset))));
                }
            }
            
            protected string ColorSeleccion {
                get {
                    return ((string)(this.GetVariableValue((6 + locationsOffset))));
                }
            }
            
            protected string Escenario {
                get {
                    return ((string)(this.GetVariableValue((8 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            protected override void GetValueTypeValues() {
                this.Separacion = ((int)(this.GetVariableValue((3 + locationsOffset))));
                this.Radio = ((int)(this.GetVariableValue((7 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 9))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 9);
                }
                expectedLocationsCount = 9;
                if (((locationReferences[(offset + 0)].Name != "BanderasCircunferencia") 
                            || (locationReferences[(offset + 0)].Type != typeof(System.Collections.Generic.List<System.Drawing.PointF>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "Mostrar180") 
                            || (locationReferences[(offset + 1)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "Agregar180") 
                            || (locationReferences[(offset + 2)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "ColorBandera") 
                            || (locationReferences[(offset + 4)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "Archivo") 
                            || (locationReferences[(offset + 5)].Type != typeof(System.Collections.Generic.List<string>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "ColorSeleccion") 
                            || (locationReferences[(offset + 6)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "Escenario") 
                            || (locationReferences[(offset + 8)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "Separacion") 
                            || (locationReferences[(offset + 3)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "Radio") 
                            || (locationReferences[(offset + 7)].Type != typeof(int)))) {
                    return false;
                }
                return PreTraining_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class PreTraining_TypedDataContext2 : PreTraining_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected System.Drawing.PointF Cruz;
            
            protected System.Drawing.PointF Coordenadas;
            
            protected int TotalBanderas;
            
            protected int Continuar;
            
            protected int Cercania;
            
            protected int Cursor;
            
            protected int BanderaRandom;
            
            public PreTraining_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string RtaCave {
                get {
                    return ((string)(this.GetVariableValue((10 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((10 + locationsOffset), value);
                }
            }
            
            protected System.Collections.Generic.List<int> BanderasAparecidas {
                get {
                    return ((System.Collections.Generic.List<int>)(this.GetVariableValue((13 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((13 + locationsOffset), value);
                }
            }
            
            protected System.Collections.Generic.List<System.Drawing.PointF> PosicionCruz {
                get {
                    return ((System.Collections.Generic.List<System.Drawing.PointF>)(this.GetVariableValue((17 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((17 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            protected override void GetValueTypeValues() {
                this.Cruz = ((System.Drawing.PointF)(this.GetVariableValue((9 + locationsOffset))));
                this.Coordenadas = ((System.Drawing.PointF)(this.GetVariableValue((11 + locationsOffset))));
                this.TotalBanderas = ((int)(this.GetVariableValue((12 + locationsOffset))));
                this.Continuar = ((int)(this.GetVariableValue((14 + locationsOffset))));
                this.Cercania = ((int)(this.GetVariableValue((15 + locationsOffset))));
                this.Cursor = ((int)(this.GetVariableValue((16 + locationsOffset))));
                this.BanderaRandom = ((int)(this.GetVariableValue((18 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((9 + locationsOffset), this.Cruz);
                this.SetVariableValue((11 + locationsOffset), this.Coordenadas);
                this.SetVariableValue((12 + locationsOffset), this.TotalBanderas);
                this.SetVariableValue((14 + locationsOffset), this.Continuar);
                this.SetVariableValue((15 + locationsOffset), this.Cercania);
                this.SetVariableValue((16 + locationsOffset), this.Cursor);
                this.SetVariableValue((18 + locationsOffset), this.BanderaRandom);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 19))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 19);
                }
                expectedLocationsCount = 19;
                if (((locationReferences[(offset + 10)].Name != "RtaCave") 
                            || (locationReferences[(offset + 10)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 13)].Name != "BanderasAparecidas") 
                            || (locationReferences[(offset + 13)].Type != typeof(System.Collections.Generic.List<int>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 17)].Name != "PosicionCruz") 
                            || (locationReferences[(offset + 17)].Type != typeof(System.Collections.Generic.List<System.Drawing.PointF>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "Cruz") 
                            || (locationReferences[(offset + 9)].Type != typeof(System.Drawing.PointF)))) {
                    return false;
                }
                if (((locationReferences[(offset + 11)].Name != "Coordenadas") 
                            || (locationReferences[(offset + 11)].Type != typeof(System.Drawing.PointF)))) {
                    return false;
                }
                if (((locationReferences[(offset + 12)].Name != "TotalBanderas") 
                            || (locationReferences[(offset + 12)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 14)].Name != "Continuar") 
                            || (locationReferences[(offset + 14)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 15)].Name != "Cercania") 
                            || (locationReferences[(offset + 15)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 16)].Name != "Cursor") 
                            || (locationReferences[(offset + 16)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 18)].Name != "BanderaRandom") 
                            || (locationReferences[(offset + 18)].Type != typeof(int)))) {
                    return false;
                }
                return PreTraining_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class PreTraining_TypedDataContext2_ForReadOnly : PreTraining_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected System.Drawing.PointF Cruz;
            
            protected System.Drawing.PointF Coordenadas;
            
            protected int TotalBanderas;
            
            protected int Continuar;
            
            protected int Cercania;
            
            protected int Cursor;
            
            protected int BanderaRandom;
            
            public PreTraining_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string RtaCave {
                get {
                    return ((string)(this.GetVariableValue((10 + locationsOffset))));
                }
            }
            
            protected System.Collections.Generic.List<int> BanderasAparecidas {
                get {
                    return ((System.Collections.Generic.List<int>)(this.GetVariableValue((13 + locationsOffset))));
                }
            }
            
            protected System.Collections.Generic.List<System.Drawing.PointF> PosicionCruz {
                get {
                    return ((System.Collections.Generic.List<System.Drawing.PointF>)(this.GetVariableValue((17 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            protected override void GetValueTypeValues() {
                this.Cruz = ((System.Drawing.PointF)(this.GetVariableValue((9 + locationsOffset))));
                this.Coordenadas = ((System.Drawing.PointF)(this.GetVariableValue((11 + locationsOffset))));
                this.TotalBanderas = ((int)(this.GetVariableValue((12 + locationsOffset))));
                this.Continuar = ((int)(this.GetVariableValue((14 + locationsOffset))));
                this.Cercania = ((int)(this.GetVariableValue((15 + locationsOffset))));
                this.Cursor = ((int)(this.GetVariableValue((16 + locationsOffset))));
                this.BanderaRandom = ((int)(this.GetVariableValue((18 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 19))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 19);
                }
                expectedLocationsCount = 19;
                if (((locationReferences[(offset + 10)].Name != "RtaCave") 
                            || (locationReferences[(offset + 10)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 13)].Name != "BanderasAparecidas") 
                            || (locationReferences[(offset + 13)].Type != typeof(System.Collections.Generic.List<int>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 17)].Name != "PosicionCruz") 
                            || (locationReferences[(offset + 17)].Type != typeof(System.Collections.Generic.List<System.Drawing.PointF>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "Cruz") 
                            || (locationReferences[(offset + 9)].Type != typeof(System.Drawing.PointF)))) {
                    return false;
                }
                if (((locationReferences[(offset + 11)].Name != "Coordenadas") 
                            || (locationReferences[(offset + 11)].Type != typeof(System.Drawing.PointF)))) {
                    return false;
                }
                if (((locationReferences[(offset + 12)].Name != "TotalBanderas") 
                            || (locationReferences[(offset + 12)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 14)].Name != "Continuar") 
                            || (locationReferences[(offset + 14)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 15)].Name != "Cercania") 
                            || (locationReferences[(offset + 15)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 16)].Name != "Cursor") 
                            || (locationReferences[(offset + 16)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 18)].Name != "BanderaRandom") 
                            || (locationReferences[(offset + 18)].Type != typeof(int)))) {
                    return false;
                }
                return PreTraining_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class PreTraining_TypedDataContext3 : PreTraining_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public PreTraining_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext3(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr1GetTree() {
                
                #line 64 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<string>>> expression = () => 
                  Archivo;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<string> @__Expr1Get() {
                
                #line 64 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                  Archivo;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<string> ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr1Set(System.Collections.Generic.List<string> value) {
                
                #line 64 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                  Archivo = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr1Set(System.Collections.Generic.List<string> value) {
                this.GetValueTypeValues();
                this.@__Expr1Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 76 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                  Cercania;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr2Get() {
                
                #line 76 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                  Cercania;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr2Set(int value) {
                
                #line 76 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                  Cercania = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr2Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr2Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 86 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                  Continuar;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr3Get() {
                
                #line 86 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                  Continuar;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr3Set(int value) {
                
                #line 86 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                  Continuar = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr3Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr3Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 96 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                  Cruz;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr5Get() {
                
                #line 96 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                  Cruz;
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr5Set(System.Drawing.PointF value) {
                
                #line 96 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                  Cruz = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr5Set(System.Drawing.PointF value) {
                this.GetValueTypeValues();
                this.@__Expr5Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 108 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<System.Drawing.PointF>>> expression = () => 
                  PosicionCruz;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<System.Drawing.PointF> @__Expr7Get() {
                
                #line 108 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                  PosicionCruz;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<System.Drawing.PointF> ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr7Set(System.Collections.Generic.List<System.Drawing.PointF> value) {
                
                #line 108 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                  PosicionCruz = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr7Set(System.Collections.Generic.List<System.Drawing.PointF> value) {
                this.GetValueTypeValues();
                this.@__Expr7Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 120 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                  TotalBanderas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr9Get() {
                
                #line 120 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                  TotalBanderas;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr9Set(int value) {
                
                #line 120 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                  TotalBanderas = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr9Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr9Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 132 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<int>>> expression = () => 
                  BanderasAparecidas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<int> @__Expr11Get() {
                
                #line 132 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                  BanderasAparecidas;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<int> ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr11Set(System.Collections.Generic.List<int> value) {
                
                #line 132 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                  BanderasAparecidas = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr11Set(System.Collections.Generic.List<int> value) {
                this.GetValueTypeValues();
                this.@__Expr11Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 150 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                      RtaCave;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr12Get() {
                
                #line 150 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                      RtaCave;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr12Set(string value) {
                
                #line 150 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                      RtaCave = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr12Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr12Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 157 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                      Coordenadas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr14Get() {
                
                #line 157 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                      Coordenadas;
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr14Set(System.Drawing.PointF value) {
                
                #line 157 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                      Coordenadas = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr14Set(System.Drawing.PointF value) {
                this.GetValueTypeValues();
                this.@__Expr14Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 19))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 19);
                }
                expectedLocationsCount = 19;
                return PreTraining_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class PreTraining_TypedDataContext3_ForReadOnly : PreTraining_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public PreTraining_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr0GetTree() {
                
                #line 69 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<string>>> expression = () => 
                  new List<string>();;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<string> @__Expr0Get() {
                
                #line 69 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                  new List<string>();;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<string> ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 101 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                  new PointF(0,0);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr4Get() {
                
                #line 101 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                  new PointF(0,0);
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 113 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<System.Drawing.PointF>>> expression = () => 
                  new List<PointF>();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<System.Drawing.PointF> @__Expr6Get() {
                
                #line 113 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                  new List<PointF>();
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<System.Drawing.PointF> ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 125 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                  360/Separacion;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr8Get() {
                
                #line 125 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                  360/Separacion;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 137 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<int>>> expression = () => 
                  new List<Int32>();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<int> @__Expr10Get() {
                
                #line 137 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                  new List<Int32>();
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<int> ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 162 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                      new PointF(Single.Parse(RtaCave.Split(';')[0].Replace(".", ",")), Single.Parse(RtaCave.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr13Get() {
                
                #line 162 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                      new PointF(Single.Parse(RtaCave.Split(';')[0].Replace(".", ",")), Single.Parse(RtaCave.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr15GetTree() {
                
                #line 877 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                    Agregar180;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr15Get() {
                
                #line 877 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                    Agregar180;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr15Get() {
                this.GetValueTypeValues();
                return this.@__Expr15Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr16GetTree() {
                
                #line 882 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                    "L{ \"id\":\""+Escenario+"\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr16Get() {
                
                #line 882 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                    "L{ \"id\":\""+Escenario+"\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr16Get() {
                this.GetValueTypeValues();
                return this.@__Expr16Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 19))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 19);
                }
                expectedLocationsCount = 19;
                return PreTraining_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class PreTraining_TypedDataContext4 : PreTraining_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public PreTraining_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext4(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr23GetTree() {
                
                #line 220 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                              RtaCave;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr23Get() {
                
                #line 220 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                              RtaCave;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr23Get() {
                this.GetValueTypeValues();
                return this.@__Expr23Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr23Set(string value) {
                
                #line 220 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                              RtaCave = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr23Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr23Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr25GetTree() {
                
                #line 227 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                              Coordenadas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr25Get() {
                
                #line 227 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                              Coordenadas;
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr25Get() {
                this.GetValueTypeValues();
                return this.@__Expr25Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr25Set(System.Drawing.PointF value) {
                
                #line 227 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                              Coordenadas = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr25Set(System.Drawing.PointF value) {
                this.GetValueTypeValues();
                this.@__Expr25Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 19))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 19);
                }
                expectedLocationsCount = 19;
                return PreTraining_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class PreTraining_TypedDataContext4_ForReadOnly : PreTraining_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public PreTraining_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr17GetTree() {
                
                #line 181 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                        Archivo;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr17Get() {
                
                #line 181 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                        Archivo;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr17Get() {
                this.GetValueTypeValues();
                return this.@__Expr17Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr18GetTree() {
                
                #line 175 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                          DateTime.Now.ToString()+";"+
                Coordenadas.X+";"+Coordenadas.Y
                +";NULL;NULL;NULL;DET";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr18Get() {
                
                #line 175 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                          DateTime.Now.ToString()+";"+
                Coordenadas.X+";"+Coordenadas.Y
                +";NULL;NULL;NULL;DET";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr18Get() {
                this.GetValueTypeValues();
                return this.@__Expr18Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr19GetTree() {
                
                #line 186 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                        DateTime.Now.ToString() + ";" +
                Coordenadas.X + ";" + Coordenadas.Y+ ";NULL;NULL;NULL;DET";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr19Get() {
                
                #line 186 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                        DateTime.Now.ToString() + ";" +
                Coordenadas.X + ";" + Coordenadas.Y+ ";NULL;NULL;NULL;DET";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr19Get() {
                this.GetValueTypeValues();
                return this.@__Expr19Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr20GetTree() {
                
                #line 192 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                        "X{ \"value\":\"rojo\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr20Get() {
                
                #line 192 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                        "X{ \"value\":\"rojo\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr20Get() {
                this.GetValueTypeValues();
                return this.@__Expr20Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr21GetTree() {
                
                #line 198 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.TimeSpan>> expression = () => 
                        TimeSpan.FromSeconds(2);;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.TimeSpan @__Expr21Get() {
                
                #line 198 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                        TimeSpan.FromSeconds(2);;
                
                #line default
                #line hidden
            }
            
            public System.TimeSpan ValueType___Expr21Get() {
                this.GetValueTypeValues();
                return this.@__Expr21Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr22GetTree() {
                
                #line 204 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                        "X{ \"value\":\"negro\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr22Get() {
                
                #line 204 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                        "X{ \"value\":\"negro\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr22Get() {
                this.GetValueTypeValues();
                return this.@__Expr22Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr24GetTree() {
                
                #line 232 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                              new PointF(Single.Parse(RtaCave.Split(';')[0].Replace(".", ",")), Single.Parse(RtaCave.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr24Get() {
                
                #line 232 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                              new PointF(Single.Parse(RtaCave.Split(';')[0].Replace(".", ",")), Single.Parse(RtaCave.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr24Get() {
                this.GetValueTypeValues();
                return this.@__Expr24Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr26GetTree() {
                
                #line 862 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      Continuar>0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr26Get() {
                
                #line 862 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                      Continuar>0;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr26Get() {
                this.GetValueTypeValues();
                return this.@__Expr26Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr35GetTree() {
                
                #line 867 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      Continuar<0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr35Get() {
                
                #line 867 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                      Continuar<0;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr35Get() {
                this.GetValueTypeValues();
                return this.@__Expr35Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 19))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 19);
                }
                expectedLocationsCount = 19;
                return PreTraining_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class PreTraining_TypedDataContext5 : PreTraining_TypedDataContext4 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public PreTraining_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext5(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.Random Random {
                get {
                    return ((System.Random)(this.GetVariableValue((19 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((19 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr28GetTree() {
                
                #line 816 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Random>> expression = () => 
                              Random;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Random @__Expr28Get() {
                
                #line 816 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                              Random;
                
                #line default
                #line hidden
            }
            
            public System.Random ValueType___Expr28Get() {
                this.GetValueTypeValues();
                return this.@__Expr28Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr28Set(System.Random value) {
                
                #line 816 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                              Random = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr28Set(System.Random value) {
                this.GetValueTypeValues();
                this.@__Expr28Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr30GetTree() {
                
                #line 828 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                              BanderaRandom;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr30Get() {
                
                #line 828 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                              BanderaRandom;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr30Get() {
                this.GetValueTypeValues();
                return this.@__Expr30Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr30Set(int value) {
                
                #line 828 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                              BanderaRandom = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr30Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr30Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr32GetTree() {
                
                #line 844 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                BanderaRandom;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr32Get() {
                
                #line 844 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                BanderaRandom;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr32Get() {
                this.GetValueTypeValues();
                return this.@__Expr32Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr32Set(int value) {
                
                #line 844 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                BanderaRandom = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr32Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr32Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 20))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 20);
                }
                expectedLocationsCount = 20;
                if (((locationReferences[(offset + 19)].Name != "Random") 
                            || (locationReferences[(offset + 19)].Type != typeof(System.Random)))) {
                    return false;
                }
                return PreTraining_TypedDataContext4.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class PreTraining_TypedDataContext5_ForReadOnly : PreTraining_TypedDataContext4_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public PreTraining_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.Random Random {
                get {
                    return ((System.Random)(this.GetVariableValue((19 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr27GetTree() {
                
                #line 821 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Random>> expression = () => 
                              new Random();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Random @__Expr27Get() {
                
                #line 821 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                              new Random();
                
                #line default
                #line hidden
            }
            
            public System.Random ValueType___Expr27Get() {
                this.GetValueTypeValues();
                return this.@__Expr27Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr29GetTree() {
                
                #line 833 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                              Random.Next(0,BanderasCircunferencia.Count);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr29Get() {
                
                #line 833 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                              Random.Next(0,BanderasCircunferencia.Count);
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr29Get() {
                this.GetValueTypeValues();
                return this.@__Expr29Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr31GetTree() {
                
                #line 849 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                Random.Next(0,TotalBanderas);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr31Get() {
                
                #line 849 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                Random.Next(0,TotalBanderas);
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr31Get() {
                this.GetValueTypeValues();
                return this.@__Expr31Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr33GetTree() {
                
                #line 839 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                            BanderasAparecidas.Contains(BanderaRandom);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr33Get() {
                
                #line 839 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                            BanderasAparecidas.Contains(BanderaRandom);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr33Get() {
                this.GetValueTypeValues();
                return this.@__Expr33Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr34GetTree() {
                
                #line 856 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                            "H{ \"id\":\"" + (int)(BanderaRandom) + "\", \"visible\":\"true\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr34Get() {
                
                #line 856 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                            "H{ \"id\":\"" + (int)(BanderaRandom) + "\", \"visible\":\"true\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr34Get() {
                this.GetValueTypeValues();
                return this.@__Expr34Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 20))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 20);
                }
                expectedLocationsCount = 20;
                if (((locationReferences[(offset + 19)].Name != "Random") 
                            || (locationReferences[(offset + 19)].Type != typeof(System.Random)))) {
                    return false;
                }
                return PreTraining_TypedDataContext4_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class PreTraining_TypedDataContext6 : PreTraining_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public PreTraining_TypedDataContext6(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext6(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext6(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr39GetTree() {
                
                #line 266 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                      RtaCave;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr39Get() {
                
                #line 266 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                      RtaCave;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr39Get() {
                this.GetValueTypeValues();
                return this.@__Expr39Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr39Set(string value) {
                
                #line 266 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                      RtaCave = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr39Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr39Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr41GetTree() {
                
                #line 273 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                                      Coordenadas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr41Get() {
                
                #line 273 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                      Coordenadas;
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr41Get() {
                this.GetValueTypeValues();
                return this.@__Expr41Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr41Set(System.Drawing.PointF value) {
                
                #line 273 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                      Coordenadas = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr41Set(System.Drawing.PointF value) {
                this.GetValueTypeValues();
                this.@__Expr41Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 19))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 19);
                }
                expectedLocationsCount = 19;
                return PreTraining_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class PreTraining_TypedDataContext6_ForReadOnly : PreTraining_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public PreTraining_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr36GetTree() {
                
                #line 248 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                              Archivo;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr36Get() {
                
                #line 248 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                              Archivo;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr36Get() {
                this.GetValueTypeValues();
                return this.@__Expr36Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr37GetTree() {
                
                #line 244 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                DateTime.Now.ToString()+";"+Coordenadas.X+";"+Coordenadas.Y+";"+"NULL;NULL;NULL;BUS";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr37Get() {
                
                #line 244 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                DateTime.Now.ToString()+";"+Coordenadas.X+";"+Coordenadas.Y+";"+"NULL;NULL;NULL;BUS";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr37Get() {
                this.GetValueTypeValues();
                return this.@__Expr37Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr38GetTree() {
                
                #line 255 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                              DateTime.Now.ToString() + ";" + Coordenadas.X + ";" + Coordenadas.Y + ";" + "NULL;NULL;NULL;BUS";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr38Get() {
                
                #line 255 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                              DateTime.Now.ToString() + ";" + Coordenadas.X + ";" + Coordenadas.Y + ";" + "NULL;NULL;NULL;BUS";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr38Get() {
                this.GetValueTypeValues();
                return this.@__Expr38Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr40GetTree() {
                
                #line 278 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                                      new PointF(Single.Parse(RtaCave.Split(';')[0].Replace(".", ",")), Single.Parse(RtaCave.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr40Get() {
                
                #line 278 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                      new PointF(Single.Parse(RtaCave.Split(';')[0].Replace(".", ",")), Single.Parse(RtaCave.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr40Get() {
                this.GetValueTypeValues();
                return this.@__Expr40Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr42GetTree() {
                
                #line 797 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              Math.Sqrt((Math.Pow(Coordenadas.X - BanderasCircunferencia[BanderaRandom].X, 2)) + Math.Pow(Coordenadas.Y - BanderasCircunferencia[BanderaRandom].Y, 2)) < Cercania;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr42Get() {
                
                #line 797 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                              Math.Sqrt((Math.Pow(Coordenadas.X - BanderasCircunferencia[BanderaRandom].X, 2)) + Math.Pow(Coordenadas.Y - BanderasCircunferencia[BanderaRandom].Y, 2)) < Cercania;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr42Get() {
                this.GetValueTypeValues();
                return this.@__Expr42Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr43GetTree() {
                
                #line 776 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                    "H{ \"id\":\"" + (int)(BanderaRandom) + "\", \"visible\":\"false\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr43Get() {
                
                #line 776 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                    "H{ \"id\":\"" + (int)(BanderaRandom) + "\", \"visible\":\"false\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr43Get() {
                this.GetValueTypeValues();
                return this.@__Expr43Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr44GetTree() {
                
                #line 786 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                                    Archivo;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr44Get() {
                
                #line 786 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                    Archivo;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr44Get() {
                this.GetValueTypeValues();
                return this.@__Expr44Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr45GetTree() {
                
                #line 782 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                      DateTime.Now.ToString() + ";" + Coordenadas.X + ";" + Coordenadas.Y + ";" + BanderasCircunferencia[BanderaRandom].X + ";" + BanderasCircunferencia[BanderaRandom].Y + ";" + BanderaRandom+";CAP";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr45Get() {
                
                #line 782 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                      DateTime.Now.ToString() + ";" + Coordenadas.X + ";" + Coordenadas.Y + ";" + BanderasCircunferencia[BanderaRandom].X + ";" + BanderasCircunferencia[BanderaRandom].Y + ";" + BanderaRandom+";CAP";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr45Get() {
                this.GetValueTypeValues();
                return this.@__Expr45Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr46GetTree() {
                
                #line 791 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                    DateTime.Now.ToString() + ";" + Coordenadas.X + ";" + Coordenadas.Y + ";" + BanderasCircunferencia[BanderaRandom].X + ";" + BanderasCircunferencia[BanderaRandom].Y + ";" + BanderaRandom + ";CAP";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr46Get() {
                
                #line 791 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                    DateTime.Now.ToString() + ";" + Coordenadas.X + ";" + Coordenadas.Y + ";" + BanderasCircunferencia[BanderaRandom].X + ";" + BanderasCircunferencia[BanderaRandom].Y + ";" + BanderaRandom + ";CAP";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr46Get() {
                this.GetValueTypeValues();
                return this.@__Expr46Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr47GetTree() {
                
                #line 802 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              !(Math.Sqrt((Math.Pow(Coordenadas.X - BanderasCircunferencia[BanderaRandom].X, 2)) + Math.Pow(Coordenadas.Y - BanderasCircunferencia[BanderaRandom].Y, 2)) < Cercania);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr47Get() {
                
                #line 802 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                              !(Math.Sqrt((Math.Pow(Coordenadas.X - BanderasCircunferencia[BanderaRandom].X, 2)) + Math.Pow(Coordenadas.Y - BanderasCircunferencia[BanderaRandom].Y, 2)) < Cercania);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr47Get() {
                this.GetValueTypeValues();
                return this.@__Expr47Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 19))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 19);
                }
                expectedLocationsCount = 19;
                return PreTraining_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class PreTraining_TypedDataContext7 : PreTraining_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public PreTraining_TypedDataContext7(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext7(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext7(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 19))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 19);
                }
                expectedLocationsCount = 19;
                return PreTraining_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class PreTraining_TypedDataContext7_ForReadOnly : PreTraining_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public PreTraining_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr48GetTree() {
                
                #line 371 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                "Q{ \"text\":\"Fin del experimento\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr48Get() {
                
                #line 371 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                "Q{ \"text\":\"Fin del experimento\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr48Get() {
                this.GetValueTypeValues();
                return this.@__Expr48Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr49GetTree() {
                
                #line 381 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                                                                Archivo;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr49Get() {
                
                #line 381 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                Archivo;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr49Get() {
                this.GetValueTypeValues();
                return this.@__Expr49Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr50GetTree() {
                
                #line 377 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                  DateTime.Now.ToString()+";"+Coordenadas.X+";"+Coordenadas.Y+";"+"NULL;NULL;NULL;FIN";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr50Get() {
                
                #line 377 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                  DateTime.Now.ToString()+";"+Coordenadas.X+";"+Coordenadas.Y+";"+"NULL;NULL;NULL;FIN";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr50Get() {
                this.GetValueTypeValues();
                return this.@__Expr50Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr51GetTree() {
                
                #line 386 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                DateTime.Now.ToString() + ";" + Coordenadas.X + ";" + Coordenadas.Y + ";" + "NULL;NULL;NULL;FIN";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr51Get() {
                
                #line 386 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                DateTime.Now.ToString() + ";" + Coordenadas.X + ";" + Coordenadas.Y + ";" + "NULL;NULL;NULL;FIN";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr51Get() {
                this.GetValueTypeValues();
                return this.@__Expr51Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr52GetTree() {
                
                #line 391 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.TimeSpan>> expression = () => 
                                                                TimeSpan.FromSeconds(5);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.TimeSpan @__Expr52Get() {
                
                #line 391 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                TimeSpan.FromSeconds(5);
                
                #line default
                #line hidden
            }
            
            public System.TimeSpan ValueType___Expr52Get() {
                this.GetValueTypeValues();
                return this.@__Expr52Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 19))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 19);
                }
                expectedLocationsCount = 19;
                return PreTraining_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class PreTraining_TypedDataContext8 : PreTraining_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public PreTraining_TypedDataContext8(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext8(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext8(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr54GetTree() {
                
                #line 346 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                      RtaCave;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr54Get() {
                
                #line 346 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                      RtaCave;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr54Get() {
                this.GetValueTypeValues();
                return this.@__Expr54Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr54Set(string value) {
                
                #line 346 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                                      RtaCave = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr54Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr54Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr86GetTree() {
                
                #line 680 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                            Cursor;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr86Get() {
                
                #line 680 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                            Cursor;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr86Get() {
                this.GetValueTypeValues();
                return this.@__Expr86Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr86Set(int value) {
                
                #line 680 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                                            Cursor = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr86Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr86Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr89GetTree() {
                
                #line 699 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                Cursor;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr89Get() {
                
                #line 699 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                Cursor;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr89Get() {
                this.GetValueTypeValues();
                return this.@__Expr89Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr89Set(int value) {
                
                #line 699 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                                                Cursor = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr89Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr89Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr91GetTree() {
                
                #line 716 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                          Cursor;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr91Get() {
                
                #line 716 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                          Cursor;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr91Get() {
                this.GetValueTypeValues();
                return this.@__Expr91Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr91Set(int value) {
                
                #line 716 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                                          Cursor = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr91Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr91Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 19))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 19);
                }
                expectedLocationsCount = 19;
                return PreTraining_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class PreTraining_TypedDataContext8_ForReadOnly : PreTraining_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public PreTraining_TypedDataContext8_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext8_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext8_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr53GetTree() {
                
                #line 335 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                              "C{ \"id\":\"" + (int)(Cursor) + "\", \"color\":\"" + ColorSeleccion + "\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr53Get() {
                
                #line 335 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                              "C{ \"id\":\"" + (int)(Cursor) + "\", \"color\":\"" + ColorSeleccion + "\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr53Get() {
                this.GetValueTypeValues();
                return this.@__Expr53Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr55GetTree() {
                
                #line 658 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                              RtaCave.Equals("2");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr55Get() {
                
                #line 658 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                              RtaCave.Equals("2");
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr55Get() {
                this.GetValueTypeValues();
                return this.@__Expr55Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr56GetTree() {
                
                #line 504 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                                                    Archivo;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr56Get() {
                
                #line 504 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                    Archivo;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr56Get() {
                this.GetValueTypeValues();
                return this.@__Expr56Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr57GetTree() {
                
                #line 500 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                      DateTime.Now.ToString() + ";" + Coordenadas.X + ";" + Coordenadas.Y + ";" + BanderasCircunferencia.ElementAt(Cursor).X + ";" + BanderasCircunferencia.ElementAt(Cursor).Y + ";" + Cursor + ";SEL";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr57Get() {
                
                #line 500 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                      DateTime.Now.ToString() + ";" + Coordenadas.X + ";" + Coordenadas.Y + ";" + BanderasCircunferencia.ElementAt(Cursor).X + ";" + BanderasCircunferencia.ElementAt(Cursor).Y + ";" + Cursor + ";SEL";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr57Get() {
                this.GetValueTypeValues();
                return this.@__Expr57Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr58GetTree() {
                
                #line 509 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    DateTime.Now.ToString() + ";" + Coordenadas.X + ";" + Coordenadas.Y + ";" + BanderasCircunferencia.ElementAt(Cursor).X + ";" + BanderasCircunferencia.ElementAt(Cursor).Y + ";" + Cursor + ";SEL";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr58Get() {
                
                #line 509 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                    DateTime.Now.ToString() + ";" + Coordenadas.X + ";" + Coordenadas.Y + ";" + BanderasCircunferencia.ElementAt(Cursor).X + ";" + BanderasCircunferencia.ElementAt(Cursor).Y + ";" + Cursor + ";SEL";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr58Get() {
                this.GetValueTypeValues();
                return this.@__Expr58Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr59GetTree() {
                
                #line 514 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    "Eligió la: "+Cursor;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr59Get() {
                
                #line 514 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                    "Eligió la: "+Cursor;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr59Get() {
                this.GetValueTypeValues();
                return this.@__Expr59Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr60GetTree() {
                
                #line 519 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    "C{ \"id\":\"" + (int)(Cursor) + "\", \"color\":\"" + ColorBandera + "\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr60Get() {
                
                #line 519 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                    "C{ \"id\":\"" + (int)(Cursor) + "\", \"color\":\"" + ColorBandera + "\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr60Get() {
                this.GetValueTypeValues();
                return this.@__Expr60Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr61GetTree() {
                
                #line 524 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    Mostrar180.Replace("true", "false");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr61Get() {
                
                #line 524 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                    Mostrar180.Replace("true", "false");
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr61Get() {
                this.GetValueTypeValues();
                return this.@__Expr61Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr81GetTree() {
                
                #line 652 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    "Q{ \"text\":\"Terminar Experimento?\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr81Get() {
                
                #line 652 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                    "Q{ \"text\":\"Terminar Experimento?\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr81Get() {
                this.GetValueTypeValues();
                return this.@__Expr81Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr82GetTree() {
                
                #line 730 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                              RtaCave.Equals("1") || RtaCave.Equals("3");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr82Get() {
                
                #line 730 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                              RtaCave.Equals("1") || RtaCave.Equals("3");
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr82Get() {
                this.GetValueTypeValues();
                return this.@__Expr82Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr83GetTree() {
                
                #line 666 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    "C{ \"id\":\"" + (int)(Cursor) + "\", \"color\":\"" + ColorBandera + "\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr83Get() {
                
                #line 666 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                    "C{ \"id\":\"" + (int)(Cursor) + "\", \"color\":\"" + ColorBandera + "\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr83Get() {
                this.GetValueTypeValues();
                return this.@__Expr83Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr84GetTree() {
                
                #line 672 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                      RtaCave.Equals("1");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr84Get() {
                
                #line 672 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                      RtaCave.Equals("1");
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr84Get() {
                this.GetValueTypeValues();
                return this.@__Expr84Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr85GetTree() {
                
                #line 685 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                            (Cursor - 1) % BanderasCircunferencia.Count;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr85Get() {
                
                #line 685 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                            (Cursor - 1) % BanderasCircunferencia.Count;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr85Get() {
                this.GetValueTypeValues();
                return this.@__Expr85Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr87GetTree() {
                
                #line 692 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                            Cursor<0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr87Get() {
                
                #line 692 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                            Cursor<0;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr87Get() {
                this.GetValueTypeValues();
                return this.@__Expr87Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr88GetTree() {
                
                #line 704 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                BanderasCircunferencia.Count-1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr88Get() {
                
                #line 704 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                BanderasCircunferencia.Count-1;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr88Get() {
                this.GetValueTypeValues();
                return this.@__Expr88Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr90GetTree() {
                
                #line 721 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                          (Cursor + 1) % BanderasCircunferencia.Count;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr90Get() {
                
                #line 721 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                          (Cursor + 1) % BanderasCircunferencia.Count;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr90Get() {
                this.GetValueTypeValues();
                return this.@__Expr90Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 19))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 19);
                }
                expectedLocationsCount = 19;
                return PreTraining_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class PreTraining_TypedDataContext9 : PreTraining_TypedDataContext8 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int CruzX;
            
            protected int CruzY;
            
            public PreTraining_TypedDataContext9(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext9(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext9(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.Random RandomX {
                get {
                    return ((System.Random)(this.GetVariableValue((19 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((19 + locationsOffset), value);
                }
            }
            
            protected System.Random RandomY {
                get {
                    return ((System.Random)(this.GetVariableValue((20 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((20 + locationsOffset), value);
                }
            }
            
            protected string variable2 {
                get {
                    return ((string)(this.GetVariableValue((21 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((21 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr63GetTree() {
                
                #line 539 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Random>> expression = () => 
                                                        RandomX;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Random @__Expr63Get() {
                
                #line 539 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                        RandomX;
                
                #line default
                #line hidden
            }
            
            public System.Random ValueType___Expr63Get() {
                this.GetValueTypeValues();
                return this.@__Expr63Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr63Set(System.Random value) {
                
                #line 539 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                                        RandomX = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr63Set(System.Random value) {
                this.GetValueTypeValues();
                this.@__Expr63Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr65GetTree() {
                
                #line 551 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Random>> expression = () => 
                                                        RandomY;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Random @__Expr65Get() {
                
                #line 551 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                        RandomY;
                
                #line default
                #line hidden
            }
            
            public System.Random ValueType___Expr65Get() {
                this.GetValueTypeValues();
                return this.@__Expr65Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr65Set(System.Random value) {
                
                #line 551 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                                        RandomY = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr65Set(System.Random value) {
                this.GetValueTypeValues();
                this.@__Expr65Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr67GetTree() {
                
                #line 563 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                        CruzX;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr67Get() {
                
                #line 563 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                        CruzX;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr67Get() {
                this.GetValueTypeValues();
                return this.@__Expr67Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr67Set(int value) {
                
                #line 563 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                                        CruzX = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr67Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr67Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr69GetTree() {
                
                #line 575 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                        CruzY;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr69Get() {
                
                #line 575 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                        CruzY;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr69Get() {
                this.GetValueTypeValues();
                return this.@__Expr69Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr69Set(int value) {
                
                #line 575 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                                        CruzY = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr69Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr69Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr71GetTree() {
                
                #line 592 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                            CruzX;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr71Get() {
                
                #line 592 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                            CruzX;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr71Get() {
                this.GetValueTypeValues();
                return this.@__Expr71Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr71Set(int value) {
                
                #line 592 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                                            CruzX = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr71Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr71Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr73GetTree() {
                
                #line 604 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                            CruzY;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr73Get() {
                
                #line 604 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                            CruzY;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr73Get() {
                this.GetValueTypeValues();
                return this.@__Expr73Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr73Set(int value) {
                
                #line 604 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                                            CruzY = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr73Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr73Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr78GetTree() {
                
                #line 628 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<float>> expression = () => 
                                                        Cruz.X;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public float @__Expr78Get() {
                
                #line 628 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                        Cruz.X;
                
                #line default
                #line hidden
            }
            
            public float ValueType___Expr78Get() {
                this.GetValueTypeValues();
                return this.@__Expr78Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr78Set(float value) {
                
                #line 628 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                                        Cruz.X = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr78Set(float value) {
                this.GetValueTypeValues();
                this.@__Expr78Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr80GetTree() {
                
                #line 640 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<float>> expression = () => 
                                                        Cruz.Y;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public float @__Expr80Get() {
                
                #line 640 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                        Cruz.Y;
                
                #line default
                #line hidden
            }
            
            public float ValueType___Expr80Get() {
                this.GetValueTypeValues();
                return this.@__Expr80Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr80Set(float value) {
                
                #line 640 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                                        Cruz.Y = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr80Set(float value) {
                this.GetValueTypeValues();
                this.@__Expr80Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.CruzX = ((int)(this.GetVariableValue((22 + locationsOffset))));
                this.CruzY = ((int)(this.GetVariableValue((23 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((22 + locationsOffset), this.CruzX);
                this.SetVariableValue((23 + locationsOffset), this.CruzY);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 24))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 24);
                }
                expectedLocationsCount = 24;
                if (((locationReferences[(offset + 19)].Name != "RandomX") 
                            || (locationReferences[(offset + 19)].Type != typeof(System.Random)))) {
                    return false;
                }
                if (((locationReferences[(offset + 20)].Name != "RandomY") 
                            || (locationReferences[(offset + 20)].Type != typeof(System.Random)))) {
                    return false;
                }
                if (((locationReferences[(offset + 21)].Name != "variable2") 
                            || (locationReferences[(offset + 21)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 22)].Name != "CruzX") 
                            || (locationReferences[(offset + 22)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 23)].Name != "CruzY") 
                            || (locationReferences[(offset + 23)].Type != typeof(int)))) {
                    return false;
                }
                return PreTraining_TypedDataContext8.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class PreTraining_TypedDataContext9_ForReadOnly : PreTraining_TypedDataContext8_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int CruzX;
            
            protected int CruzY;
            
            public PreTraining_TypedDataContext9_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext9_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext9_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.Random RandomX {
                get {
                    return ((System.Random)(this.GetVariableValue((19 + locationsOffset))));
                }
            }
            
            protected System.Random RandomY {
                get {
                    return ((System.Random)(this.GetVariableValue((20 + locationsOffset))));
                }
            }
            
            protected string variable2 {
                get {
                    return ((string)(this.GetVariableValue((21 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr62GetTree() {
                
                #line 544 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Random>> expression = () => 
                                                        new Random();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Random @__Expr62Get() {
                
                #line 544 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                        new Random();
                
                #line default
                #line hidden
            }
            
            public System.Random ValueType___Expr62Get() {
                this.GetValueTypeValues();
                return this.@__Expr62Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr64GetTree() {
                
                #line 556 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Random>> expression = () => 
                                                        new Random();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Random @__Expr64Get() {
                
                #line 556 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                        new Random();
                
                #line default
                #line hidden
            }
            
            public System.Random ValueType___Expr64Get() {
                this.GetValueTypeValues();
                return this.@__Expr64Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr66GetTree() {
                
                #line 568 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                        RandomX.Next(-13,13);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr66Get() {
                
                #line 568 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                        RandomX.Next(-13,13);
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr66Get() {
                this.GetValueTypeValues();
                return this.@__Expr66Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr68GetTree() {
                
                #line 580 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                        RandomY.Next(-13, 13);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr68Get() {
                
                #line 580 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                        RandomY.Next(-13, 13);
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr68Get() {
                this.GetValueTypeValues();
                return this.@__Expr68Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr70GetTree() {
                
                #line 597 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                            RandomX.Next(-13,13);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr70Get() {
                
                #line 597 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                            RandomX.Next(-13,13);
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr70Get() {
                this.GetValueTypeValues();
                return this.@__Expr70Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr72GetTree() {
                
                #line 609 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                            RandomY.Next(-13,13);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr72Get() {
                
                #line 609 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                            RandomY.Next(-13,13);
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr72Get() {
                this.GetValueTypeValues();
                return this.@__Expr72Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr74GetTree() {
                
                #line 586 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                      (Math.Sqrt(Math.Pow(Cruz.X-CruzX,2)+Math.Pow(Cruz.Y-CruzY,2))<Cercania) || (PosicionCruz.Contains(new PointF(CruzX,CruzY)));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr74Get() {
                
                #line 586 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                      (Math.Sqrt(Math.Pow(Cruz.X-CruzX,2)+Math.Pow(Cruz.Y-CruzY,2))<Cercania) || (PosicionCruz.Contains(new PointF(CruzX,CruzY)));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr74Get() {
                this.GetValueTypeValues();
                return this.@__Expr74Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr75GetTree() {
                
                #line 622 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<System.Drawing.PointF>>> expression = () => 
                                                      PosicionCruz;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<System.Drawing.PointF> @__Expr75Get() {
                
                #line 622 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                      PosicionCruz;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<System.Drawing.PointF> ValueType___Expr75Get() {
                this.GetValueTypeValues();
                return this.@__Expr75Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr76GetTree() {
                
                #line 618 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                                                        Cruz;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr76Get() {
                
                #line 618 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                        Cruz;
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr76Get() {
                this.GetValueTypeValues();
                return this.@__Expr76Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr77GetTree() {
                
                #line 633 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<float>> expression = () => 
                                                        CruzX;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public float @__Expr77Get() {
                
                #line 633 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                        CruzX;
                
                #line default
                #line hidden
            }
            
            public float ValueType___Expr77Get() {
                this.GetValueTypeValues();
                return this.@__Expr77Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr79GetTree() {
                
                #line 645 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<float>> expression = () => 
                                                        CruzY;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public float @__Expr79Get() {
                
                #line 645 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                        CruzY;
                
                #line default
                #line hidden
            }
            
            public float ValueType___Expr79Get() {
                this.GetValueTypeValues();
                return this.@__Expr79Get();
            }
            
            protected override void GetValueTypeValues() {
                this.CruzX = ((int)(this.GetVariableValue((22 + locationsOffset))));
                this.CruzY = ((int)(this.GetVariableValue((23 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 24))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 24);
                }
                expectedLocationsCount = 24;
                if (((locationReferences[(offset + 19)].Name != "RandomX") 
                            || (locationReferences[(offset + 19)].Type != typeof(System.Random)))) {
                    return false;
                }
                if (((locationReferences[(offset + 20)].Name != "RandomY") 
                            || (locationReferences[(offset + 20)].Type != typeof(System.Random)))) {
                    return false;
                }
                if (((locationReferences[(offset + 21)].Name != "variable2") 
                            || (locationReferences[(offset + 21)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 22)].Name != "CruzX") 
                            || (locationReferences[(offset + 22)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 23)].Name != "CruzY") 
                            || (locationReferences[(offset + 23)].Type != typeof(int)))) {
                    return false;
                }
                return PreTraining_TypedDataContext8_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class PreTraining_TypedDataContext10 : PreTraining_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public PreTraining_TypedDataContext10(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext10(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext10(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 19))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 19);
                }
                expectedLocationsCount = 19;
                return PreTraining_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class PreTraining_TypedDataContext10_ForReadOnly : PreTraining_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public PreTraining_TypedDataContext10_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext10_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext10_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 19))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 19);
                }
                expectedLocationsCount = 19;
                return PreTraining_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class PreTraining_TypedDataContext11 : PreTraining_TypedDataContext10 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int CruzX;
            
            protected int CruzY;
            
            public PreTraining_TypedDataContext11(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext11(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext11(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string variable1 {
                get {
                    return ((string)(this.GetVariableValue((19 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((19 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr92GetTree() {
                
                #line 360 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                            RtaCave;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr92Get() {
                
                #line 360 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                            RtaCave;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr92Get() {
                this.GetValueTypeValues();
                return this.@__Expr92Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr92Set(string value) {
                
                #line 360 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                                            RtaCave = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr92Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr92Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.CruzX = ((int)(this.GetVariableValue((20 + locationsOffset))));
                this.CruzY = ((int)(this.GetVariableValue((21 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((20 + locationsOffset), this.CruzX);
                this.SetVariableValue((21 + locationsOffset), this.CruzY);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 22))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 22);
                }
                expectedLocationsCount = 22;
                if (((locationReferences[(offset + 19)].Name != "variable1") 
                            || (locationReferences[(offset + 19)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 20)].Name != "CruzX") 
                            || (locationReferences[(offset + 20)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 21)].Name != "CruzY") 
                            || (locationReferences[(offset + 21)].Type != typeof(int)))) {
                    return false;
                }
                return PreTraining_TypedDataContext10.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class PreTraining_TypedDataContext11_ForReadOnly : PreTraining_TypedDataContext10_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int CruzX;
            
            protected int CruzY;
            
            public PreTraining_TypedDataContext11_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext11_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext11_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string variable1 {
                get {
                    return ((string)(this.GetVariableValue((19 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr93GetTree() {
                
                #line 403 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                      RtaCave.Equals("2");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr93Get() {
                
                #line 403 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                      RtaCave.Equals("2");
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr93Get() {
                this.GetValueTypeValues();
                return this.@__Expr93Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr94GetTree() {
                
                #line 408 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                      !RtaCave.Equals("1") && !RtaCave.Equals("2");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr94Get() {
                
                #line 408 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                      !RtaCave.Equals("1") && !RtaCave.Equals("2");
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr94Get() {
                this.GetValueTypeValues();
                return this.@__Expr94Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr95GetTree() {
                
                #line 484 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                      RtaCave.Equals("1");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr95Get() {
                
                #line 484 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                      RtaCave.Equals("1");
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr95Get() {
                this.GetValueTypeValues();
                return this.@__Expr95Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr96GetTree() {
                
                #line 478 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                            "M{ \"x\":\""+Cruz.X+"\", \"y\":\""+Cruz.Y+"\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr96Get() {
                
                #line 478 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                            "M{ \"x\":\""+Cruz.X+"\", \"y\":\""+Cruz.Y+"\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr96Get() {
                this.GetValueTypeValues();
                return this.@__Expr96Get();
            }
            
            protected override void GetValueTypeValues() {
                this.CruzX = ((int)(this.GetVariableValue((20 + locationsOffset))));
                this.CruzY = ((int)(this.GetVariableValue((21 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 22))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 22);
                }
                expectedLocationsCount = 22;
                if (((locationReferences[(offset + 19)].Name != "variable1") 
                            || (locationReferences[(offset + 19)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 20)].Name != "CruzX") 
                            || (locationReferences[(offset + 20)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 21)].Name != "CruzY") 
                            || (locationReferences[(offset + 21)].Type != typeof(int)))) {
                    return false;
                }
                return PreTraining_TypedDataContext10_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class PreTraining_TypedDataContext12 : PreTraining_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public PreTraining_TypedDataContext12(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext12(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext12(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr100GetTree() {
                
                #line 312 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                              RtaCave;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr100Get() {
                
                #line 312 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                              RtaCave;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr100Get() {
                this.GetValueTypeValues();
                return this.@__Expr100Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr100Set(string value) {
                
                #line 312 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                              RtaCave = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr100Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr100Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr102GetTree() {
                
                #line 319 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                                              Coordenadas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr102Get() {
                
                #line 319 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                              Coordenadas;
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr102Get() {
                this.GetValueTypeValues();
                return this.@__Expr102Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr102Set(System.Drawing.PointF value) {
                
                #line 319 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                              Coordenadas = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr102Set(System.Drawing.PointF value) {
                this.GetValueTypeValues();
                this.@__Expr102Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr104GetTree() {
                
                #line 741 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                              Cursor;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr104Get() {
                
                #line 741 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                              Cursor;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr104Get() {
                this.GetValueTypeValues();
                return this.@__Expr104Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr104Set(int value) {
                
                #line 741 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                              Cursor = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr104Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr104Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 19))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 19);
                }
                expectedLocationsCount = 19;
                return PreTraining_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class PreTraining_TypedDataContext12_ForReadOnly : PreTraining_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public PreTraining_TypedDataContext12_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext12_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext12_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr97GetTree() {
                
                #line 294 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                                      Archivo;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr97Get() {
                
                #line 294 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                      Archivo;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr97Get() {
                this.GetValueTypeValues();
                return this.@__Expr97Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr98GetTree() {
                
                #line 290 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                        DateTime.Now.ToString()+";"+Coordenadas.X+";"+Coordenadas.Y+";"+"NULL;NULL;NULL;CEN";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr98Get() {
                
                #line 290 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                        DateTime.Now.ToString()+";"+Coordenadas.X+";"+Coordenadas.Y+";"+"NULL;NULL;NULL;CEN";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr98Get() {
                this.GetValueTypeValues();
                return this.@__Expr98Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr99GetTree() {
                
                #line 301 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                      DateTime.Now.ToString() + ";" + Coordenadas.X + ";" + Coordenadas.Y + ";" + "NULL;NULL;NULL;CEN";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr99Get() {
                
                #line 301 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                      DateTime.Now.ToString() + ";" + Coordenadas.X + ";" + Coordenadas.Y + ";" + "NULL;NULL;NULL;CEN";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr99Get() {
                this.GetValueTypeValues();
                return this.@__Expr99Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr101GetTree() {
                
                #line 324 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                                              new PointF(Single.Parse(RtaCave.Split(';')[0].Replace(".", ",")), Single.Parse(RtaCave.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr101Get() {
                
                #line 324 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                              new PointF(Single.Parse(RtaCave.Split(';')[0].Replace(".", ",")), Single.Parse(RtaCave.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr101Get() {
                this.GetValueTypeValues();
                return this.@__Expr101Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr103GetTree() {
                
                #line 761 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                      Math.Sqrt((Math.Pow(Coordenadas.X - Cruz.X, 2)) + Math.Pow(Coordenadas.Y - Cruz.Y, 2)) < Cercania;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr103Get() {
                
                #line 761 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                      Math.Sqrt((Math.Pow(Coordenadas.X - Cruz.X, 2)) + Math.Pow(Coordenadas.Y - Cruz.Y, 2)) < Cercania;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr103Get() {
                this.GetValueTypeValues();
                return this.@__Expr103Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr105GetTree() {
                
                #line 750 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                            "Q{ \"text\":\"Marca la bandera que recolectaste.\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr105Get() {
                
                #line 750 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                            "Q{ \"text\":\"Marca la bandera que recolectaste.\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr105Get() {
                this.GetValueTypeValues();
                return this.@__Expr105Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr106GetTree() {
                
                #line 755 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                            Mostrar180;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr106Get() {
                
                #line 755 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                            Mostrar180;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr106Get() {
                this.GetValueTypeValues();
                return this.@__Expr106Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr107GetTree() {
                
                #line 766 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                      !(Math.Sqrt((Math.Pow(Coordenadas.X - Cruz.X, 2)) + Math.Pow(Coordenadas.Y - Cruz.Y, 2)) < Cercania);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr107Get() {
                
                #line 766 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                      !(Math.Sqrt((Math.Pow(Coordenadas.X - Cruz.X, 2)) + Math.Pow(Coordenadas.Y - Cruz.Y, 2)) < Cercania);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr107Get() {
                this.GetValueTypeValues();
                return this.@__Expr107Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 19))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 19);
                }
                expectedLocationsCount = 19;
                return PreTraining_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class PreTraining_TypedDataContext13 : PreTraining_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public PreTraining_TypedDataContext13(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext13(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext13(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr111GetTree() {
                
                #line 440 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                      RtaCave;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr111Get() {
                
                #line 440 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                      RtaCave;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr111Get() {
                this.GetValueTypeValues();
                return this.@__Expr111Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr111Set(string value) {
                
                #line 440 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                                                      RtaCave = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr111Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr111Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr113GetTree() {
                
                #line 447 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                                                                      Coordenadas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr113Get() {
                
                #line 447 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                      Coordenadas;
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr113Get() {
                this.GetValueTypeValues();
                return this.@__Expr113Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr113Set(System.Drawing.PointF value) {
                
                #line 447 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                                                      Coordenadas = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr113Set(System.Drawing.PointF value) {
                this.GetValueTypeValues();
                this.@__Expr113Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 19))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 19);
                }
                expectedLocationsCount = 19;
                return PreTraining_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class PreTraining_TypedDataContext13_ForReadOnly : PreTraining_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public PreTraining_TypedDataContext13_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext13_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext13_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr108GetTree() {
                
                #line 422 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                                                              Archivo;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr108Get() {
                
                #line 422 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                              Archivo;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr108Get() {
                this.GetValueTypeValues();
                return this.@__Expr108Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr109GetTree() {
                
                #line 418 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                DateTime.Now.ToString() + ";" + Coordenadas.X + ";" + Coordenadas.Y + ";" + BanderasCircunferencia.ElementAt(Cursor).X + ";" + BanderasCircunferencia.ElementAt(Cursor).Y + ";" + Cursor + ";CRUZ";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr109Get() {
                
                #line 418 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                DateTime.Now.ToString() + ";" + Coordenadas.X + ";" + Coordenadas.Y + ";" + BanderasCircunferencia.ElementAt(Cursor).X + ";" + BanderasCircunferencia.ElementAt(Cursor).Y + ";" + Cursor + ";CRUZ";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr109Get() {
                this.GetValueTypeValues();
                return this.@__Expr109Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr110GetTree() {
                
                #line 429 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                              DateTime.Now.ToString() + ";" + Coordenadas.X + ";" + Coordenadas.Y + ";" + BanderasCircunferencia.ElementAt(Cursor).X + ";" + BanderasCircunferencia.ElementAt(Cursor).Y + ";" + Cursor + ";CRUZ";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr110Get() {
                
                #line 429 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                              DateTime.Now.ToString() + ";" + Coordenadas.X + ";" + Coordenadas.Y + ";" + BanderasCircunferencia.ElementAt(Cursor).X + ";" + BanderasCircunferencia.ElementAt(Cursor).Y + ";" + Cursor + ";CRUZ";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr110Get() {
                this.GetValueTypeValues();
                return this.@__Expr110Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr112GetTree() {
                
                #line 452 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                                                                      new PointF(Single.Parse(RtaCave.Split(';')[0].Replace(".", ",")), Single.Parse(RtaCave.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr112Get() {
                
                #line 452 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                      new PointF(Single.Parse(RtaCave.Split(';')[0].Replace(".", ",")), Single.Parse(RtaCave.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr112Get() {
                this.GetValueTypeValues();
                return this.@__Expr112Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr114GetTree() {
                
                #line 462 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                              Math.Sqrt((Math.Pow(Coordenadas.X - Cruz.X, 2)) + Math.Pow(Coordenadas.Y - Cruz.Y, 2)) < Cercania;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr114Get() {
                
                #line 462 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                              Math.Sqrt((Math.Pow(Coordenadas.X - Cruz.X, 2)) + Math.Pow(Coordenadas.Y - Cruz.Y, 2)) < Cercania;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr114Get() {
                this.GetValueTypeValues();
                return this.@__Expr114Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr115GetTree() {
                
                #line 467 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                              !(Math.Sqrt((Math.Pow(Coordenadas.X - Cruz.X, 2)) + Math.Pow(Coordenadas.Y - Cruz.Y, 2)) < Cercania);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr115Get() {
                
                #line 467 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                              !(Math.Sqrt((Math.Pow(Coordenadas.X - Cruz.X, 2)) + Math.Pow(Coordenadas.Y - Cruz.Y, 2)) < Cercania);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr115Get() {
                this.GetValueTypeValues();
                return this.@__Expr115Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 19))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 19);
                }
                expectedLocationsCount = 19;
                return PreTraining_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
