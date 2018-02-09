namespace PreTraining {
    
    #line 32 "C:\Users\DellPladema\Desktop\Nueva carpeta (2)\VFinal\WFFlagCollector\FlagCollector\PreTraining\PreTraining.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\DellPladema\Desktop\Nueva carpeta (2)\VFinal\WFFlagCollector\FlagCollector\PreTraining\PreTraining.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 33 "C:\Users\DellPladema\Desktop\Nueva carpeta (2)\VFinal\WFFlagCollector\FlagCollector\PreTraining\PreTraining.xaml"
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
    
    #line 34 "C:\Users\DellPladema\Desktop\Nueva carpeta (2)\VFinal\WFFlagCollector\FlagCollector\PreTraining\PreTraining.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 35 "C:\Users\DellPladema\Desktop\Nueva carpeta (2)\VFinal\WFFlagCollector\FlagCollector\PreTraining\PreTraining.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 36 "C:\Users\DellPladema\Desktop\Nueva carpeta (2)\VFinal\WFFlagCollector\FlagCollector\PreTraining\PreTraining.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 37 "C:\Users\DellPladema\Desktop\Nueva carpeta (2)\VFinal\WFFlagCollector\FlagCollector\PreTraining\PreTraining.xaml"
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
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PreTraining_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext3_ForReadOnly valDataContext0 = ((PreTraining_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PreTraining_TypedDataContext3(locations, activityContext, true);
                }
                PreTraining_TypedDataContext3 refDataContext1 = ((PreTraining_TypedDataContext3)(cachedCompiledDataContext[1]));
                return refDataContext1.GetLocation<System.Collections.Generic.List<string>>(refDataContext1.ValueType___Expr1Get, refDataContext1.ValueType___Expr1Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PreTraining_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext3_ForReadOnly valDataContext2 = ((PreTraining_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PreTraining_TypedDataContext3(locations, activityContext, true);
                }
                PreTraining_TypedDataContext3 refDataContext3 = ((PreTraining_TypedDataContext3)(cachedCompiledDataContext[1]));
                return refDataContext3.GetLocation<System.Collections.Generic.List<string>>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PreTraining_TypedDataContext3(locations, activityContext, true);
                }
                PreTraining_TypedDataContext3 refDataContext4 = ((PreTraining_TypedDataContext3)(cachedCompiledDataContext[1]));
                return refDataContext4.GetLocation<int>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PreTraining_TypedDataContext3(locations, activityContext, true);
                }
                PreTraining_TypedDataContext3 refDataContext5 = ((PreTraining_TypedDataContext3)(cachedCompiledDataContext[1]));
                return refDataContext5.GetLocation<int>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PreTraining_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext3_ForReadOnly valDataContext6 = ((PreTraining_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PreTraining_TypedDataContext3(locations, activityContext, true);
                }
                PreTraining_TypedDataContext3 refDataContext7 = ((PreTraining_TypedDataContext3)(cachedCompiledDataContext[1]));
                return refDataContext7.GetLocation<System.Drawing.PointF>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PreTraining_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext3_ForReadOnly valDataContext8 = ((PreTraining_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PreTraining_TypedDataContext3(locations, activityContext, true);
                }
                PreTraining_TypedDataContext3 refDataContext9 = ((PreTraining_TypedDataContext3)(cachedCompiledDataContext[1]));
                return refDataContext9.GetLocation<System.Collections.Generic.List<System.Drawing.PointF>>(refDataContext9.ValueType___Expr9Get, refDataContext9.ValueType___Expr9Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PreTraining_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext3_ForReadOnly valDataContext10 = ((PreTraining_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PreTraining_TypedDataContext3(locations, activityContext, true);
                }
                PreTraining_TypedDataContext3 refDataContext11 = ((PreTraining_TypedDataContext3)(cachedCompiledDataContext[1]));
                return refDataContext11.GetLocation<int>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PreTraining_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext3_ForReadOnly valDataContext12 = ((PreTraining_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PreTraining_TypedDataContext3(locations, activityContext, true);
                }
                PreTraining_TypedDataContext3 refDataContext13 = ((PreTraining_TypedDataContext3)(cachedCompiledDataContext[1]));
                return refDataContext13.GetLocation<System.Collections.Generic.List<int>>(refDataContext13.ValueType___Expr13Get, refDataContext13.ValueType___Expr13Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PreTraining_TypedDataContext3(locations, activityContext, true);
                }
                PreTraining_TypedDataContext3 refDataContext14 = ((PreTraining_TypedDataContext3)(cachedCompiledDataContext[1]));
                return refDataContext14.GetLocation<string>(refDataContext14.ValueType___Expr14Get, refDataContext14.ValueType___Expr14Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 15)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PreTraining_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext3_ForReadOnly valDataContext15 = ((PreTraining_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PreTraining_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext3_ForReadOnly valDataContext16 = ((PreTraining_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PreTraining_TypedDataContext3(locations, activityContext, true);
                }
                PreTraining_TypedDataContext3 refDataContext17 = ((PreTraining_TypedDataContext3)(cachedCompiledDataContext[1]));
                return refDataContext17.GetLocation<System.Drawing.PointF>(refDataContext17.ValueType___Expr17Get, refDataContext17.ValueType___Expr17Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 18)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PreTraining_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext3_ForReadOnly valDataContext18 = ((PreTraining_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext18.ValueType___Expr18Get();
            }
            if ((expressionId == 19)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PreTraining_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext3_ForReadOnly valDataContext19 = ((PreTraining_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext19.ValueType___Expr19Get();
            }
            if ((expressionId == 20)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PreTraining_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext3_ForReadOnly valDataContext20 = ((PreTraining_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PreTraining_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext3_ForReadOnly valDataContext21 = ((PreTraining_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext21.ValueType___Expr21Get();
            }
            if ((expressionId == 22)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new PreTraining_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext4_ForReadOnly valDataContext22 = ((PreTraining_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new PreTraining_TypedDataContext4(locations, activityContext, true);
                }
                PreTraining_TypedDataContext4 refDataContext23 = ((PreTraining_TypedDataContext4)(cachedCompiledDataContext[3]));
                return refDataContext23.GetLocation<string>(refDataContext23.ValueType___Expr23Get, refDataContext23.ValueType___Expr23Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 24)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new PreTraining_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext4_ForReadOnly valDataContext24 = ((PreTraining_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext24.ValueType___Expr24Get();
            }
            if ((expressionId == 25)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new PreTraining_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext4_ForReadOnly valDataContext25 = ((PreTraining_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext25.ValueType___Expr25Get();
            }
            if ((expressionId == 26)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new PreTraining_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext4_ForReadOnly valDataContext26 = ((PreTraining_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext26.ValueType___Expr26Get();
            }
            if ((expressionId == 27)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new PreTraining_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext4_ForReadOnly valDataContext27 = ((PreTraining_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext27.ValueType___Expr27Get();
            }
            if ((expressionId == 28)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new PreTraining_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext4_ForReadOnly valDataContext28 = ((PreTraining_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext28.ValueType___Expr28Get();
            }
            if ((expressionId == 29)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new PreTraining_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext4_ForReadOnly valDataContext29 = ((PreTraining_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext29.ValueType___Expr29Get();
            }
            if ((expressionId == 30)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new PreTraining_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext4_ForReadOnly valDataContext30 = ((PreTraining_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext30.ValueType___Expr30Get();
            }
            if ((expressionId == 31)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new PreTraining_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext4_ForReadOnly valDataContext31 = ((PreTraining_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext31.ValueType___Expr31Get();
            }
            if ((expressionId == 32)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new PreTraining_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext4_ForReadOnly valDataContext32 = ((PreTraining_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext32.ValueType___Expr32Get();
            }
            if ((expressionId == 33)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new PreTraining_TypedDataContext4(locations, activityContext, true);
                }
                PreTraining_TypedDataContext4 refDataContext33 = ((PreTraining_TypedDataContext4)(cachedCompiledDataContext[3]));
                return refDataContext33.GetLocation<string>(refDataContext33.ValueType___Expr33Get, refDataContext33.ValueType___Expr33Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 34)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new PreTraining_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext4_ForReadOnly valDataContext34 = ((PreTraining_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext34.ValueType___Expr34Get();
            }
            if ((expressionId == 35)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new PreTraining_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext4_ForReadOnly valDataContext35 = ((PreTraining_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext35.ValueType___Expr35Get();
            }
            if ((expressionId == 36)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new PreTraining_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext4_ForReadOnly valDataContext36 = ((PreTraining_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext36.ValueType___Expr36Get();
            }
            if ((expressionId == 37)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new PreTraining_TypedDataContext4(locations, activityContext, true);
                }
                PreTraining_TypedDataContext4 refDataContext37 = ((PreTraining_TypedDataContext4)(cachedCompiledDataContext[3]));
                return refDataContext37.GetLocation<string>(refDataContext37.ValueType___Expr37Get, refDataContext37.ValueType___Expr37Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 38)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new PreTraining_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext4_ForReadOnly valDataContext38 = ((PreTraining_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext38.ValueType___Expr38Get();
            }
            if ((expressionId == 39)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new PreTraining_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext4_ForReadOnly valDataContext39 = ((PreTraining_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext39.ValueType___Expr39Get();
            }
            if ((expressionId == 40)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new PreTraining_TypedDataContext4(locations, activityContext, true);
                }
                PreTraining_TypedDataContext4 refDataContext40 = ((PreTraining_TypedDataContext4)(cachedCompiledDataContext[3]));
                return refDataContext40.GetLocation<System.Drawing.PointF>(refDataContext40.ValueType___Expr40Get, refDataContext40.ValueType___Expr40Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 41)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new PreTraining_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext4_ForReadOnly valDataContext41 = ((PreTraining_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext41.ValueType___Expr41Get();
            }
            if ((expressionId == 42)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new PreTraining_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext5_ForReadOnly valDataContext42 = ((PreTraining_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext42.ValueType___Expr42Get();
            }
            if ((expressionId == 43)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new PreTraining_TypedDataContext5(locations, activityContext, true);
                }
                PreTraining_TypedDataContext5 refDataContext43 = ((PreTraining_TypedDataContext5)(cachedCompiledDataContext[5]));
                return refDataContext43.GetLocation<System.Random>(refDataContext43.ValueType___Expr43Get, refDataContext43.ValueType___Expr43Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 44)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new PreTraining_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext5_ForReadOnly valDataContext44 = ((PreTraining_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext44.ValueType___Expr44Get();
            }
            if ((expressionId == 45)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new PreTraining_TypedDataContext5(locations, activityContext, true);
                }
                PreTraining_TypedDataContext5 refDataContext45 = ((PreTraining_TypedDataContext5)(cachedCompiledDataContext[5]));
                return refDataContext45.GetLocation<int>(refDataContext45.ValueType___Expr45Get, refDataContext45.ValueType___Expr45Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 46)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new PreTraining_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext5_ForReadOnly valDataContext46 = ((PreTraining_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext46.ValueType___Expr46Get();
            }
            if ((expressionId == 47)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new PreTraining_TypedDataContext5(locations, activityContext, true);
                }
                PreTraining_TypedDataContext5 refDataContext47 = ((PreTraining_TypedDataContext5)(cachedCompiledDataContext[5]));
                return refDataContext47.GetLocation<int>(refDataContext47.ValueType___Expr47Get, refDataContext47.ValueType___Expr47Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 48)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new PreTraining_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext5_ForReadOnly valDataContext48 = ((PreTraining_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext48.ValueType___Expr48Get();
            }
            if ((expressionId == 49)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new PreTraining_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext5_ForReadOnly valDataContext49 = ((PreTraining_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext49.ValueType___Expr49Get();
            }
            if ((expressionId == 50)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new PreTraining_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext5_ForReadOnly valDataContext50 = ((PreTraining_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext50.ValueType___Expr50Get();
            }
            if ((expressionId == 51)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new PreTraining_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext5_ForReadOnly valDataContext51 = ((PreTraining_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext51.ValueType___Expr51Get();
            }
            if ((expressionId == 52)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new PreTraining_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext5_ForReadOnly valDataContext52 = ((PreTraining_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext52.ValueType___Expr52Get();
            }
            if ((expressionId == 53)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new PreTraining_TypedDataContext5(locations, activityContext, true);
                }
                PreTraining_TypedDataContext5 refDataContext53 = ((PreTraining_TypedDataContext5)(cachedCompiledDataContext[5]));
                return refDataContext53.GetLocation<string>(refDataContext53.ValueType___Expr53Get, refDataContext53.ValueType___Expr53Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 54)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new PreTraining_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext5_ForReadOnly valDataContext54 = ((PreTraining_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext54.ValueType___Expr54Get();
            }
            if ((expressionId == 55)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new PreTraining_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext5_ForReadOnly valDataContext55 = ((PreTraining_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext55.ValueType___Expr55Get();
            }
            if ((expressionId == 56)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new PreTraining_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext5_ForReadOnly valDataContext56 = ((PreTraining_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext56.ValueType___Expr56Get();
            }
            if ((expressionId == 57)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new PreTraining_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext4_ForReadOnly valDataContext57 = ((PreTraining_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext57.ValueType___Expr57Get();
            }
            if ((expressionId == 58)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new PreTraining_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext6_ForReadOnly valDataContext58 = ((PreTraining_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext58.ValueType___Expr58Get();
            }
            if ((expressionId == 59)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new PreTraining_TypedDataContext6(locations, activityContext, true);
                }
                PreTraining_TypedDataContext6 refDataContext59 = ((PreTraining_TypedDataContext6)(cachedCompiledDataContext[7]));
                return refDataContext59.GetLocation<string>(refDataContext59.ValueType___Expr59Get, refDataContext59.ValueType___Expr59Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 60)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new PreTraining_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext6_ForReadOnly valDataContext60 = ((PreTraining_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext60.ValueType___Expr60Get();
            }
            if ((expressionId == 61)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new PreTraining_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext6_ForReadOnly valDataContext61 = ((PreTraining_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext61.ValueType___Expr61Get();
            }
            if ((expressionId == 62)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new PreTraining_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext6_ForReadOnly valDataContext62 = ((PreTraining_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext62.ValueType___Expr62Get();
            }
            if ((expressionId == 63)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new PreTraining_TypedDataContext6(locations, activityContext, true);
                }
                PreTraining_TypedDataContext6 refDataContext63 = ((PreTraining_TypedDataContext6)(cachedCompiledDataContext[7]));
                return refDataContext63.GetLocation<string>(refDataContext63.ValueType___Expr63Get, refDataContext63.ValueType___Expr63Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 64)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new PreTraining_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext6_ForReadOnly valDataContext64 = ((PreTraining_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext64.ValueType___Expr64Get();
            }
            if ((expressionId == 65)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new PreTraining_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext6_ForReadOnly valDataContext65 = ((PreTraining_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext65.ValueType___Expr65Get();
            }
            if ((expressionId == 66)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new PreTraining_TypedDataContext6(locations, activityContext, true);
                }
                PreTraining_TypedDataContext6 refDataContext66 = ((PreTraining_TypedDataContext6)(cachedCompiledDataContext[7]));
                return refDataContext66.GetLocation<System.Drawing.PointF>(refDataContext66.ValueType___Expr66Get, refDataContext66.ValueType___Expr66Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 67)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new PreTraining_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext6_ForReadOnly valDataContext67 = ((PreTraining_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext67.ValueType___Expr67Get();
            }
            if ((expressionId == 68)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new PreTraining_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext6_ForReadOnly valDataContext68 = ((PreTraining_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext68.ValueType___Expr68Get();
            }
            if ((expressionId == 69)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new PreTraining_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext6_ForReadOnly valDataContext69 = ((PreTraining_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext69.ValueType___Expr69Get();
            }
            if ((expressionId == 70)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new PreTraining_TypedDataContext6(locations, activityContext, true);
                }
                PreTraining_TypedDataContext6 refDataContext70 = ((PreTraining_TypedDataContext6)(cachedCompiledDataContext[7]));
                return refDataContext70.GetLocation<string>(refDataContext70.ValueType___Expr70Get, refDataContext70.ValueType___Expr70Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 71)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new PreTraining_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext6_ForReadOnly valDataContext71 = ((PreTraining_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext71.ValueType___Expr71Get();
            }
            if ((expressionId == 72)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new PreTraining_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext6_ForReadOnly valDataContext72 = ((PreTraining_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext72.ValueType___Expr72Get();
            }
            if ((expressionId == 73)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new PreTraining_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext6_ForReadOnly valDataContext73 = ((PreTraining_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext73.ValueType___Expr73Get();
            }
            if ((expressionId == 74)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new PreTraining_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext6_ForReadOnly valDataContext74 = ((PreTraining_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext74.ValueType___Expr74Get();
            }
            if ((expressionId == 75)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new PreTraining_TypedDataContext6(locations, activityContext, true);
                }
                PreTraining_TypedDataContext6 refDataContext75 = ((PreTraining_TypedDataContext6)(cachedCompiledDataContext[7]));
                return refDataContext75.GetLocation<string>(refDataContext75.ValueType___Expr75Get, refDataContext75.ValueType___Expr75Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 76)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new PreTraining_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext6_ForReadOnly valDataContext76 = ((PreTraining_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext76.ValueType___Expr76Get();
            }
            if ((expressionId == 77)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new PreTraining_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext6_ForReadOnly valDataContext77 = ((PreTraining_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext77.ValueType___Expr77Get();
            }
            if ((expressionId == 78)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new PreTraining_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext6_ForReadOnly valDataContext78 = ((PreTraining_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext78.ValueType___Expr78Get();
            }
            if ((expressionId == 79)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new PreTraining_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext6_ForReadOnly valDataContext79 = ((PreTraining_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext79.ValueType___Expr79Get();
            }
            if ((expressionId == 80)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new PreTraining_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext7_ForReadOnly valDataContext80 = ((PreTraining_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext80.ValueType___Expr80Get();
            }
            if ((expressionId == 81)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new PreTraining_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext7_ForReadOnly valDataContext81 = ((PreTraining_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext81.ValueType___Expr81Get();
            }
            if ((expressionId == 82)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new PreTraining_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext7_ForReadOnly valDataContext82 = ((PreTraining_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext82.ValueType___Expr82Get();
            }
            if ((expressionId == 83)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new PreTraining_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext7_ForReadOnly valDataContext83 = ((PreTraining_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext83.ValueType___Expr83Get();
            }
            if ((expressionId == 84)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new PreTraining_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext7_ForReadOnly valDataContext84 = ((PreTraining_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext84.ValueType___Expr84Get();
            }
            if ((expressionId == 85)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new PreTraining_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext8_ForReadOnly valDataContext85 = ((PreTraining_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext85.ValueType___Expr85Get();
            }
            if ((expressionId == 86)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new PreTraining_TypedDataContext8(locations, activityContext, true);
                }
                PreTraining_TypedDataContext8 refDataContext86 = ((PreTraining_TypedDataContext8)(cachedCompiledDataContext[10]));
                return refDataContext86.GetLocation<string>(refDataContext86.ValueType___Expr86Get, refDataContext86.ValueType___Expr86Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 87)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new PreTraining_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext8_ForReadOnly valDataContext87 = ((PreTraining_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext87.ValueType___Expr87Get();
            }
            if ((expressionId == 88)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new PreTraining_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext8_ForReadOnly valDataContext88 = ((PreTraining_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext88.ValueType___Expr88Get();
            }
            if ((expressionId == 89)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new PreTraining_TypedDataContext8(locations, activityContext, true);
                }
                PreTraining_TypedDataContext8 refDataContext89 = ((PreTraining_TypedDataContext8)(cachedCompiledDataContext[10]));
                return refDataContext89.GetLocation<System.Drawing.PointF>(refDataContext89.ValueType___Expr89Get, refDataContext89.ValueType___Expr89Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 90)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new PreTraining_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext8_ForReadOnly valDataContext90 = ((PreTraining_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext90.ValueType___Expr90Get();
            }
            if ((expressionId == 91)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new PreTraining_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext8_ForReadOnly valDataContext91 = ((PreTraining_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext91.ValueType___Expr91Get();
            }
            if ((expressionId == 92)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new PreTraining_TypedDataContext8(locations, activityContext, true);
                }
                PreTraining_TypedDataContext8 refDataContext92 = ((PreTraining_TypedDataContext8)(cachedCompiledDataContext[10]));
                return refDataContext92.GetLocation<string>(refDataContext92.ValueType___Expr92Get, refDataContext92.ValueType___Expr92Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 93)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new PreTraining_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext8_ForReadOnly valDataContext93 = ((PreTraining_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext93.ValueType___Expr93Get();
            }
            if ((expressionId == 94)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new PreTraining_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext8_ForReadOnly valDataContext94 = ((PreTraining_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext94.ValueType___Expr94Get();
            }
            if ((expressionId == 95)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new PreTraining_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext8_ForReadOnly valDataContext95 = ((PreTraining_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext95.ValueType___Expr95Get();
            }
            if ((expressionId == 96)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new PreTraining_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext8_ForReadOnly valDataContext96 = ((PreTraining_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext96.ValueType___Expr96Get();
            }
            if ((expressionId == 97)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new PreTraining_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext8_ForReadOnly valDataContext97 = ((PreTraining_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext97.ValueType___Expr97Get();
            }
            if ((expressionId == 98)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new PreTraining_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext9_ForReadOnly valDataContext98 = ((PreTraining_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext98.ValueType___Expr98Get();
            }
            if ((expressionId == 99)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new PreTraining_TypedDataContext9(locations, activityContext, true);
                }
                PreTraining_TypedDataContext9 refDataContext99 = ((PreTraining_TypedDataContext9)(cachedCompiledDataContext[12]));
                return refDataContext99.GetLocation<System.Random>(refDataContext99.ValueType___Expr99Get, refDataContext99.ValueType___Expr99Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 100)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new PreTraining_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext9_ForReadOnly valDataContext100 = ((PreTraining_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext100.ValueType___Expr100Get();
            }
            if ((expressionId == 101)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new PreTraining_TypedDataContext9(locations, activityContext, true);
                }
                PreTraining_TypedDataContext9 refDataContext101 = ((PreTraining_TypedDataContext9)(cachedCompiledDataContext[12]));
                return refDataContext101.GetLocation<System.Random>(refDataContext101.ValueType___Expr101Get, refDataContext101.ValueType___Expr101Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 102)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new PreTraining_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext9_ForReadOnly valDataContext102 = ((PreTraining_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext102.ValueType___Expr102Get();
            }
            if ((expressionId == 103)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new PreTraining_TypedDataContext9(locations, activityContext, true);
                }
                PreTraining_TypedDataContext9 refDataContext103 = ((PreTraining_TypedDataContext9)(cachedCompiledDataContext[12]));
                return refDataContext103.GetLocation<int>(refDataContext103.ValueType___Expr103Get, refDataContext103.ValueType___Expr103Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 104)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new PreTraining_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext9_ForReadOnly valDataContext104 = ((PreTraining_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext104.ValueType___Expr104Get();
            }
            if ((expressionId == 105)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new PreTraining_TypedDataContext9(locations, activityContext, true);
                }
                PreTraining_TypedDataContext9 refDataContext105 = ((PreTraining_TypedDataContext9)(cachedCompiledDataContext[12]));
                return refDataContext105.GetLocation<int>(refDataContext105.ValueType___Expr105Get, refDataContext105.ValueType___Expr105Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 106)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new PreTraining_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext9_ForReadOnly valDataContext106 = ((PreTraining_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext106.ValueType___Expr106Get();
            }
            if ((expressionId == 107)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new PreTraining_TypedDataContext9(locations, activityContext, true);
                }
                PreTraining_TypedDataContext9 refDataContext107 = ((PreTraining_TypedDataContext9)(cachedCompiledDataContext[12]));
                return refDataContext107.GetLocation<int>(refDataContext107.ValueType___Expr107Get, refDataContext107.ValueType___Expr107Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 108)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new PreTraining_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext9_ForReadOnly valDataContext108 = ((PreTraining_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext108.ValueType___Expr108Get();
            }
            if ((expressionId == 109)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new PreTraining_TypedDataContext9(locations, activityContext, true);
                }
                PreTraining_TypedDataContext9 refDataContext109 = ((PreTraining_TypedDataContext9)(cachedCompiledDataContext[12]));
                return refDataContext109.GetLocation<int>(refDataContext109.ValueType___Expr109Get, refDataContext109.ValueType___Expr109Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 110)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new PreTraining_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext9_ForReadOnly valDataContext110 = ((PreTraining_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext110.ValueType___Expr110Get();
            }
            if ((expressionId == 111)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new PreTraining_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext9_ForReadOnly valDataContext111 = ((PreTraining_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext111.ValueType___Expr111Get();
            }
            if ((expressionId == 112)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new PreTraining_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext9_ForReadOnly valDataContext112 = ((PreTraining_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext112.ValueType___Expr112Get();
            }
            if ((expressionId == 113)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new PreTraining_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext9_ForReadOnly valDataContext113 = ((PreTraining_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext113.ValueType___Expr113Get();
            }
            if ((expressionId == 114)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new PreTraining_TypedDataContext9(locations, activityContext, true);
                }
                PreTraining_TypedDataContext9 refDataContext114 = ((PreTraining_TypedDataContext9)(cachedCompiledDataContext[12]));
                return refDataContext114.GetLocation<float>(refDataContext114.ValueType___Expr114Get, refDataContext114.ValueType___Expr114Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 115)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new PreTraining_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext9_ForReadOnly valDataContext115 = ((PreTraining_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext115.ValueType___Expr115Get();
            }
            if ((expressionId == 116)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new PreTraining_TypedDataContext9(locations, activityContext, true);
                }
                PreTraining_TypedDataContext9 refDataContext116 = ((PreTraining_TypedDataContext9)(cachedCompiledDataContext[12]));
                return refDataContext116.GetLocation<float>(refDataContext116.ValueType___Expr116Get, refDataContext116.ValueType___Expr116Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 117)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new PreTraining_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext9_ForReadOnly valDataContext117 = ((PreTraining_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext117.ValueType___Expr117Get();
            }
            if ((expressionId == 118)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new PreTraining_TypedDataContext9(locations, activityContext, true);
                }
                PreTraining_TypedDataContext9 refDataContext118 = ((PreTraining_TypedDataContext9)(cachedCompiledDataContext[12]));
                return refDataContext118.GetLocation<string>(refDataContext118.ValueType___Expr118Get, refDataContext118.ValueType___Expr118Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 119)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new PreTraining_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext9_ForReadOnly valDataContext119 = ((PreTraining_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext119.ValueType___Expr119Get();
            }
            if ((expressionId == 120)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new PreTraining_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext9_ForReadOnly valDataContext120 = ((PreTraining_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext120.ValueType___Expr120Get();
            }
            if ((expressionId == 121)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new PreTraining_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext9_ForReadOnly valDataContext121 = ((PreTraining_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext121.ValueType___Expr121Get();
            }
            if ((expressionId == 122)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new PreTraining_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext8_ForReadOnly valDataContext122 = ((PreTraining_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext122.ValueType___Expr122Get();
            }
            if ((expressionId == 123)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new PreTraining_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext8_ForReadOnly valDataContext123 = ((PreTraining_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext123.ValueType___Expr123Get();
            }
            if ((expressionId == 124)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new PreTraining_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext8_ForReadOnly valDataContext124 = ((PreTraining_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext124.ValueType___Expr124Get();
            }
            if ((expressionId == 125)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new PreTraining_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext8_ForReadOnly valDataContext125 = ((PreTraining_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext125.ValueType___Expr125Get();
            }
            if ((expressionId == 126)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new PreTraining_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext8_ForReadOnly valDataContext126 = ((PreTraining_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext126.ValueType___Expr126Get();
            }
            if ((expressionId == 127)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new PreTraining_TypedDataContext8(locations, activityContext, true);
                }
                PreTraining_TypedDataContext8 refDataContext127 = ((PreTraining_TypedDataContext8)(cachedCompiledDataContext[10]));
                return refDataContext127.GetLocation<int>(refDataContext127.ValueType___Expr127Get, refDataContext127.ValueType___Expr127Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 128)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new PreTraining_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext8_ForReadOnly valDataContext128 = ((PreTraining_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext128.ValueType___Expr128Get();
            }
            if ((expressionId == 129)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new PreTraining_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext8_ForReadOnly valDataContext129 = ((PreTraining_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext129.ValueType___Expr129Get();
            }
            if ((expressionId == 130)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new PreTraining_TypedDataContext8(locations, activityContext, true);
                }
                PreTraining_TypedDataContext8 refDataContext130 = ((PreTraining_TypedDataContext8)(cachedCompiledDataContext[10]));
                return refDataContext130.GetLocation<int>(refDataContext130.ValueType___Expr130Get, refDataContext130.ValueType___Expr130Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 131)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new PreTraining_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext8_ForReadOnly valDataContext131 = ((PreTraining_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext131.ValueType___Expr131Get();
            }
            if ((expressionId == 132)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new PreTraining_TypedDataContext8(locations, activityContext, true);
                }
                PreTraining_TypedDataContext8 refDataContext132 = ((PreTraining_TypedDataContext8)(cachedCompiledDataContext[10]));
                return refDataContext132.GetLocation<int>(refDataContext132.ValueType___Expr132Get, refDataContext132.ValueType___Expr132Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 133)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext11.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new PreTraining_TypedDataContext11(locations, activityContext, true);
                }
                PreTraining_TypedDataContext11 refDataContext133 = ((PreTraining_TypedDataContext11)(cachedCompiledDataContext[13]));
                return refDataContext133.GetLocation<string>(refDataContext133.ValueType___Expr133Get, refDataContext133.ValueType___Expr133Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 134)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext11_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[14] == null)) {
                    cachedCompiledDataContext[14] = new PreTraining_TypedDataContext11_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext11_ForReadOnly valDataContext134 = ((PreTraining_TypedDataContext11_ForReadOnly)(cachedCompiledDataContext[14]));
                return valDataContext134.ValueType___Expr134Get();
            }
            if ((expressionId == 135)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext11_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[14] == null)) {
                    cachedCompiledDataContext[14] = new PreTraining_TypedDataContext11_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext11_ForReadOnly valDataContext135 = ((PreTraining_TypedDataContext11_ForReadOnly)(cachedCompiledDataContext[14]));
                return valDataContext135.ValueType___Expr135Get();
            }
            if ((expressionId == 136)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext11.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new PreTraining_TypedDataContext11(locations, activityContext, true);
                }
                PreTraining_TypedDataContext11 refDataContext136 = ((PreTraining_TypedDataContext11)(cachedCompiledDataContext[13]));
                return refDataContext136.GetLocation<System.Drawing.PointF>(refDataContext136.ValueType___Expr136Get, refDataContext136.ValueType___Expr136Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 137)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext11_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[14] == null)) {
                    cachedCompiledDataContext[14] = new PreTraining_TypedDataContext11_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext11_ForReadOnly valDataContext137 = ((PreTraining_TypedDataContext11_ForReadOnly)(cachedCompiledDataContext[14]));
                return valDataContext137.ValueType___Expr137Get();
            }
            if ((expressionId == 138)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext11_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[14] == null)) {
                    cachedCompiledDataContext[14] = new PreTraining_TypedDataContext11_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext11_ForReadOnly valDataContext138 = ((PreTraining_TypedDataContext11_ForReadOnly)(cachedCompiledDataContext[14]));
                return valDataContext138.ValueType___Expr138Get();
            }
            if ((expressionId == 139)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext11_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[14] == null)) {
                    cachedCompiledDataContext[14] = new PreTraining_TypedDataContext11_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext11_ForReadOnly valDataContext139 = ((PreTraining_TypedDataContext11_ForReadOnly)(cachedCompiledDataContext[14]));
                return valDataContext139.ValueType___Expr139Get();
            }
            if ((expressionId == 140)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext11_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[14] == null)) {
                    cachedCompiledDataContext[14] = new PreTraining_TypedDataContext11_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext11_ForReadOnly valDataContext140 = ((PreTraining_TypedDataContext11_ForReadOnly)(cachedCompiledDataContext[14]));
                return valDataContext140.ValueType___Expr140Get();
            }
            if ((expressionId == 141)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[15] == null)) {
                    cachedCompiledDataContext[15] = new PreTraining_TypedDataContext12_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext12_ForReadOnly valDataContext141 = ((PreTraining_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[15]));
                return valDataContext141.ValueType___Expr141Get();
            }
            if ((expressionId == 142)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new PreTraining_TypedDataContext12(locations, activityContext, true);
                }
                PreTraining_TypedDataContext12 refDataContext142 = ((PreTraining_TypedDataContext12)(cachedCompiledDataContext[16]));
                return refDataContext142.GetLocation<string>(refDataContext142.ValueType___Expr142Get, refDataContext142.ValueType___Expr142Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 143)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[15] == null)) {
                    cachedCompiledDataContext[15] = new PreTraining_TypedDataContext12_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext12_ForReadOnly valDataContext143 = ((PreTraining_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[15]));
                return valDataContext143.ValueType___Expr143Get();
            }
            if ((expressionId == 144)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[15] == null)) {
                    cachedCompiledDataContext[15] = new PreTraining_TypedDataContext12_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext12_ForReadOnly valDataContext144 = ((PreTraining_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[15]));
                return valDataContext144.ValueType___Expr144Get();
            }
            if ((expressionId == 145)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[15] == null)) {
                    cachedCompiledDataContext[15] = new PreTraining_TypedDataContext12_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext12_ForReadOnly valDataContext145 = ((PreTraining_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[15]));
                return valDataContext145.ValueType___Expr145Get();
            }
            if ((expressionId == 146)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new PreTraining_TypedDataContext12(locations, activityContext, true);
                }
                PreTraining_TypedDataContext12 refDataContext146 = ((PreTraining_TypedDataContext12)(cachedCompiledDataContext[16]));
                return refDataContext146.GetLocation<string>(refDataContext146.ValueType___Expr146Get, refDataContext146.ValueType___Expr146Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 147)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[15] == null)) {
                    cachedCompiledDataContext[15] = new PreTraining_TypedDataContext12_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext12_ForReadOnly valDataContext147 = ((PreTraining_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[15]));
                return valDataContext147.ValueType___Expr147Get();
            }
            if ((expressionId == 148)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[15] == null)) {
                    cachedCompiledDataContext[15] = new PreTraining_TypedDataContext12_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext12_ForReadOnly valDataContext148 = ((PreTraining_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[15]));
                return valDataContext148.ValueType___Expr148Get();
            }
            if ((expressionId == 149)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new PreTraining_TypedDataContext12(locations, activityContext, true);
                }
                PreTraining_TypedDataContext12 refDataContext149 = ((PreTraining_TypedDataContext12)(cachedCompiledDataContext[16]));
                return refDataContext149.GetLocation<System.Drawing.PointF>(refDataContext149.ValueType___Expr149Get, refDataContext149.ValueType___Expr149Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 150)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[15] == null)) {
                    cachedCompiledDataContext[15] = new PreTraining_TypedDataContext12_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext12_ForReadOnly valDataContext150 = ((PreTraining_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[15]));
                return valDataContext150.ValueType___Expr150Get();
            }
            if ((expressionId == 151)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[15] == null)) {
                    cachedCompiledDataContext[15] = new PreTraining_TypedDataContext12_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext12_ForReadOnly valDataContext151 = ((PreTraining_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[15]));
                return valDataContext151.ValueType___Expr151Get();
            }
            if ((expressionId == 152)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new PreTraining_TypedDataContext12(locations, activityContext, true);
                }
                PreTraining_TypedDataContext12 refDataContext152 = ((PreTraining_TypedDataContext12)(cachedCompiledDataContext[16]));
                return refDataContext152.GetLocation<int>(refDataContext152.ValueType___Expr152Get, refDataContext152.ValueType___Expr152Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 153)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[15] == null)) {
                    cachedCompiledDataContext[15] = new PreTraining_TypedDataContext12_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext12_ForReadOnly valDataContext153 = ((PreTraining_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[15]));
                return valDataContext153.ValueType___Expr153Get();
            }
            if ((expressionId == 154)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[15] == null)) {
                    cachedCompiledDataContext[15] = new PreTraining_TypedDataContext12_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext12_ForReadOnly valDataContext154 = ((PreTraining_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[15]));
                return valDataContext154.ValueType___Expr154Get();
            }
            if ((expressionId == 155)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext13.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[17] == null)) {
                    cachedCompiledDataContext[17] = new PreTraining_TypedDataContext13(locations, activityContext, true);
                }
                PreTraining_TypedDataContext13 refDataContext155 = ((PreTraining_TypedDataContext13)(cachedCompiledDataContext[17]));
                return refDataContext155.GetLocation<string>(refDataContext155.ValueType___Expr155Get, refDataContext155.ValueType___Expr155Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 156)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext13_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[18] == null)) {
                    cachedCompiledDataContext[18] = new PreTraining_TypedDataContext13_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext13_ForReadOnly valDataContext156 = ((PreTraining_TypedDataContext13_ForReadOnly)(cachedCompiledDataContext[18]));
                return valDataContext156.ValueType___Expr156Get();
            }
            if ((expressionId == 157)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext13_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[18] == null)) {
                    cachedCompiledDataContext[18] = new PreTraining_TypedDataContext13_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext13_ForReadOnly valDataContext157 = ((PreTraining_TypedDataContext13_ForReadOnly)(cachedCompiledDataContext[18]));
                return valDataContext157.ValueType___Expr157Get();
            }
            if ((expressionId == 158)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext13.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[17] == null)) {
                    cachedCompiledDataContext[17] = new PreTraining_TypedDataContext13(locations, activityContext, true);
                }
                PreTraining_TypedDataContext13 refDataContext158 = ((PreTraining_TypedDataContext13)(cachedCompiledDataContext[17]));
                return refDataContext158.GetLocation<System.Drawing.PointF>(refDataContext158.ValueType___Expr158Get, refDataContext158.ValueType___Expr158Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 159)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext13_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[18] == null)) {
                    cachedCompiledDataContext[18] = new PreTraining_TypedDataContext13_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext13_ForReadOnly valDataContext159 = ((PreTraining_TypedDataContext13_ForReadOnly)(cachedCompiledDataContext[18]));
                return valDataContext159.ValueType___Expr159Get();
            }
            if ((expressionId == 160)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext13_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[18] == null)) {
                    cachedCompiledDataContext[18] = new PreTraining_TypedDataContext13_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext13_ForReadOnly valDataContext160 = ((PreTraining_TypedDataContext13_ForReadOnly)(cachedCompiledDataContext[18]));
                return valDataContext160.ValueType___Expr160Get();
            }
            if ((expressionId == 161)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[19] == null)) {
                    cachedCompiledDataContext[19] = new PreTraining_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext14_ForReadOnly valDataContext161 = ((PreTraining_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[19]));
                return valDataContext161.ValueType___Expr161Get();
            }
            if ((expressionId == 162)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext14.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[20] == null)) {
                    cachedCompiledDataContext[20] = new PreTraining_TypedDataContext14(locations, activityContext, true);
                }
                PreTraining_TypedDataContext14 refDataContext162 = ((PreTraining_TypedDataContext14)(cachedCompiledDataContext[20]));
                return refDataContext162.GetLocation<string>(refDataContext162.ValueType___Expr162Get, refDataContext162.ValueType___Expr162Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 163)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[19] == null)) {
                    cachedCompiledDataContext[19] = new PreTraining_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext14_ForReadOnly valDataContext163 = ((PreTraining_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[19]));
                return valDataContext163.ValueType___Expr163Get();
            }
            if ((expressionId == 164)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[19] == null)) {
                    cachedCompiledDataContext[19] = new PreTraining_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext14_ForReadOnly valDataContext164 = ((PreTraining_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[19]));
                return valDataContext164.ValueType___Expr164Get();
            }
            if ((expressionId == 165)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[19] == null)) {
                    cachedCompiledDataContext[19] = new PreTraining_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext14_ForReadOnly valDataContext165 = ((PreTraining_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[19]));
                return valDataContext165.ValueType___Expr165Get();
            }
            if ((expressionId == 166)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext14.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[20] == null)) {
                    cachedCompiledDataContext[20] = new PreTraining_TypedDataContext14(locations, activityContext, true);
                }
                PreTraining_TypedDataContext14 refDataContext166 = ((PreTraining_TypedDataContext14)(cachedCompiledDataContext[20]));
                return refDataContext166.GetLocation<string>(refDataContext166.ValueType___Expr166Get, refDataContext166.ValueType___Expr166Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 167)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[19] == null)) {
                    cachedCompiledDataContext[19] = new PreTraining_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext14_ForReadOnly valDataContext167 = ((PreTraining_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[19]));
                return valDataContext167.ValueType___Expr167Get();
            }
            if ((expressionId == 168)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[19] == null)) {
                    cachedCompiledDataContext[19] = new PreTraining_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext14_ForReadOnly valDataContext168 = ((PreTraining_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[19]));
                return valDataContext168.ValueType___Expr168Get();
            }
            if ((expressionId == 169)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext14.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[20] == null)) {
                    cachedCompiledDataContext[20] = new PreTraining_TypedDataContext14(locations, activityContext, true);
                }
                PreTraining_TypedDataContext14 refDataContext169 = ((PreTraining_TypedDataContext14)(cachedCompiledDataContext[20]));
                return refDataContext169.GetLocation<System.Drawing.PointF>(refDataContext169.ValueType___Expr169Get, refDataContext169.ValueType___Expr169Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 170)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[19] == null)) {
                    cachedCompiledDataContext[19] = new PreTraining_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext14_ForReadOnly valDataContext170 = ((PreTraining_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[19]));
                return valDataContext170.ValueType___Expr170Get();
            }
            if ((expressionId == 171)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext14.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[20] == null)) {
                    cachedCompiledDataContext[20] = new PreTraining_TypedDataContext14(locations, activityContext, true);
                }
                PreTraining_TypedDataContext14 refDataContext171 = ((PreTraining_TypedDataContext14)(cachedCompiledDataContext[20]));
                return refDataContext171.GetLocation<int>(refDataContext171.ValueType___Expr171Get, refDataContext171.ValueType___Expr171Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 172)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[19] == null)) {
                    cachedCompiledDataContext[19] = new PreTraining_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext14_ForReadOnly valDataContext172 = ((PreTraining_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[19]));
                return valDataContext172.ValueType___Expr172Get();
            }
            if ((expressionId == 173)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[19] == null)) {
                    cachedCompiledDataContext[19] = new PreTraining_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext14_ForReadOnly valDataContext173 = ((PreTraining_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[19]));
                return valDataContext173.ValueType___Expr173Get();
            }
            if ((expressionId == 174)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[19] == null)) {
                    cachedCompiledDataContext[19] = new PreTraining_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext14_ForReadOnly valDataContext174 = ((PreTraining_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[19]));
                return valDataContext174.ValueType___Expr174Get();
            }
            if ((expressionId == 175)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[19] == null)) {
                    cachedCompiledDataContext[19] = new PreTraining_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext14_ForReadOnly valDataContext175 = ((PreTraining_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[19]));
                return valDataContext175.ValueType___Expr175Get();
            }
            if ((expressionId == 176)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext15_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[21] == null)) {
                    cachedCompiledDataContext[21] = new PreTraining_TypedDataContext15_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext15_ForReadOnly valDataContext176 = ((PreTraining_TypedDataContext15_ForReadOnly)(cachedCompiledDataContext[21]));
                return valDataContext176.ValueType___Expr176Get();
            }
            if ((expressionId == 177)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext15_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[21] == null)) {
                    cachedCompiledDataContext[21] = new PreTraining_TypedDataContext15_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext15_ForReadOnly valDataContext177 = ((PreTraining_TypedDataContext15_ForReadOnly)(cachedCompiledDataContext[21]));
                return valDataContext177.ValueType___Expr177Get();
            }
            if ((expressionId == 178)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext15.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[22] == null)) {
                    cachedCompiledDataContext[22] = new PreTraining_TypedDataContext15(locations, activityContext, true);
                }
                PreTraining_TypedDataContext15 refDataContext178 = ((PreTraining_TypedDataContext15)(cachedCompiledDataContext[22]));
                return refDataContext178.GetLocation<string>(refDataContext178.ValueType___Expr178Get, refDataContext178.ValueType___Expr178Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 179)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext15_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[21] == null)) {
                    cachedCompiledDataContext[21] = new PreTraining_TypedDataContext15_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext15_ForReadOnly valDataContext179 = ((PreTraining_TypedDataContext15_ForReadOnly)(cachedCompiledDataContext[21]));
                return valDataContext179.ValueType___Expr179Get();
            }
            if ((expressionId == 180)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext15_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[21] == null)) {
                    cachedCompiledDataContext[21] = new PreTraining_TypedDataContext15_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext15_ForReadOnly valDataContext180 = ((PreTraining_TypedDataContext15_ForReadOnly)(cachedCompiledDataContext[21]));
                return valDataContext180.ValueType___Expr180Get();
            }
            if ((expressionId == 181)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PreTraining_TypedDataContext15_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 23);
                if ((cachedCompiledDataContext[21] == null)) {
                    cachedCompiledDataContext[21] = new PreTraining_TypedDataContext15_ForReadOnly(locations, activityContext, true);
                }
                PreTraining_TypedDataContext15_ForReadOnly valDataContext181 = ((PreTraining_TypedDataContext15_ForReadOnly)(cachedCompiledDataContext[21]));
                return valDataContext181.ValueType___Expr181Get();
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
                PreTraining_TypedDataContext3_ForReadOnly valDataContext2 = new PreTraining_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                PreTraining_TypedDataContext3 refDataContext3 = new PreTraining_TypedDataContext3(locations, true);
                return refDataContext3.GetLocation<System.Collections.Generic.List<string>>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set);
            }
            if ((expressionId == 4)) {
                PreTraining_TypedDataContext3 refDataContext4 = new PreTraining_TypedDataContext3(locations, true);
                return refDataContext4.GetLocation<int>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set);
            }
            if ((expressionId == 5)) {
                PreTraining_TypedDataContext3 refDataContext5 = new PreTraining_TypedDataContext3(locations, true);
                return refDataContext5.GetLocation<int>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set);
            }
            if ((expressionId == 6)) {
                PreTraining_TypedDataContext3_ForReadOnly valDataContext6 = new PreTraining_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                PreTraining_TypedDataContext3 refDataContext7 = new PreTraining_TypedDataContext3(locations, true);
                return refDataContext7.GetLocation<System.Drawing.PointF>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set);
            }
            if ((expressionId == 8)) {
                PreTraining_TypedDataContext3_ForReadOnly valDataContext8 = new PreTraining_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                PreTraining_TypedDataContext3 refDataContext9 = new PreTraining_TypedDataContext3(locations, true);
                return refDataContext9.GetLocation<System.Collections.Generic.List<System.Drawing.PointF>>(refDataContext9.ValueType___Expr9Get, refDataContext9.ValueType___Expr9Set);
            }
            if ((expressionId == 10)) {
                PreTraining_TypedDataContext3_ForReadOnly valDataContext10 = new PreTraining_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                PreTraining_TypedDataContext3 refDataContext11 = new PreTraining_TypedDataContext3(locations, true);
                return refDataContext11.GetLocation<int>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set);
            }
            if ((expressionId == 12)) {
                PreTraining_TypedDataContext3_ForReadOnly valDataContext12 = new PreTraining_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                PreTraining_TypedDataContext3 refDataContext13 = new PreTraining_TypedDataContext3(locations, true);
                return refDataContext13.GetLocation<System.Collections.Generic.List<int>>(refDataContext13.ValueType___Expr13Get, refDataContext13.ValueType___Expr13Set);
            }
            if ((expressionId == 14)) {
                PreTraining_TypedDataContext3 refDataContext14 = new PreTraining_TypedDataContext3(locations, true);
                return refDataContext14.GetLocation<string>(refDataContext14.ValueType___Expr14Get, refDataContext14.ValueType___Expr14Set);
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
                PreTraining_TypedDataContext3 refDataContext17 = new PreTraining_TypedDataContext3(locations, true);
                return refDataContext17.GetLocation<System.Drawing.PointF>(refDataContext17.ValueType___Expr17Get, refDataContext17.ValueType___Expr17Set);
            }
            if ((expressionId == 18)) {
                PreTraining_TypedDataContext3_ForReadOnly valDataContext18 = new PreTraining_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext18.ValueType___Expr18Get();
            }
            if ((expressionId == 19)) {
                PreTraining_TypedDataContext3_ForReadOnly valDataContext19 = new PreTraining_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext19.ValueType___Expr19Get();
            }
            if ((expressionId == 20)) {
                PreTraining_TypedDataContext3_ForReadOnly valDataContext20 = new PreTraining_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                PreTraining_TypedDataContext3_ForReadOnly valDataContext21 = new PreTraining_TypedDataContext3_ForReadOnly(locations, true);
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
                PreTraining_TypedDataContext4_ForReadOnly valDataContext25 = new PreTraining_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext25.ValueType___Expr25Get();
            }
            if ((expressionId == 26)) {
                PreTraining_TypedDataContext4_ForReadOnly valDataContext26 = new PreTraining_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext26.ValueType___Expr26Get();
            }
            if ((expressionId == 27)) {
                PreTraining_TypedDataContext4_ForReadOnly valDataContext27 = new PreTraining_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext27.ValueType___Expr27Get();
            }
            if ((expressionId == 28)) {
                PreTraining_TypedDataContext4_ForReadOnly valDataContext28 = new PreTraining_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext28.ValueType___Expr28Get();
            }
            if ((expressionId == 29)) {
                PreTraining_TypedDataContext4_ForReadOnly valDataContext29 = new PreTraining_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext29.ValueType___Expr29Get();
            }
            if ((expressionId == 30)) {
                PreTraining_TypedDataContext4_ForReadOnly valDataContext30 = new PreTraining_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext30.ValueType___Expr30Get();
            }
            if ((expressionId == 31)) {
                PreTraining_TypedDataContext4_ForReadOnly valDataContext31 = new PreTraining_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext31.ValueType___Expr31Get();
            }
            if ((expressionId == 32)) {
                PreTraining_TypedDataContext4_ForReadOnly valDataContext32 = new PreTraining_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext32.ValueType___Expr32Get();
            }
            if ((expressionId == 33)) {
                PreTraining_TypedDataContext4 refDataContext33 = new PreTraining_TypedDataContext4(locations, true);
                return refDataContext33.GetLocation<string>(refDataContext33.ValueType___Expr33Get, refDataContext33.ValueType___Expr33Set);
            }
            if ((expressionId == 34)) {
                PreTraining_TypedDataContext4_ForReadOnly valDataContext34 = new PreTraining_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext34.ValueType___Expr34Get();
            }
            if ((expressionId == 35)) {
                PreTraining_TypedDataContext4_ForReadOnly valDataContext35 = new PreTraining_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext35.ValueType___Expr35Get();
            }
            if ((expressionId == 36)) {
                PreTraining_TypedDataContext4_ForReadOnly valDataContext36 = new PreTraining_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext36.ValueType___Expr36Get();
            }
            if ((expressionId == 37)) {
                PreTraining_TypedDataContext4 refDataContext37 = new PreTraining_TypedDataContext4(locations, true);
                return refDataContext37.GetLocation<string>(refDataContext37.ValueType___Expr37Get, refDataContext37.ValueType___Expr37Set);
            }
            if ((expressionId == 38)) {
                PreTraining_TypedDataContext4_ForReadOnly valDataContext38 = new PreTraining_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext38.ValueType___Expr38Get();
            }
            if ((expressionId == 39)) {
                PreTraining_TypedDataContext4_ForReadOnly valDataContext39 = new PreTraining_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext39.ValueType___Expr39Get();
            }
            if ((expressionId == 40)) {
                PreTraining_TypedDataContext4 refDataContext40 = new PreTraining_TypedDataContext4(locations, true);
                return refDataContext40.GetLocation<System.Drawing.PointF>(refDataContext40.ValueType___Expr40Get, refDataContext40.ValueType___Expr40Set);
            }
            if ((expressionId == 41)) {
                PreTraining_TypedDataContext4_ForReadOnly valDataContext41 = new PreTraining_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext41.ValueType___Expr41Get();
            }
            if ((expressionId == 42)) {
                PreTraining_TypedDataContext5_ForReadOnly valDataContext42 = new PreTraining_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext42.ValueType___Expr42Get();
            }
            if ((expressionId == 43)) {
                PreTraining_TypedDataContext5 refDataContext43 = new PreTraining_TypedDataContext5(locations, true);
                return refDataContext43.GetLocation<System.Random>(refDataContext43.ValueType___Expr43Get, refDataContext43.ValueType___Expr43Set);
            }
            if ((expressionId == 44)) {
                PreTraining_TypedDataContext5_ForReadOnly valDataContext44 = new PreTraining_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext44.ValueType___Expr44Get();
            }
            if ((expressionId == 45)) {
                PreTraining_TypedDataContext5 refDataContext45 = new PreTraining_TypedDataContext5(locations, true);
                return refDataContext45.GetLocation<int>(refDataContext45.ValueType___Expr45Get, refDataContext45.ValueType___Expr45Set);
            }
            if ((expressionId == 46)) {
                PreTraining_TypedDataContext5_ForReadOnly valDataContext46 = new PreTraining_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext46.ValueType___Expr46Get();
            }
            if ((expressionId == 47)) {
                PreTraining_TypedDataContext5 refDataContext47 = new PreTraining_TypedDataContext5(locations, true);
                return refDataContext47.GetLocation<int>(refDataContext47.ValueType___Expr47Get, refDataContext47.ValueType___Expr47Set);
            }
            if ((expressionId == 48)) {
                PreTraining_TypedDataContext5_ForReadOnly valDataContext48 = new PreTraining_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext48.ValueType___Expr48Get();
            }
            if ((expressionId == 49)) {
                PreTraining_TypedDataContext5_ForReadOnly valDataContext49 = new PreTraining_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext49.ValueType___Expr49Get();
            }
            if ((expressionId == 50)) {
                PreTraining_TypedDataContext5_ForReadOnly valDataContext50 = new PreTraining_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext50.ValueType___Expr50Get();
            }
            if ((expressionId == 51)) {
                PreTraining_TypedDataContext5_ForReadOnly valDataContext51 = new PreTraining_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext51.ValueType___Expr51Get();
            }
            if ((expressionId == 52)) {
                PreTraining_TypedDataContext5_ForReadOnly valDataContext52 = new PreTraining_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext52.ValueType___Expr52Get();
            }
            if ((expressionId == 53)) {
                PreTraining_TypedDataContext5 refDataContext53 = new PreTraining_TypedDataContext5(locations, true);
                return refDataContext53.GetLocation<string>(refDataContext53.ValueType___Expr53Get, refDataContext53.ValueType___Expr53Set);
            }
            if ((expressionId == 54)) {
                PreTraining_TypedDataContext5_ForReadOnly valDataContext54 = new PreTraining_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext54.ValueType___Expr54Get();
            }
            if ((expressionId == 55)) {
                PreTraining_TypedDataContext5_ForReadOnly valDataContext55 = new PreTraining_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext55.ValueType___Expr55Get();
            }
            if ((expressionId == 56)) {
                PreTraining_TypedDataContext5_ForReadOnly valDataContext56 = new PreTraining_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext56.ValueType___Expr56Get();
            }
            if ((expressionId == 57)) {
                PreTraining_TypedDataContext4_ForReadOnly valDataContext57 = new PreTraining_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext57.ValueType___Expr57Get();
            }
            if ((expressionId == 58)) {
                PreTraining_TypedDataContext6_ForReadOnly valDataContext58 = new PreTraining_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext58.ValueType___Expr58Get();
            }
            if ((expressionId == 59)) {
                PreTraining_TypedDataContext6 refDataContext59 = new PreTraining_TypedDataContext6(locations, true);
                return refDataContext59.GetLocation<string>(refDataContext59.ValueType___Expr59Get, refDataContext59.ValueType___Expr59Set);
            }
            if ((expressionId == 60)) {
                PreTraining_TypedDataContext6_ForReadOnly valDataContext60 = new PreTraining_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext60.ValueType___Expr60Get();
            }
            if ((expressionId == 61)) {
                PreTraining_TypedDataContext6_ForReadOnly valDataContext61 = new PreTraining_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext61.ValueType___Expr61Get();
            }
            if ((expressionId == 62)) {
                PreTraining_TypedDataContext6_ForReadOnly valDataContext62 = new PreTraining_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext62.ValueType___Expr62Get();
            }
            if ((expressionId == 63)) {
                PreTraining_TypedDataContext6 refDataContext63 = new PreTraining_TypedDataContext6(locations, true);
                return refDataContext63.GetLocation<string>(refDataContext63.ValueType___Expr63Get, refDataContext63.ValueType___Expr63Set);
            }
            if ((expressionId == 64)) {
                PreTraining_TypedDataContext6_ForReadOnly valDataContext64 = new PreTraining_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext64.ValueType___Expr64Get();
            }
            if ((expressionId == 65)) {
                PreTraining_TypedDataContext6_ForReadOnly valDataContext65 = new PreTraining_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext65.ValueType___Expr65Get();
            }
            if ((expressionId == 66)) {
                PreTraining_TypedDataContext6 refDataContext66 = new PreTraining_TypedDataContext6(locations, true);
                return refDataContext66.GetLocation<System.Drawing.PointF>(refDataContext66.ValueType___Expr66Get, refDataContext66.ValueType___Expr66Set);
            }
            if ((expressionId == 67)) {
                PreTraining_TypedDataContext6_ForReadOnly valDataContext67 = new PreTraining_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext67.ValueType___Expr67Get();
            }
            if ((expressionId == 68)) {
                PreTraining_TypedDataContext6_ForReadOnly valDataContext68 = new PreTraining_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext68.ValueType___Expr68Get();
            }
            if ((expressionId == 69)) {
                PreTraining_TypedDataContext6_ForReadOnly valDataContext69 = new PreTraining_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext69.ValueType___Expr69Get();
            }
            if ((expressionId == 70)) {
                PreTraining_TypedDataContext6 refDataContext70 = new PreTraining_TypedDataContext6(locations, true);
                return refDataContext70.GetLocation<string>(refDataContext70.ValueType___Expr70Get, refDataContext70.ValueType___Expr70Set);
            }
            if ((expressionId == 71)) {
                PreTraining_TypedDataContext6_ForReadOnly valDataContext71 = new PreTraining_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext71.ValueType___Expr71Get();
            }
            if ((expressionId == 72)) {
                PreTraining_TypedDataContext6_ForReadOnly valDataContext72 = new PreTraining_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext72.ValueType___Expr72Get();
            }
            if ((expressionId == 73)) {
                PreTraining_TypedDataContext6_ForReadOnly valDataContext73 = new PreTraining_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext73.ValueType___Expr73Get();
            }
            if ((expressionId == 74)) {
                PreTraining_TypedDataContext6_ForReadOnly valDataContext74 = new PreTraining_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext74.ValueType___Expr74Get();
            }
            if ((expressionId == 75)) {
                PreTraining_TypedDataContext6 refDataContext75 = new PreTraining_TypedDataContext6(locations, true);
                return refDataContext75.GetLocation<string>(refDataContext75.ValueType___Expr75Get, refDataContext75.ValueType___Expr75Set);
            }
            if ((expressionId == 76)) {
                PreTraining_TypedDataContext6_ForReadOnly valDataContext76 = new PreTraining_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext76.ValueType___Expr76Get();
            }
            if ((expressionId == 77)) {
                PreTraining_TypedDataContext6_ForReadOnly valDataContext77 = new PreTraining_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext77.ValueType___Expr77Get();
            }
            if ((expressionId == 78)) {
                PreTraining_TypedDataContext6_ForReadOnly valDataContext78 = new PreTraining_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext78.ValueType___Expr78Get();
            }
            if ((expressionId == 79)) {
                PreTraining_TypedDataContext6_ForReadOnly valDataContext79 = new PreTraining_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext79.ValueType___Expr79Get();
            }
            if ((expressionId == 80)) {
                PreTraining_TypedDataContext7_ForReadOnly valDataContext80 = new PreTraining_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext80.ValueType___Expr80Get();
            }
            if ((expressionId == 81)) {
                PreTraining_TypedDataContext7_ForReadOnly valDataContext81 = new PreTraining_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext81.ValueType___Expr81Get();
            }
            if ((expressionId == 82)) {
                PreTraining_TypedDataContext7_ForReadOnly valDataContext82 = new PreTraining_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext82.ValueType___Expr82Get();
            }
            if ((expressionId == 83)) {
                PreTraining_TypedDataContext7_ForReadOnly valDataContext83 = new PreTraining_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext83.ValueType___Expr83Get();
            }
            if ((expressionId == 84)) {
                PreTraining_TypedDataContext7_ForReadOnly valDataContext84 = new PreTraining_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext84.ValueType___Expr84Get();
            }
            if ((expressionId == 85)) {
                PreTraining_TypedDataContext8_ForReadOnly valDataContext85 = new PreTraining_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext85.ValueType___Expr85Get();
            }
            if ((expressionId == 86)) {
                PreTraining_TypedDataContext8 refDataContext86 = new PreTraining_TypedDataContext8(locations, true);
                return refDataContext86.GetLocation<string>(refDataContext86.ValueType___Expr86Get, refDataContext86.ValueType___Expr86Set);
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
                return refDataContext89.GetLocation<System.Drawing.PointF>(refDataContext89.ValueType___Expr89Get, refDataContext89.ValueType___Expr89Set);
            }
            if ((expressionId == 90)) {
                PreTraining_TypedDataContext8_ForReadOnly valDataContext90 = new PreTraining_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext90.ValueType___Expr90Get();
            }
            if ((expressionId == 91)) {
                PreTraining_TypedDataContext8_ForReadOnly valDataContext91 = new PreTraining_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext91.ValueType___Expr91Get();
            }
            if ((expressionId == 92)) {
                PreTraining_TypedDataContext8 refDataContext92 = new PreTraining_TypedDataContext8(locations, true);
                return refDataContext92.GetLocation<string>(refDataContext92.ValueType___Expr92Get, refDataContext92.ValueType___Expr92Set);
            }
            if ((expressionId == 93)) {
                PreTraining_TypedDataContext8_ForReadOnly valDataContext93 = new PreTraining_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext93.ValueType___Expr93Get();
            }
            if ((expressionId == 94)) {
                PreTraining_TypedDataContext8_ForReadOnly valDataContext94 = new PreTraining_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext94.ValueType___Expr94Get();
            }
            if ((expressionId == 95)) {
                PreTraining_TypedDataContext8_ForReadOnly valDataContext95 = new PreTraining_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext95.ValueType___Expr95Get();
            }
            if ((expressionId == 96)) {
                PreTraining_TypedDataContext8_ForReadOnly valDataContext96 = new PreTraining_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext96.ValueType___Expr96Get();
            }
            if ((expressionId == 97)) {
                PreTraining_TypedDataContext8_ForReadOnly valDataContext97 = new PreTraining_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext97.ValueType___Expr97Get();
            }
            if ((expressionId == 98)) {
                PreTraining_TypedDataContext9_ForReadOnly valDataContext98 = new PreTraining_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext98.ValueType___Expr98Get();
            }
            if ((expressionId == 99)) {
                PreTraining_TypedDataContext9 refDataContext99 = new PreTraining_TypedDataContext9(locations, true);
                return refDataContext99.GetLocation<System.Random>(refDataContext99.ValueType___Expr99Get, refDataContext99.ValueType___Expr99Set);
            }
            if ((expressionId == 100)) {
                PreTraining_TypedDataContext9_ForReadOnly valDataContext100 = new PreTraining_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext100.ValueType___Expr100Get();
            }
            if ((expressionId == 101)) {
                PreTraining_TypedDataContext9 refDataContext101 = new PreTraining_TypedDataContext9(locations, true);
                return refDataContext101.GetLocation<System.Random>(refDataContext101.ValueType___Expr101Get, refDataContext101.ValueType___Expr101Set);
            }
            if ((expressionId == 102)) {
                PreTraining_TypedDataContext9_ForReadOnly valDataContext102 = new PreTraining_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext102.ValueType___Expr102Get();
            }
            if ((expressionId == 103)) {
                PreTraining_TypedDataContext9 refDataContext103 = new PreTraining_TypedDataContext9(locations, true);
                return refDataContext103.GetLocation<int>(refDataContext103.ValueType___Expr103Get, refDataContext103.ValueType___Expr103Set);
            }
            if ((expressionId == 104)) {
                PreTraining_TypedDataContext9_ForReadOnly valDataContext104 = new PreTraining_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext104.ValueType___Expr104Get();
            }
            if ((expressionId == 105)) {
                PreTraining_TypedDataContext9 refDataContext105 = new PreTraining_TypedDataContext9(locations, true);
                return refDataContext105.GetLocation<int>(refDataContext105.ValueType___Expr105Get, refDataContext105.ValueType___Expr105Set);
            }
            if ((expressionId == 106)) {
                PreTraining_TypedDataContext9_ForReadOnly valDataContext106 = new PreTraining_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext106.ValueType___Expr106Get();
            }
            if ((expressionId == 107)) {
                PreTraining_TypedDataContext9 refDataContext107 = new PreTraining_TypedDataContext9(locations, true);
                return refDataContext107.GetLocation<int>(refDataContext107.ValueType___Expr107Get, refDataContext107.ValueType___Expr107Set);
            }
            if ((expressionId == 108)) {
                PreTraining_TypedDataContext9_ForReadOnly valDataContext108 = new PreTraining_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext108.ValueType___Expr108Get();
            }
            if ((expressionId == 109)) {
                PreTraining_TypedDataContext9 refDataContext109 = new PreTraining_TypedDataContext9(locations, true);
                return refDataContext109.GetLocation<int>(refDataContext109.ValueType___Expr109Get, refDataContext109.ValueType___Expr109Set);
            }
            if ((expressionId == 110)) {
                PreTraining_TypedDataContext9_ForReadOnly valDataContext110 = new PreTraining_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext110.ValueType___Expr110Get();
            }
            if ((expressionId == 111)) {
                PreTraining_TypedDataContext9_ForReadOnly valDataContext111 = new PreTraining_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext111.ValueType___Expr111Get();
            }
            if ((expressionId == 112)) {
                PreTraining_TypedDataContext9_ForReadOnly valDataContext112 = new PreTraining_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext112.ValueType___Expr112Get();
            }
            if ((expressionId == 113)) {
                PreTraining_TypedDataContext9_ForReadOnly valDataContext113 = new PreTraining_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext113.ValueType___Expr113Get();
            }
            if ((expressionId == 114)) {
                PreTraining_TypedDataContext9 refDataContext114 = new PreTraining_TypedDataContext9(locations, true);
                return refDataContext114.GetLocation<float>(refDataContext114.ValueType___Expr114Get, refDataContext114.ValueType___Expr114Set);
            }
            if ((expressionId == 115)) {
                PreTraining_TypedDataContext9_ForReadOnly valDataContext115 = new PreTraining_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext115.ValueType___Expr115Get();
            }
            if ((expressionId == 116)) {
                PreTraining_TypedDataContext9 refDataContext116 = new PreTraining_TypedDataContext9(locations, true);
                return refDataContext116.GetLocation<float>(refDataContext116.ValueType___Expr116Get, refDataContext116.ValueType___Expr116Set);
            }
            if ((expressionId == 117)) {
                PreTraining_TypedDataContext9_ForReadOnly valDataContext117 = new PreTraining_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext117.ValueType___Expr117Get();
            }
            if ((expressionId == 118)) {
                PreTraining_TypedDataContext9 refDataContext118 = new PreTraining_TypedDataContext9(locations, true);
                return refDataContext118.GetLocation<string>(refDataContext118.ValueType___Expr118Get, refDataContext118.ValueType___Expr118Set);
            }
            if ((expressionId == 119)) {
                PreTraining_TypedDataContext9_ForReadOnly valDataContext119 = new PreTraining_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext119.ValueType___Expr119Get();
            }
            if ((expressionId == 120)) {
                PreTraining_TypedDataContext9_ForReadOnly valDataContext120 = new PreTraining_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext120.ValueType___Expr120Get();
            }
            if ((expressionId == 121)) {
                PreTraining_TypedDataContext9_ForReadOnly valDataContext121 = new PreTraining_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext121.ValueType___Expr121Get();
            }
            if ((expressionId == 122)) {
                PreTraining_TypedDataContext8_ForReadOnly valDataContext122 = new PreTraining_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext122.ValueType___Expr122Get();
            }
            if ((expressionId == 123)) {
                PreTraining_TypedDataContext8_ForReadOnly valDataContext123 = new PreTraining_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext123.ValueType___Expr123Get();
            }
            if ((expressionId == 124)) {
                PreTraining_TypedDataContext8_ForReadOnly valDataContext124 = new PreTraining_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext124.ValueType___Expr124Get();
            }
            if ((expressionId == 125)) {
                PreTraining_TypedDataContext8_ForReadOnly valDataContext125 = new PreTraining_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext125.ValueType___Expr125Get();
            }
            if ((expressionId == 126)) {
                PreTraining_TypedDataContext8_ForReadOnly valDataContext126 = new PreTraining_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext126.ValueType___Expr126Get();
            }
            if ((expressionId == 127)) {
                PreTraining_TypedDataContext8 refDataContext127 = new PreTraining_TypedDataContext8(locations, true);
                return refDataContext127.GetLocation<int>(refDataContext127.ValueType___Expr127Get, refDataContext127.ValueType___Expr127Set);
            }
            if ((expressionId == 128)) {
                PreTraining_TypedDataContext8_ForReadOnly valDataContext128 = new PreTraining_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext128.ValueType___Expr128Get();
            }
            if ((expressionId == 129)) {
                PreTraining_TypedDataContext8_ForReadOnly valDataContext129 = new PreTraining_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext129.ValueType___Expr129Get();
            }
            if ((expressionId == 130)) {
                PreTraining_TypedDataContext8 refDataContext130 = new PreTraining_TypedDataContext8(locations, true);
                return refDataContext130.GetLocation<int>(refDataContext130.ValueType___Expr130Get, refDataContext130.ValueType___Expr130Set);
            }
            if ((expressionId == 131)) {
                PreTraining_TypedDataContext8_ForReadOnly valDataContext131 = new PreTraining_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext131.ValueType___Expr131Get();
            }
            if ((expressionId == 132)) {
                PreTraining_TypedDataContext8 refDataContext132 = new PreTraining_TypedDataContext8(locations, true);
                return refDataContext132.GetLocation<int>(refDataContext132.ValueType___Expr132Get, refDataContext132.ValueType___Expr132Set);
            }
            if ((expressionId == 133)) {
                PreTraining_TypedDataContext11 refDataContext133 = new PreTraining_TypedDataContext11(locations, true);
                return refDataContext133.GetLocation<string>(refDataContext133.ValueType___Expr133Get, refDataContext133.ValueType___Expr133Set);
            }
            if ((expressionId == 134)) {
                PreTraining_TypedDataContext11_ForReadOnly valDataContext134 = new PreTraining_TypedDataContext11_ForReadOnly(locations, true);
                return valDataContext134.ValueType___Expr134Get();
            }
            if ((expressionId == 135)) {
                PreTraining_TypedDataContext11_ForReadOnly valDataContext135 = new PreTraining_TypedDataContext11_ForReadOnly(locations, true);
                return valDataContext135.ValueType___Expr135Get();
            }
            if ((expressionId == 136)) {
                PreTraining_TypedDataContext11 refDataContext136 = new PreTraining_TypedDataContext11(locations, true);
                return refDataContext136.GetLocation<System.Drawing.PointF>(refDataContext136.ValueType___Expr136Get, refDataContext136.ValueType___Expr136Set);
            }
            if ((expressionId == 137)) {
                PreTraining_TypedDataContext11_ForReadOnly valDataContext137 = new PreTraining_TypedDataContext11_ForReadOnly(locations, true);
                return valDataContext137.ValueType___Expr137Get();
            }
            if ((expressionId == 138)) {
                PreTraining_TypedDataContext11_ForReadOnly valDataContext138 = new PreTraining_TypedDataContext11_ForReadOnly(locations, true);
                return valDataContext138.ValueType___Expr138Get();
            }
            if ((expressionId == 139)) {
                PreTraining_TypedDataContext11_ForReadOnly valDataContext139 = new PreTraining_TypedDataContext11_ForReadOnly(locations, true);
                return valDataContext139.ValueType___Expr139Get();
            }
            if ((expressionId == 140)) {
                PreTraining_TypedDataContext11_ForReadOnly valDataContext140 = new PreTraining_TypedDataContext11_ForReadOnly(locations, true);
                return valDataContext140.ValueType___Expr140Get();
            }
            if ((expressionId == 141)) {
                PreTraining_TypedDataContext12_ForReadOnly valDataContext141 = new PreTraining_TypedDataContext12_ForReadOnly(locations, true);
                return valDataContext141.ValueType___Expr141Get();
            }
            if ((expressionId == 142)) {
                PreTraining_TypedDataContext12 refDataContext142 = new PreTraining_TypedDataContext12(locations, true);
                return refDataContext142.GetLocation<string>(refDataContext142.ValueType___Expr142Get, refDataContext142.ValueType___Expr142Set);
            }
            if ((expressionId == 143)) {
                PreTraining_TypedDataContext12_ForReadOnly valDataContext143 = new PreTraining_TypedDataContext12_ForReadOnly(locations, true);
                return valDataContext143.ValueType___Expr143Get();
            }
            if ((expressionId == 144)) {
                PreTraining_TypedDataContext12_ForReadOnly valDataContext144 = new PreTraining_TypedDataContext12_ForReadOnly(locations, true);
                return valDataContext144.ValueType___Expr144Get();
            }
            if ((expressionId == 145)) {
                PreTraining_TypedDataContext12_ForReadOnly valDataContext145 = new PreTraining_TypedDataContext12_ForReadOnly(locations, true);
                return valDataContext145.ValueType___Expr145Get();
            }
            if ((expressionId == 146)) {
                PreTraining_TypedDataContext12 refDataContext146 = new PreTraining_TypedDataContext12(locations, true);
                return refDataContext146.GetLocation<string>(refDataContext146.ValueType___Expr146Get, refDataContext146.ValueType___Expr146Set);
            }
            if ((expressionId == 147)) {
                PreTraining_TypedDataContext12_ForReadOnly valDataContext147 = new PreTraining_TypedDataContext12_ForReadOnly(locations, true);
                return valDataContext147.ValueType___Expr147Get();
            }
            if ((expressionId == 148)) {
                PreTraining_TypedDataContext12_ForReadOnly valDataContext148 = new PreTraining_TypedDataContext12_ForReadOnly(locations, true);
                return valDataContext148.ValueType___Expr148Get();
            }
            if ((expressionId == 149)) {
                PreTraining_TypedDataContext12 refDataContext149 = new PreTraining_TypedDataContext12(locations, true);
                return refDataContext149.GetLocation<System.Drawing.PointF>(refDataContext149.ValueType___Expr149Get, refDataContext149.ValueType___Expr149Set);
            }
            if ((expressionId == 150)) {
                PreTraining_TypedDataContext12_ForReadOnly valDataContext150 = new PreTraining_TypedDataContext12_ForReadOnly(locations, true);
                return valDataContext150.ValueType___Expr150Get();
            }
            if ((expressionId == 151)) {
                PreTraining_TypedDataContext12_ForReadOnly valDataContext151 = new PreTraining_TypedDataContext12_ForReadOnly(locations, true);
                return valDataContext151.ValueType___Expr151Get();
            }
            if ((expressionId == 152)) {
                PreTraining_TypedDataContext12 refDataContext152 = new PreTraining_TypedDataContext12(locations, true);
                return refDataContext152.GetLocation<int>(refDataContext152.ValueType___Expr152Get, refDataContext152.ValueType___Expr152Set);
            }
            if ((expressionId == 153)) {
                PreTraining_TypedDataContext12_ForReadOnly valDataContext153 = new PreTraining_TypedDataContext12_ForReadOnly(locations, true);
                return valDataContext153.ValueType___Expr153Get();
            }
            if ((expressionId == 154)) {
                PreTraining_TypedDataContext12_ForReadOnly valDataContext154 = new PreTraining_TypedDataContext12_ForReadOnly(locations, true);
                return valDataContext154.ValueType___Expr154Get();
            }
            if ((expressionId == 155)) {
                PreTraining_TypedDataContext13 refDataContext155 = new PreTraining_TypedDataContext13(locations, true);
                return refDataContext155.GetLocation<string>(refDataContext155.ValueType___Expr155Get, refDataContext155.ValueType___Expr155Set);
            }
            if ((expressionId == 156)) {
                PreTraining_TypedDataContext13_ForReadOnly valDataContext156 = new PreTraining_TypedDataContext13_ForReadOnly(locations, true);
                return valDataContext156.ValueType___Expr156Get();
            }
            if ((expressionId == 157)) {
                PreTraining_TypedDataContext13_ForReadOnly valDataContext157 = new PreTraining_TypedDataContext13_ForReadOnly(locations, true);
                return valDataContext157.ValueType___Expr157Get();
            }
            if ((expressionId == 158)) {
                PreTraining_TypedDataContext13 refDataContext158 = new PreTraining_TypedDataContext13(locations, true);
                return refDataContext158.GetLocation<System.Drawing.PointF>(refDataContext158.ValueType___Expr158Get, refDataContext158.ValueType___Expr158Set);
            }
            if ((expressionId == 159)) {
                PreTraining_TypedDataContext13_ForReadOnly valDataContext159 = new PreTraining_TypedDataContext13_ForReadOnly(locations, true);
                return valDataContext159.ValueType___Expr159Get();
            }
            if ((expressionId == 160)) {
                PreTraining_TypedDataContext13_ForReadOnly valDataContext160 = new PreTraining_TypedDataContext13_ForReadOnly(locations, true);
                return valDataContext160.ValueType___Expr160Get();
            }
            if ((expressionId == 161)) {
                PreTraining_TypedDataContext14_ForReadOnly valDataContext161 = new PreTraining_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext161.ValueType___Expr161Get();
            }
            if ((expressionId == 162)) {
                PreTraining_TypedDataContext14 refDataContext162 = new PreTraining_TypedDataContext14(locations, true);
                return refDataContext162.GetLocation<string>(refDataContext162.ValueType___Expr162Get, refDataContext162.ValueType___Expr162Set);
            }
            if ((expressionId == 163)) {
                PreTraining_TypedDataContext14_ForReadOnly valDataContext163 = new PreTraining_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext163.ValueType___Expr163Get();
            }
            if ((expressionId == 164)) {
                PreTraining_TypedDataContext14_ForReadOnly valDataContext164 = new PreTraining_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext164.ValueType___Expr164Get();
            }
            if ((expressionId == 165)) {
                PreTraining_TypedDataContext14_ForReadOnly valDataContext165 = new PreTraining_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext165.ValueType___Expr165Get();
            }
            if ((expressionId == 166)) {
                PreTraining_TypedDataContext14 refDataContext166 = new PreTraining_TypedDataContext14(locations, true);
                return refDataContext166.GetLocation<string>(refDataContext166.ValueType___Expr166Get, refDataContext166.ValueType___Expr166Set);
            }
            if ((expressionId == 167)) {
                PreTraining_TypedDataContext14_ForReadOnly valDataContext167 = new PreTraining_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext167.ValueType___Expr167Get();
            }
            if ((expressionId == 168)) {
                PreTraining_TypedDataContext14_ForReadOnly valDataContext168 = new PreTraining_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext168.ValueType___Expr168Get();
            }
            if ((expressionId == 169)) {
                PreTraining_TypedDataContext14 refDataContext169 = new PreTraining_TypedDataContext14(locations, true);
                return refDataContext169.GetLocation<System.Drawing.PointF>(refDataContext169.ValueType___Expr169Get, refDataContext169.ValueType___Expr169Set);
            }
            if ((expressionId == 170)) {
                PreTraining_TypedDataContext14_ForReadOnly valDataContext170 = new PreTraining_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext170.ValueType___Expr170Get();
            }
            if ((expressionId == 171)) {
                PreTraining_TypedDataContext14 refDataContext171 = new PreTraining_TypedDataContext14(locations, true);
                return refDataContext171.GetLocation<int>(refDataContext171.ValueType___Expr171Get, refDataContext171.ValueType___Expr171Set);
            }
            if ((expressionId == 172)) {
                PreTraining_TypedDataContext14_ForReadOnly valDataContext172 = new PreTraining_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext172.ValueType___Expr172Get();
            }
            if ((expressionId == 173)) {
                PreTraining_TypedDataContext14_ForReadOnly valDataContext173 = new PreTraining_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext173.ValueType___Expr173Get();
            }
            if ((expressionId == 174)) {
                PreTraining_TypedDataContext14_ForReadOnly valDataContext174 = new PreTraining_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext174.ValueType___Expr174Get();
            }
            if ((expressionId == 175)) {
                PreTraining_TypedDataContext14_ForReadOnly valDataContext175 = new PreTraining_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext175.ValueType___Expr175Get();
            }
            if ((expressionId == 176)) {
                PreTraining_TypedDataContext15_ForReadOnly valDataContext176 = new PreTraining_TypedDataContext15_ForReadOnly(locations, true);
                return valDataContext176.ValueType___Expr176Get();
            }
            if ((expressionId == 177)) {
                PreTraining_TypedDataContext15_ForReadOnly valDataContext177 = new PreTraining_TypedDataContext15_ForReadOnly(locations, true);
                return valDataContext177.ValueType___Expr177Get();
            }
            if ((expressionId == 178)) {
                PreTraining_TypedDataContext15 refDataContext178 = new PreTraining_TypedDataContext15(locations, true);
                return refDataContext178.GetLocation<string>(refDataContext178.ValueType___Expr178Get, refDataContext178.ValueType___Expr178Set);
            }
            if ((expressionId == 179)) {
                PreTraining_TypedDataContext15_ForReadOnly valDataContext179 = new PreTraining_TypedDataContext15_ForReadOnly(locations, true);
                return valDataContext179.ValueType___Expr179Get();
            }
            if ((expressionId == 180)) {
                PreTraining_TypedDataContext15_ForReadOnly valDataContext180 = new PreTraining_TypedDataContext15_ForReadOnly(locations, true);
                return valDataContext180.ValueType___Expr180Get();
            }
            if ((expressionId == 181)) {
                PreTraining_TypedDataContext15_ForReadOnly valDataContext181 = new PreTraining_TypedDataContext15_ForReadOnly(locations, true);
                return valDataContext181.ValueType___Expr181Get();
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
                        && ((expressionText == "Reporte") 
                        && (PreTraining_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new List<string>();") 
                        && (PreTraining_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Recorrido") 
                        && (PreTraining_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Cercania") 
                        && (PreTraining_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Continuar") 
                        && (PreTraining_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new PointF(0,0)") 
                        && (PreTraining_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Cruz") 
                        && (PreTraining_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new List<PointF>()") 
                        && (PreTraining_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "PosicionCruz") 
                        && (PreTraining_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "360/Separacion") 
                        && (PreTraining_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "TotalBanderas") 
                        && (PreTraining_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new List<Int32>()") 
                        && (PreTraining_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "BanderasAparecidas") 
                        && (PreTraining_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "RtaCave") 
                        && (PreTraining_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RtaCave.Split(\';\').Length > 1") 
                        && (PreTraining_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 15;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new PointF(Single.Parse(RtaCave.Split(\';\')[0].Replace(\".\", \",\")), Single.Parse(Rt" +
                            "aCave.Split(\';\')[1].Replace(\".\", \",\")))") 
                        && (PreTraining_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 16;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Coordenadas") 
                        && (PreTraining_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 17;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Agregar180") 
                        && (PreTraining_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 18;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"L{ \\\"id\\\":\\\"null\\\" }\"") 
                        && (PreTraining_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 19;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Reporte") 
                        && (PreTraining_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 20;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Inicia: \" + DateTime.Now.ToString()") 
                        && (PreTraining_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 21;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DateTime.Now.ToString() + \";\" +\n                Coordenadas.X + \";\" + Coordenadas" +
                            ".Y + \";DET\"") 
                        && (PreTraining_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 22;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Mensaje") 
                        && (PreTraining_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 23;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Recorrido") 
                        && (PreTraining_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 24;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Mensaje") 
                        && (PreTraining_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 25;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Mensaje") 
                        && (PreTraining_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 26;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"X{ \\\"value\\\":\\\"rojo\\\" }\"") 
                        && (PreTraining_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 27;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TimeSpan.FromSeconds(1);") 
                        && (PreTraining_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 28;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"X{ \\\"value\\\":\\\"negro\\\" }\"") 
                        && (PreTraining_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 29;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Q{ \\\"text\\\":\\\"Trial \" + (int)(BanderasAparecidas.Count + 1) + \" \\\" }\"") 
                        && (PreTraining_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 30;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TimeSpan.FromSeconds(2)") 
                        && (PreTraining_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 31;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Iteracion;\"+BanderasAparecidas.Count") 
                        && (PreTraining_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 32;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Mensaje") 
                        && (PreTraining_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 33;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Reporte") 
                        && (PreTraining_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 34;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Mensaje") 
                        && (PreTraining_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 35;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Mensaje") 
                        && (PreTraining_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 36;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "RtaCave") 
                        && (PreTraining_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 37;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RtaCave.Split(\';\').Length > 1") 
                        && (PreTraining_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 38;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new PointF(Single.Parse(RtaCave.Split(\';\')[0].Replace(\".\", \",\")), Single.Parse(Rt" +
                            "aCave.Split(\';\')[1].Replace(\".\", \",\")))") 
                        && (PreTraining_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 39;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Coordenadas") 
                        && (PreTraining_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 40;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Continuar>0") 
                        && (PreTraining_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 41;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new Random()") 
                        && (PreTraining_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 42;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Random") 
                        && (PreTraining_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 43;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Random.Next(0,BanderasCircunferencia.Count)") 
                        && (PreTraining_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 44;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "BanderaRandom") 
                        && (PreTraining_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 45;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Random.Next(0,TotalBanderas)") 
                        && (PreTraining_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 46;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "BanderaRandom") 
                        && (PreTraining_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 47;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "BanderasAparecidas.Contains(BanderaRandom)") 
                        && (PreTraining_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 48;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "BanderasAparecidas") 
                        && (PreTraining_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 49;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "BanderaRandom") 
                        && (PreTraining_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 50;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"H{ \\\"id\\\":\\\"\" + (int)(BanderaRandom) + \"\\\", \\\"visible\\\":\\\"true\\\" }\"") 
                        && (PreTraining_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 51;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Hora;\"+DateTime.Now.ToString()+\"\\nBandera;\" + BanderaRandom + \"\\nX;\" + BanderasC" +
                            "ircunferencia.ElementAt(BanderaRandom).X + \"\\nY;\" + BanderasCircunferencia.Eleme" +
                            "ntAt(BanderaRandom).Y") 
                        && (PreTraining_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 52;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Mensaje") 
                        && (PreTraining_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 53;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Reporte") 
                        && (PreTraining_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 54;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Mensaje") 
                        && (PreTraining_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 55;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Mensaje") 
                        && (PreTraining_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 56;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "!(Continuar > 0)") 
                        && (PreTraining_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 57;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DateTime.Now.ToString() + \";\" + Coordenadas.X + \";\" + Coordenadas.Y + \";\" + \"BUS\"" +
                            "") 
                        && (PreTraining_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 58;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Mensaje") 
                        && (PreTraining_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 59;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Recorrido") 
                        && (PreTraining_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 60;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Mensaje") 
                        && (PreTraining_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 61;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Mensaje") 
                        && (PreTraining_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 62;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "RtaCave") 
                        && (PreTraining_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 63;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RtaCave.Split(\';\').Length > 1") 
                        && (PreTraining_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 64;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new PointF(Single.Parse(RtaCave.Split(\';\')[0].Replace(\".\", \",\")), Single.Parse(Rt" +
                            "aCave.Split(\';\')[1].Replace(\".\", \",\")))") 
                        && (PreTraining_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 65;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Coordenadas") 
                        && (PreTraining_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 66;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Sqrt((Math.Pow(Coordenadas.X - BanderasCircunferencia[BanderaRandom].X, 2)) " +
                            "+ Math.Pow(Coordenadas.Y - BanderasCircunferencia[BanderaRandom].Y, 2)) < Cercan" +
                            "ia") 
                        && (PreTraining_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 67;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"H{ \\\"id\\\":\\\"\" + (int)(BanderaRandom) + \"\\\", \\\"visible\\\":\\\"false\\\" }\"") 
                        && (PreTraining_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 68;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Hora Captura;\"+DateTime.Now.ToString()") 
                        && (PreTraining_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 69;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Mensaje") 
                        && (PreTraining_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 70;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Reporte") 
                        && (PreTraining_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 71;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Mensaje") 
                        && (PreTraining_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 72;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Mensaje") 
                        && (PreTraining_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 73;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DateTime.Now.ToString() + \";\" + Coordenadas.X + \";\" + Coordenadas.Y + \";\" + Bande" +
                            "rasCircunferencia[BanderaRandom].X + \";\" + BanderasCircunferencia[BanderaRandom]" +
                            ".Y + \";\" + BanderaRandom + \";CAP\"") 
                        && (PreTraining_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 74;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Mensaje") 
                        && (PreTraining_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 75;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Recorrido") 
                        && (PreTraining_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 76;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Mensaje") 
                        && (PreTraining_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 77;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Mensaje") 
                        && (PreTraining_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 78;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "!(Math.Sqrt((Math.Pow(Coordenadas.X - BanderasCircunferencia[BanderaRandom].X, 2)" +
                            ") + Math.Pow(Coordenadas.Y - BanderasCircunferencia[BanderaRandom].Y, 2)) < Cerc" +
                            "ania)") 
                        && (PreTraining_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 79;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Q{ \\\"text\\\":\\\"Fin del experimento\\\" }\"") 
                        && (PreTraining_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 80;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Recorrido") 
                        && (PreTraining_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 81;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DateTime.Now.ToString()+\";\"+Coordenadas.X+\";\"+Coordenadas.Y+\";\"+\";FIN\"") 
                        && (PreTraining_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 82;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DateTime.Now.ToString() + \";\" + Coordenadas.X + \";\" + Coordenadas.Y + \";\" + \"NULL" +
                            ";NULL;NULL;FIN\"") 
                        && (PreTraining_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 83;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TimeSpan.FromSeconds(5)") 
                        && (PreTraining_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 84;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"C{ \\\"id\\\":\\\"\" + (int)(Cursor) + \"\\\", \\\"color\\\":\\\"\" + ColorSeleccion + \"\\\" }\"") 
                        && (PreTraining_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 85;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "RtaCave") 
                        && (PreTraining_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 86;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RtaCave.Split(\';\').Length > 1") 
                        && (PreTraining_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 87;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new PointF(Single.Parse(RtaCave.Split(\';\')[0].Replace(\".\", \",\")), Single.Parse(Rt" +
                            "aCave.Split(\';\')[1].Replace(\".\", \",\")))") 
                        && (PreTraining_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 88;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Coordenadas") 
                        && (PreTraining_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 89;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RtaCave.Equals(\"2\")") 
                        && (PreTraining_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 90;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Selecciona;\"+Cursor+\n\"\\nX;\"+BanderasCircunferencia.ElementAt(Cursor).X +\n\"\\nY;\"+" +
                            "BanderasCircunferencia.ElementAt(Cursor).Y +\n\"\\nHoraSelecciona;\"+DateTime.Now.To" +
                            "String()") 
                        && (PreTraining_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 91;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Mensaje") 
                        && (PreTraining_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 92;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Reporte") 
                        && (PreTraining_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 93;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Mensaje") 
                        && (PreTraining_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 94;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Mensaje") 
                        && (PreTraining_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 95;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"C{ \\\"id\\\":\\\"\" + (int)(Cursor) + \"\\\", \\\"color\\\":\\\"\" + ColorBandera + \"\\\" }\"") 
                        && (PreTraining_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 96;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Mostrar180.Replace(\"true\", \"false\")") 
                        && (PreTraining_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 97;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new Random()") 
                        && (PreTraining_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 98;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "RandomX") 
                        && (PreTraining_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 99;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new Random()") 
                        && (PreTraining_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 100;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "RandomY") 
                        && (PreTraining_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 101;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RandomX.Next(-13,13)") 
                        && (PreTraining_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 102;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "CruzX") 
                        && (PreTraining_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 103;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RandomY.Next(-13, 13)") 
                        && (PreTraining_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 104;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "CruzY") 
                        && (PreTraining_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 105;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RandomX.Next(-13,13)") 
                        && (PreTraining_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 106;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "CruzX") 
                        && (PreTraining_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 107;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RandomY.Next(-13,13)") 
                        && (PreTraining_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 108;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "CruzY") 
                        && (PreTraining_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 109;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Math.Sqrt(Math.Pow(Cruz.X-CruzX,2)+Math.Pow(Cruz.Y-CruzY,2))<Cercania) || (Posic" +
                            "ionCruz.Contains(new PointF(CruzX,CruzY)))") 
                        && (PreTraining_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 110;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "PosicionCruz") 
                        && (PreTraining_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 111;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Cruz") 
                        && (PreTraining_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 112;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CruzX") 
                        && (PreTraining_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 113;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Cruz.X") 
                        && (PreTraining_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 114;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CruzY") 
                        && (PreTraining_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 115;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Cruz.Y") 
                        && (PreTraining_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 116;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"CruzX;\"+CruzX+\"\\nCruzY;\"+CruzY") 
                        && (PreTraining_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 117;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Mensaje") 
                        && (PreTraining_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 118;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Reporte") 
                        && (PreTraining_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 119;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Mensaje") 
                        && (PreTraining_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 120;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Mensaje") 
                        && (PreTraining_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 121;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Q{ \\\"text\\\":\\\"Terminar Experimento?\\\" }\"") 
                        && (PreTraining_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 122;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RtaCave.Equals(\"1\") || RtaCave.Equals(\"3\")") 
                        && (PreTraining_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 123;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"C{ \\\"id\\\":\\\"\" + (int)(Cursor) + \"\\\", \\\"color\\\":\\\"\" + ColorBandera + \"\\\" }\"") 
                        && (PreTraining_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 124;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RtaCave.Equals(\"1\")") 
                        && (PreTraining_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 125;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Cursor - 1) % BanderasCircunferencia.Count") 
                        && (PreTraining_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 126;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Cursor") 
                        && (PreTraining_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 127;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Cursor<0") 
                        && (PreTraining_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 128;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "BanderasCircunferencia.Count-1") 
                        && (PreTraining_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 129;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Cursor") 
                        && (PreTraining_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 130;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Cursor + 1) % BanderasCircunferencia.Count") 
                        && (PreTraining_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 131;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Cursor") 
                        && (PreTraining_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 132;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "RtaCave") 
                        && (PreTraining_TypedDataContext11.Validate(locations, true, 0) == true)))) {
                expressionId = 133;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RtaCave.Split(\';\').Length > 1") 
                        && (PreTraining_TypedDataContext11_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 134;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new PointF(Single.Parse(RtaCave.Split(\';\')[0].Replace(\".\", \",\")), Single.Parse(Rt" +
                            "aCave.Split(\';\')[1].Replace(\".\", \",\")))") 
                        && (PreTraining_TypedDataContext11_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 135;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Coordenadas") 
                        && (PreTraining_TypedDataContext11.Validate(locations, true, 0) == true)))) {
                expressionId = 136;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RtaCave.Equals(\"2\")") 
                        && (PreTraining_TypedDataContext11_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 137;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "!RtaCave.Equals(\"1\") && !RtaCave.Equals(\"2\")") 
                        && (PreTraining_TypedDataContext11_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 138;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RtaCave.Equals(\"1\")") 
                        && (PreTraining_TypedDataContext11_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 139;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"M{ \\\"x\\\":\\\"\"+Cruz.X+\"\\\", \\\"y\\\":\\\"\"+Cruz.Y+\"\\\" }\"") 
                        && (PreTraining_TypedDataContext11_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 140;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DateTime.Now.ToString() + \";\" + Coordenadas.X + \";\" + Coordenadas.Y + \";\" + \"NULL" +
                            ";NULL;NULL;CEN\"") 
                        && (PreTraining_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 141;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Mensaje") 
                        && (PreTraining_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 142;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Recorrido") 
                        && (PreTraining_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 143;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Mensaje") 
                        && (PreTraining_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 144;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Mensaje") 
                        && (PreTraining_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 145;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "RtaCave") 
                        && (PreTraining_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 146;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RtaCave.Split(\';\').Length > 1") 
                        && (PreTraining_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 147;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new PointF(Single.Parse(RtaCave.Split(\';\')[0].Replace(\".\", \",\")), Single.Parse(Rt" +
                            "aCave.Split(\';\')[1].Replace(\".\", \",\")))") 
                        && (PreTraining_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 148;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Coordenadas") 
                        && (PreTraining_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 149;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "!(Math.Sqrt((Math.Pow(Coordenadas.X - Cruz.X, 2)) + Math.Pow(Coordenadas.Y - Cruz" +
                            ".Y, 2)) < Cercania)") 
                        && (PreTraining_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 150;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Sqrt((Math.Pow(Coordenadas.X - Cruz.X, 2)) + Math.Pow(Coordenadas.Y - Cruz.Y" +
                            ", 2)) < Cercania") 
                        && (PreTraining_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 151;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Cursor") 
                        && (PreTraining_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 152;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Q{ \\\"text\\\":\\\"Marca la bandera que recolectaste.\\\" }\"") 
                        && (PreTraining_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 153;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Mostrar180") 
                        && (PreTraining_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 154;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "RtaCave") 
                        && (PreTraining_TypedDataContext13.Validate(locations, true, 0) == true)))) {
                expressionId = 155;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RtaCave.Split(\';\').Length > 1") 
                        && (PreTraining_TypedDataContext13_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 156;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new PointF(Single.Parse(RtaCave.Split(\';\')[0].Replace(\".\", \",\")), Single.Parse(Rt" +
                            "aCave.Split(\';\')[1].Replace(\".\", \",\")))") 
                        && (PreTraining_TypedDataContext13_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 157;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Coordenadas") 
                        && (PreTraining_TypedDataContext13.Validate(locations, true, 0) == true)))) {
                expressionId = 158;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Sqrt((Math.Pow(Coordenadas.X - Cruz.X, 2)) + Math.Pow(Coordenadas.Y - Cruz.Y" +
                            ", 2)) < Cercania") 
                        && (PreTraining_TypedDataContext13_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 159;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "!(Math.Sqrt((Math.Pow(Coordenadas.X - Cruz.X, 2)) + Math.Pow(Coordenadas.Y - Cruz" +
                            ".Y, 2)) < Cercania)") 
                        && (PreTraining_TypedDataContext13_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 160;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DateTime.Now.ToString() + \";\" + Coordenadas.X + \";\" + Coordenadas.Y + \";EVA\"") 
                        && (PreTraining_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 161;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Mensaje") 
                        && (PreTraining_TypedDataContext14.Validate(locations, true, 0) == true)))) {
                expressionId = 162;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Recorrido") 
                        && (PreTraining_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 163;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Mensaje") 
                        && (PreTraining_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 164;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Mensaje") 
                        && (PreTraining_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 165;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "RtaCave") 
                        && (PreTraining_TypedDataContext14.Validate(locations, true, 0) == true)))) {
                expressionId = 166;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RtaCave.Split(\';\').Length > 1") 
                        && (PreTraining_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 167;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new PointF(Single.Parse(RtaCave.Split(\';\')[0].Replace(\".\", \",\")), Single.Parse(Rt" +
                            "aCave.Split(\';\')[1].Replace(\".\", \",\")))") 
                        && (PreTraining_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 168;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Coordenadas") 
                        && (PreTraining_TypedDataContext14.Validate(locations, true, 0) == true)))) {
                expressionId = 169;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(BanderasAparecidas.Count().CompareTo(Protocolo.Length) < 0 && !(Protocolo[Bander" +
                            "asAparecidas.Count()].Equals(1)) && !(Protocolo[BanderasAparecidas.Count()].Equa" +
                            "ls(3))) || !(BanderasAparecidas.Count().CompareTo(Protocolo.Length) <0)") 
                        && (PreTraining_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 170;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Cursor") 
                        && (PreTraining_TypedDataContext14.Validate(locations, true, 0) == true)))) {
                expressionId = 171;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Q{ \\\"text\\\":\\\"Escucha la consigna\\\" }\"") 
                        && (PreTraining_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 172;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TimeSpan.FromSeconds(4)") 
                        && (PreTraining_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 173;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Q{ \\\"text\\\":\\\"X(izq) Y(Sel) B(der)\\\" }\"") 
                        && (PreTraining_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 174;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Mostrar180") 
                        && (PreTraining_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 175;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"C{ \\\"id\\\":\\\"\" + (int)(Cursor) + \"\\\", \\\"color\\\":\\\"azul\\\" }\"") 
                        && (PreTraining_TypedDataContext15_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 176;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DateTime.Now.ToString() + \";\" + Coordenadas.X + \";\" + Coordenadas.Y + \";PR2\"") 
                        && (PreTraining_TypedDataContext15_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 177;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Mensaje") 
                        && (PreTraining_TypedDataContext15.Validate(locations, true, 0) == true)))) {
                expressionId = 178;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Recorrido") 
                        && (PreTraining_TypedDataContext15_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 179;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Mensaje") 
                        && (PreTraining_TypedDataContext15_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 180;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Mensaje") 
                        && (PreTraining_TypedDataContext15_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 181;
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
                return new PreTraining_TypedDataContext3_ForReadOnly(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new PreTraining_TypedDataContext3(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new PreTraining_TypedDataContext3(locationReferences).@__Expr4GetTree();
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
                return new PreTraining_TypedDataContext3_ForReadOnly(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new PreTraining_TypedDataContext3(locationReferences).@__Expr13GetTree();
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
                return new PreTraining_TypedDataContext3(locationReferences).@__Expr17GetTree();
            }
            if ((expressionId == 18)) {
                return new PreTraining_TypedDataContext3_ForReadOnly(locationReferences).@__Expr18GetTree();
            }
            if ((expressionId == 19)) {
                return new PreTraining_TypedDataContext3_ForReadOnly(locationReferences).@__Expr19GetTree();
            }
            if ((expressionId == 20)) {
                return new PreTraining_TypedDataContext3_ForReadOnly(locationReferences).@__Expr20GetTree();
            }
            if ((expressionId == 21)) {
                return new PreTraining_TypedDataContext3_ForReadOnly(locationReferences).@__Expr21GetTree();
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
                return new PreTraining_TypedDataContext4_ForReadOnly(locationReferences).@__Expr25GetTree();
            }
            if ((expressionId == 26)) {
                return new PreTraining_TypedDataContext4_ForReadOnly(locationReferences).@__Expr26GetTree();
            }
            if ((expressionId == 27)) {
                return new PreTraining_TypedDataContext4_ForReadOnly(locationReferences).@__Expr27GetTree();
            }
            if ((expressionId == 28)) {
                return new PreTraining_TypedDataContext4_ForReadOnly(locationReferences).@__Expr28GetTree();
            }
            if ((expressionId == 29)) {
                return new PreTraining_TypedDataContext4_ForReadOnly(locationReferences).@__Expr29GetTree();
            }
            if ((expressionId == 30)) {
                return new PreTraining_TypedDataContext4_ForReadOnly(locationReferences).@__Expr30GetTree();
            }
            if ((expressionId == 31)) {
                return new PreTraining_TypedDataContext4_ForReadOnly(locationReferences).@__Expr31GetTree();
            }
            if ((expressionId == 32)) {
                return new PreTraining_TypedDataContext4_ForReadOnly(locationReferences).@__Expr32GetTree();
            }
            if ((expressionId == 33)) {
                return new PreTraining_TypedDataContext4(locationReferences).@__Expr33GetTree();
            }
            if ((expressionId == 34)) {
                return new PreTraining_TypedDataContext4_ForReadOnly(locationReferences).@__Expr34GetTree();
            }
            if ((expressionId == 35)) {
                return new PreTraining_TypedDataContext4_ForReadOnly(locationReferences).@__Expr35GetTree();
            }
            if ((expressionId == 36)) {
                return new PreTraining_TypedDataContext4_ForReadOnly(locationReferences).@__Expr36GetTree();
            }
            if ((expressionId == 37)) {
                return new PreTraining_TypedDataContext4(locationReferences).@__Expr37GetTree();
            }
            if ((expressionId == 38)) {
                return new PreTraining_TypedDataContext4_ForReadOnly(locationReferences).@__Expr38GetTree();
            }
            if ((expressionId == 39)) {
                return new PreTraining_TypedDataContext4_ForReadOnly(locationReferences).@__Expr39GetTree();
            }
            if ((expressionId == 40)) {
                return new PreTraining_TypedDataContext4(locationReferences).@__Expr40GetTree();
            }
            if ((expressionId == 41)) {
                return new PreTraining_TypedDataContext4_ForReadOnly(locationReferences).@__Expr41GetTree();
            }
            if ((expressionId == 42)) {
                return new PreTraining_TypedDataContext5_ForReadOnly(locationReferences).@__Expr42GetTree();
            }
            if ((expressionId == 43)) {
                return new PreTraining_TypedDataContext5(locationReferences).@__Expr43GetTree();
            }
            if ((expressionId == 44)) {
                return new PreTraining_TypedDataContext5_ForReadOnly(locationReferences).@__Expr44GetTree();
            }
            if ((expressionId == 45)) {
                return new PreTraining_TypedDataContext5(locationReferences).@__Expr45GetTree();
            }
            if ((expressionId == 46)) {
                return new PreTraining_TypedDataContext5_ForReadOnly(locationReferences).@__Expr46GetTree();
            }
            if ((expressionId == 47)) {
                return new PreTraining_TypedDataContext5(locationReferences).@__Expr47GetTree();
            }
            if ((expressionId == 48)) {
                return new PreTraining_TypedDataContext5_ForReadOnly(locationReferences).@__Expr48GetTree();
            }
            if ((expressionId == 49)) {
                return new PreTraining_TypedDataContext5_ForReadOnly(locationReferences).@__Expr49GetTree();
            }
            if ((expressionId == 50)) {
                return new PreTraining_TypedDataContext5_ForReadOnly(locationReferences).@__Expr50GetTree();
            }
            if ((expressionId == 51)) {
                return new PreTraining_TypedDataContext5_ForReadOnly(locationReferences).@__Expr51GetTree();
            }
            if ((expressionId == 52)) {
                return new PreTraining_TypedDataContext5_ForReadOnly(locationReferences).@__Expr52GetTree();
            }
            if ((expressionId == 53)) {
                return new PreTraining_TypedDataContext5(locationReferences).@__Expr53GetTree();
            }
            if ((expressionId == 54)) {
                return new PreTraining_TypedDataContext5_ForReadOnly(locationReferences).@__Expr54GetTree();
            }
            if ((expressionId == 55)) {
                return new PreTraining_TypedDataContext5_ForReadOnly(locationReferences).@__Expr55GetTree();
            }
            if ((expressionId == 56)) {
                return new PreTraining_TypedDataContext5_ForReadOnly(locationReferences).@__Expr56GetTree();
            }
            if ((expressionId == 57)) {
                return new PreTraining_TypedDataContext4_ForReadOnly(locationReferences).@__Expr57GetTree();
            }
            if ((expressionId == 58)) {
                return new PreTraining_TypedDataContext6_ForReadOnly(locationReferences).@__Expr58GetTree();
            }
            if ((expressionId == 59)) {
                return new PreTraining_TypedDataContext6(locationReferences).@__Expr59GetTree();
            }
            if ((expressionId == 60)) {
                return new PreTraining_TypedDataContext6_ForReadOnly(locationReferences).@__Expr60GetTree();
            }
            if ((expressionId == 61)) {
                return new PreTraining_TypedDataContext6_ForReadOnly(locationReferences).@__Expr61GetTree();
            }
            if ((expressionId == 62)) {
                return new PreTraining_TypedDataContext6_ForReadOnly(locationReferences).@__Expr62GetTree();
            }
            if ((expressionId == 63)) {
                return new PreTraining_TypedDataContext6(locationReferences).@__Expr63GetTree();
            }
            if ((expressionId == 64)) {
                return new PreTraining_TypedDataContext6_ForReadOnly(locationReferences).@__Expr64GetTree();
            }
            if ((expressionId == 65)) {
                return new PreTraining_TypedDataContext6_ForReadOnly(locationReferences).@__Expr65GetTree();
            }
            if ((expressionId == 66)) {
                return new PreTraining_TypedDataContext6(locationReferences).@__Expr66GetTree();
            }
            if ((expressionId == 67)) {
                return new PreTraining_TypedDataContext6_ForReadOnly(locationReferences).@__Expr67GetTree();
            }
            if ((expressionId == 68)) {
                return new PreTraining_TypedDataContext6_ForReadOnly(locationReferences).@__Expr68GetTree();
            }
            if ((expressionId == 69)) {
                return new PreTraining_TypedDataContext6_ForReadOnly(locationReferences).@__Expr69GetTree();
            }
            if ((expressionId == 70)) {
                return new PreTraining_TypedDataContext6(locationReferences).@__Expr70GetTree();
            }
            if ((expressionId == 71)) {
                return new PreTraining_TypedDataContext6_ForReadOnly(locationReferences).@__Expr71GetTree();
            }
            if ((expressionId == 72)) {
                return new PreTraining_TypedDataContext6_ForReadOnly(locationReferences).@__Expr72GetTree();
            }
            if ((expressionId == 73)) {
                return new PreTraining_TypedDataContext6_ForReadOnly(locationReferences).@__Expr73GetTree();
            }
            if ((expressionId == 74)) {
                return new PreTraining_TypedDataContext6_ForReadOnly(locationReferences).@__Expr74GetTree();
            }
            if ((expressionId == 75)) {
                return new PreTraining_TypedDataContext6(locationReferences).@__Expr75GetTree();
            }
            if ((expressionId == 76)) {
                return new PreTraining_TypedDataContext6_ForReadOnly(locationReferences).@__Expr76GetTree();
            }
            if ((expressionId == 77)) {
                return new PreTraining_TypedDataContext6_ForReadOnly(locationReferences).@__Expr77GetTree();
            }
            if ((expressionId == 78)) {
                return new PreTraining_TypedDataContext6_ForReadOnly(locationReferences).@__Expr78GetTree();
            }
            if ((expressionId == 79)) {
                return new PreTraining_TypedDataContext6_ForReadOnly(locationReferences).@__Expr79GetTree();
            }
            if ((expressionId == 80)) {
                return new PreTraining_TypedDataContext7_ForReadOnly(locationReferences).@__Expr80GetTree();
            }
            if ((expressionId == 81)) {
                return new PreTraining_TypedDataContext7_ForReadOnly(locationReferences).@__Expr81GetTree();
            }
            if ((expressionId == 82)) {
                return new PreTraining_TypedDataContext7_ForReadOnly(locationReferences).@__Expr82GetTree();
            }
            if ((expressionId == 83)) {
                return new PreTraining_TypedDataContext7_ForReadOnly(locationReferences).@__Expr83GetTree();
            }
            if ((expressionId == 84)) {
                return new PreTraining_TypedDataContext7_ForReadOnly(locationReferences).@__Expr84GetTree();
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
                return new PreTraining_TypedDataContext8_ForReadOnly(locationReferences).@__Expr91GetTree();
            }
            if ((expressionId == 92)) {
                return new PreTraining_TypedDataContext8(locationReferences).@__Expr92GetTree();
            }
            if ((expressionId == 93)) {
                return new PreTraining_TypedDataContext8_ForReadOnly(locationReferences).@__Expr93GetTree();
            }
            if ((expressionId == 94)) {
                return new PreTraining_TypedDataContext8_ForReadOnly(locationReferences).@__Expr94GetTree();
            }
            if ((expressionId == 95)) {
                return new PreTraining_TypedDataContext8_ForReadOnly(locationReferences).@__Expr95GetTree();
            }
            if ((expressionId == 96)) {
                return new PreTraining_TypedDataContext8_ForReadOnly(locationReferences).@__Expr96GetTree();
            }
            if ((expressionId == 97)) {
                return new PreTraining_TypedDataContext8_ForReadOnly(locationReferences).@__Expr97GetTree();
            }
            if ((expressionId == 98)) {
                return new PreTraining_TypedDataContext9_ForReadOnly(locationReferences).@__Expr98GetTree();
            }
            if ((expressionId == 99)) {
                return new PreTraining_TypedDataContext9(locationReferences).@__Expr99GetTree();
            }
            if ((expressionId == 100)) {
                return new PreTraining_TypedDataContext9_ForReadOnly(locationReferences).@__Expr100GetTree();
            }
            if ((expressionId == 101)) {
                return new PreTraining_TypedDataContext9(locationReferences).@__Expr101GetTree();
            }
            if ((expressionId == 102)) {
                return new PreTraining_TypedDataContext9_ForReadOnly(locationReferences).@__Expr102GetTree();
            }
            if ((expressionId == 103)) {
                return new PreTraining_TypedDataContext9(locationReferences).@__Expr103GetTree();
            }
            if ((expressionId == 104)) {
                return new PreTraining_TypedDataContext9_ForReadOnly(locationReferences).@__Expr104GetTree();
            }
            if ((expressionId == 105)) {
                return new PreTraining_TypedDataContext9(locationReferences).@__Expr105GetTree();
            }
            if ((expressionId == 106)) {
                return new PreTraining_TypedDataContext9_ForReadOnly(locationReferences).@__Expr106GetTree();
            }
            if ((expressionId == 107)) {
                return new PreTraining_TypedDataContext9(locationReferences).@__Expr107GetTree();
            }
            if ((expressionId == 108)) {
                return new PreTraining_TypedDataContext9_ForReadOnly(locationReferences).@__Expr108GetTree();
            }
            if ((expressionId == 109)) {
                return new PreTraining_TypedDataContext9(locationReferences).@__Expr109GetTree();
            }
            if ((expressionId == 110)) {
                return new PreTraining_TypedDataContext9_ForReadOnly(locationReferences).@__Expr110GetTree();
            }
            if ((expressionId == 111)) {
                return new PreTraining_TypedDataContext9_ForReadOnly(locationReferences).@__Expr111GetTree();
            }
            if ((expressionId == 112)) {
                return new PreTraining_TypedDataContext9_ForReadOnly(locationReferences).@__Expr112GetTree();
            }
            if ((expressionId == 113)) {
                return new PreTraining_TypedDataContext9_ForReadOnly(locationReferences).@__Expr113GetTree();
            }
            if ((expressionId == 114)) {
                return new PreTraining_TypedDataContext9(locationReferences).@__Expr114GetTree();
            }
            if ((expressionId == 115)) {
                return new PreTraining_TypedDataContext9_ForReadOnly(locationReferences).@__Expr115GetTree();
            }
            if ((expressionId == 116)) {
                return new PreTraining_TypedDataContext9(locationReferences).@__Expr116GetTree();
            }
            if ((expressionId == 117)) {
                return new PreTraining_TypedDataContext9_ForReadOnly(locationReferences).@__Expr117GetTree();
            }
            if ((expressionId == 118)) {
                return new PreTraining_TypedDataContext9(locationReferences).@__Expr118GetTree();
            }
            if ((expressionId == 119)) {
                return new PreTraining_TypedDataContext9_ForReadOnly(locationReferences).@__Expr119GetTree();
            }
            if ((expressionId == 120)) {
                return new PreTraining_TypedDataContext9_ForReadOnly(locationReferences).@__Expr120GetTree();
            }
            if ((expressionId == 121)) {
                return new PreTraining_TypedDataContext9_ForReadOnly(locationReferences).@__Expr121GetTree();
            }
            if ((expressionId == 122)) {
                return new PreTraining_TypedDataContext8_ForReadOnly(locationReferences).@__Expr122GetTree();
            }
            if ((expressionId == 123)) {
                return new PreTraining_TypedDataContext8_ForReadOnly(locationReferences).@__Expr123GetTree();
            }
            if ((expressionId == 124)) {
                return new PreTraining_TypedDataContext8_ForReadOnly(locationReferences).@__Expr124GetTree();
            }
            if ((expressionId == 125)) {
                return new PreTraining_TypedDataContext8_ForReadOnly(locationReferences).@__Expr125GetTree();
            }
            if ((expressionId == 126)) {
                return new PreTraining_TypedDataContext8_ForReadOnly(locationReferences).@__Expr126GetTree();
            }
            if ((expressionId == 127)) {
                return new PreTraining_TypedDataContext8(locationReferences).@__Expr127GetTree();
            }
            if ((expressionId == 128)) {
                return new PreTraining_TypedDataContext8_ForReadOnly(locationReferences).@__Expr128GetTree();
            }
            if ((expressionId == 129)) {
                return new PreTraining_TypedDataContext8_ForReadOnly(locationReferences).@__Expr129GetTree();
            }
            if ((expressionId == 130)) {
                return new PreTraining_TypedDataContext8(locationReferences).@__Expr130GetTree();
            }
            if ((expressionId == 131)) {
                return new PreTraining_TypedDataContext8_ForReadOnly(locationReferences).@__Expr131GetTree();
            }
            if ((expressionId == 132)) {
                return new PreTraining_TypedDataContext8(locationReferences).@__Expr132GetTree();
            }
            if ((expressionId == 133)) {
                return new PreTraining_TypedDataContext11(locationReferences).@__Expr133GetTree();
            }
            if ((expressionId == 134)) {
                return new PreTraining_TypedDataContext11_ForReadOnly(locationReferences).@__Expr134GetTree();
            }
            if ((expressionId == 135)) {
                return new PreTraining_TypedDataContext11_ForReadOnly(locationReferences).@__Expr135GetTree();
            }
            if ((expressionId == 136)) {
                return new PreTraining_TypedDataContext11(locationReferences).@__Expr136GetTree();
            }
            if ((expressionId == 137)) {
                return new PreTraining_TypedDataContext11_ForReadOnly(locationReferences).@__Expr137GetTree();
            }
            if ((expressionId == 138)) {
                return new PreTraining_TypedDataContext11_ForReadOnly(locationReferences).@__Expr138GetTree();
            }
            if ((expressionId == 139)) {
                return new PreTraining_TypedDataContext11_ForReadOnly(locationReferences).@__Expr139GetTree();
            }
            if ((expressionId == 140)) {
                return new PreTraining_TypedDataContext11_ForReadOnly(locationReferences).@__Expr140GetTree();
            }
            if ((expressionId == 141)) {
                return new PreTraining_TypedDataContext12_ForReadOnly(locationReferences).@__Expr141GetTree();
            }
            if ((expressionId == 142)) {
                return new PreTraining_TypedDataContext12(locationReferences).@__Expr142GetTree();
            }
            if ((expressionId == 143)) {
                return new PreTraining_TypedDataContext12_ForReadOnly(locationReferences).@__Expr143GetTree();
            }
            if ((expressionId == 144)) {
                return new PreTraining_TypedDataContext12_ForReadOnly(locationReferences).@__Expr144GetTree();
            }
            if ((expressionId == 145)) {
                return new PreTraining_TypedDataContext12_ForReadOnly(locationReferences).@__Expr145GetTree();
            }
            if ((expressionId == 146)) {
                return new PreTraining_TypedDataContext12(locationReferences).@__Expr146GetTree();
            }
            if ((expressionId == 147)) {
                return new PreTraining_TypedDataContext12_ForReadOnly(locationReferences).@__Expr147GetTree();
            }
            if ((expressionId == 148)) {
                return new PreTraining_TypedDataContext12_ForReadOnly(locationReferences).@__Expr148GetTree();
            }
            if ((expressionId == 149)) {
                return new PreTraining_TypedDataContext12(locationReferences).@__Expr149GetTree();
            }
            if ((expressionId == 150)) {
                return new PreTraining_TypedDataContext12_ForReadOnly(locationReferences).@__Expr150GetTree();
            }
            if ((expressionId == 151)) {
                return new PreTraining_TypedDataContext12_ForReadOnly(locationReferences).@__Expr151GetTree();
            }
            if ((expressionId == 152)) {
                return new PreTraining_TypedDataContext12(locationReferences).@__Expr152GetTree();
            }
            if ((expressionId == 153)) {
                return new PreTraining_TypedDataContext12_ForReadOnly(locationReferences).@__Expr153GetTree();
            }
            if ((expressionId == 154)) {
                return new PreTraining_TypedDataContext12_ForReadOnly(locationReferences).@__Expr154GetTree();
            }
            if ((expressionId == 155)) {
                return new PreTraining_TypedDataContext13(locationReferences).@__Expr155GetTree();
            }
            if ((expressionId == 156)) {
                return new PreTraining_TypedDataContext13_ForReadOnly(locationReferences).@__Expr156GetTree();
            }
            if ((expressionId == 157)) {
                return new PreTraining_TypedDataContext13_ForReadOnly(locationReferences).@__Expr157GetTree();
            }
            if ((expressionId == 158)) {
                return new PreTraining_TypedDataContext13(locationReferences).@__Expr158GetTree();
            }
            if ((expressionId == 159)) {
                return new PreTraining_TypedDataContext13_ForReadOnly(locationReferences).@__Expr159GetTree();
            }
            if ((expressionId == 160)) {
                return new PreTraining_TypedDataContext13_ForReadOnly(locationReferences).@__Expr160GetTree();
            }
            if ((expressionId == 161)) {
                return new PreTraining_TypedDataContext14_ForReadOnly(locationReferences).@__Expr161GetTree();
            }
            if ((expressionId == 162)) {
                return new PreTraining_TypedDataContext14(locationReferences).@__Expr162GetTree();
            }
            if ((expressionId == 163)) {
                return new PreTraining_TypedDataContext14_ForReadOnly(locationReferences).@__Expr163GetTree();
            }
            if ((expressionId == 164)) {
                return new PreTraining_TypedDataContext14_ForReadOnly(locationReferences).@__Expr164GetTree();
            }
            if ((expressionId == 165)) {
                return new PreTraining_TypedDataContext14_ForReadOnly(locationReferences).@__Expr165GetTree();
            }
            if ((expressionId == 166)) {
                return new PreTraining_TypedDataContext14(locationReferences).@__Expr166GetTree();
            }
            if ((expressionId == 167)) {
                return new PreTraining_TypedDataContext14_ForReadOnly(locationReferences).@__Expr167GetTree();
            }
            if ((expressionId == 168)) {
                return new PreTraining_TypedDataContext14_ForReadOnly(locationReferences).@__Expr168GetTree();
            }
            if ((expressionId == 169)) {
                return new PreTraining_TypedDataContext14(locationReferences).@__Expr169GetTree();
            }
            if ((expressionId == 170)) {
                return new PreTraining_TypedDataContext14_ForReadOnly(locationReferences).@__Expr170GetTree();
            }
            if ((expressionId == 171)) {
                return new PreTraining_TypedDataContext14(locationReferences).@__Expr171GetTree();
            }
            if ((expressionId == 172)) {
                return new PreTraining_TypedDataContext14_ForReadOnly(locationReferences).@__Expr172GetTree();
            }
            if ((expressionId == 173)) {
                return new PreTraining_TypedDataContext14_ForReadOnly(locationReferences).@__Expr173GetTree();
            }
            if ((expressionId == 174)) {
                return new PreTraining_TypedDataContext14_ForReadOnly(locationReferences).@__Expr174GetTree();
            }
            if ((expressionId == 175)) {
                return new PreTraining_TypedDataContext14_ForReadOnly(locationReferences).@__Expr175GetTree();
            }
            if ((expressionId == 176)) {
                return new PreTraining_TypedDataContext15_ForReadOnly(locationReferences).@__Expr176GetTree();
            }
            if ((expressionId == 177)) {
                return new PreTraining_TypedDataContext15_ForReadOnly(locationReferences).@__Expr177GetTree();
            }
            if ((expressionId == 178)) {
                return new PreTraining_TypedDataContext15(locationReferences).@__Expr178GetTree();
            }
            if ((expressionId == 179)) {
                return new PreTraining_TypedDataContext15_ForReadOnly(locationReferences).@__Expr179GetTree();
            }
            if ((expressionId == 180)) {
                return new PreTraining_TypedDataContext15_ForReadOnly(locationReferences).@__Expr180GetTree();
            }
            if ((expressionId == 181)) {
                return new PreTraining_TypedDataContext15_ForReadOnly(locationReferences).@__Expr181GetTree();
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
            
            protected int[] Protocolo {
                get {
                    return ((int[])(this.GetVariableValue((3 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((3 + locationsOffset), value);
                }
            }
            
            protected string ColorBandera {
                get {
                    return ((string)(this.GetVariableValue((5 + locationsOffset))));
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
            
            protected System.Collections.Generic.List<string> Recorrido {
                get {
                    return ((System.Collections.Generic.List<string>)(this.GetVariableValue((8 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((8 + locationsOffset), value);
                }
            }
            
            protected System.Collections.Generic.List<string> Reporte {
                get {
                    return ((System.Collections.Generic.List<string>)(this.GetVariableValue((9 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((9 + locationsOffset), value);
                }
            }
            
            protected string Escenario {
                get {
                    return ((string)(this.GetVariableValue((10 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((10 + locationsOffset), value);
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
                this.Separacion = ((int)(this.GetVariableValue((4 + locationsOffset))));
                this.Radio = ((int)(this.GetVariableValue((7 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((4 + locationsOffset), this.Separacion);
                this.SetVariableValue((7 + locationsOffset), this.Radio);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 11))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 11);
                }
                expectedLocationsCount = 11;
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
                if (((locationReferences[(offset + 3)].Name != "Protocolo") 
                            || (locationReferences[(offset + 3)].Type != typeof(int[])))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "ColorBandera") 
                            || (locationReferences[(offset + 5)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "ColorSeleccion") 
                            || (locationReferences[(offset + 6)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "Recorrido") 
                            || (locationReferences[(offset + 8)].Type != typeof(System.Collections.Generic.List<string>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "Reporte") 
                            || (locationReferences[(offset + 9)].Type != typeof(System.Collections.Generic.List<string>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 10)].Name != "Escenario") 
                            || (locationReferences[(offset + 10)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "Separacion") 
                            || (locationReferences[(offset + 4)].Type != typeof(int)))) {
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
            
            protected int[] Protocolo {
                get {
                    return ((int[])(this.GetVariableValue((3 + locationsOffset))));
                }
            }
            
            protected string ColorBandera {
                get {
                    return ((string)(this.GetVariableValue((5 + locationsOffset))));
                }
            }
            
            protected string ColorSeleccion {
                get {
                    return ((string)(this.GetVariableValue((6 + locationsOffset))));
                }
            }
            
            protected System.Collections.Generic.List<string> Recorrido {
                get {
                    return ((System.Collections.Generic.List<string>)(this.GetVariableValue((8 + locationsOffset))));
                }
            }
            
            protected System.Collections.Generic.List<string> Reporte {
                get {
                    return ((System.Collections.Generic.List<string>)(this.GetVariableValue((9 + locationsOffset))));
                }
            }
            
            protected string Escenario {
                get {
                    return ((string)(this.GetVariableValue((10 + locationsOffset))));
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
                this.Separacion = ((int)(this.GetVariableValue((4 + locationsOffset))));
                this.Radio = ((int)(this.GetVariableValue((7 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 11))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 11);
                }
                expectedLocationsCount = 11;
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
                if (((locationReferences[(offset + 3)].Name != "Protocolo") 
                            || (locationReferences[(offset + 3)].Type != typeof(int[])))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "ColorBandera") 
                            || (locationReferences[(offset + 5)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "ColorSeleccion") 
                            || (locationReferences[(offset + 6)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "Recorrido") 
                            || (locationReferences[(offset + 8)].Type != typeof(System.Collections.Generic.List<string>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "Reporte") 
                            || (locationReferences[(offset + 9)].Type != typeof(System.Collections.Generic.List<string>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 10)].Name != "Escenario") 
                            || (locationReferences[(offset + 10)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "Separacion") 
                            || (locationReferences[(offset + 4)].Type != typeof(int)))) {
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
                    return ((string)(this.GetVariableValue((12 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((12 + locationsOffset), value);
                }
            }
            
            protected System.Collections.Generic.List<int> BanderasAparecidas {
                get {
                    return ((System.Collections.Generic.List<int>)(this.GetVariableValue((15 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((15 + locationsOffset), value);
                }
            }
            
            protected System.Collections.Generic.List<System.Drawing.PointF> PosicionCruz {
                get {
                    return ((System.Collections.Generic.List<System.Drawing.PointF>)(this.GetVariableValue((19 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((19 + locationsOffset), value);
                }
            }
            
            protected string Mensaje {
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
            
            protected override void GetValueTypeValues() {
                this.Cruz = ((System.Drawing.PointF)(this.GetVariableValue((11 + locationsOffset))));
                this.Coordenadas = ((System.Drawing.PointF)(this.GetVariableValue((13 + locationsOffset))));
                this.TotalBanderas = ((int)(this.GetVariableValue((14 + locationsOffset))));
                this.Continuar = ((int)(this.GetVariableValue((16 + locationsOffset))));
                this.Cercania = ((int)(this.GetVariableValue((17 + locationsOffset))));
                this.Cursor = ((int)(this.GetVariableValue((18 + locationsOffset))));
                this.BanderaRandom = ((int)(this.GetVariableValue((20 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((11 + locationsOffset), this.Cruz);
                this.SetVariableValue((13 + locationsOffset), this.Coordenadas);
                this.SetVariableValue((14 + locationsOffset), this.TotalBanderas);
                this.SetVariableValue((16 + locationsOffset), this.Continuar);
                this.SetVariableValue((17 + locationsOffset), this.Cercania);
                this.SetVariableValue((18 + locationsOffset), this.Cursor);
                this.SetVariableValue((20 + locationsOffset), this.BanderaRandom);
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
                if (((locationReferences[(offset + 12)].Name != "RtaCave") 
                            || (locationReferences[(offset + 12)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 15)].Name != "BanderasAparecidas") 
                            || (locationReferences[(offset + 15)].Type != typeof(System.Collections.Generic.List<int>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 19)].Name != "PosicionCruz") 
                            || (locationReferences[(offset + 19)].Type != typeof(System.Collections.Generic.List<System.Drawing.PointF>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 21)].Name != "Mensaje") 
                            || (locationReferences[(offset + 21)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 11)].Name != "Cruz") 
                            || (locationReferences[(offset + 11)].Type != typeof(System.Drawing.PointF)))) {
                    return false;
                }
                if (((locationReferences[(offset + 13)].Name != "Coordenadas") 
                            || (locationReferences[(offset + 13)].Type != typeof(System.Drawing.PointF)))) {
                    return false;
                }
                if (((locationReferences[(offset + 14)].Name != "TotalBanderas") 
                            || (locationReferences[(offset + 14)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 16)].Name != "Continuar") 
                            || (locationReferences[(offset + 16)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 17)].Name != "Cercania") 
                            || (locationReferences[(offset + 17)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 18)].Name != "Cursor") 
                            || (locationReferences[(offset + 18)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 20)].Name != "BanderaRandom") 
                            || (locationReferences[(offset + 20)].Type != typeof(int)))) {
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
                    return ((string)(this.GetVariableValue((12 + locationsOffset))));
                }
            }
            
            protected System.Collections.Generic.List<int> BanderasAparecidas {
                get {
                    return ((System.Collections.Generic.List<int>)(this.GetVariableValue((15 + locationsOffset))));
                }
            }
            
            protected System.Collections.Generic.List<System.Drawing.PointF> PosicionCruz {
                get {
                    return ((System.Collections.Generic.List<System.Drawing.PointF>)(this.GetVariableValue((19 + locationsOffset))));
                }
            }
            
            protected string Mensaje {
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
            
            protected override void GetValueTypeValues() {
                this.Cruz = ((System.Drawing.PointF)(this.GetVariableValue((11 + locationsOffset))));
                this.Coordenadas = ((System.Drawing.PointF)(this.GetVariableValue((13 + locationsOffset))));
                this.TotalBanderas = ((int)(this.GetVariableValue((14 + locationsOffset))));
                this.Continuar = ((int)(this.GetVariableValue((16 + locationsOffset))));
                this.Cercania = ((int)(this.GetVariableValue((17 + locationsOffset))));
                this.Cursor = ((int)(this.GetVariableValue((18 + locationsOffset))));
                this.BanderaRandom = ((int)(this.GetVariableValue((20 + locationsOffset))));
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
                if (((locationReferences[(offset + 12)].Name != "RtaCave") 
                            || (locationReferences[(offset + 12)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 15)].Name != "BanderasAparecidas") 
                            || (locationReferences[(offset + 15)].Type != typeof(System.Collections.Generic.List<int>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 19)].Name != "PosicionCruz") 
                            || (locationReferences[(offset + 19)].Type != typeof(System.Collections.Generic.List<System.Drawing.PointF>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 21)].Name != "Mensaje") 
                            || (locationReferences[(offset + 21)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 11)].Name != "Cruz") 
                            || (locationReferences[(offset + 11)].Type != typeof(System.Drawing.PointF)))) {
                    return false;
                }
                if (((locationReferences[(offset + 13)].Name != "Coordenadas") 
                            || (locationReferences[(offset + 13)].Type != typeof(System.Drawing.PointF)))) {
                    return false;
                }
                if (((locationReferences[(offset + 14)].Name != "TotalBanderas") 
                            || (locationReferences[(offset + 14)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 16)].Name != "Continuar") 
                            || (locationReferences[(offset + 16)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 17)].Name != "Cercania") 
                            || (locationReferences[(offset + 17)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 18)].Name != "Cursor") 
                            || (locationReferences[(offset + 18)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 20)].Name != "BanderaRandom") 
                            || (locationReferences[(offset + 20)].Type != typeof(int)))) {
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
                
                #line 66 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<string>>> expression = () => 
                  Reporte;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<string> @__Expr1Get() {
                
                #line 66 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                  Reporte;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<string> ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr1Set(System.Collections.Generic.List<string> value) {
                
                #line 66 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                  Reporte = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr1Set(System.Collections.Generic.List<string> value) {
                this.GetValueTypeValues();
                this.@__Expr1Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 78 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<string>>> expression = () => 
                  Recorrido;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<string> @__Expr3Get() {
                
                #line 78 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                  Recorrido;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<string> ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr3Set(System.Collections.Generic.List<string> value) {
                
                #line 78 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                  Recorrido = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr3Set(System.Collections.Generic.List<string> value) {
                this.GetValueTypeValues();
                this.@__Expr3Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 90 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                  Cercania;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr4Get() {
                
                #line 90 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                  Cercania;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr4Set(int value) {
                
                #line 90 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                  Cercania = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr4Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr4Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 100 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                  Continuar;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr5Get() {
                
                #line 100 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                  Continuar;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr5Set(int value) {
                
                #line 100 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                  Continuar = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr5Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr5Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 110 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                  Cruz;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr7Get() {
                
                #line 110 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                  Cruz;
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr7Set(System.Drawing.PointF value) {
                
                #line 110 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                  Cruz = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr7Set(System.Drawing.PointF value) {
                this.GetValueTypeValues();
                this.@__Expr7Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 122 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<System.Drawing.PointF>>> expression = () => 
                  PosicionCruz;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<System.Drawing.PointF> @__Expr9Get() {
                
                #line 122 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                  PosicionCruz;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<System.Drawing.PointF> ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr9Set(System.Collections.Generic.List<System.Drawing.PointF> value) {
                
                #line 122 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                  PosicionCruz = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr9Set(System.Collections.Generic.List<System.Drawing.PointF> value) {
                this.GetValueTypeValues();
                this.@__Expr9Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 134 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                  TotalBanderas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr11Get() {
                
                #line 134 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                  TotalBanderas;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr11Set(int value) {
                
                #line 134 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                  TotalBanderas = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr11Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr11Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 146 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<int>>> expression = () => 
                  BanderasAparecidas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<int> @__Expr13Get() {
                
                #line 146 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                  BanderasAparecidas;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<int> ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr13Set(System.Collections.Generic.List<int> value) {
                
                #line 146 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                  BanderasAparecidas = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr13Set(System.Collections.Generic.List<int> value) {
                this.GetValueTypeValues();
                this.@__Expr13Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 164 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                      RtaCave;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr14Get() {
                
                #line 164 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                      RtaCave;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr14Set(string value) {
                
                #line 164 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                      RtaCave = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr14Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr14Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr17GetTree() {
                
                #line 178 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                          Coordenadas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr17Get() {
                
                #line 178 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                          Coordenadas;
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr17Get() {
                this.GetValueTypeValues();
                return this.@__Expr17Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr17Set(System.Drawing.PointF value) {
                
                #line 178 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                          Coordenadas = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr17Set(System.Drawing.PointF value) {
                this.GetValueTypeValues();
                this.@__Expr17Set(value);
                this.SetValueTypeValues();
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
                
                #line 71 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<string>>> expression = () => 
                  new List<string>();;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<string> @__Expr0Get() {
                
                #line 71 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                  new List<string>();;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<string> ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 83 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<string>>> expression = () => 
                  new List<string>();;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<string> @__Expr2Get() {
                
                #line 83 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                  new List<string>();;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<string> ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 115 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                  new PointF(0,0);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr6Get() {
                
                #line 115 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                  new PointF(0,0);
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 127 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<System.Drawing.PointF>>> expression = () => 
                  new List<PointF>();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<System.Drawing.PointF> @__Expr8Get() {
                
                #line 127 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                  new List<PointF>();
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<System.Drawing.PointF> ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 139 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                  360/Separacion;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr10Get() {
                
                #line 139 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                  360/Separacion;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 151 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<int>>> expression = () => 
                  new List<Int32>();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<int> @__Expr12Get() {
                
                #line 151 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                  new List<Int32>();
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<int> ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr15GetTree() {
                
                #line 171 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      RtaCave.Split(';').Length > 1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr15Get() {
                
                #line 171 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                      RtaCave.Split(';').Length > 1;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr15Get() {
                this.GetValueTypeValues();
                return this.@__Expr15Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr16GetTree() {
                
                #line 183 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                          new PointF(Single.Parse(RtaCave.Split(';')[0].Replace(".", ",")), Single.Parse(RtaCave.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr16Get() {
                
                #line 183 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                          new PointF(Single.Parse(RtaCave.Split(';')[0].Replace(".", ",")), Single.Parse(RtaCave.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr16Get() {
                this.GetValueTypeValues();
                return this.@__Expr16Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr18GetTree() {
                
                #line 1324 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                    Agregar180;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr18Get() {
                
                #line 1324 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                    Agregar180;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr18Get() {
                this.GetValueTypeValues();
                return this.@__Expr18Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr19GetTree() {
                
                #line 1329 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                    "L{ \"id\":\"null\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr19Get() {
                
                #line 1329 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                    "L{ \"id\":\"null\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr19Get() {
                this.GetValueTypeValues();
                return this.@__Expr19Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr20GetTree() {
                
                #line 1339 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                    Reporte;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr20Get() {
                
                #line 1339 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                    Reporte;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr20Get() {
                this.GetValueTypeValues();
                return this.@__Expr20Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr21GetTree() {
                
                #line 1335 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                      "Inicia: " + DateTime.Now.ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr21Get() {
                
                #line 1335 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                      "Inicia: " + DateTime.Now.ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr21Get() {
                this.GetValueTypeValues();
                return this.@__Expr21Get();
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
                
                #line 199 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                            Mensaje;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr23Get() {
                
                #line 199 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                            Mensaje;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr23Get() {
                this.GetValueTypeValues();
                return this.@__Expr23Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr23Set(string value) {
                
                #line 199 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                            Mensaje = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr23Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr23Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr33GetTree() {
                
                #line 263 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                            Mensaje;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr33Get() {
                
                #line 263 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                            Mensaje;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr33Get() {
                this.GetValueTypeValues();
                return this.@__Expr33Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr33Set(string value) {
                
                #line 263 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                            Mensaje = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr33Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr33Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr37GetTree() {
                
                #line 297 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                              RtaCave;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr37Get() {
                
                #line 297 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                              RtaCave;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr37Get() {
                this.GetValueTypeValues();
                return this.@__Expr37Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr37Set(string value) {
                
                #line 297 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                              RtaCave = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr37Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr37Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr40GetTree() {
                
                #line 311 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                                  Coordenadas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr40Get() {
                
                #line 311 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                  Coordenadas;
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr40Get() {
                this.GetValueTypeValues();
                return this.@__Expr40Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr40Set(System.Drawing.PointF value) {
                
                #line 311 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                  Coordenadas = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr40Set(System.Drawing.PointF value) {
                this.GetValueTypeValues();
                this.@__Expr40Set(value);
                this.SetValueTypeValues();
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
            
            internal System.Linq.Expressions.Expression @__Expr22GetTree() {
                
                #line 204 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                            DateTime.Now.ToString() + ";" +
                Coordenadas.X + ";" + Coordenadas.Y + ";DET";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr22Get() {
                
                #line 204 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                            DateTime.Now.ToString() + ";" +
                Coordenadas.X + ";" + Coordenadas.Y + ";DET";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr22Get() {
                this.GetValueTypeValues();
                return this.@__Expr22Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr24GetTree() {
                
                #line 216 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                          Recorrido;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr24Get() {
                
                #line 216 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                          Recorrido;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr24Get() {
                this.GetValueTypeValues();
                return this.@__Expr24Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr25GetTree() {
                
                #line 212 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                            Mensaje;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr25Get() {
                
                #line 212 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                            Mensaje;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr25Get() {
                this.GetValueTypeValues();
                return this.@__Expr25Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr26GetTree() {
                
                #line 221 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                          Mensaje;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr26Get() {
                
                #line 221 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                          Mensaje;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr26Get() {
                this.GetValueTypeValues();
                return this.@__Expr26Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr27GetTree() {
                
                #line 228 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                          "X{ \"value\":\"rojo\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr27Get() {
                
                #line 228 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                          "X{ \"value\":\"rojo\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr27Get() {
                this.GetValueTypeValues();
                return this.@__Expr27Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr28GetTree() {
                
                #line 233 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.TimeSpan>> expression = () => 
                          TimeSpan.FromSeconds(1);;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.TimeSpan @__Expr28Get() {
                
                #line 233 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                          TimeSpan.FromSeconds(1);;
                
                #line default
                #line hidden
            }
            
            public System.TimeSpan ValueType___Expr28Get() {
                this.GetValueTypeValues();
                return this.@__Expr28Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr29GetTree() {
                
                #line 238 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                          "X{ \"value\":\"negro\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr29Get() {
                
                #line 238 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                          "X{ \"value\":\"negro\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr29Get() {
                this.GetValueTypeValues();
                return this.@__Expr29Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr30GetTree() {
                
                #line 249 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                          "Q{ \"text\":\"Trial " + (int)(BanderasAparecidas.Count + 1) + " \" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr30Get() {
                
                #line 249 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                          "Q{ \"text\":\"Trial " + (int)(BanderasAparecidas.Count + 1) + " \" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr30Get() {
                this.GetValueTypeValues();
                return this.@__Expr30Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr31GetTree() {
                
                #line 254 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.TimeSpan>> expression = () => 
                          TimeSpan.FromSeconds(2);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.TimeSpan @__Expr31Get() {
                
                #line 254 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                          TimeSpan.FromSeconds(2);
                
                #line default
                #line hidden
            }
            
            public System.TimeSpan ValueType___Expr31Get() {
                this.GetValueTypeValues();
                return this.@__Expr31Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr32GetTree() {
                
                #line 268 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                            "Iteracion;"+BanderasAparecidas.Count;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr32Get() {
                
                #line 268 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                            "Iteracion;"+BanderasAparecidas.Count;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr32Get() {
                this.GetValueTypeValues();
                return this.@__Expr32Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr34GetTree() {
                
                #line 279 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                          Reporte;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr34Get() {
                
                #line 279 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                          Reporte;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr34Get() {
                this.GetValueTypeValues();
                return this.@__Expr34Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr35GetTree() {
                
                #line 275 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                            Mensaje;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr35Get() {
                
                #line 275 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                            Mensaje;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr35Get() {
                this.GetValueTypeValues();
                return this.@__Expr35Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr36GetTree() {
                
                #line 284 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                          Mensaje;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr36Get() {
                
                #line 284 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                          Mensaje;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr36Get() {
                this.GetValueTypeValues();
                return this.@__Expr36Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr38GetTree() {
                
                #line 304 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              RtaCave.Split(';').Length > 1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr38Get() {
                
                #line 304 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                              RtaCave.Split(';').Length > 1;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr38Get() {
                this.GetValueTypeValues();
                return this.@__Expr38Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr39GetTree() {
                
                #line 316 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                                  new PointF(Single.Parse(RtaCave.Split(';')[0].Replace(".", ",")), Single.Parse(RtaCave.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr39Get() {
                
                #line 316 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                  new PointF(Single.Parse(RtaCave.Split(';')[0].Replace(".", ",")), Single.Parse(RtaCave.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr39Get() {
                this.GetValueTypeValues();
                return this.@__Expr39Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr41GetTree() {
                
                #line 1309 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      Continuar>0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr41Get() {
                
                #line 1309 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                      Continuar>0;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr41Get() {
                this.GetValueTypeValues();
                return this.@__Expr41Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr57GetTree() {
                
                #line 1314 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      !(Continuar > 0);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr57Get() {
                
                #line 1314 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                      !(Continuar > 0);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr57Get() {
                this.GetValueTypeValues();
                return this.@__Expr57Get();
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
                    return ((System.Random)(this.GetVariableValue((22 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((22 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr43GetTree() {
                
                #line 1224 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Random>> expression = () => 
                              Random;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Random @__Expr43Get() {
                
                #line 1224 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                              Random;
                
                #line default
                #line hidden
            }
            
            public System.Random ValueType___Expr43Get() {
                this.GetValueTypeValues();
                return this.@__Expr43Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr43Set(System.Random value) {
                
                #line 1224 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                              Random = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr43Set(System.Random value) {
                this.GetValueTypeValues();
                this.@__Expr43Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr45GetTree() {
                
                #line 1236 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                              BanderaRandom;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr45Get() {
                
                #line 1236 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                              BanderaRandom;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr45Get() {
                this.GetValueTypeValues();
                return this.@__Expr45Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr45Set(int value) {
                
                #line 1236 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                              BanderaRandom = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr45Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr45Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr47GetTree() {
                
                #line 1252 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                BanderaRandom;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr47Get() {
                
                #line 1252 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                BanderaRandom;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr47Get() {
                this.GetValueTypeValues();
                return this.@__Expr47Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr47Set(int value) {
                
                #line 1252 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                BanderaRandom = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr47Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr47Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr53GetTree() {
                
                #line 1281 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                Mensaje;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr53Get() {
                
                #line 1281 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                Mensaje;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr53Get() {
                this.GetValueTypeValues();
                return this.@__Expr53Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr53Set(string value) {
                
                #line 1281 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                Mensaje = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr53Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr53Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 23))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 23);
                }
                expectedLocationsCount = 23;
                if (((locationReferences[(offset + 22)].Name != "Random") 
                            || (locationReferences[(offset + 22)].Type != typeof(System.Random)))) {
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
                    return ((System.Random)(this.GetVariableValue((22 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr42GetTree() {
                
                #line 1229 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Random>> expression = () => 
                              new Random();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Random @__Expr42Get() {
                
                #line 1229 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                              new Random();
                
                #line default
                #line hidden
            }
            
            public System.Random ValueType___Expr42Get() {
                this.GetValueTypeValues();
                return this.@__Expr42Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr44GetTree() {
                
                #line 1241 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                              Random.Next(0,BanderasCircunferencia.Count);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr44Get() {
                
                #line 1241 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                              Random.Next(0,BanderasCircunferencia.Count);
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr44Get() {
                this.GetValueTypeValues();
                return this.@__Expr44Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr46GetTree() {
                
                #line 1257 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                Random.Next(0,TotalBanderas);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr46Get() {
                
                #line 1257 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                Random.Next(0,TotalBanderas);
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr46Get() {
                this.GetValueTypeValues();
                return this.@__Expr46Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr48GetTree() {
                
                #line 1247 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                            BanderasAparecidas.Contains(BanderaRandom);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr48Get() {
                
                #line 1247 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                            BanderasAparecidas.Contains(BanderaRandom);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr48Get() {
                this.GetValueTypeValues();
                return this.@__Expr48Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr49GetTree() {
                
                #line 1269 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<int>>> expression = () => 
                            BanderasAparecidas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<int> @__Expr49Get() {
                
                #line 1269 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                            BanderasAparecidas;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<int> ValueType___Expr49Get() {
                this.GetValueTypeValues();
                return this.@__Expr49Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr50GetTree() {
                
                #line 1265 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                              BanderaRandom;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr50Get() {
                
                #line 1265 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                              BanderaRandom;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr50Get() {
                this.GetValueTypeValues();
                return this.@__Expr50Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr51GetTree() {
                
                #line 1274 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                            "H{ \"id\":\"" + (int)(BanderaRandom) + "\", \"visible\":\"true\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr51Get() {
                
                #line 1274 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                            "H{ \"id\":\"" + (int)(BanderaRandom) + "\", \"visible\":\"true\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr51Get() {
                this.GetValueTypeValues();
                return this.@__Expr51Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr52GetTree() {
                
                #line 1286 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                "Hora;"+DateTime.Now.ToString()+"\nBandera;" + BanderaRandom + "\nX;" + BanderasCircunferencia.ElementAt(BanderaRandom).X + "\nY;" + BanderasCircunferencia.ElementAt(BanderaRandom).Y;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr52Get() {
                
                #line 1286 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                "Hora;"+DateTime.Now.ToString()+"\nBandera;" + BanderaRandom + "\nX;" + BanderasCircunferencia.ElementAt(BanderaRandom).X + "\nY;" + BanderasCircunferencia.ElementAt(BanderaRandom).Y;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr52Get() {
                this.GetValueTypeValues();
                return this.@__Expr52Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr54GetTree() {
                
                #line 1297 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                              Reporte;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr54Get() {
                
                #line 1297 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                              Reporte;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr54Get() {
                this.GetValueTypeValues();
                return this.@__Expr54Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr55GetTree() {
                
                #line 1293 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                Mensaje;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr55Get() {
                
                #line 1293 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                Mensaje;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr55Get() {
                this.GetValueTypeValues();
                return this.@__Expr55Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr56GetTree() {
                
                #line 1302 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                              Mensaje;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr56Get() {
                
                #line 1302 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                              Mensaje;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr56Get() {
                this.GetValueTypeValues();
                return this.@__Expr56Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 23))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 23);
                }
                expectedLocationsCount = 23;
                if (((locationReferences[(offset + 22)].Name != "Random") 
                            || (locationReferences[(offset + 22)].Type != typeof(System.Random)))) {
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
            
            internal System.Linq.Expressions.Expression @__Expr59GetTree() {
                
                #line 331 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  Mensaje;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr59Get() {
                
                #line 331 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                  Mensaje;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr59Get() {
                this.GetValueTypeValues();
                return this.@__Expr59Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr59Set(string value) {
                
                #line 331 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                  Mensaje = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr59Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr59Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr63GetTree() {
                
                #line 364 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                      RtaCave;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr63Get() {
                
                #line 364 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                      RtaCave;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr63Get() {
                this.GetValueTypeValues();
                return this.@__Expr63Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr63Set(string value) {
                
                #line 364 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                      RtaCave = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr63Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr63Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr66GetTree() {
                
                #line 378 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                                          Coordenadas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr66Get() {
                
                #line 378 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                          Coordenadas;
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr66Get() {
                this.GetValueTypeValues();
                return this.@__Expr66Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr66Set(System.Drawing.PointF value) {
                
                #line 378 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                          Coordenadas = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr66Set(System.Drawing.PointF value) {
                this.GetValueTypeValues();
                this.@__Expr66Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr70GetTree() {
                
                #line 1148 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                        Mensaje;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr70Get() {
                
                #line 1148 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                        Mensaje;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr70Get() {
                this.GetValueTypeValues();
                return this.@__Expr70Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr70Set(string value) {
                
                #line 1148 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                        Mensaje = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr70Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr70Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr75GetTree() {
                
                #line 1177 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                        Mensaje;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr75Get() {
                
                #line 1177 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                        Mensaje;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr75Get() {
                this.GetValueTypeValues();
                return this.@__Expr75Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr75Set(string value) {
                
                #line 1177 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                        Mensaje = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr75Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr75Set(value);
                this.SetValueTypeValues();
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
            
            internal System.Linq.Expressions.Expression @__Expr58GetTree() {
                
                #line 336 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  DateTime.Now.ToString() + ";" + Coordenadas.X + ";" + Coordenadas.Y + ";" + "BUS";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr58Get() {
                
                #line 336 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                  DateTime.Now.ToString() + ";" + Coordenadas.X + ";" + Coordenadas.Y + ";" + "BUS";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr58Get() {
                this.GetValueTypeValues();
                return this.@__Expr58Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr60GetTree() {
                
                #line 347 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                                Recorrido;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr60Get() {
                
                #line 347 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                Recorrido;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr60Get() {
                this.GetValueTypeValues();
                return this.@__Expr60Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr61GetTree() {
                
                #line 343 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  Mensaje;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr61Get() {
                
                #line 343 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                  Mensaje;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr61Get() {
                this.GetValueTypeValues();
                return this.@__Expr61Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr62GetTree() {
                
                #line 352 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                Mensaje;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr62Get() {
                
                #line 352 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                Mensaje;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr62Get() {
                this.GetValueTypeValues();
                return this.@__Expr62Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr64GetTree() {
                
                #line 371 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                      RtaCave.Split(';').Length > 1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr64Get() {
                
                #line 371 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                      RtaCave.Split(';').Length > 1;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr64Get() {
                this.GetValueTypeValues();
                return this.@__Expr64Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr65GetTree() {
                
                #line 383 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                                          new PointF(Single.Parse(RtaCave.Split(';')[0].Replace(".", ",")), Single.Parse(RtaCave.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr65Get() {
                
                #line 383 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                          new PointF(Single.Parse(RtaCave.Split(';')[0].Replace(".", ",")), Single.Parse(RtaCave.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr65Get() {
                this.GetValueTypeValues();
                return this.@__Expr65Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr67GetTree() {
                
                #line 1205 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              Math.Sqrt((Math.Pow(Coordenadas.X - BanderasCircunferencia[BanderaRandom].X, 2)) + Math.Pow(Coordenadas.Y - BanderasCircunferencia[BanderaRandom].Y, 2)) < Cercania;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr67Get() {
                
                #line 1205 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                              Math.Sqrt((Math.Pow(Coordenadas.X - BanderasCircunferencia[BanderaRandom].X, 2)) + Math.Pow(Coordenadas.Y - BanderasCircunferencia[BanderaRandom].Y, 2)) < Cercania;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr67Get() {
                this.GetValueTypeValues();
                return this.@__Expr67Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr68GetTree() {
                
                #line 1141 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                    "H{ \"id\":\"" + (int)(BanderaRandom) + "\", \"visible\":\"false\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr68Get() {
                
                #line 1141 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                    "H{ \"id\":\"" + (int)(BanderaRandom) + "\", \"visible\":\"false\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr68Get() {
                this.GetValueTypeValues();
                return this.@__Expr68Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr69GetTree() {
                
                #line 1153 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                        "Hora Captura;"+DateTime.Now.ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr69Get() {
                
                #line 1153 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                        "Hora Captura;"+DateTime.Now.ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr69Get() {
                this.GetValueTypeValues();
                return this.@__Expr69Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr71GetTree() {
                
                #line 1164 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                                      Reporte;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr71Get() {
                
                #line 1164 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                      Reporte;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr71Get() {
                this.GetValueTypeValues();
                return this.@__Expr71Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr72GetTree() {
                
                #line 1160 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                        Mensaje;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr72Get() {
                
                #line 1160 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                        Mensaje;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr72Get() {
                this.GetValueTypeValues();
                return this.@__Expr72Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr73GetTree() {
                
                #line 1169 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                      Mensaje;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr73Get() {
                
                #line 1169 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                      Mensaje;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr73Get() {
                this.GetValueTypeValues();
                return this.@__Expr73Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr74GetTree() {
                
                #line 1182 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                        DateTime.Now.ToString() + ";" + Coordenadas.X + ";" + Coordenadas.Y + ";" + BanderasCircunferencia[BanderaRandom].X + ";" + BanderasCircunferencia[BanderaRandom].Y + ";" + BanderaRandom + ";CAP";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr74Get() {
                
                #line 1182 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                        DateTime.Now.ToString() + ";" + Coordenadas.X + ";" + Coordenadas.Y + ";" + BanderasCircunferencia[BanderaRandom].X + ";" + BanderasCircunferencia[BanderaRandom].Y + ";" + BanderaRandom + ";CAP";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr74Get() {
                this.GetValueTypeValues();
                return this.@__Expr74Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr76GetTree() {
                
                #line 1193 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                                      Recorrido;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr76Get() {
                
                #line 1193 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                      Recorrido;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr76Get() {
                this.GetValueTypeValues();
                return this.@__Expr76Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr77GetTree() {
                
                #line 1189 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                        Mensaje;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr77Get() {
                
                #line 1189 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                        Mensaje;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr77Get() {
                this.GetValueTypeValues();
                return this.@__Expr77Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr78GetTree() {
                
                #line 1198 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                      Mensaje;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr78Get() {
                
                #line 1198 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                      Mensaje;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr78Get() {
                this.GetValueTypeValues();
                return this.@__Expr78Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr79GetTree() {
                
                #line 1210 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              !(Math.Sqrt((Math.Pow(Coordenadas.X - BanderasCircunferencia[BanderaRandom].X, 2)) + Math.Pow(Coordenadas.Y - BanderasCircunferencia[BanderaRandom].Y, 2)) < Cercania);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr79Get() {
                
                #line 1210 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                              !(Math.Sqrt((Math.Pow(Coordenadas.X - BanderasCircunferencia[BanderaRandom].X, 2)) + Math.Pow(Coordenadas.Y - BanderasCircunferencia[BanderaRandom].Y, 2)) < Cercania);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr79Get() {
                this.GetValueTypeValues();
                return this.@__Expr79Get();
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
                            && (locationReferences.Count < 22))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 22);
                }
                expectedLocationsCount = 22;
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
            
            internal System.Linq.Expressions.Expression @__Expr80GetTree() {
                
                #line 662 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                                "Q{ \"text\":\"Fin del experimento\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr80Get() {
                
                #line 662 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                                "Q{ \"text\":\"Fin del experimento\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr80Get() {
                this.GetValueTypeValues();
                return this.@__Expr80Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr81GetTree() {
                
                #line 672 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                                                                                Recorrido;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr81Get() {
                
                #line 672 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                                Recorrido;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr81Get() {
                this.GetValueTypeValues();
                return this.@__Expr81Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr82GetTree() {
                
                #line 668 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                                  DateTime.Now.ToString()+";"+Coordenadas.X+";"+Coordenadas.Y+";"+";FIN";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr82Get() {
                
                #line 668 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                                  DateTime.Now.ToString()+";"+Coordenadas.X+";"+Coordenadas.Y+";"+";FIN";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr82Get() {
                this.GetValueTypeValues();
                return this.@__Expr82Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr83GetTree() {
                
                #line 677 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                                DateTime.Now.ToString() + ";" + Coordenadas.X + ";" + Coordenadas.Y + ";" + "NULL;NULL;NULL;FIN";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr83Get() {
                
                #line 677 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                                DateTime.Now.ToString() + ";" + Coordenadas.X + ";" + Coordenadas.Y + ";" + "NULL;NULL;NULL;FIN";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr83Get() {
                this.GetValueTypeValues();
                return this.@__Expr83Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr84GetTree() {
                
                #line 682 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.TimeSpan>> expression = () => 
                                                                                TimeSpan.FromSeconds(5);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.TimeSpan @__Expr84Get() {
                
                #line 682 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                                TimeSpan.FromSeconds(5);
                
                #line default
                #line hidden
            }
            
            public System.TimeSpan ValueType___Expr84Get() {
                this.GetValueTypeValues();
                return this.@__Expr84Get();
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
            
            internal System.Linq.Expressions.Expression @__Expr86GetTree() {
                
                #line 593 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                      RtaCave;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr86Get() {
                
                #line 593 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                      RtaCave;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr86Get() {
                this.GetValueTypeValues();
                return this.@__Expr86Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr86Set(string value) {
                
                #line 593 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                                                      RtaCave = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr86Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr86Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr89GetTree() {
                
                #line 607 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                                                                          Coordenadas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr89Get() {
                
                #line 607 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                          Coordenadas;
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr89Get() {
                this.GetValueTypeValues();
                return this.@__Expr89Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr89Set(System.Drawing.PointF value) {
                
                #line 607 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                                                          Coordenadas = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr89Set(System.Drawing.PointF value) {
                this.GetValueTypeValues();
                this.@__Expr89Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr92GetTree() {
                
                #line 782 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                        Mensaje;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr92Get() {
                
                #line 782 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                        Mensaje;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr92Get() {
                this.GetValueTypeValues();
                return this.@__Expr92Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr92Set(string value) {
                
                #line 782 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                                                        Mensaje = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr92Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr92Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr127GetTree() {
                
                #line 1004 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                            Cursor;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr127Get() {
                
                #line 1004 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                            Cursor;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr127Get() {
                this.GetValueTypeValues();
                return this.@__Expr127Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr127Set(int value) {
                
                #line 1004 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                                                            Cursor = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr127Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr127Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr130GetTree() {
                
                #line 1023 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                                Cursor;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr130Get() {
                
                #line 1023 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                                Cursor;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr130Get() {
                this.GetValueTypeValues();
                return this.@__Expr130Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr130Set(int value) {
                
                #line 1023 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                                                                Cursor = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr130Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr130Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr132GetTree() {
                
                #line 1040 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                          Cursor;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr132Get() {
                
                #line 1040 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                          Cursor;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr132Get() {
                this.GetValueTypeValues();
                return this.@__Expr132Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr132Set(int value) {
                
                #line 1040 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                                                          Cursor = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr132Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr132Set(value);
                this.SetValueTypeValues();
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
            
            internal System.Linq.Expressions.Expression @__Expr85GetTree() {
                
                #line 582 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                              "C{ \"id\":\"" + (int)(Cursor) + "\", \"color\":\"" + ColorSeleccion + "\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr85Get() {
                
                #line 582 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                              "C{ \"id\":\"" + (int)(Cursor) + "\", \"color\":\"" + ColorSeleccion + "\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr85Get() {
                this.GetValueTypeValues();
                return this.@__Expr85Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr87GetTree() {
                
                #line 600 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                      RtaCave.Split(';').Length > 1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr87Get() {
                
                #line 600 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                      RtaCave.Split(';').Length > 1;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr87Get() {
                this.GetValueTypeValues();
                return this.@__Expr87Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr88GetTree() {
                
                #line 612 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                                                                          new PointF(Single.Parse(RtaCave.Split(';')[0].Replace(".", ",")), Single.Parse(RtaCave.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr88Get() {
                
                #line 612 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                          new PointF(Single.Parse(RtaCave.Split(';')[0].Replace(".", ",")), Single.Parse(RtaCave.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr88Get() {
                this.GetValueTypeValues();
                return this.@__Expr88Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr90GetTree() {
                
                #line 982 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                              RtaCave.Equals("2");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr90Get() {
                
                #line 982 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                              RtaCave.Equals("2");
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr90Get() {
                this.GetValueTypeValues();
                return this.@__Expr90Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr91GetTree() {
                
                #line 787 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                        "Selecciona;"+Cursor+
"\nX;"+BanderasCircunferencia.ElementAt(Cursor).X +
"\nY;"+BanderasCircunferencia.ElementAt(Cursor).Y +
"\nHoraSelecciona;"+DateTime.Now.ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr91Get() {
                
                #line 787 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                        "Selecciona;"+Cursor+
"\nX;"+BanderasCircunferencia.ElementAt(Cursor).X +
"\nY;"+BanderasCircunferencia.ElementAt(Cursor).Y +
"\nHoraSelecciona;"+DateTime.Now.ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr91Get() {
                this.GetValueTypeValues();
                return this.@__Expr91Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr93GetTree() {
                
                #line 801 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                                                                      Reporte;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr93Get() {
                
                #line 801 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                      Reporte;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr93Get() {
                this.GetValueTypeValues();
                return this.@__Expr93Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr94GetTree() {
                
                #line 797 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                        Mensaje;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr94Get() {
                
                #line 797 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                        Mensaje;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr94Get() {
                this.GetValueTypeValues();
                return this.@__Expr94Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr95GetTree() {
                
                #line 806 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                      Mensaje;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr95Get() {
                
                #line 806 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                      Mensaje;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr95Get() {
                this.GetValueTypeValues();
                return this.@__Expr95Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr96GetTree() {
                
                #line 813 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                      "C{ \"id\":\"" + (int)(Cursor) + "\", \"color\":\"" + ColorBandera + "\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr96Get() {
                
                #line 813 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                      "C{ \"id\":\"" + (int)(Cursor) + "\", \"color\":\"" + ColorBandera + "\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr96Get() {
                this.GetValueTypeValues();
                return this.@__Expr96Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr97GetTree() {
                
                #line 818 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                      Mostrar180.Replace("true", "false");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr97Get() {
                
                #line 818 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                      Mostrar180.Replace("true", "false");
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr97Get() {
                this.GetValueTypeValues();
                return this.@__Expr97Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr122GetTree() {
                
                #line 975 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                      "Q{ \"text\":\"Terminar Experimento?\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr122Get() {
                
                #line 975 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                      "Q{ \"text\":\"Terminar Experimento?\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr122Get() {
                this.GetValueTypeValues();
                return this.@__Expr122Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr123GetTree() {
                
                #line 1054 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                              RtaCave.Equals("1") || RtaCave.Equals("3");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr123Get() {
                
                #line 1054 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                              RtaCave.Equals("1") || RtaCave.Equals("3");
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr123Get() {
                this.GetValueTypeValues();
                return this.@__Expr123Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr124GetTree() {
                
                #line 990 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                    "C{ \"id\":\"" + (int)(Cursor) + "\", \"color\":\"" + ColorBandera + "\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr124Get() {
                
                #line 990 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                    "C{ \"id\":\"" + (int)(Cursor) + "\", \"color\":\"" + ColorBandera + "\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr124Get() {
                this.GetValueTypeValues();
                return this.@__Expr124Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr125GetTree() {
                
                #line 996 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                      RtaCave.Equals("1");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr125Get() {
                
                #line 996 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                      RtaCave.Equals("1");
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr125Get() {
                this.GetValueTypeValues();
                return this.@__Expr125Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr126GetTree() {
                
                #line 1009 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                            (Cursor - 1) % BanderasCircunferencia.Count;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr126Get() {
                
                #line 1009 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                            (Cursor - 1) % BanderasCircunferencia.Count;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr126Get() {
                this.GetValueTypeValues();
                return this.@__Expr126Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr128GetTree() {
                
                #line 1016 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                            Cursor<0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr128Get() {
                
                #line 1016 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                            Cursor<0;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr128Get() {
                this.GetValueTypeValues();
                return this.@__Expr128Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr129GetTree() {
                
                #line 1028 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                                BanderasCircunferencia.Count-1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr129Get() {
                
                #line 1028 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                                BanderasCircunferencia.Count-1;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr129Get() {
                this.GetValueTypeValues();
                return this.@__Expr129Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr131GetTree() {
                
                #line 1045 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                          (Cursor + 1) % BanderasCircunferencia.Count;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr131Get() {
                
                #line 1045 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                          (Cursor + 1) % BanderasCircunferencia.Count;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr131Get() {
                this.GetValueTypeValues();
                return this.@__Expr131Get();
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
                    return ((System.Random)(this.GetVariableValue((22 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((22 + locationsOffset), value);
                }
            }
            
            protected System.Random RandomY {
                get {
                    return ((System.Random)(this.GetVariableValue((23 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((23 + locationsOffset), value);
                }
            }
            
            protected string variable2 {
                get {
                    return ((string)(this.GetVariableValue((24 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((24 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr99GetTree() {
                
                #line 833 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Random>> expression = () => 
                                                                          RandomX;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Random @__Expr99Get() {
                
                #line 833 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                          RandomX;
                
                #line default
                #line hidden
            }
            
            public System.Random ValueType___Expr99Get() {
                this.GetValueTypeValues();
                return this.@__Expr99Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr99Set(System.Random value) {
                
                #line 833 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                                                          RandomX = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr99Set(System.Random value) {
                this.GetValueTypeValues();
                this.@__Expr99Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr101GetTree() {
                
                #line 845 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Random>> expression = () => 
                                                                          RandomY;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Random @__Expr101Get() {
                
                #line 845 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                          RandomY;
                
                #line default
                #line hidden
            }
            
            public System.Random ValueType___Expr101Get() {
                this.GetValueTypeValues();
                return this.@__Expr101Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr101Set(System.Random value) {
                
                #line 845 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                                                          RandomY = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr101Set(System.Random value) {
                this.GetValueTypeValues();
                this.@__Expr101Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr103GetTree() {
                
                #line 857 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                          CruzX;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr103Get() {
                
                #line 857 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                          CruzX;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr103Get() {
                this.GetValueTypeValues();
                return this.@__Expr103Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr103Set(int value) {
                
                #line 857 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                                                          CruzX = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr103Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr103Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr105GetTree() {
                
                #line 869 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                          CruzY;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr105Get() {
                
                #line 869 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                          CruzY;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr105Get() {
                this.GetValueTypeValues();
                return this.@__Expr105Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr105Set(int value) {
                
                #line 869 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                                                          CruzY = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr105Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr105Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr107GetTree() {
                
                #line 886 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                              CruzX;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr107Get() {
                
                #line 886 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                              CruzX;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr107Get() {
                this.GetValueTypeValues();
                return this.@__Expr107Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr107Set(int value) {
                
                #line 886 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                                                              CruzX = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr107Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr107Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr109GetTree() {
                
                #line 898 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                              CruzY;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr109Get() {
                
                #line 898 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                              CruzY;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr109Get() {
                this.GetValueTypeValues();
                return this.@__Expr109Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr109Set(int value) {
                
                #line 898 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                                                              CruzY = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr109Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr109Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr114GetTree() {
                
                #line 922 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<float>> expression = () => 
                                                                          Cruz.X;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public float @__Expr114Get() {
                
                #line 922 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                          Cruz.X;
                
                #line default
                #line hidden
            }
            
            public float ValueType___Expr114Get() {
                this.GetValueTypeValues();
                return this.@__Expr114Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr114Set(float value) {
                
                #line 922 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                                                          Cruz.X = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr114Set(float value) {
                this.GetValueTypeValues();
                this.@__Expr114Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr116GetTree() {
                
                #line 934 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<float>> expression = () => 
                                                                          Cruz.Y;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public float @__Expr116Get() {
                
                #line 934 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                          Cruz.Y;
                
                #line default
                #line hidden
            }
            
            public float ValueType___Expr116Get() {
                this.GetValueTypeValues();
                return this.@__Expr116Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr116Set(float value) {
                
                #line 934 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                                                          Cruz.Y = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr116Set(float value) {
                this.GetValueTypeValues();
                this.@__Expr116Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr118GetTree() {
                
                #line 947 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                            Mensaje;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr118Get() {
                
                #line 947 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                            Mensaje;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr118Get() {
                this.GetValueTypeValues();
                return this.@__Expr118Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr118Set(string value) {
                
                #line 947 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                                                            Mensaje = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr118Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr118Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.CruzX = ((int)(this.GetVariableValue((25 + locationsOffset))));
                this.CruzY = ((int)(this.GetVariableValue((26 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((25 + locationsOffset), this.CruzX);
                this.SetVariableValue((26 + locationsOffset), this.CruzY);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 27))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 27);
                }
                expectedLocationsCount = 27;
                if (((locationReferences[(offset + 22)].Name != "RandomX") 
                            || (locationReferences[(offset + 22)].Type != typeof(System.Random)))) {
                    return false;
                }
                if (((locationReferences[(offset + 23)].Name != "RandomY") 
                            || (locationReferences[(offset + 23)].Type != typeof(System.Random)))) {
                    return false;
                }
                if (((locationReferences[(offset + 24)].Name != "variable2") 
                            || (locationReferences[(offset + 24)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 25)].Name != "CruzX") 
                            || (locationReferences[(offset + 25)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 26)].Name != "CruzY") 
                            || (locationReferences[(offset + 26)].Type != typeof(int)))) {
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
                    return ((System.Random)(this.GetVariableValue((22 + locationsOffset))));
                }
            }
            
            protected System.Random RandomY {
                get {
                    return ((System.Random)(this.GetVariableValue((23 + locationsOffset))));
                }
            }
            
            protected string variable2 {
                get {
                    return ((string)(this.GetVariableValue((24 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr98GetTree() {
                
                #line 838 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Random>> expression = () => 
                                                                          new Random();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Random @__Expr98Get() {
                
                #line 838 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                          new Random();
                
                #line default
                #line hidden
            }
            
            public System.Random ValueType___Expr98Get() {
                this.GetValueTypeValues();
                return this.@__Expr98Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr100GetTree() {
                
                #line 850 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Random>> expression = () => 
                                                                          new Random();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Random @__Expr100Get() {
                
                #line 850 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                          new Random();
                
                #line default
                #line hidden
            }
            
            public System.Random ValueType___Expr100Get() {
                this.GetValueTypeValues();
                return this.@__Expr100Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr102GetTree() {
                
                #line 862 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                          RandomX.Next(-13,13);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr102Get() {
                
                #line 862 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                          RandomX.Next(-13,13);
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr102Get() {
                this.GetValueTypeValues();
                return this.@__Expr102Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr104GetTree() {
                
                #line 874 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                          RandomY.Next(-13, 13);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr104Get() {
                
                #line 874 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                          RandomY.Next(-13, 13);
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr104Get() {
                this.GetValueTypeValues();
                return this.@__Expr104Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr106GetTree() {
                
                #line 891 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                              RandomX.Next(-13,13);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr106Get() {
                
                #line 891 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                              RandomX.Next(-13,13);
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr106Get() {
                this.GetValueTypeValues();
                return this.@__Expr106Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr108GetTree() {
                
                #line 903 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                              RandomY.Next(-13,13);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr108Get() {
                
                #line 903 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                              RandomY.Next(-13,13);
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr108Get() {
                this.GetValueTypeValues();
                return this.@__Expr108Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr110GetTree() {
                
                #line 880 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                        (Math.Sqrt(Math.Pow(Cruz.X-CruzX,2)+Math.Pow(Cruz.Y-CruzY,2))<Cercania) || (PosicionCruz.Contains(new PointF(CruzX,CruzY)));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr110Get() {
                
                #line 880 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                        (Math.Sqrt(Math.Pow(Cruz.X-CruzX,2)+Math.Pow(Cruz.Y-CruzY,2))<Cercania) || (PosicionCruz.Contains(new PointF(CruzX,CruzY)));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr110Get() {
                this.GetValueTypeValues();
                return this.@__Expr110Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr111GetTree() {
                
                #line 916 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<System.Drawing.PointF>>> expression = () => 
                                                                        PosicionCruz;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<System.Drawing.PointF> @__Expr111Get() {
                
                #line 916 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                        PosicionCruz;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<System.Drawing.PointF> ValueType___Expr111Get() {
                this.GetValueTypeValues();
                return this.@__Expr111Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr112GetTree() {
                
                #line 912 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                                                                          Cruz;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr112Get() {
                
                #line 912 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                          Cruz;
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr112Get() {
                this.GetValueTypeValues();
                return this.@__Expr112Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr113GetTree() {
                
                #line 927 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<float>> expression = () => 
                                                                          CruzX;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public float @__Expr113Get() {
                
                #line 927 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                          CruzX;
                
                #line default
                #line hidden
            }
            
            public float ValueType___Expr113Get() {
                this.GetValueTypeValues();
                return this.@__Expr113Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr115GetTree() {
                
                #line 939 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<float>> expression = () => 
                                                                          CruzY;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public float @__Expr115Get() {
                
                #line 939 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                          CruzY;
                
                #line default
                #line hidden
            }
            
            public float ValueType___Expr115Get() {
                this.GetValueTypeValues();
                return this.@__Expr115Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr117GetTree() {
                
                #line 952 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                            "CruzX;"+CruzX+"\nCruzY;"+CruzY;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr117Get() {
                
                #line 952 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                            "CruzX;"+CruzX+"\nCruzY;"+CruzY;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr117Get() {
                this.GetValueTypeValues();
                return this.@__Expr117Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr119GetTree() {
                
                #line 963 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                                                                          Reporte;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr119Get() {
                
                #line 963 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                          Reporte;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr119Get() {
                this.GetValueTypeValues();
                return this.@__Expr119Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr120GetTree() {
                
                #line 959 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                            Mensaje;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr120Get() {
                
                #line 959 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                            Mensaje;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr120Get() {
                this.GetValueTypeValues();
                return this.@__Expr120Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr121GetTree() {
                
                #line 968 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                          Mensaje;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr121Get() {
                
                #line 968 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                          Mensaje;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr121Get() {
                this.GetValueTypeValues();
                return this.@__Expr121Get();
            }
            
            protected override void GetValueTypeValues() {
                this.CruzX = ((int)(this.GetVariableValue((25 + locationsOffset))));
                this.CruzY = ((int)(this.GetVariableValue((26 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 27))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 27);
                }
                expectedLocationsCount = 27;
                if (((locationReferences[(offset + 22)].Name != "RandomX") 
                            || (locationReferences[(offset + 22)].Type != typeof(System.Random)))) {
                    return false;
                }
                if (((locationReferences[(offset + 23)].Name != "RandomY") 
                            || (locationReferences[(offset + 23)].Type != typeof(System.Random)))) {
                    return false;
                }
                if (((locationReferences[(offset + 24)].Name != "variable2") 
                            || (locationReferences[(offset + 24)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 25)].Name != "CruzX") 
                            || (locationReferences[(offset + 25)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 26)].Name != "CruzY") 
                            || (locationReferences[(offset + 26)].Type != typeof(int)))) {
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
                            && (locationReferences.Count < 22))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 22);
                }
                expectedLocationsCount = 22;
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
                            && (locationReferences.Count < 22))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 22);
                }
                expectedLocationsCount = 22;
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
                    return ((string)(this.GetVariableValue((22 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((22 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr133GetTree() {
                
                #line 629 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                              RtaCave;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr133Get() {
                
                #line 629 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                              RtaCave;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr133Get() {
                this.GetValueTypeValues();
                return this.@__Expr133Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr133Set(string value) {
                
                #line 629 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                                                              RtaCave = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr133Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr133Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr136GetTree() {
                
                #line 643 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                                                                                  Coordenadas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr136Get() {
                
                #line 643 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                                  Coordenadas;
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr136Get() {
                this.GetValueTypeValues();
                return this.@__Expr136Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr136Set(System.Drawing.PointF value) {
                
                #line 643 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                                                                  Coordenadas = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr136Set(System.Drawing.PointF value) {
                this.GetValueTypeValues();
                this.@__Expr136Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.CruzX = ((int)(this.GetVariableValue((23 + locationsOffset))));
                this.CruzY = ((int)(this.GetVariableValue((24 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((23 + locationsOffset), this.CruzX);
                this.SetVariableValue((24 + locationsOffset), this.CruzY);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 25))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 25);
                }
                expectedLocationsCount = 25;
                if (((locationReferences[(offset + 22)].Name != "variable1") 
                            || (locationReferences[(offset + 22)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 23)].Name != "CruzX") 
                            || (locationReferences[(offset + 23)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 24)].Name != "CruzY") 
                            || (locationReferences[(offset + 24)].Type != typeof(int)))) {
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
                    return ((string)(this.GetVariableValue((22 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr134GetTree() {
                
                #line 636 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                              RtaCave.Split(';').Length > 1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr134Get() {
                
                #line 636 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                              RtaCave.Split(';').Length > 1;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr134Get() {
                this.GetValueTypeValues();
                return this.@__Expr134Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr135GetTree() {
                
                #line 648 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                                                                                  new PointF(Single.Parse(RtaCave.Split(';')[0].Replace(".", ",")), Single.Parse(RtaCave.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr135Get() {
                
                #line 648 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                                  new PointF(Single.Parse(RtaCave.Split(';')[0].Replace(".", ",")), Single.Parse(RtaCave.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr135Get() {
                this.GetValueTypeValues();
                return this.@__Expr135Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr137GetTree() {
                
                #line 694 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                      RtaCave.Equals("2");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr137Get() {
                
                #line 694 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                      RtaCave.Equals("2");
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr137Get() {
                this.GetValueTypeValues();
                return this.@__Expr137Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr138GetTree() {
                
                #line 699 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                      !RtaCave.Equals("1") && !RtaCave.Equals("2");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr138Get() {
                
                #line 699 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                      !RtaCave.Equals("1") && !RtaCave.Equals("2");
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr138Get() {
                this.GetValueTypeValues();
                return this.@__Expr138Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr139GetTree() {
                
                #line 765 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                      RtaCave.Equals("1");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr139Get() {
                
                #line 765 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                      RtaCave.Equals("1");
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr139Get() {
                this.GetValueTypeValues();
                return this.@__Expr139Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr140GetTree() {
                
                #line 759 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                            "M{ \"x\":\""+Cruz.X+"\", \"y\":\""+Cruz.Y+"\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr140Get() {
                
                #line 759 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                            "M{ \"x\":\""+Cruz.X+"\", \"y\":\""+Cruz.Y+"\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr140Get() {
                this.GetValueTypeValues();
                return this.@__Expr140Get();
            }
            
            protected override void GetValueTypeValues() {
                this.CruzX = ((int)(this.GetVariableValue((23 + locationsOffset))));
                this.CruzY = ((int)(this.GetVariableValue((24 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 25))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 25);
                }
                expectedLocationsCount = 25;
                if (((locationReferences[(offset + 22)].Name != "variable1") 
                            || (locationReferences[(offset + 22)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 23)].Name != "CruzX") 
                            || (locationReferences[(offset + 23)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 24)].Name != "CruzY") 
                            || (locationReferences[(offset + 24)].Type != typeof(int)))) {
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
            
            internal System.Linq.Expressions.Expression @__Expr142GetTree() {
                
                #line 398 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                          Mensaje;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr142Get() {
                
                #line 398 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                          Mensaje;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr142Get() {
                this.GetValueTypeValues();
                return this.@__Expr142Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr142Set(string value) {
                
                #line 398 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                          Mensaje = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr142Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr142Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr146GetTree() {
                
                #line 431 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                              RtaCave;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr146Get() {
                
                #line 431 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                              RtaCave;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr146Get() {
                this.GetValueTypeValues();
                return this.@__Expr146Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr146Set(string value) {
                
                #line 431 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                              RtaCave = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr146Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr146Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr149GetTree() {
                
                #line 445 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                                                  Coordenadas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr149Get() {
                
                #line 445 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                  Coordenadas;
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr149Get() {
                this.GetValueTypeValues();
                return this.@__Expr149Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr149Set(System.Drawing.PointF value) {
                
                #line 445 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                                  Coordenadas = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr149Set(System.Drawing.PointF value) {
                this.GetValueTypeValues();
                this.@__Expr149Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr152GetTree() {
                
                #line 1111 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                              Cursor;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr152Get() {
                
                #line 1111 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                              Cursor;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr152Get() {
                this.GetValueTypeValues();
                return this.@__Expr152Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr152Set(int value) {
                
                #line 1111 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                              Cursor = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr152Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr152Set(value);
                this.SetValueTypeValues();
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
            
            internal System.Linq.Expressions.Expression @__Expr141GetTree() {
                
                #line 403 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                          DateTime.Now.ToString() + ";" + Coordenadas.X + ";" + Coordenadas.Y + ";" + "NULL;NULL;NULL;CEN";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr141Get() {
                
                #line 403 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                          DateTime.Now.ToString() + ";" + Coordenadas.X + ";" + Coordenadas.Y + ";" + "NULL;NULL;NULL;CEN";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr141Get() {
                this.GetValueTypeValues();
                return this.@__Expr141Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr143GetTree() {
                
                #line 414 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                                        Recorrido;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr143Get() {
                
                #line 414 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                        Recorrido;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr143Get() {
                this.GetValueTypeValues();
                return this.@__Expr143Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr144GetTree() {
                
                #line 410 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                          Mensaje;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr144Get() {
                
                #line 410 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                          Mensaje;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr144Get() {
                this.GetValueTypeValues();
                return this.@__Expr144Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr145GetTree() {
                
                #line 419 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                        Mensaje;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr145Get() {
                
                #line 419 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                        Mensaje;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr145Get() {
                this.GetValueTypeValues();
                return this.@__Expr145Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr147GetTree() {
                
                #line 438 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                              RtaCave.Split(';').Length > 1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr147Get() {
                
                #line 438 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                              RtaCave.Split(';').Length > 1;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr147Get() {
                this.GetValueTypeValues();
                return this.@__Expr147Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr148GetTree() {
                
                #line 450 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                                                  new PointF(Single.Parse(RtaCave.Split(';')[0].Replace(".", ",")), Single.Parse(RtaCave.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr148Get() {
                
                #line 450 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                  new PointF(Single.Parse(RtaCave.Split(';')[0].Replace(".", ",")), Single.Parse(RtaCave.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr148Get() {
                this.GetValueTypeValues();
                return this.@__Expr148Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr150GetTree() {
                
                #line 462 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                      !(Math.Sqrt((Math.Pow(Coordenadas.X - Cruz.X, 2)) + Math.Pow(Coordenadas.Y - Cruz.Y, 2)) < Cercania);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr150Get() {
                
                #line 462 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                      !(Math.Sqrt((Math.Pow(Coordenadas.X - Cruz.X, 2)) + Math.Pow(Coordenadas.Y - Cruz.Y, 2)) < Cercania);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr150Get() {
                this.GetValueTypeValues();
                return this.@__Expr150Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr151GetTree() {
                
                #line 1131 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                      Math.Sqrt((Math.Pow(Coordenadas.X - Cruz.X, 2)) + Math.Pow(Coordenadas.Y - Cruz.Y, 2)) < Cercania;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr151Get() {
                
                #line 1131 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                      Math.Sqrt((Math.Pow(Coordenadas.X - Cruz.X, 2)) + Math.Pow(Coordenadas.Y - Cruz.Y, 2)) < Cercania;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr151Get() {
                this.GetValueTypeValues();
                return this.@__Expr151Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr153GetTree() {
                
                #line 1120 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                            "Q{ \"text\":\"Marca la bandera que recolectaste.\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr153Get() {
                
                #line 1120 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                            "Q{ \"text\":\"Marca la bandera que recolectaste.\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr153Get() {
                this.GetValueTypeValues();
                return this.@__Expr153Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr154GetTree() {
                
                #line 1125 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                            Mostrar180;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr154Get() {
                
                #line 1125 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                            Mostrar180;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr154Get() {
                this.GetValueTypeValues();
                return this.@__Expr154Get();
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
            
            internal System.Linq.Expressions.Expression @__Expr155GetTree() {
                
                #line 712 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                                      RtaCave;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr155Get() {
                
                #line 712 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                                      RtaCave;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr155Get() {
                this.GetValueTypeValues();
                return this.@__Expr155Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr155Set(string value) {
                
                #line 712 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                                                                      RtaCave = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr155Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr155Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr158GetTree() {
                
                #line 726 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                                                                                          Coordenadas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr158Get() {
                
                #line 726 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                                          Coordenadas;
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr158Get() {
                this.GetValueTypeValues();
                return this.@__Expr158Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr158Set(System.Drawing.PointF value) {
                
                #line 726 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                                                                          Coordenadas = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr158Set(System.Drawing.PointF value) {
                this.GetValueTypeValues();
                this.@__Expr158Set(value);
                this.SetValueTypeValues();
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
            
            internal System.Linq.Expressions.Expression @__Expr156GetTree() {
                
                #line 719 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                                      RtaCave.Split(';').Length > 1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr156Get() {
                
                #line 719 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                                      RtaCave.Split(';').Length > 1;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr156Get() {
                this.GetValueTypeValues();
                return this.@__Expr156Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr157GetTree() {
                
                #line 731 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                                                                                          new PointF(Single.Parse(RtaCave.Split(';')[0].Replace(".", ",")), Single.Parse(RtaCave.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr157Get() {
                
                #line 731 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                                          new PointF(Single.Parse(RtaCave.Split(';')[0].Replace(".", ",")), Single.Parse(RtaCave.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr157Get() {
                this.GetValueTypeValues();
                return this.@__Expr157Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr159GetTree() {
                
                #line 743 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                              Math.Sqrt((Math.Pow(Coordenadas.X - Cruz.X, 2)) + Math.Pow(Coordenadas.Y - Cruz.Y, 2)) < Cercania;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr159Get() {
                
                #line 743 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                              Math.Sqrt((Math.Pow(Coordenadas.X - Cruz.X, 2)) + Math.Pow(Coordenadas.Y - Cruz.Y, 2)) < Cercania;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr159Get() {
                this.GetValueTypeValues();
                return this.@__Expr159Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr160GetTree() {
                
                #line 748 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                              !(Math.Sqrt((Math.Pow(Coordenadas.X - Cruz.X, 2)) + Math.Pow(Coordenadas.Y - Cruz.Y, 2)) < Cercania);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr160Get() {
                
                #line 748 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                                              !(Math.Sqrt((Math.Pow(Coordenadas.X - Cruz.X, 2)) + Math.Pow(Coordenadas.Y - Cruz.Y, 2)) < Cercania);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr160Get() {
                this.GetValueTypeValues();
                return this.@__Expr160Get();
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
                return PreTraining_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class PreTraining_TypedDataContext14 : PreTraining_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public PreTraining_TypedDataContext14(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext14(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext14(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr162GetTree() {
                
                #line 473 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                  Mensaje;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr162Get() {
                
                #line 473 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                  Mensaje;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr162Get() {
                this.GetValueTypeValues();
                return this.@__Expr162Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr162Set(string value) {
                
                #line 473 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                                  Mensaje = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr162Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr162Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr166GetTree() {
                
                #line 506 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                      RtaCave;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr166Get() {
                
                #line 506 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                      RtaCave;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr166Get() {
                this.GetValueTypeValues();
                return this.@__Expr166Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr166Set(string value) {
                
                #line 506 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                                      RtaCave = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr166Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr166Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr169GetTree() {
                
                #line 520 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                                                          Coordenadas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr169Get() {
                
                #line 520 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                          Coordenadas;
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr169Get() {
                this.GetValueTypeValues();
                return this.@__Expr169Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr169Set(System.Drawing.PointF value) {
                
                #line 520 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                                          Coordenadas = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr169Set(System.Drawing.PointF value) {
                this.GetValueTypeValues();
                this.@__Expr169Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr171GetTree() {
                
                #line 1069 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                      Cursor;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr171Get() {
                
                #line 1069 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                      Cursor;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr171Get() {
                this.GetValueTypeValues();
                return this.@__Expr171Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr171Set(int value) {
                
                #line 1069 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                                      Cursor = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr171Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr171Set(value);
                this.SetValueTypeValues();
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
                return PreTraining_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class PreTraining_TypedDataContext14_ForReadOnly : PreTraining_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public PreTraining_TypedDataContext14_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext14_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext14_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr161GetTree() {
                
                #line 478 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                  DateTime.Now.ToString() + ";" + Coordenadas.X + ";" + Coordenadas.Y + ";EVA";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr161Get() {
                
                #line 478 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                  DateTime.Now.ToString() + ";" + Coordenadas.X + ";" + Coordenadas.Y + ";EVA";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr161Get() {
                this.GetValueTypeValues();
                return this.@__Expr161Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr163GetTree() {
                
                #line 489 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                                                Recorrido;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr163Get() {
                
                #line 489 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                Recorrido;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr163Get() {
                this.GetValueTypeValues();
                return this.@__Expr163Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr164GetTree() {
                
                #line 485 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                  Mensaje;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr164Get() {
                
                #line 485 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                  Mensaje;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr164Get() {
                this.GetValueTypeValues();
                return this.@__Expr164Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr165GetTree() {
                
                #line 494 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                Mensaje;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr165Get() {
                
                #line 494 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                Mensaje;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr165Get() {
                this.GetValueTypeValues();
                return this.@__Expr165Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr167GetTree() {
                
                #line 513 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                      RtaCave.Split(';').Length > 1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr167Get() {
                
                #line 513 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                      RtaCave.Split(';').Length > 1;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr167Get() {
                this.GetValueTypeValues();
                return this.@__Expr167Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr168GetTree() {
                
                #line 525 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                                                          new PointF(Single.Parse(RtaCave.Split(';')[0].Replace(".", ",")), Single.Parse(RtaCave.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr168Get() {
                
                #line 525 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                          new PointF(Single.Parse(RtaCave.Split(';')[0].Replace(".", ",")), Single.Parse(RtaCave.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr168Get() {
                this.GetValueTypeValues();
                return this.@__Expr168Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr170GetTree() {
                
                #line 1100 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                              (BanderasAparecidas.Count().CompareTo(Protocolo.Length) < 0 && !(Protocolo[BanderasAparecidas.Count()].Equals(1)) && !(Protocolo[BanderasAparecidas.Count()].Equals(3))) || !(BanderasAparecidas.Count().CompareTo(Protocolo.Length) <0);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr170Get() {
                
                #line 1100 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                              (BanderasAparecidas.Count().CompareTo(Protocolo.Length) < 0 && !(Protocolo[BanderasAparecidas.Count()].Equals(1)) && !(Protocolo[BanderasAparecidas.Count()].Equals(3))) || !(BanderasAparecidas.Count().CompareTo(Protocolo.Length) <0);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr170Get() {
                this.GetValueTypeValues();
                return this.@__Expr170Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr172GetTree() {
                
                #line 1078 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    "Q{ \"text\":\"Escucha la consigna\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr172Get() {
                
                #line 1078 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                    "Q{ \"text\":\"Escucha la consigna\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr172Get() {
                this.GetValueTypeValues();
                return this.@__Expr172Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr173GetTree() {
                
                #line 1083 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.TimeSpan>> expression = () => 
                                                    TimeSpan.FromSeconds(4);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.TimeSpan @__Expr173Get() {
                
                #line 1083 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                    TimeSpan.FromSeconds(4);
                
                #line default
                #line hidden
            }
            
            public System.TimeSpan ValueType___Expr173Get() {
                this.GetValueTypeValues();
                return this.@__Expr173Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr174GetTree() {
                
                #line 1089 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    "Q{ \"text\":\"X(izq) Y(Sel) B(der)\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr174Get() {
                
                #line 1089 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                    "Q{ \"text\":\"X(izq) Y(Sel) B(der)\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr174Get() {
                this.GetValueTypeValues();
                return this.@__Expr174Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr175GetTree() {
                
                #line 1094 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    Mostrar180;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr175Get() {
                
                #line 1094 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                    Mostrar180;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr175Get() {
                this.GetValueTypeValues();
                return this.@__Expr175Get();
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
                return PreTraining_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class PreTraining_TypedDataContext15 : PreTraining_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public PreTraining_TypedDataContext15(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext15(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext15(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr178GetTree() {
                
                #line 549 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                          Mensaje;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr178Get() {
                
                #line 549 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                          Mensaje;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr178Get() {
                this.GetValueTypeValues();
                return this.@__Expr178Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr178Set(string value) {
                
                #line 549 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                
                                                          Mensaje = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr178Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr178Set(value);
                this.SetValueTypeValues();
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
                return PreTraining_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class PreTraining_TypedDataContext15_ForReadOnly : PreTraining_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public PreTraining_TypedDataContext15_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext15_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PreTraining_TypedDataContext15_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr176GetTree() {
                
                #line 539 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                        "C{ \"id\":\"" + (int)(Cursor) + "\", \"color\":\"azul\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr176Get() {
                
                #line 539 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                        "C{ \"id\":\"" + (int)(Cursor) + "\", \"color\":\"azul\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr176Get() {
                this.GetValueTypeValues();
                return this.@__Expr176Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr177GetTree() {
                
                #line 554 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                          DateTime.Now.ToString() + ";" + Coordenadas.X + ";" + Coordenadas.Y + ";PR2";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr177Get() {
                
                #line 554 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                          DateTime.Now.ToString() + ";" + Coordenadas.X + ";" + Coordenadas.Y + ";PR2";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr177Get() {
                this.GetValueTypeValues();
                return this.@__Expr177Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr179GetTree() {
                
                #line 565 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                                                        Recorrido;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr179Get() {
                
                #line 565 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                        Recorrido;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr179Get() {
                this.GetValueTypeValues();
                return this.@__Expr179Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr180GetTree() {
                
                #line 561 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                          Mensaje;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr180Get() {
                
                #line 561 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                          Mensaje;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr180Get() {
                this.GetValueTypeValues();
                return this.@__Expr180Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr181GetTree() {
                
                #line 570 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                        Mensaje;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr181Get() {
                
                #line 570 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PRETRAINING\PRETRAINING.XAML"
                return 
                                                        Mensaje;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr181Get() {
                this.GetValueTypeValues();
                return this.@__Expr181Get();
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
                return PreTraining_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
