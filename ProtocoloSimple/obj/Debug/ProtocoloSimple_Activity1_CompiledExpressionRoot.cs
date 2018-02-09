namespace ProtocoloSimple {
    
    #line 35 "C:\Users\DellPladema\Desktop\Nueva carpeta (2)\VFinal\WFFlagCollector\FlagCollector\ProtocoloSimple\Activity1.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\DellPladema\Desktop\Nueva carpeta (2)\VFinal\WFFlagCollector\FlagCollector\ProtocoloSimple\Activity1.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 36 "C:\Users\DellPladema\Desktop\Nueva carpeta (2)\VFinal\WFFlagCollector\FlagCollector\ProtocoloSimple\Activity1.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\DellPladema\Desktop\Nueva carpeta (2)\VFinal\WFFlagCollector\FlagCollector\ProtocoloSimple\Activity1.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\DellPladema\Desktop\Nueva carpeta (2)\VFinal\WFFlagCollector\FlagCollector\ProtocoloSimple\Activity1.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\DellPladema\Desktop\Nueva carpeta (2)\VFinal\WFFlagCollector\FlagCollector\ProtocoloSimple\Activity1.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 37 "C:\Users\DellPladema\Desktop\Nueva carpeta (2)\VFinal\WFFlagCollector\FlagCollector\ProtocoloSimple\Activity1.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 38 "C:\Users\DellPladema\Desktop\Nueva carpeta (2)\VFinal\WFFlagCollector\FlagCollector\ProtocoloSimple\Activity1.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 39 "C:\Users\DellPladema\Desktop\Nueva carpeta (2)\VFinal\WFFlagCollector\FlagCollector\ProtocoloSimple\Activity1.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 40 "C:\Users\DellPladema\Desktop\Nueva carpeta (2)\VFinal\WFFlagCollector\FlagCollector\ProtocoloSimple\Activity1.xaml"
    using System.Drawing;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\DellPladema\Desktop\Nueva carpeta (2)\VFinal\WFFlagCollector\FlagCollector\ProtocoloSimple\Activity1.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class Activity1 : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
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
                this.dataContextActivities = Activity1_TypedDataContext3.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Activity1_TypedDataContext3(locations, activityContext, true);
                }
                Activity1_TypedDataContext3 refDataContext0 = ((Activity1_TypedDataContext3)(cachedCompiledDataContext[0]));
                return refDataContext0.GetLocation<int>(refDataContext0.ValueType___Expr0Get, refDataContext0.ValueType___Expr0Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Activity1_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext3_ForReadOnly valDataContext1 = ((Activity1_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Activity1_TypedDataContext3(locations, activityContext, true);
                }
                Activity1_TypedDataContext3 refDataContext2 = ((Activity1_TypedDataContext3)(cachedCompiledDataContext[0]));
                return refDataContext2.GetLocation<System.Collections.Generic.List<string>>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Activity1_TypedDataContext3(locations, activityContext, true);
                }
                Activity1_TypedDataContext3 refDataContext3 = ((Activity1_TypedDataContext3)(cachedCompiledDataContext[0]));
                return refDataContext3.GetLocation<int>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Activity1_TypedDataContext3(locations, activityContext, true);
                }
                Activity1_TypedDataContext3 refDataContext4 = ((Activity1_TypedDataContext3)(cachedCompiledDataContext[0]));
                return refDataContext4.GetLocation<int>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Activity1_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext3_ForReadOnly valDataContext5 = ((Activity1_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Activity1_TypedDataContext3(locations, activityContext, true);
                }
                Activity1_TypedDataContext3 refDataContext6 = ((Activity1_TypedDataContext3)(cachedCompiledDataContext[0]));
                return refDataContext6.GetLocation<int[]>(refDataContext6.ValueType___Expr6Get, refDataContext6.ValueType___Expr6Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Activity1_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext3_ForReadOnly valDataContext7 = ((Activity1_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Activity1_TypedDataContext3(locations, activityContext, true);
                }
                Activity1_TypedDataContext3 refDataContext8 = ((Activity1_TypedDataContext3)(cachedCompiledDataContext[0]));
                return refDataContext8.GetLocation<bool[]>(refDataContext8.ValueType___Expr8Get, refDataContext8.ValueType___Expr8Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Activity1_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext3_ForReadOnly valDataContext9 = ((Activity1_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Activity1_TypedDataContext3(locations, activityContext, true);
                }
                Activity1_TypedDataContext3 refDataContext10 = ((Activity1_TypedDataContext3)(cachedCompiledDataContext[0]));
                return refDataContext10.GetLocation<System.Drawing.PointF>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Activity1_TypedDataContext3(locations, activityContext, true);
                }
                Activity1_TypedDataContext3 refDataContext11 = ((Activity1_TypedDataContext3)(cachedCompiledDataContext[0]));
                return refDataContext11.GetLocation<int>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Activity1_TypedDataContext3(locations, activityContext, true);
                }
                Activity1_TypedDataContext3 refDataContext12 = ((Activity1_TypedDataContext3)(cachedCompiledDataContext[0]));
                return refDataContext12.GetLocation<string>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Activity1_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext3_ForReadOnly valDataContext13 = ((Activity1_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Activity1_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext3_ForReadOnly valDataContext14 = ((Activity1_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Activity1_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext4_ForReadOnly valDataContext15 = ((Activity1_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Activity1_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext4_ForReadOnly valDataContext16 = ((Activity1_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Activity1_TypedDataContext4(locations, activityContext, true);
                }
                Activity1_TypedDataContext4 refDataContext17 = ((Activity1_TypedDataContext4)(cachedCompiledDataContext[3]));
                return refDataContext17.GetLocation<string>(refDataContext17.ValueType___Expr17Get, refDataContext17.ValueType___Expr17Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 18)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Activity1_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext4_ForReadOnly valDataContext18 = ((Activity1_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext18.ValueType___Expr18Get();
            }
            if ((expressionId == 19)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Activity1_TypedDataContext4(locations, activityContext, true);
                }
                Activity1_TypedDataContext4 refDataContext19 = ((Activity1_TypedDataContext4)(cachedCompiledDataContext[3]));
                return refDataContext19.GetLocation<System.Drawing.PointF>(refDataContext19.ValueType___Expr19Get, refDataContext19.ValueType___Expr19Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 20)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Activity1_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext4_ForReadOnly valDataContext20 = ((Activity1_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Activity1_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext4_ForReadOnly valDataContext21 = ((Activity1_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext21.ValueType___Expr21Get();
            }
            if ((expressionId == 22)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Activity1_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext4_ForReadOnly valDataContext22 = ((Activity1_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Activity1_TypedDataContext4(locations, activityContext, true);
                }
                Activity1_TypedDataContext4 refDataContext23 = ((Activity1_TypedDataContext4)(cachedCompiledDataContext[3]));
                return refDataContext23.GetLocation<int>(refDataContext23.ValueType___Expr23Get, refDataContext23.ValueType___Expr23Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 24)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Activity1_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext4_ForReadOnly valDataContext24 = ((Activity1_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext24.ValueType___Expr24Get();
            }
            if ((expressionId == 25)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Activity1_TypedDataContext4(locations, activityContext, true);
                }
                Activity1_TypedDataContext4 refDataContext25 = ((Activity1_TypedDataContext4)(cachedCompiledDataContext[3]));
                return refDataContext25.GetLocation<bool>(refDataContext25.ValueType___Expr25Get, refDataContext25.ValueType___Expr25Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 26)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Activity1_TypedDataContext4(locations, activityContext, true);
                }
                Activity1_TypedDataContext4 refDataContext26 = ((Activity1_TypedDataContext4)(cachedCompiledDataContext[3]));
                return refDataContext26.GetLocation<bool>(refDataContext26.ValueType___Expr26Get, refDataContext26.ValueType___Expr26Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 27)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Activity1_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext4_ForReadOnly valDataContext27 = ((Activity1_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext27.ValueType___Expr27Get();
            }
            if ((expressionId == 28)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Activity1_TypedDataContext4(locations, activityContext, true);
                }
                Activity1_TypedDataContext4 refDataContext28 = ((Activity1_TypedDataContext4)(cachedCompiledDataContext[3]));
                return refDataContext28.GetLocation<int>(refDataContext28.ValueType___Expr28Get, refDataContext28.ValueType___Expr28Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 29)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Activity1_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext4_ForReadOnly valDataContext29 = ((Activity1_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext29.ValueType___Expr29Get();
            }
            if ((expressionId == 30)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Activity1_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext4_ForReadOnly valDataContext30 = ((Activity1_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext30.ValueType___Expr30Get();
            }
            if ((expressionId == 31)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Activity1_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext5_ForReadOnly valDataContext31 = ((Activity1_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext31.ValueType___Expr31Get();
            }
            if ((expressionId == 32)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Activity1_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext5_ForReadOnly valDataContext32 = ((Activity1_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext32.ValueType___Expr32Get();
            }
            if ((expressionId == 33)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Activity1_TypedDataContext5(locations, activityContext, true);
                }
                Activity1_TypedDataContext5 refDataContext33 = ((Activity1_TypedDataContext5)(cachedCompiledDataContext[5]));
                return refDataContext33.GetLocation<string>(refDataContext33.ValueType___Expr33Get, refDataContext33.ValueType___Expr33Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 34)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Activity1_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext5_ForReadOnly valDataContext34 = ((Activity1_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext34.ValueType___Expr34Get();
            }
            if ((expressionId == 35)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Activity1_TypedDataContext5(locations, activityContext, true);
                }
                Activity1_TypedDataContext5 refDataContext35 = ((Activity1_TypedDataContext5)(cachedCompiledDataContext[5]));
                return refDataContext35.GetLocation<System.Drawing.PointF>(refDataContext35.ValueType___Expr35Get, refDataContext35.ValueType___Expr35Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 36)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Activity1_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext5_ForReadOnly valDataContext36 = ((Activity1_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext36.ValueType___Expr36Get();
            }
            if ((expressionId == 37)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Activity1_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext5_ForReadOnly valDataContext37 = ((Activity1_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext37.ValueType___Expr37Get();
            }
            if ((expressionId == 38)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Activity1_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext5_ForReadOnly valDataContext38 = ((Activity1_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext38.ValueType___Expr38Get();
            }
            if ((expressionId == 39)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Activity1_TypedDataContext5(locations, activityContext, true);
                }
                Activity1_TypedDataContext5 refDataContext39 = ((Activity1_TypedDataContext5)(cachedCompiledDataContext[5]));
                return refDataContext39.GetLocation<int>(refDataContext39.ValueType___Expr39Get, refDataContext39.ValueType___Expr39Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 40)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Activity1_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext5_ForReadOnly valDataContext40 = ((Activity1_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext40.ValueType___Expr40Get();
            }
            if ((expressionId == 41)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Activity1_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext5_ForReadOnly valDataContext41 = ((Activity1_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext41.ValueType___Expr41Get();
            }
            if ((expressionId == 42)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Activity1_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext5_ForReadOnly valDataContext42 = ((Activity1_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext42.ValueType___Expr42Get();
            }
            if ((expressionId == 43)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Activity1_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext5_ForReadOnly valDataContext43 = ((Activity1_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext43.ValueType___Expr43Get();
            }
            if ((expressionId == 44)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Activity1_TypedDataContext5(locations, activityContext, true);
                }
                Activity1_TypedDataContext5 refDataContext44 = ((Activity1_TypedDataContext5)(cachedCompiledDataContext[5]));
                return refDataContext44.GetLocation<bool>(refDataContext44.ValueType___Expr44Get, refDataContext44.ValueType___Expr44Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 45)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Activity1_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext5_ForReadOnly valDataContext45 = ((Activity1_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext45.ValueType___Expr45Get();
            }
            if ((expressionId == 46)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Activity1_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext5_ForReadOnly valDataContext46 = ((Activity1_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext46.ValueType___Expr46Get();
            }
            if ((expressionId == 47)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Activity1_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext5_ForReadOnly valDataContext47 = ((Activity1_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext47.ValueType___Expr47Get();
            }
            if ((expressionId == 48)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Activity1_TypedDataContext5(locations, activityContext, true);
                }
                Activity1_TypedDataContext5 refDataContext48 = ((Activity1_TypedDataContext5)(cachedCompiledDataContext[5]));
                return refDataContext48.GetLocation<bool>(refDataContext48.ValueType___Expr48Get, refDataContext48.ValueType___Expr48Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 49)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Activity1_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext6_ForReadOnly valDataContext49 = ((Activity1_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext49.ValueType___Expr49Get();
            }
            if ((expressionId == 50)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Activity1_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext6_ForReadOnly valDataContext50 = ((Activity1_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext50.ValueType___Expr50Get();
            }
            if ((expressionId == 51)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new Activity1_TypedDataContext6(locations, activityContext, true);
                }
                Activity1_TypedDataContext6 refDataContext51 = ((Activity1_TypedDataContext6)(cachedCompiledDataContext[7]));
                return refDataContext51.GetLocation<string>(refDataContext51.ValueType___Expr51Get, refDataContext51.ValueType___Expr51Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 52)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Activity1_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext6_ForReadOnly valDataContext52 = ((Activity1_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext52.ValueType___Expr52Get();
            }
            if ((expressionId == 53)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new Activity1_TypedDataContext6(locations, activityContext, true);
                }
                Activity1_TypedDataContext6 refDataContext53 = ((Activity1_TypedDataContext6)(cachedCompiledDataContext[7]));
                return refDataContext53.GetLocation<System.Drawing.PointF>(refDataContext53.ValueType___Expr53Get, refDataContext53.ValueType___Expr53Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 54)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Activity1_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext6_ForReadOnly valDataContext54 = ((Activity1_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext54.ValueType___Expr54Get();
            }
            if ((expressionId == 55)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Activity1_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext6_ForReadOnly valDataContext55 = ((Activity1_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext55.ValueType___Expr55Get();
            }
            if ((expressionId == 56)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Activity1_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext6_ForReadOnly valDataContext56 = ((Activity1_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext56.ValueType___Expr56Get();
            }
            if ((expressionId == 57)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Activity1_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext6_ForReadOnly valDataContext57 = ((Activity1_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext57.ValueType___Expr57Get();
            }
            if ((expressionId == 58)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Activity1_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext6_ForReadOnly valDataContext58 = ((Activity1_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext58.ValueType___Expr58Get();
            }
            if ((expressionId == 59)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Activity1_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext6_ForReadOnly valDataContext59 = ((Activity1_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext59.ValueType___Expr59Get();
            }
            if ((expressionId == 60)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Activity1_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext6_ForReadOnly valDataContext60 = ((Activity1_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext60.ValueType___Expr60Get();
            }
            if ((expressionId == 61)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Activity1_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext6_ForReadOnly valDataContext61 = ((Activity1_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext61.ValueType___Expr61Get();
            }
            if ((expressionId == 62)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new Activity1_TypedDataContext6(locations, activityContext, true);
                }
                Activity1_TypedDataContext6 refDataContext62 = ((Activity1_TypedDataContext6)(cachedCompiledDataContext[7]));
                return refDataContext62.GetLocation<int>(refDataContext62.ValueType___Expr62Get, refDataContext62.ValueType___Expr62Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 63)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Activity1_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext6_ForReadOnly valDataContext63 = ((Activity1_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext63.ValueType___Expr63Get();
            }
            if ((expressionId == 64)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Activity1_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext6_ForReadOnly valDataContext64 = ((Activity1_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext64.ValueType___Expr64Get();
            }
            if ((expressionId == 65)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Activity1_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext6_ForReadOnly valDataContext65 = ((Activity1_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext65.ValueType___Expr65Get();
            }
            if ((expressionId == 66)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Activity1_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext6_ForReadOnly valDataContext66 = ((Activity1_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext66.ValueType___Expr66Get();
            }
            if ((expressionId == 67)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Activity1_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext6_ForReadOnly valDataContext67 = ((Activity1_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext67.ValueType___Expr67Get();
            }
            if ((expressionId == 68)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Activity1_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext6_ForReadOnly valDataContext68 = ((Activity1_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext68.ValueType___Expr68Get();
            }
            if ((expressionId == 69)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Activity1_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext6_ForReadOnly valDataContext69 = ((Activity1_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext69.ValueType___Expr69Get();
            }
            if ((expressionId == 70)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Activity1_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext6_ForReadOnly valDataContext70 = ((Activity1_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext70.ValueType___Expr70Get();
            }
            if ((expressionId == 71)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Activity1_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext6_ForReadOnly valDataContext71 = ((Activity1_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext71.ValueType___Expr71Get();
            }
            if ((expressionId == 72)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Activity1_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext6_ForReadOnly valDataContext72 = ((Activity1_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext72.ValueType___Expr72Get();
            }
            if ((expressionId == 73)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new Activity1_TypedDataContext6(locations, activityContext, true);
                }
                Activity1_TypedDataContext6 refDataContext73 = ((Activity1_TypedDataContext6)(cachedCompiledDataContext[7]));
                return refDataContext73.GetLocation<int>(refDataContext73.ValueType___Expr73Get, refDataContext73.ValueType___Expr73Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 74)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Activity1_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext6_ForReadOnly valDataContext74 = ((Activity1_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext74.ValueType___Expr74Get();
            }
            if ((expressionId == 75)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Activity1_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext6_ForReadOnly valDataContext75 = ((Activity1_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext75.ValueType___Expr75Get();
            }
            if ((expressionId == 76)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Activity1_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext6_ForReadOnly valDataContext76 = ((Activity1_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext76.ValueType___Expr76Get();
            }
            if ((expressionId == 77)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Activity1_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext6_ForReadOnly valDataContext77 = ((Activity1_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext77.ValueType___Expr77Get();
            }
            if ((expressionId == 78)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new Activity1_TypedDataContext6(locations, activityContext, true);
                }
                Activity1_TypedDataContext6 refDataContext78 = ((Activity1_TypedDataContext6)(cachedCompiledDataContext[7]));
                return refDataContext78.GetLocation<int>(refDataContext78.ValueType___Expr78Get, refDataContext78.ValueType___Expr78Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 79)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new Activity1_TypedDataContext6(locations, activityContext, true);
                }
                Activity1_TypedDataContext6 refDataContext79 = ((Activity1_TypedDataContext6)(cachedCompiledDataContext[7]));
                return refDataContext79.GetLocation<int>(refDataContext79.ValueType___Expr79Get, refDataContext79.ValueType___Expr79Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 80)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Activity1_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext6_ForReadOnly valDataContext80 = ((Activity1_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext80.ValueType___Expr80Get();
            }
            if ((expressionId == 81)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Activity1_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext6_ForReadOnly valDataContext81 = ((Activity1_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext81.ValueType___Expr81Get();
            }
            if ((expressionId == 82)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Activity1_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext6_ForReadOnly valDataContext82 = ((Activity1_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext82.ValueType___Expr82Get();
            }
            if ((expressionId == 83)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Activity1_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext6_ForReadOnly valDataContext83 = ((Activity1_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext83.ValueType___Expr83Get();
            }
            if ((expressionId == 84)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new Activity1_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext7_ForReadOnly valDataContext84 = ((Activity1_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext84.ValueType___Expr84Get();
            }
            if ((expressionId == 85)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new Activity1_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext7_ForReadOnly valDataContext85 = ((Activity1_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext85.ValueType___Expr85Get();
            }
            if ((expressionId == 86)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new Activity1_TypedDataContext7(locations, activityContext, true);
                }
                Activity1_TypedDataContext7 refDataContext86 = ((Activity1_TypedDataContext7)(cachedCompiledDataContext[9]));
                return refDataContext86.GetLocation<string>(refDataContext86.ValueType___Expr86Get, refDataContext86.ValueType___Expr86Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 87)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new Activity1_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext7_ForReadOnly valDataContext87 = ((Activity1_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext87.ValueType___Expr87Get();
            }
            if ((expressionId == 88)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new Activity1_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext7_ForReadOnly valDataContext88 = ((Activity1_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext88.ValueType___Expr88Get();
            }
            if ((expressionId == 89)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new Activity1_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext7_ForReadOnly valDataContext89 = ((Activity1_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext89.ValueType___Expr89Get();
            }
            if ((expressionId == 90)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new Activity1_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext7_ForReadOnly valDataContext90 = ((Activity1_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext90.ValueType___Expr90Get();
            }
            if ((expressionId == 91)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new Activity1_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext7_ForReadOnly valDataContext91 = ((Activity1_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext91.ValueType___Expr91Get();
            }
            if ((expressionId == 92)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new Activity1_TypedDataContext7(locations, activityContext, true);
                }
                Activity1_TypedDataContext7 refDataContext92 = ((Activity1_TypedDataContext7)(cachedCompiledDataContext[9]));
                return refDataContext92.GetLocation<int>(refDataContext92.ValueType___Expr92Get, refDataContext92.ValueType___Expr92Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 93)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new Activity1_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext7_ForReadOnly valDataContext93 = ((Activity1_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext93.ValueType___Expr93Get();
            }
            if ((expressionId == 94)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new Activity1_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext7_ForReadOnly valDataContext94 = ((Activity1_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext94.ValueType___Expr94Get();
            }
            if ((expressionId == 95)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new Activity1_TypedDataContext7(locations, activityContext, true);
                }
                Activity1_TypedDataContext7 refDataContext95 = ((Activity1_TypedDataContext7)(cachedCompiledDataContext[9]));
                return refDataContext95.GetLocation<int>(refDataContext95.ValueType___Expr95Get, refDataContext95.ValueType___Expr95Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 96)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new Activity1_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext7_ForReadOnly valDataContext96 = ((Activity1_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext96.ValueType___Expr96Get();
            }
            if ((expressionId == 97)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new Activity1_TypedDataContext7(locations, activityContext, true);
                }
                Activity1_TypedDataContext7 refDataContext97 = ((Activity1_TypedDataContext7)(cachedCompiledDataContext[9]));
                return refDataContext97.GetLocation<int>(refDataContext97.ValueType___Expr97Get, refDataContext97.ValueType___Expr97Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 98)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new Activity1_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext7_ForReadOnly valDataContext98 = ((Activity1_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext98.ValueType___Expr98Get();
            }
            if ((expressionId == 99)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new Activity1_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext8_ForReadOnly valDataContext99 = ((Activity1_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[10]));
                return valDataContext99.ValueType___Expr99Get();
            }
            if ((expressionId == 100)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new Activity1_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext8_ForReadOnly valDataContext100 = ((Activity1_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[10]));
                return valDataContext100.ValueType___Expr100Get();
            }
            if ((expressionId == 101)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new Activity1_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext8_ForReadOnly valDataContext101 = ((Activity1_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[10]));
                return valDataContext101.ValueType___Expr101Get();
            }
            if ((expressionId == 102)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new Activity1_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext8_ForReadOnly valDataContext102 = ((Activity1_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[10]));
                return valDataContext102.ValueType___Expr102Get();
            }
            if ((expressionId == 103)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Activity1_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext9_ForReadOnly valDataContext103 = ((Activity1_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext103.ValueType___Expr103Get();
            }
            if ((expressionId == 104)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Activity1_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext9_ForReadOnly valDataContext104 = ((Activity1_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext104.ValueType___Expr104Get();
            }
            if ((expressionId == 105)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Activity1_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext9_ForReadOnly valDataContext105 = ((Activity1_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext105.ValueType___Expr105Get();
            }
            if ((expressionId == 106)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Activity1_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext9_ForReadOnly valDataContext106 = ((Activity1_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext106.ValueType___Expr106Get();
            }
            if ((expressionId == 107)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Activity1_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext9_ForReadOnly valDataContext107 = ((Activity1_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext107.ValueType___Expr107Get();
            }
            if ((expressionId == 108)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Activity1_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext9_ForReadOnly valDataContext108 = ((Activity1_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext108.ValueType___Expr108Get();
            }
            if ((expressionId == 109)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Activity1_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext9_ForReadOnly valDataContext109 = ((Activity1_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext109.ValueType___Expr109Get();
            }
            if ((expressionId == 110)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Activity1_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext9_ForReadOnly valDataContext110 = ((Activity1_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext110.ValueType___Expr110Get();
            }
            if ((expressionId == 111)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Activity1_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext9_ForReadOnly valDataContext111 = ((Activity1_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext111.ValueType___Expr111Get();
            }
            if ((expressionId == 112)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Activity1_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext9_ForReadOnly valDataContext112 = ((Activity1_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext112.ValueType___Expr112Get();
            }
            if ((expressionId == 113)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Activity1_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext9_ForReadOnly valDataContext113 = ((Activity1_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext113.ValueType___Expr113Get();
            }
            if ((expressionId == 114)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Activity1_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext9_ForReadOnly valDataContext114 = ((Activity1_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext114.ValueType___Expr114Get();
            }
            if ((expressionId == 115)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Activity1_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext9_ForReadOnly valDataContext115 = ((Activity1_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext115.ValueType___Expr115Get();
            }
            if ((expressionId == 116)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Activity1_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext9_ForReadOnly valDataContext116 = ((Activity1_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext116.ValueType___Expr116Get();
            }
            if ((expressionId == 117)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Activity1_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext9_ForReadOnly valDataContext117 = ((Activity1_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext117.ValueType___Expr117Get();
            }
            if ((expressionId == 118)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Activity1_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext9_ForReadOnly valDataContext118 = ((Activity1_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext118.ValueType___Expr118Get();
            }
            if ((expressionId == 119)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Activity1_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext9_ForReadOnly valDataContext119 = ((Activity1_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext119.ValueType___Expr119Get();
            }
            if ((expressionId == 120)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Activity1_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext9_ForReadOnly valDataContext120 = ((Activity1_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext120.ValueType___Expr120Get();
            }
            if ((expressionId == 121)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Activity1_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext9_ForReadOnly valDataContext121 = ((Activity1_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext121.ValueType___Expr121Get();
            }
            if ((expressionId == 122)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new Activity1_TypedDataContext9(locations, activityContext, true);
                }
                Activity1_TypedDataContext9 refDataContext122 = ((Activity1_TypedDataContext9)(cachedCompiledDataContext[12]));
                return refDataContext122.GetLocation<string>(refDataContext122.ValueType___Expr122Get, refDataContext122.ValueType___Expr122Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 123)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Activity1_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext9_ForReadOnly valDataContext123 = ((Activity1_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext123.ValueType___Expr123Get();
            }
            if ((expressionId == 124)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new Activity1_TypedDataContext9(locations, activityContext, true);
                }
                Activity1_TypedDataContext9 refDataContext124 = ((Activity1_TypedDataContext9)(cachedCompiledDataContext[12]));
                return refDataContext124.GetLocation<System.Drawing.PointF>(refDataContext124.ValueType___Expr124Get, refDataContext124.ValueType___Expr124Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 125)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Activity1_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext9_ForReadOnly valDataContext125 = ((Activity1_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext125.ValueType___Expr125Get();
            }
            if ((expressionId == 126)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Activity1_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext9_ForReadOnly valDataContext126 = ((Activity1_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext126.ValueType___Expr126Get();
            }
            if ((expressionId == 127)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new Activity1_TypedDataContext10_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext10_ForReadOnly valDataContext127 = ((Activity1_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[13]));
                return valDataContext127.ValueType___Expr127Get();
            }
            if ((expressionId == 128)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new Activity1_TypedDataContext10_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext10_ForReadOnly valDataContext128 = ((Activity1_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[13]));
                return valDataContext128.ValueType___Expr128Get();
            }
            if ((expressionId == 129)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext10.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[14] == null)) {
                    cachedCompiledDataContext[14] = new Activity1_TypedDataContext10(locations, activityContext, true);
                }
                Activity1_TypedDataContext10 refDataContext129 = ((Activity1_TypedDataContext10)(cachedCompiledDataContext[14]));
                return refDataContext129.GetLocation<string>(refDataContext129.ValueType___Expr129Get, refDataContext129.ValueType___Expr129Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 130)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new Activity1_TypedDataContext10_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext10_ForReadOnly valDataContext130 = ((Activity1_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[13]));
                return valDataContext130.ValueType___Expr130Get();
            }
            if ((expressionId == 131)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new Activity1_TypedDataContext10_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext10_ForReadOnly valDataContext131 = ((Activity1_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[13]));
                return valDataContext131.ValueType___Expr131Get();
            }
            if ((expressionId == 132)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new Activity1_TypedDataContext10_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext10_ForReadOnly valDataContext132 = ((Activity1_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[13]));
                return valDataContext132.ValueType___Expr132Get();
            }
            if ((expressionId == 133)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new Activity1_TypedDataContext10_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext10_ForReadOnly valDataContext133 = ((Activity1_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[13]));
                return valDataContext133.ValueType___Expr133Get();
            }
            if ((expressionId == 134)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new Activity1_TypedDataContext10_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext10_ForReadOnly valDataContext134 = ((Activity1_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[13]));
                return valDataContext134.ValueType___Expr134Get();
            }
            if ((expressionId == 135)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext10.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[14] == null)) {
                    cachedCompiledDataContext[14] = new Activity1_TypedDataContext10(locations, activityContext, true);
                }
                Activity1_TypedDataContext10 refDataContext135 = ((Activity1_TypedDataContext10)(cachedCompiledDataContext[14]));
                return refDataContext135.GetLocation<int>(refDataContext135.ValueType___Expr135Get, refDataContext135.ValueType___Expr135Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 136)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new Activity1_TypedDataContext10_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext10_ForReadOnly valDataContext136 = ((Activity1_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[13]));
                return valDataContext136.ValueType___Expr136Get();
            }
            if ((expressionId == 137)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new Activity1_TypedDataContext10_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext10_ForReadOnly valDataContext137 = ((Activity1_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[13]));
                return valDataContext137.ValueType___Expr137Get();
            }
            if ((expressionId == 138)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new Activity1_TypedDataContext10_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext10_ForReadOnly valDataContext138 = ((Activity1_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[13]));
                return valDataContext138.ValueType___Expr138Get();
            }
            if ((expressionId == 139)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new Activity1_TypedDataContext10_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext10_ForReadOnly valDataContext139 = ((Activity1_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[13]));
                return valDataContext139.ValueType___Expr139Get();
            }
            if ((expressionId == 140)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new Activity1_TypedDataContext10_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext10_ForReadOnly valDataContext140 = ((Activity1_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[13]));
                return valDataContext140.ValueType___Expr140Get();
            }
            if ((expressionId == 141)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new Activity1_TypedDataContext10_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext10_ForReadOnly valDataContext141 = ((Activity1_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[13]));
                return valDataContext141.ValueType___Expr141Get();
            }
            if ((expressionId == 142)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new Activity1_TypedDataContext10_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext10_ForReadOnly valDataContext142 = ((Activity1_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[13]));
                return valDataContext142.ValueType___Expr142Get();
            }
            if ((expressionId == 143)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext10.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[14] == null)) {
                    cachedCompiledDataContext[14] = new Activity1_TypedDataContext10(locations, activityContext, true);
                }
                Activity1_TypedDataContext10 refDataContext143 = ((Activity1_TypedDataContext10)(cachedCompiledDataContext[14]));
                return refDataContext143.GetLocation<System.Drawing.PointF>(refDataContext143.ValueType___Expr143Get, refDataContext143.ValueType___Expr143Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 144)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext11_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[15] == null)) {
                    cachedCompiledDataContext[15] = new Activity1_TypedDataContext11_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext11_ForReadOnly valDataContext144 = ((Activity1_TypedDataContext11_ForReadOnly)(cachedCompiledDataContext[15]));
                return valDataContext144.ValueType___Expr144Get();
            }
            if ((expressionId == 145)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext11_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[15] == null)) {
                    cachedCompiledDataContext[15] = new Activity1_TypedDataContext11_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext11_ForReadOnly valDataContext145 = ((Activity1_TypedDataContext11_ForReadOnly)(cachedCompiledDataContext[15]));
                return valDataContext145.ValueType___Expr145Get();
            }
            if ((expressionId == 146)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext11.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new Activity1_TypedDataContext11(locations, activityContext, true);
                }
                Activity1_TypedDataContext11 refDataContext146 = ((Activity1_TypedDataContext11)(cachedCompiledDataContext[16]));
                return refDataContext146.GetLocation<string>(refDataContext146.ValueType___Expr146Get, refDataContext146.ValueType___Expr146Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 147)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext11_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[15] == null)) {
                    cachedCompiledDataContext[15] = new Activity1_TypedDataContext11_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext11_ForReadOnly valDataContext147 = ((Activity1_TypedDataContext11_ForReadOnly)(cachedCompiledDataContext[15]));
                return valDataContext147.ValueType___Expr147Get();
            }
            if ((expressionId == 148)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext11_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[15] == null)) {
                    cachedCompiledDataContext[15] = new Activity1_TypedDataContext11_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext11_ForReadOnly valDataContext148 = ((Activity1_TypedDataContext11_ForReadOnly)(cachedCompiledDataContext[15]));
                return valDataContext148.ValueType___Expr148Get();
            }
            if ((expressionId == 149)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext11_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[15] == null)) {
                    cachedCompiledDataContext[15] = new Activity1_TypedDataContext11_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext11_ForReadOnly valDataContext149 = ((Activity1_TypedDataContext11_ForReadOnly)(cachedCompiledDataContext[15]));
                return valDataContext149.ValueType___Expr149Get();
            }
            if ((expressionId == 150)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext11.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new Activity1_TypedDataContext11(locations, activityContext, true);
                }
                Activity1_TypedDataContext11 refDataContext150 = ((Activity1_TypedDataContext11)(cachedCompiledDataContext[16]));
                return refDataContext150.GetLocation<int>(refDataContext150.ValueType___Expr150Get, refDataContext150.ValueType___Expr150Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 151)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext11_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[15] == null)) {
                    cachedCompiledDataContext[15] = new Activity1_TypedDataContext11_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext11_ForReadOnly valDataContext151 = ((Activity1_TypedDataContext11_ForReadOnly)(cachedCompiledDataContext[15]));
                return valDataContext151.ValueType___Expr151Get();
            }
            if ((expressionId == 152)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext11_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[15] == null)) {
                    cachedCompiledDataContext[15] = new Activity1_TypedDataContext11_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext11_ForReadOnly valDataContext152 = ((Activity1_TypedDataContext11_ForReadOnly)(cachedCompiledDataContext[15]));
                return valDataContext152.ValueType___Expr152Get();
            }
            if ((expressionId == 153)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext11_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 17);
                if ((cachedCompiledDataContext[15] == null)) {
                    cachedCompiledDataContext[15] = new Activity1_TypedDataContext11_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext11_ForReadOnly valDataContext153 = ((Activity1_TypedDataContext11_ForReadOnly)(cachedCompiledDataContext[15]));
                return valDataContext153.ValueType___Expr153Get();
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
                Activity1_TypedDataContext3 refDataContext0 = new Activity1_TypedDataContext3(locations, true);
                return refDataContext0.GetLocation<int>(refDataContext0.ValueType___Expr0Get, refDataContext0.ValueType___Expr0Set);
            }
            if ((expressionId == 1)) {
                Activity1_TypedDataContext3_ForReadOnly valDataContext1 = new Activity1_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                Activity1_TypedDataContext3 refDataContext2 = new Activity1_TypedDataContext3(locations, true);
                return refDataContext2.GetLocation<System.Collections.Generic.List<string>>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set);
            }
            if ((expressionId == 3)) {
                Activity1_TypedDataContext3 refDataContext3 = new Activity1_TypedDataContext3(locations, true);
                return refDataContext3.GetLocation<int>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set);
            }
            if ((expressionId == 4)) {
                Activity1_TypedDataContext3 refDataContext4 = new Activity1_TypedDataContext3(locations, true);
                return refDataContext4.GetLocation<int>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set);
            }
            if ((expressionId == 5)) {
                Activity1_TypedDataContext3_ForReadOnly valDataContext5 = new Activity1_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                Activity1_TypedDataContext3 refDataContext6 = new Activity1_TypedDataContext3(locations, true);
                return refDataContext6.GetLocation<int[]>(refDataContext6.ValueType___Expr6Get, refDataContext6.ValueType___Expr6Set);
            }
            if ((expressionId == 7)) {
                Activity1_TypedDataContext3_ForReadOnly valDataContext7 = new Activity1_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                Activity1_TypedDataContext3 refDataContext8 = new Activity1_TypedDataContext3(locations, true);
                return refDataContext8.GetLocation<bool[]>(refDataContext8.ValueType___Expr8Get, refDataContext8.ValueType___Expr8Set);
            }
            if ((expressionId == 9)) {
                Activity1_TypedDataContext3_ForReadOnly valDataContext9 = new Activity1_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                Activity1_TypedDataContext3 refDataContext10 = new Activity1_TypedDataContext3(locations, true);
                return refDataContext10.GetLocation<System.Drawing.PointF>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set);
            }
            if ((expressionId == 11)) {
                Activity1_TypedDataContext3 refDataContext11 = new Activity1_TypedDataContext3(locations, true);
                return refDataContext11.GetLocation<int>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set);
            }
            if ((expressionId == 12)) {
                Activity1_TypedDataContext3 refDataContext12 = new Activity1_TypedDataContext3(locations, true);
                return refDataContext12.GetLocation<string>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set);
            }
            if ((expressionId == 13)) {
                Activity1_TypedDataContext3_ForReadOnly valDataContext13 = new Activity1_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                Activity1_TypedDataContext3_ForReadOnly valDataContext14 = new Activity1_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                Activity1_TypedDataContext4_ForReadOnly valDataContext15 = new Activity1_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                Activity1_TypedDataContext4_ForReadOnly valDataContext16 = new Activity1_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                Activity1_TypedDataContext4 refDataContext17 = new Activity1_TypedDataContext4(locations, true);
                return refDataContext17.GetLocation<string>(refDataContext17.ValueType___Expr17Get, refDataContext17.ValueType___Expr17Set);
            }
            if ((expressionId == 18)) {
                Activity1_TypedDataContext4_ForReadOnly valDataContext18 = new Activity1_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext18.ValueType___Expr18Get();
            }
            if ((expressionId == 19)) {
                Activity1_TypedDataContext4 refDataContext19 = new Activity1_TypedDataContext4(locations, true);
                return refDataContext19.GetLocation<System.Drawing.PointF>(refDataContext19.ValueType___Expr19Get, refDataContext19.ValueType___Expr19Set);
            }
            if ((expressionId == 20)) {
                Activity1_TypedDataContext4_ForReadOnly valDataContext20 = new Activity1_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                Activity1_TypedDataContext4_ForReadOnly valDataContext21 = new Activity1_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext21.ValueType___Expr21Get();
            }
            if ((expressionId == 22)) {
                Activity1_TypedDataContext4_ForReadOnly valDataContext22 = new Activity1_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                Activity1_TypedDataContext4 refDataContext23 = new Activity1_TypedDataContext4(locations, true);
                return refDataContext23.GetLocation<int>(refDataContext23.ValueType___Expr23Get, refDataContext23.ValueType___Expr23Set);
            }
            if ((expressionId == 24)) {
                Activity1_TypedDataContext4_ForReadOnly valDataContext24 = new Activity1_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext24.ValueType___Expr24Get();
            }
            if ((expressionId == 25)) {
                Activity1_TypedDataContext4 refDataContext25 = new Activity1_TypedDataContext4(locations, true);
                return refDataContext25.GetLocation<bool>(refDataContext25.ValueType___Expr25Get, refDataContext25.ValueType___Expr25Set);
            }
            if ((expressionId == 26)) {
                Activity1_TypedDataContext4 refDataContext26 = new Activity1_TypedDataContext4(locations, true);
                return refDataContext26.GetLocation<bool>(refDataContext26.ValueType___Expr26Get, refDataContext26.ValueType___Expr26Set);
            }
            if ((expressionId == 27)) {
                Activity1_TypedDataContext4_ForReadOnly valDataContext27 = new Activity1_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext27.ValueType___Expr27Get();
            }
            if ((expressionId == 28)) {
                Activity1_TypedDataContext4 refDataContext28 = new Activity1_TypedDataContext4(locations, true);
                return refDataContext28.GetLocation<int>(refDataContext28.ValueType___Expr28Get, refDataContext28.ValueType___Expr28Set);
            }
            if ((expressionId == 29)) {
                Activity1_TypedDataContext4_ForReadOnly valDataContext29 = new Activity1_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext29.ValueType___Expr29Get();
            }
            if ((expressionId == 30)) {
                Activity1_TypedDataContext4_ForReadOnly valDataContext30 = new Activity1_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext30.ValueType___Expr30Get();
            }
            if ((expressionId == 31)) {
                Activity1_TypedDataContext5_ForReadOnly valDataContext31 = new Activity1_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext31.ValueType___Expr31Get();
            }
            if ((expressionId == 32)) {
                Activity1_TypedDataContext5_ForReadOnly valDataContext32 = new Activity1_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext32.ValueType___Expr32Get();
            }
            if ((expressionId == 33)) {
                Activity1_TypedDataContext5 refDataContext33 = new Activity1_TypedDataContext5(locations, true);
                return refDataContext33.GetLocation<string>(refDataContext33.ValueType___Expr33Get, refDataContext33.ValueType___Expr33Set);
            }
            if ((expressionId == 34)) {
                Activity1_TypedDataContext5_ForReadOnly valDataContext34 = new Activity1_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext34.ValueType___Expr34Get();
            }
            if ((expressionId == 35)) {
                Activity1_TypedDataContext5 refDataContext35 = new Activity1_TypedDataContext5(locations, true);
                return refDataContext35.GetLocation<System.Drawing.PointF>(refDataContext35.ValueType___Expr35Get, refDataContext35.ValueType___Expr35Set);
            }
            if ((expressionId == 36)) {
                Activity1_TypedDataContext5_ForReadOnly valDataContext36 = new Activity1_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext36.ValueType___Expr36Get();
            }
            if ((expressionId == 37)) {
                Activity1_TypedDataContext5_ForReadOnly valDataContext37 = new Activity1_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext37.ValueType___Expr37Get();
            }
            if ((expressionId == 38)) {
                Activity1_TypedDataContext5_ForReadOnly valDataContext38 = new Activity1_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext38.ValueType___Expr38Get();
            }
            if ((expressionId == 39)) {
                Activity1_TypedDataContext5 refDataContext39 = new Activity1_TypedDataContext5(locations, true);
                return refDataContext39.GetLocation<int>(refDataContext39.ValueType___Expr39Get, refDataContext39.ValueType___Expr39Set);
            }
            if ((expressionId == 40)) {
                Activity1_TypedDataContext5_ForReadOnly valDataContext40 = new Activity1_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext40.ValueType___Expr40Get();
            }
            if ((expressionId == 41)) {
                Activity1_TypedDataContext5_ForReadOnly valDataContext41 = new Activity1_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext41.ValueType___Expr41Get();
            }
            if ((expressionId == 42)) {
                Activity1_TypedDataContext5_ForReadOnly valDataContext42 = new Activity1_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext42.ValueType___Expr42Get();
            }
            if ((expressionId == 43)) {
                Activity1_TypedDataContext5_ForReadOnly valDataContext43 = new Activity1_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext43.ValueType___Expr43Get();
            }
            if ((expressionId == 44)) {
                Activity1_TypedDataContext5 refDataContext44 = new Activity1_TypedDataContext5(locations, true);
                return refDataContext44.GetLocation<bool>(refDataContext44.ValueType___Expr44Get, refDataContext44.ValueType___Expr44Set);
            }
            if ((expressionId == 45)) {
                Activity1_TypedDataContext5_ForReadOnly valDataContext45 = new Activity1_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext45.ValueType___Expr45Get();
            }
            if ((expressionId == 46)) {
                Activity1_TypedDataContext5_ForReadOnly valDataContext46 = new Activity1_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext46.ValueType___Expr46Get();
            }
            if ((expressionId == 47)) {
                Activity1_TypedDataContext5_ForReadOnly valDataContext47 = new Activity1_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext47.ValueType___Expr47Get();
            }
            if ((expressionId == 48)) {
                Activity1_TypedDataContext5 refDataContext48 = new Activity1_TypedDataContext5(locations, true);
                return refDataContext48.GetLocation<bool>(refDataContext48.ValueType___Expr48Get, refDataContext48.ValueType___Expr48Set);
            }
            if ((expressionId == 49)) {
                Activity1_TypedDataContext6_ForReadOnly valDataContext49 = new Activity1_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext49.ValueType___Expr49Get();
            }
            if ((expressionId == 50)) {
                Activity1_TypedDataContext6_ForReadOnly valDataContext50 = new Activity1_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext50.ValueType___Expr50Get();
            }
            if ((expressionId == 51)) {
                Activity1_TypedDataContext6 refDataContext51 = new Activity1_TypedDataContext6(locations, true);
                return refDataContext51.GetLocation<string>(refDataContext51.ValueType___Expr51Get, refDataContext51.ValueType___Expr51Set);
            }
            if ((expressionId == 52)) {
                Activity1_TypedDataContext6_ForReadOnly valDataContext52 = new Activity1_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext52.ValueType___Expr52Get();
            }
            if ((expressionId == 53)) {
                Activity1_TypedDataContext6 refDataContext53 = new Activity1_TypedDataContext6(locations, true);
                return refDataContext53.GetLocation<System.Drawing.PointF>(refDataContext53.ValueType___Expr53Get, refDataContext53.ValueType___Expr53Set);
            }
            if ((expressionId == 54)) {
                Activity1_TypedDataContext6_ForReadOnly valDataContext54 = new Activity1_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext54.ValueType___Expr54Get();
            }
            if ((expressionId == 55)) {
                Activity1_TypedDataContext6_ForReadOnly valDataContext55 = new Activity1_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext55.ValueType___Expr55Get();
            }
            if ((expressionId == 56)) {
                Activity1_TypedDataContext6_ForReadOnly valDataContext56 = new Activity1_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext56.ValueType___Expr56Get();
            }
            if ((expressionId == 57)) {
                Activity1_TypedDataContext6_ForReadOnly valDataContext57 = new Activity1_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext57.ValueType___Expr57Get();
            }
            if ((expressionId == 58)) {
                Activity1_TypedDataContext6_ForReadOnly valDataContext58 = new Activity1_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext58.ValueType___Expr58Get();
            }
            if ((expressionId == 59)) {
                Activity1_TypedDataContext6_ForReadOnly valDataContext59 = new Activity1_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext59.ValueType___Expr59Get();
            }
            if ((expressionId == 60)) {
                Activity1_TypedDataContext6_ForReadOnly valDataContext60 = new Activity1_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext60.ValueType___Expr60Get();
            }
            if ((expressionId == 61)) {
                Activity1_TypedDataContext6_ForReadOnly valDataContext61 = new Activity1_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext61.ValueType___Expr61Get();
            }
            if ((expressionId == 62)) {
                Activity1_TypedDataContext6 refDataContext62 = new Activity1_TypedDataContext6(locations, true);
                return refDataContext62.GetLocation<int>(refDataContext62.ValueType___Expr62Get, refDataContext62.ValueType___Expr62Set);
            }
            if ((expressionId == 63)) {
                Activity1_TypedDataContext6_ForReadOnly valDataContext63 = new Activity1_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext63.ValueType___Expr63Get();
            }
            if ((expressionId == 64)) {
                Activity1_TypedDataContext6_ForReadOnly valDataContext64 = new Activity1_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext64.ValueType___Expr64Get();
            }
            if ((expressionId == 65)) {
                Activity1_TypedDataContext6_ForReadOnly valDataContext65 = new Activity1_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext65.ValueType___Expr65Get();
            }
            if ((expressionId == 66)) {
                Activity1_TypedDataContext6_ForReadOnly valDataContext66 = new Activity1_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext66.ValueType___Expr66Get();
            }
            if ((expressionId == 67)) {
                Activity1_TypedDataContext6_ForReadOnly valDataContext67 = new Activity1_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext67.ValueType___Expr67Get();
            }
            if ((expressionId == 68)) {
                Activity1_TypedDataContext6_ForReadOnly valDataContext68 = new Activity1_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext68.ValueType___Expr68Get();
            }
            if ((expressionId == 69)) {
                Activity1_TypedDataContext6_ForReadOnly valDataContext69 = new Activity1_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext69.ValueType___Expr69Get();
            }
            if ((expressionId == 70)) {
                Activity1_TypedDataContext6_ForReadOnly valDataContext70 = new Activity1_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext70.ValueType___Expr70Get();
            }
            if ((expressionId == 71)) {
                Activity1_TypedDataContext6_ForReadOnly valDataContext71 = new Activity1_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext71.ValueType___Expr71Get();
            }
            if ((expressionId == 72)) {
                Activity1_TypedDataContext6_ForReadOnly valDataContext72 = new Activity1_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext72.ValueType___Expr72Get();
            }
            if ((expressionId == 73)) {
                Activity1_TypedDataContext6 refDataContext73 = new Activity1_TypedDataContext6(locations, true);
                return refDataContext73.GetLocation<int>(refDataContext73.ValueType___Expr73Get, refDataContext73.ValueType___Expr73Set);
            }
            if ((expressionId == 74)) {
                Activity1_TypedDataContext6_ForReadOnly valDataContext74 = new Activity1_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext74.ValueType___Expr74Get();
            }
            if ((expressionId == 75)) {
                Activity1_TypedDataContext6_ForReadOnly valDataContext75 = new Activity1_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext75.ValueType___Expr75Get();
            }
            if ((expressionId == 76)) {
                Activity1_TypedDataContext6_ForReadOnly valDataContext76 = new Activity1_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext76.ValueType___Expr76Get();
            }
            if ((expressionId == 77)) {
                Activity1_TypedDataContext6_ForReadOnly valDataContext77 = new Activity1_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext77.ValueType___Expr77Get();
            }
            if ((expressionId == 78)) {
                Activity1_TypedDataContext6 refDataContext78 = new Activity1_TypedDataContext6(locations, true);
                return refDataContext78.GetLocation<int>(refDataContext78.ValueType___Expr78Get, refDataContext78.ValueType___Expr78Set);
            }
            if ((expressionId == 79)) {
                Activity1_TypedDataContext6 refDataContext79 = new Activity1_TypedDataContext6(locations, true);
                return refDataContext79.GetLocation<int>(refDataContext79.ValueType___Expr79Get, refDataContext79.ValueType___Expr79Set);
            }
            if ((expressionId == 80)) {
                Activity1_TypedDataContext6_ForReadOnly valDataContext80 = new Activity1_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext80.ValueType___Expr80Get();
            }
            if ((expressionId == 81)) {
                Activity1_TypedDataContext6_ForReadOnly valDataContext81 = new Activity1_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext81.ValueType___Expr81Get();
            }
            if ((expressionId == 82)) {
                Activity1_TypedDataContext6_ForReadOnly valDataContext82 = new Activity1_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext82.ValueType___Expr82Get();
            }
            if ((expressionId == 83)) {
                Activity1_TypedDataContext6_ForReadOnly valDataContext83 = new Activity1_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext83.ValueType___Expr83Get();
            }
            if ((expressionId == 84)) {
                Activity1_TypedDataContext7_ForReadOnly valDataContext84 = new Activity1_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext84.ValueType___Expr84Get();
            }
            if ((expressionId == 85)) {
                Activity1_TypedDataContext7_ForReadOnly valDataContext85 = new Activity1_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext85.ValueType___Expr85Get();
            }
            if ((expressionId == 86)) {
                Activity1_TypedDataContext7 refDataContext86 = new Activity1_TypedDataContext7(locations, true);
                return refDataContext86.GetLocation<string>(refDataContext86.ValueType___Expr86Get, refDataContext86.ValueType___Expr86Set);
            }
            if ((expressionId == 87)) {
                Activity1_TypedDataContext7_ForReadOnly valDataContext87 = new Activity1_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext87.ValueType___Expr87Get();
            }
            if ((expressionId == 88)) {
                Activity1_TypedDataContext7_ForReadOnly valDataContext88 = new Activity1_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext88.ValueType___Expr88Get();
            }
            if ((expressionId == 89)) {
                Activity1_TypedDataContext7_ForReadOnly valDataContext89 = new Activity1_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext89.ValueType___Expr89Get();
            }
            if ((expressionId == 90)) {
                Activity1_TypedDataContext7_ForReadOnly valDataContext90 = new Activity1_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext90.ValueType___Expr90Get();
            }
            if ((expressionId == 91)) {
                Activity1_TypedDataContext7_ForReadOnly valDataContext91 = new Activity1_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext91.ValueType___Expr91Get();
            }
            if ((expressionId == 92)) {
                Activity1_TypedDataContext7 refDataContext92 = new Activity1_TypedDataContext7(locations, true);
                return refDataContext92.GetLocation<int>(refDataContext92.ValueType___Expr92Get, refDataContext92.ValueType___Expr92Set);
            }
            if ((expressionId == 93)) {
                Activity1_TypedDataContext7_ForReadOnly valDataContext93 = new Activity1_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext93.ValueType___Expr93Get();
            }
            if ((expressionId == 94)) {
                Activity1_TypedDataContext7_ForReadOnly valDataContext94 = new Activity1_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext94.ValueType___Expr94Get();
            }
            if ((expressionId == 95)) {
                Activity1_TypedDataContext7 refDataContext95 = new Activity1_TypedDataContext7(locations, true);
                return refDataContext95.GetLocation<int>(refDataContext95.ValueType___Expr95Get, refDataContext95.ValueType___Expr95Set);
            }
            if ((expressionId == 96)) {
                Activity1_TypedDataContext7_ForReadOnly valDataContext96 = new Activity1_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext96.ValueType___Expr96Get();
            }
            if ((expressionId == 97)) {
                Activity1_TypedDataContext7 refDataContext97 = new Activity1_TypedDataContext7(locations, true);
                return refDataContext97.GetLocation<int>(refDataContext97.ValueType___Expr97Get, refDataContext97.ValueType___Expr97Set);
            }
            if ((expressionId == 98)) {
                Activity1_TypedDataContext7_ForReadOnly valDataContext98 = new Activity1_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext98.ValueType___Expr98Get();
            }
            if ((expressionId == 99)) {
                Activity1_TypedDataContext8_ForReadOnly valDataContext99 = new Activity1_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext99.ValueType___Expr99Get();
            }
            if ((expressionId == 100)) {
                Activity1_TypedDataContext8_ForReadOnly valDataContext100 = new Activity1_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext100.ValueType___Expr100Get();
            }
            if ((expressionId == 101)) {
                Activity1_TypedDataContext8_ForReadOnly valDataContext101 = new Activity1_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext101.ValueType___Expr101Get();
            }
            if ((expressionId == 102)) {
                Activity1_TypedDataContext8_ForReadOnly valDataContext102 = new Activity1_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext102.ValueType___Expr102Get();
            }
            if ((expressionId == 103)) {
                Activity1_TypedDataContext9_ForReadOnly valDataContext103 = new Activity1_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext103.ValueType___Expr103Get();
            }
            if ((expressionId == 104)) {
                Activity1_TypedDataContext9_ForReadOnly valDataContext104 = new Activity1_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext104.ValueType___Expr104Get();
            }
            if ((expressionId == 105)) {
                Activity1_TypedDataContext9_ForReadOnly valDataContext105 = new Activity1_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext105.ValueType___Expr105Get();
            }
            if ((expressionId == 106)) {
                Activity1_TypedDataContext9_ForReadOnly valDataContext106 = new Activity1_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext106.ValueType___Expr106Get();
            }
            if ((expressionId == 107)) {
                Activity1_TypedDataContext9_ForReadOnly valDataContext107 = new Activity1_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext107.ValueType___Expr107Get();
            }
            if ((expressionId == 108)) {
                Activity1_TypedDataContext9_ForReadOnly valDataContext108 = new Activity1_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext108.ValueType___Expr108Get();
            }
            if ((expressionId == 109)) {
                Activity1_TypedDataContext9_ForReadOnly valDataContext109 = new Activity1_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext109.ValueType___Expr109Get();
            }
            if ((expressionId == 110)) {
                Activity1_TypedDataContext9_ForReadOnly valDataContext110 = new Activity1_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext110.ValueType___Expr110Get();
            }
            if ((expressionId == 111)) {
                Activity1_TypedDataContext9_ForReadOnly valDataContext111 = new Activity1_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext111.ValueType___Expr111Get();
            }
            if ((expressionId == 112)) {
                Activity1_TypedDataContext9_ForReadOnly valDataContext112 = new Activity1_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext112.ValueType___Expr112Get();
            }
            if ((expressionId == 113)) {
                Activity1_TypedDataContext9_ForReadOnly valDataContext113 = new Activity1_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext113.ValueType___Expr113Get();
            }
            if ((expressionId == 114)) {
                Activity1_TypedDataContext9_ForReadOnly valDataContext114 = new Activity1_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext114.ValueType___Expr114Get();
            }
            if ((expressionId == 115)) {
                Activity1_TypedDataContext9_ForReadOnly valDataContext115 = new Activity1_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext115.ValueType___Expr115Get();
            }
            if ((expressionId == 116)) {
                Activity1_TypedDataContext9_ForReadOnly valDataContext116 = new Activity1_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext116.ValueType___Expr116Get();
            }
            if ((expressionId == 117)) {
                Activity1_TypedDataContext9_ForReadOnly valDataContext117 = new Activity1_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext117.ValueType___Expr117Get();
            }
            if ((expressionId == 118)) {
                Activity1_TypedDataContext9_ForReadOnly valDataContext118 = new Activity1_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext118.ValueType___Expr118Get();
            }
            if ((expressionId == 119)) {
                Activity1_TypedDataContext9_ForReadOnly valDataContext119 = new Activity1_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext119.ValueType___Expr119Get();
            }
            if ((expressionId == 120)) {
                Activity1_TypedDataContext9_ForReadOnly valDataContext120 = new Activity1_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext120.ValueType___Expr120Get();
            }
            if ((expressionId == 121)) {
                Activity1_TypedDataContext9_ForReadOnly valDataContext121 = new Activity1_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext121.ValueType___Expr121Get();
            }
            if ((expressionId == 122)) {
                Activity1_TypedDataContext9 refDataContext122 = new Activity1_TypedDataContext9(locations, true);
                return refDataContext122.GetLocation<string>(refDataContext122.ValueType___Expr122Get, refDataContext122.ValueType___Expr122Set);
            }
            if ((expressionId == 123)) {
                Activity1_TypedDataContext9_ForReadOnly valDataContext123 = new Activity1_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext123.ValueType___Expr123Get();
            }
            if ((expressionId == 124)) {
                Activity1_TypedDataContext9 refDataContext124 = new Activity1_TypedDataContext9(locations, true);
                return refDataContext124.GetLocation<System.Drawing.PointF>(refDataContext124.ValueType___Expr124Get, refDataContext124.ValueType___Expr124Set);
            }
            if ((expressionId == 125)) {
                Activity1_TypedDataContext9_ForReadOnly valDataContext125 = new Activity1_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext125.ValueType___Expr125Get();
            }
            if ((expressionId == 126)) {
                Activity1_TypedDataContext9_ForReadOnly valDataContext126 = new Activity1_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext126.ValueType___Expr126Get();
            }
            if ((expressionId == 127)) {
                Activity1_TypedDataContext10_ForReadOnly valDataContext127 = new Activity1_TypedDataContext10_ForReadOnly(locations, true);
                return valDataContext127.ValueType___Expr127Get();
            }
            if ((expressionId == 128)) {
                Activity1_TypedDataContext10_ForReadOnly valDataContext128 = new Activity1_TypedDataContext10_ForReadOnly(locations, true);
                return valDataContext128.ValueType___Expr128Get();
            }
            if ((expressionId == 129)) {
                Activity1_TypedDataContext10 refDataContext129 = new Activity1_TypedDataContext10(locations, true);
                return refDataContext129.GetLocation<string>(refDataContext129.ValueType___Expr129Get, refDataContext129.ValueType___Expr129Set);
            }
            if ((expressionId == 130)) {
                Activity1_TypedDataContext10_ForReadOnly valDataContext130 = new Activity1_TypedDataContext10_ForReadOnly(locations, true);
                return valDataContext130.ValueType___Expr130Get();
            }
            if ((expressionId == 131)) {
                Activity1_TypedDataContext10_ForReadOnly valDataContext131 = new Activity1_TypedDataContext10_ForReadOnly(locations, true);
                return valDataContext131.ValueType___Expr131Get();
            }
            if ((expressionId == 132)) {
                Activity1_TypedDataContext10_ForReadOnly valDataContext132 = new Activity1_TypedDataContext10_ForReadOnly(locations, true);
                return valDataContext132.ValueType___Expr132Get();
            }
            if ((expressionId == 133)) {
                Activity1_TypedDataContext10_ForReadOnly valDataContext133 = new Activity1_TypedDataContext10_ForReadOnly(locations, true);
                return valDataContext133.ValueType___Expr133Get();
            }
            if ((expressionId == 134)) {
                Activity1_TypedDataContext10_ForReadOnly valDataContext134 = new Activity1_TypedDataContext10_ForReadOnly(locations, true);
                return valDataContext134.ValueType___Expr134Get();
            }
            if ((expressionId == 135)) {
                Activity1_TypedDataContext10 refDataContext135 = new Activity1_TypedDataContext10(locations, true);
                return refDataContext135.GetLocation<int>(refDataContext135.ValueType___Expr135Get, refDataContext135.ValueType___Expr135Set);
            }
            if ((expressionId == 136)) {
                Activity1_TypedDataContext10_ForReadOnly valDataContext136 = new Activity1_TypedDataContext10_ForReadOnly(locations, true);
                return valDataContext136.ValueType___Expr136Get();
            }
            if ((expressionId == 137)) {
                Activity1_TypedDataContext10_ForReadOnly valDataContext137 = new Activity1_TypedDataContext10_ForReadOnly(locations, true);
                return valDataContext137.ValueType___Expr137Get();
            }
            if ((expressionId == 138)) {
                Activity1_TypedDataContext10_ForReadOnly valDataContext138 = new Activity1_TypedDataContext10_ForReadOnly(locations, true);
                return valDataContext138.ValueType___Expr138Get();
            }
            if ((expressionId == 139)) {
                Activity1_TypedDataContext10_ForReadOnly valDataContext139 = new Activity1_TypedDataContext10_ForReadOnly(locations, true);
                return valDataContext139.ValueType___Expr139Get();
            }
            if ((expressionId == 140)) {
                Activity1_TypedDataContext10_ForReadOnly valDataContext140 = new Activity1_TypedDataContext10_ForReadOnly(locations, true);
                return valDataContext140.ValueType___Expr140Get();
            }
            if ((expressionId == 141)) {
                Activity1_TypedDataContext10_ForReadOnly valDataContext141 = new Activity1_TypedDataContext10_ForReadOnly(locations, true);
                return valDataContext141.ValueType___Expr141Get();
            }
            if ((expressionId == 142)) {
                Activity1_TypedDataContext10_ForReadOnly valDataContext142 = new Activity1_TypedDataContext10_ForReadOnly(locations, true);
                return valDataContext142.ValueType___Expr142Get();
            }
            if ((expressionId == 143)) {
                Activity1_TypedDataContext10 refDataContext143 = new Activity1_TypedDataContext10(locations, true);
                return refDataContext143.GetLocation<System.Drawing.PointF>(refDataContext143.ValueType___Expr143Get, refDataContext143.ValueType___Expr143Set);
            }
            if ((expressionId == 144)) {
                Activity1_TypedDataContext11_ForReadOnly valDataContext144 = new Activity1_TypedDataContext11_ForReadOnly(locations, true);
                return valDataContext144.ValueType___Expr144Get();
            }
            if ((expressionId == 145)) {
                Activity1_TypedDataContext11_ForReadOnly valDataContext145 = new Activity1_TypedDataContext11_ForReadOnly(locations, true);
                return valDataContext145.ValueType___Expr145Get();
            }
            if ((expressionId == 146)) {
                Activity1_TypedDataContext11 refDataContext146 = new Activity1_TypedDataContext11(locations, true);
                return refDataContext146.GetLocation<string>(refDataContext146.ValueType___Expr146Get, refDataContext146.ValueType___Expr146Set);
            }
            if ((expressionId == 147)) {
                Activity1_TypedDataContext11_ForReadOnly valDataContext147 = new Activity1_TypedDataContext11_ForReadOnly(locations, true);
                return valDataContext147.ValueType___Expr147Get();
            }
            if ((expressionId == 148)) {
                Activity1_TypedDataContext11_ForReadOnly valDataContext148 = new Activity1_TypedDataContext11_ForReadOnly(locations, true);
                return valDataContext148.ValueType___Expr148Get();
            }
            if ((expressionId == 149)) {
                Activity1_TypedDataContext11_ForReadOnly valDataContext149 = new Activity1_TypedDataContext11_ForReadOnly(locations, true);
                return valDataContext149.ValueType___Expr149Get();
            }
            if ((expressionId == 150)) {
                Activity1_TypedDataContext11 refDataContext150 = new Activity1_TypedDataContext11(locations, true);
                return refDataContext150.GetLocation<int>(refDataContext150.ValueType___Expr150Get, refDataContext150.ValueType___Expr150Set);
            }
            if ((expressionId == 151)) {
                Activity1_TypedDataContext11_ForReadOnly valDataContext151 = new Activity1_TypedDataContext11_ForReadOnly(locations, true);
                return valDataContext151.ValueType___Expr151Get();
            }
            if ((expressionId == 152)) {
                Activity1_TypedDataContext11_ForReadOnly valDataContext152 = new Activity1_TypedDataContext11_ForReadOnly(locations, true);
                return valDataContext152.ValueType___Expr152Get();
            }
            if ((expressionId == 153)) {
                Activity1_TypedDataContext11_ForReadOnly valDataContext153 = new Activity1_TypedDataContext11_ForReadOnly(locations, true);
                return valDataContext153.ValueType___Expr153Get();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == true) 
                        && ((expressionText == "Cercania") 
                        && (Activity1_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new List<string>();") 
                        && (Activity1_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Archivo") 
                        && (Activity1_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "NroPrueba") 
                        && (Activity1_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IBanderaPar") 
                        && (Activity1_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new int[2]") 
                        && (Activity1_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "BanderasExperimento") 
                        && (Activity1_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new bool[2]") 
                        && (Activity1_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "BanderasVisibles") 
                        && (Activity1_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new PointF(0,0)") 
                        && (Activity1_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Cruz") 
                        && (Activity1_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "idNueva") 
                        && (Activity1_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "RtaCave") 
                        && (Activity1_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Agregar180") 
                        && (Activity1_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"L{ \\\"id\\\":\\\"\"+Escenario+\"\\\" }\"") 
                        && (Activity1_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Archivo") 
                        && (Activity1_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 15;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DateTime.Now.ToString()+\";\"+Coordenadas.X+\";\"+Coordenadas.Y+\";NULL;NULL;NULL;DET\"" +
                            "") 
                        && (Activity1_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 16;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "RtaCave") 
                        && (Activity1_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 17;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new PointF(Single.Parse(RtaCave.Split(\';\')[0].Replace(\".\", \",\")), Single.Parse(Rt" +
                            "aCave.Split(\';\')[1].Replace(\".\", \",\")))") 
                        && (Activity1_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 18;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Coordenadas") 
                        && (Activity1_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 19;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(IBanderaPar<2)&&(Angulo.Length > NroPrueba)") 
                        && (Activity1_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 20;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "IBanderaPar==0") 
                        && (Activity1_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 21;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new Random().Next(0, BanderasCircunferencia.Count-1)") 
                        && (Activity1_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 22;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "BanderasExperimento[0]") 
                        && (Activity1_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 23;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(BanderasCircunferencia.Count - 1).ToString()") 
                        && (Activity1_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 24;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "BanderasVisibles[0]") 
                        && (Activity1_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 25;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "BanderasVisibles[1]") 
                        && (Activity1_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 26;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(BanderasExperimento[0] + (int)(Angulo[NroPrueba] / Separacion)) % BanderasCircun" +
                            "ferencia.Count") 
                        && (Activity1_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 27;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "BanderasExperimento[1]") 
                        && (Activity1_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 28;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"H{ \\\"id\\\":\\\"\" + (int)(BanderasExperimento[0]) + \"\\\", \\\"visible\\\":\\\"true\\\" }\"") 
                        && (Activity1_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 29;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"H{ \\\"id\\\":\\\"\" + (int)(BanderasExperimento[1]) + \"\\\", \\\"visible\\\":\\\"true\\\" }\"") 
                        && (Activity1_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 30;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Archivo") 
                        && (Activity1_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 31;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DateTime.Now.ToString()+\";\"+Coordenadas.X+\";\"+Coordenadas.Y+\";\"+\"NULL;NULL;NULL;B" +
                            "US\"") 
                        && (Activity1_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 32;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "RtaCave") 
                        && (Activity1_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 33;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new PointF(Single.Parse(RtaCave.Split(\';\')[0].Replace(\".\", \",\")), Single.Parse(Rt" +
                            "aCave.Split(\';\')[1].Replace(\".\", \",\")))") 
                        && (Activity1_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 34;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Coordenadas") 
                        && (Activity1_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 35;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == @"!((((Math.Pow(BanderasCircunferencia[BanderasExperimento[0]].X - Coordenadas.X, 2) + Math.Pow(BanderasCircunferencia[BanderasExperimento[0]].Y - Coordenadas.Y, 2)) < Cercania) && (BanderasVisibles[0])) || (((Math.Pow(BanderasCircunferencia[BanderasExperimento[1]].X - Coordenadas.X, 2) + Math.Pow(BanderasCircunferencia[BanderasExperimento[1]].Y - Coordenadas.Y, 2)) < Cercania) && (BanderasVisibles[1])))") 
                        && (Activity1_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 36;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == @"(((Math.Pow(BanderasCircunferencia[BanderasExperimento[0]].X - Coordenadas.X, 2) + Math.Pow(BanderasCircunferencia[BanderasExperimento[0]].Y - Coordenadas.Y, 2)) < Cercania) && (BanderasVisibles[0])) || (((Math.Pow(BanderasCircunferencia[BanderasExperimento[1]].X - Coordenadas.X, 2) + Math.Pow(BanderasCircunferencia[BanderasExperimento[1]].Y - Coordenadas.Y, 2)) < Cercania) && (BanderasVisibles[1]))") 
                        && (Activity1_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 37;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "IBanderaPar+1") 
                        && (Activity1_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 38;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IBanderaPar") 
                        && (Activity1_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 39;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(((Math.Pow(BanderasCircunferencia[BanderasExperimento[0]].X - Coordenadas.X, 2) " +
                            "+ Math.Pow(BanderasCircunferencia[BanderasExperimento[0]].Y - Coordenadas.Y, 2))" +
                            " < Cercania) && (BanderasVisibles[0]))") 
                        && (Activity1_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 40;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"H{ \\\"id\\\":\\\"\" + (int)(BanderasExperimento[0]) + \"\\\", \\\"visible\\\":\\\"false\\\" }\"") 
                        && (Activity1_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 41;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Archivo") 
                        && (Activity1_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 42;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DateTime.Now.ToString() + \";\" + Coordenadas.X + \";\" + Coordenadas.Y + \";\" + Bande" +
                            "rasCircunferencia[BanderasExperimento[0]].X + \";\" + BanderasCircunferencia[Bande" +
                            "rasExperimento[0]].Y + \";\" + BanderasExperimento[0]+\";CAP\"") 
                        && (Activity1_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 43;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "BanderasVisibles[0]") 
                        && (Activity1_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 44;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"H{ \\\"id\\\":\\\"\" + (int)(BanderasExperimento[1]) + \"\\\", \\\"visible\\\":\\\"false\\\" }\"") 
                        && (Activity1_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 45;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Archivo") 
                        && (Activity1_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 46;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DateTime.Now.ToString() + \";\" + Coordenadas.X + \";\" + Coordenadas.Y + \";\" + Bande" +
                            "rasCircunferencia[BanderasExperimento[1]].X + \";\" + BanderasCircunferencia[Bande" +
                            "rasExperimento[1]].Y + \";\" + BanderasExperimento[1]+\";CAP\"") 
                        && (Activity1_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 47;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "BanderasVisibles[1]") 
                        && (Activity1_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 48;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Archivo") 
                        && (Activity1_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 49;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DateTime.Now.ToString()+\";\"+Coordenadas.X+\";\"+Coordenadas.Y+\";\"+\"NULL;NULL;NULL;C" +
                            "EN\"") 
                        && (Activity1_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 50;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "RtaCave") 
                        && (Activity1_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 51;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new PointF(Single.Parse(RtaCave.Split(\';\')[0].Replace(\".\", \",\")), Single.Parse(Rt" +
                            "aCave.Split(\';\')[1].Replace(\".\", \",\")))") 
                        && (Activity1_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 52;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Coordenadas") 
                        && (Activity1_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 53;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "!((Math.Pow(Coordenadas.X-Cruz.X, 2) + Math.Pow(Coordenadas.Y-Cruz.Y, 2)) < Cerca" +
                            "nia)") 
                        && (Activity1_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 54;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "((Math.Pow(Coordenadas.X - Cruz.X, 2) + Math.Pow(Coordenadas.Y - Cruz.Y, 2)) < Ce" +
                            "rcania) && (NroPrueba < Angulo.Length) && (IBanderaPar < 2)") 
                        && (Activity1_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 55;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"X{ \\\"value\\\":\\\"rojo\\\" }\"") 
                        && (Activity1_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 56;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TimeSpan.FromSeconds(2);") 
                        && (Activity1_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 57;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"X{ \\\"value\\\":\\\"negro\\\" }\"") 
                        && (Activity1_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 58;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "((Math.Pow(Coordenadas.X-Cruz.X, 2) + Math.Pow(Coordenadas.Y-Cruz.Y, 2)) < Cercan" +
                            "ia) && (TestMemoria.Equals(\"N\")) && (IBanderaPar==2)") 
                        && (Activity1_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 59;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "((Math.Pow(Coordenadas.X-Cruz.X, 2) + Math.Pow(Coordenadas.Y-Cruz.Y, 2)) < Cercan" +
                            "ia)&&(IBanderaPar == 2) && (Angulo.Length > NroPrueba) && (NroProtocolo!=3)") 
                        && (Activity1_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 60;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "NroProtocolo.Equals(2)") 
                        && (Activity1_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 61;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Cursor") 
                        && (Activity1_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 62;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Q{ \\\"text\\\":\\\"Escucha la consigna\\\" }\"") 
                        && (Activity1_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 63;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TimeSpan.FromSeconds(4)") 
                        && (Activity1_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 64;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Q{ \\\"text\\\":\\\" \\\" }\"") 
                        && (Activity1_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 65;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Mostrar180") 
                        && (Activity1_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 66;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Q{ \\\"text\\\":\\\"Esta la bandera en una nueva posicion?\\\" }\"") 
                        && (Activity1_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 67;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Protocolo_P1[NroPrueba]==1") 
                        && (Activity1_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 68;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Archivo") 
                        && (Activity1_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 69;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DateTime.Now.ToString() + \";\" + Coordenadas.X + \";\" + Coordenadas.Y + \";\" + Bande" +
                            "rasCircunferencia[BanderasExperimento[0]].X + \";\" + BanderasCircunferencia[Bande" +
                            "rasExperimento[0]].Y + \";\" + BanderasExperimento[0] + \";MOS\"") 
                        && (Activity1_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 70;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"H{ \\\"id\\\":\\\"\" + (int)(BanderasExperimento[0]) + \"\\\", \\\"visible\\\":\\\"true\\\" }\"") 
                        && (Activity1_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 71;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Abs(BanderasExperimento[0] + BanderasExperimento[1]) / 2") 
                        && (Activity1_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 72;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "medio") 
                        && (Activity1_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 73;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Archivo") 
                        && (Activity1_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 74;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DateTime.Now.ToString() + \";\" + Coordenadas.X + \";\" + Coordenadas.Y + \";\" + Bande" +
                            "rasCircunferencia[medio].X + \";\" + BanderasCircunferencia[medio].Y + \";\" + medio" +
                            "+ \";MOS\"") 
                        && (Activity1_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 75;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"H{ \\\"id\\\":\\\"\" + (int)(medio) + \"\\\", \\\"visible\\\":\\\"true\\\" }\"") 
                        && (Activity1_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 76;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "NroPrueba+1") 
                        && (Activity1_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 77;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "NroPrueba") 
                        && (Activity1_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 78;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IBanderaPar") 
                        && (Activity1_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 79;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "((Math.Pow(Coordenadas.X - Cruz.X, 2) + Math.Pow(Coordenadas.Y - Cruz.Y, 2)) < Ce" +
                            "rcania) && (IBanderaPar == 2) && (Angulo.Length > NroPrueba) && (NroProtocolo.Eq" +
                            "uals(3))") 
                        && (Activity1_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 80;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Q{ \\\"text\\\":\\\"Coloca la bandera\\\" }\"") 
                        && (Activity1_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 81;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TimeSpan.FromSeconds(4)") 
                        && (Activity1_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 82;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Q{ \\\"text\\\":\\\" \\\" }\"") 
                        && (Activity1_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 83;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "NroProtocolo.Equals(2)") 
                        && (Activity1_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 84;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"C{ \\\"id\\\":\\\"\" + (int)(Cursor) + \"\\\", \\\"color\\\":\\\"\" + ColorSeleccion + \"\\\" }\"") 
                        && (Activity1_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 85;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "RtaCave") 
                        && (Activity1_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 86;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(RtaCave.Equals(\"1\") && (NroProtocolo == 2)) || RtaCave.Equals(\"3\")") 
                        && (Activity1_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 87;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "NroProtocolo==2") 
                        && (Activity1_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 88;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"C{ \\\"id\\\":\\\"\" + (int)(Cursor) + \"\\\", \\\"color\\\":\\\"\" + ColorBandera + \"\\\" }\"") 
                        && (Activity1_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 89;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RtaCave.Equals(\"1\")") 
                        && (Activity1_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 90;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Cursor - 1) % BanderasCircunferencia.Count") 
                        && (Activity1_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 91;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Cursor") 
                        && (Activity1_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 92;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Cursor<0") 
                        && (Activity1_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 93;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "BanderasCircunferencia.Count-1") 
                        && (Activity1_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 94;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Cursor") 
                        && (Activity1_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 95;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Cursor + 1) % BanderasCircunferencia.Count") 
                        && (Activity1_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 96;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Cursor") 
                        && (Activity1_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 97;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(RtaCave.Equals(\"2\") || ((RtaCave.Equals(\"1\") && NroProtocolo == 1)))") 
                        && (Activity1_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 98;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Q{ \\\"text\\\":\\\"Fin del experimento\\\" }\"") 
                        && (Activity1_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 99;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Archivo") 
                        && (Activity1_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 100;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DateTime.Now.ToString()+\";\"+Coordenadas.X+\";\"+Coordenadas.Y+\";\"+\"NULL;NULL;NULL;F" +
                            "IN\"") 
                        && (Activity1_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 101;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TimeSpan.FromSeconds(5)") 
                        && (Activity1_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 102;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "NroProtocolo.Equals(1)") 
                        && (Activity1_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 103;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Protocolo_P1[NroPrueba-1]==1") 
                        && (Activity1_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 104;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"H{ \\\"id\\\":\\\"\" + (int)(BanderasExperimento[0]) + \"\\\", \\\"visible\\\":\\\"false\\\" }\"") 
                        && (Activity1_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 105;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RtaCave.Equals(\"1\")") 
                        && (Activity1_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 106;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Archivo") 
                        && (Activity1_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 107;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DateTime.Now.ToString() + \";\" + Coordenadas.X + \";\" + Coordenadas.Y + \";NULL;NULL" +
                            ";NO;SEL\"") 
                        && (Activity1_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 108;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Archivo") 
                        && (Activity1_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 109;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DateTime.Now.ToString()+\";\"+Coordenadas.X+\";\"+Coordenadas.Y+\";NULL;NULL;OK;SEL\"") 
                        && (Activity1_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 110;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"H{ \\\"id\\\":\\\"\" + (int)(medio) + \"\\\", \\\"visible\\\":\\\"false\\\" }\"") 
                        && (Activity1_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 111;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RtaCave.Equals(\"2\")") 
                        && (Activity1_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 112;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Archivo") 
                        && (Activity1_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 113;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DateTime.Now.ToString()+\";\"+Coordenadas.X+\";\"+Coordenadas.Y+\";NULL;NULL;OK;SEL\"") 
                        && (Activity1_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 114;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Archivo") 
                        && (Activity1_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 115;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DateTime.Now.ToString()+\";\"+Coordenadas.X+\";\"+Coordenadas.Y+\";NULL;NULL;NO;SEL\"") 
                        && (Activity1_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 116;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "NroProtocolo.Equals(2)") 
                        && (Activity1_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 117;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Archivo") 
                        && (Activity1_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 118;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DateTime.Now.ToString() + \";\" + Coordenadas.X + \";\" + Coordenadas.Y + \";\" + Bande" +
                            "rasCircunferencia.ElementAt(Cursor).X + \";\" + BanderasCircunferencia.ElementAt(C" +
                            "ursor).Y + \";\" + Cursor + \";SEL\"") 
                        && (Activity1_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 119;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"C{ \\\"id\\\":\\\"\" + (int)(Cursor) + \"\\\", \\\"color\\\":\\\"\" + ColorBandera + \"\\\" }\"") 
                        && (Activity1_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 120;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Mostrar180.Replace(\"true\", \"false\")") 
                        && (Activity1_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 121;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "RtaCave") 
                        && (Activity1_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 122;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new PointF(Single.Parse(RtaCave.Split(\';\')[0].Replace(\".\", \",\")), Single.Parse(Rt" +
                            "aCave.Split(\';\')[1].Replace(\".\", \",\")))") 
                        && (Activity1_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 123;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Coordenadas") 
                        && (Activity1_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 124;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Angulo.Length > NroPrueba)") 
                        && (Activity1_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 125;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Angulo.Length <= NroPrueba)") 
                        && (Activity1_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 126;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Archivo") 
                        && (Activity1_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 127;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DateTime.Now.ToString()+\";\"+Coordenadas.X+\";\"+Coordenadas.Y+\";NULL;NULL;NULL;DEP\"" +
                            "") 
                        && (Activity1_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 128;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "RtaCave") 
                        && (Activity1_TypedDataContext10.Validate(locations, true, 0) == true)))) {
                expressionId = 129;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RtaCave.Equals(\"2\")") 
                        && (Activity1_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 130;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Archivo") 
                        && (Activity1_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 131;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DateTime.Now.ToString() + \";\" + Coordenadas.X + \";\" + Coordenadas.Y + \";\" + Coord" +
                            "enadas.X + \";\" + Coordenadas.Y + \";null;COL\"") 
                        && (Activity1_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 132;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == @"""A{ \""id\"":\"""" + idNueva + ""\"", \""color\"":\"""" + ColorBandera + ""\"", \""x\"":\"""" + Coordenadas.X.ToString(System.Globalization.CultureInfo.InvariantCulture).Replace("","", ""."") + ""\"", \""y\"":\"""" + Coordenadas.Y.ToString(System.Globalization.CultureInfo.InvariantCulture).Replace("","", ""."") + ""\"", \""visible\"":\""true\"" }""") 
                        && (Activity1_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 133;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "idNueva+1") 
                        && (Activity1_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 134;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "idNueva") 
                        && (Activity1_TypedDataContext10.Validate(locations, true, 0) == true)))) {
                expressionId = 135;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TimeSpan.FromSeconds(2)") 
                        && (Activity1_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 136;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Q{ \\\"text\\\":\\\"Confirma la posicion (Y)\\\" }\"") 
                        && (Activity1_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 137;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TimeSpan.FromSeconds(2)") 
                        && (Activity1_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 138;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Q{ \\\"text\\\":\\\" \\\" }\"") 
                        && (Activity1_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 139;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "!RtaCave.Equals(\"2\")") 
                        && (Activity1_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 140;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "!RtaCave.Equals(\"1\") && !RtaCave.Equals(\"3\") && !RtaCave.Equals(\"4\")") 
                        && (Activity1_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 141;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new PointF(Single.Parse(RtaCave.Split(\';\')[0].Replace(\".\", \",\")), Single.Parse(Rt" +
                            "aCave.Split(\';\')[1].Replace(\".\", \",\")))") 
                        && (Activity1_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 142;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Coordenadas") 
                        && (Activity1_TypedDataContext10.Validate(locations, true, 0) == true)))) {
                expressionId = 143;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Archivo") 
                        && (Activity1_TypedDataContext11_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 144;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DateTime.Now.ToString() + \";\" + Coordenadas.X + \";\" + Coordenadas.Y + \";\" + Bande" +
                            "rasCircunferencia.ElementAt(Cursor).X + \";\" + BanderasCircunferencia.ElementAt(C" +
                            "ursor).Y + \";\" + Cursor + \";CON\"") 
                        && (Activity1_TypedDataContext11_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 145;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "RtaCave") 
                        && (Activity1_TypedDataContext11.Validate(locations, true, 0) == true)))) {
                expressionId = 146;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(RtaCave.Equals(\"1\"))") 
                        && (Activity1_TypedDataContext11_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 147;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"H{ \\\"id\\\":\\\"\" + (int)(idNueva-1) + \"\\\", \\\"visible\\\":\\\"false\\\" }\"") 
                        && (Activity1_TypedDataContext11_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 148;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "NroPrueba+1") 
                        && (Activity1_TypedDataContext11_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 149;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "NroPrueba") 
                        && (Activity1_TypedDataContext11.Validate(locations, true, 0) == true)))) {
                expressionId = 150;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(RtaCave.Equals(\"2\"))") 
                        && (Activity1_TypedDataContext11_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 151;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"H{ \\\"id\\\":\\\"\" + (int)(idNueva-1) + \"\\\", \\\"visible\\\":\\\"false\\\" }\"") 
                        && (Activity1_TypedDataContext11_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 152;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "!(RtaCave.Equals(\"2\")) && !(RtaCave.Equals(\"1\"))") 
                        && (Activity1_TypedDataContext11_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 153;
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
                return new Activity1_TypedDataContext3(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new Activity1_TypedDataContext3_ForReadOnly(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new Activity1_TypedDataContext3(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new Activity1_TypedDataContext3(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new Activity1_TypedDataContext3(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new Activity1_TypedDataContext3_ForReadOnly(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new Activity1_TypedDataContext3(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new Activity1_TypedDataContext3_ForReadOnly(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new Activity1_TypedDataContext3(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new Activity1_TypedDataContext3_ForReadOnly(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new Activity1_TypedDataContext3(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new Activity1_TypedDataContext3(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new Activity1_TypedDataContext3(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new Activity1_TypedDataContext3_ForReadOnly(locationReferences).@__Expr13GetTree();
            }
            if ((expressionId == 14)) {
                return new Activity1_TypedDataContext3_ForReadOnly(locationReferences).@__Expr14GetTree();
            }
            if ((expressionId == 15)) {
                return new Activity1_TypedDataContext4_ForReadOnly(locationReferences).@__Expr15GetTree();
            }
            if ((expressionId == 16)) {
                return new Activity1_TypedDataContext4_ForReadOnly(locationReferences).@__Expr16GetTree();
            }
            if ((expressionId == 17)) {
                return new Activity1_TypedDataContext4(locationReferences).@__Expr17GetTree();
            }
            if ((expressionId == 18)) {
                return new Activity1_TypedDataContext4_ForReadOnly(locationReferences).@__Expr18GetTree();
            }
            if ((expressionId == 19)) {
                return new Activity1_TypedDataContext4(locationReferences).@__Expr19GetTree();
            }
            if ((expressionId == 20)) {
                return new Activity1_TypedDataContext4_ForReadOnly(locationReferences).@__Expr20GetTree();
            }
            if ((expressionId == 21)) {
                return new Activity1_TypedDataContext4_ForReadOnly(locationReferences).@__Expr21GetTree();
            }
            if ((expressionId == 22)) {
                return new Activity1_TypedDataContext4_ForReadOnly(locationReferences).@__Expr22GetTree();
            }
            if ((expressionId == 23)) {
                return new Activity1_TypedDataContext4(locationReferences).@__Expr23GetTree();
            }
            if ((expressionId == 24)) {
                return new Activity1_TypedDataContext4_ForReadOnly(locationReferences).@__Expr24GetTree();
            }
            if ((expressionId == 25)) {
                return new Activity1_TypedDataContext4(locationReferences).@__Expr25GetTree();
            }
            if ((expressionId == 26)) {
                return new Activity1_TypedDataContext4(locationReferences).@__Expr26GetTree();
            }
            if ((expressionId == 27)) {
                return new Activity1_TypedDataContext4_ForReadOnly(locationReferences).@__Expr27GetTree();
            }
            if ((expressionId == 28)) {
                return new Activity1_TypedDataContext4(locationReferences).@__Expr28GetTree();
            }
            if ((expressionId == 29)) {
                return new Activity1_TypedDataContext4_ForReadOnly(locationReferences).@__Expr29GetTree();
            }
            if ((expressionId == 30)) {
                return new Activity1_TypedDataContext4_ForReadOnly(locationReferences).@__Expr30GetTree();
            }
            if ((expressionId == 31)) {
                return new Activity1_TypedDataContext5_ForReadOnly(locationReferences).@__Expr31GetTree();
            }
            if ((expressionId == 32)) {
                return new Activity1_TypedDataContext5_ForReadOnly(locationReferences).@__Expr32GetTree();
            }
            if ((expressionId == 33)) {
                return new Activity1_TypedDataContext5(locationReferences).@__Expr33GetTree();
            }
            if ((expressionId == 34)) {
                return new Activity1_TypedDataContext5_ForReadOnly(locationReferences).@__Expr34GetTree();
            }
            if ((expressionId == 35)) {
                return new Activity1_TypedDataContext5(locationReferences).@__Expr35GetTree();
            }
            if ((expressionId == 36)) {
                return new Activity1_TypedDataContext5_ForReadOnly(locationReferences).@__Expr36GetTree();
            }
            if ((expressionId == 37)) {
                return new Activity1_TypedDataContext5_ForReadOnly(locationReferences).@__Expr37GetTree();
            }
            if ((expressionId == 38)) {
                return new Activity1_TypedDataContext5_ForReadOnly(locationReferences).@__Expr38GetTree();
            }
            if ((expressionId == 39)) {
                return new Activity1_TypedDataContext5(locationReferences).@__Expr39GetTree();
            }
            if ((expressionId == 40)) {
                return new Activity1_TypedDataContext5_ForReadOnly(locationReferences).@__Expr40GetTree();
            }
            if ((expressionId == 41)) {
                return new Activity1_TypedDataContext5_ForReadOnly(locationReferences).@__Expr41GetTree();
            }
            if ((expressionId == 42)) {
                return new Activity1_TypedDataContext5_ForReadOnly(locationReferences).@__Expr42GetTree();
            }
            if ((expressionId == 43)) {
                return new Activity1_TypedDataContext5_ForReadOnly(locationReferences).@__Expr43GetTree();
            }
            if ((expressionId == 44)) {
                return new Activity1_TypedDataContext5(locationReferences).@__Expr44GetTree();
            }
            if ((expressionId == 45)) {
                return new Activity1_TypedDataContext5_ForReadOnly(locationReferences).@__Expr45GetTree();
            }
            if ((expressionId == 46)) {
                return new Activity1_TypedDataContext5_ForReadOnly(locationReferences).@__Expr46GetTree();
            }
            if ((expressionId == 47)) {
                return new Activity1_TypedDataContext5_ForReadOnly(locationReferences).@__Expr47GetTree();
            }
            if ((expressionId == 48)) {
                return new Activity1_TypedDataContext5(locationReferences).@__Expr48GetTree();
            }
            if ((expressionId == 49)) {
                return new Activity1_TypedDataContext6_ForReadOnly(locationReferences).@__Expr49GetTree();
            }
            if ((expressionId == 50)) {
                return new Activity1_TypedDataContext6_ForReadOnly(locationReferences).@__Expr50GetTree();
            }
            if ((expressionId == 51)) {
                return new Activity1_TypedDataContext6(locationReferences).@__Expr51GetTree();
            }
            if ((expressionId == 52)) {
                return new Activity1_TypedDataContext6_ForReadOnly(locationReferences).@__Expr52GetTree();
            }
            if ((expressionId == 53)) {
                return new Activity1_TypedDataContext6(locationReferences).@__Expr53GetTree();
            }
            if ((expressionId == 54)) {
                return new Activity1_TypedDataContext6_ForReadOnly(locationReferences).@__Expr54GetTree();
            }
            if ((expressionId == 55)) {
                return new Activity1_TypedDataContext6_ForReadOnly(locationReferences).@__Expr55GetTree();
            }
            if ((expressionId == 56)) {
                return new Activity1_TypedDataContext6_ForReadOnly(locationReferences).@__Expr56GetTree();
            }
            if ((expressionId == 57)) {
                return new Activity1_TypedDataContext6_ForReadOnly(locationReferences).@__Expr57GetTree();
            }
            if ((expressionId == 58)) {
                return new Activity1_TypedDataContext6_ForReadOnly(locationReferences).@__Expr58GetTree();
            }
            if ((expressionId == 59)) {
                return new Activity1_TypedDataContext6_ForReadOnly(locationReferences).@__Expr59GetTree();
            }
            if ((expressionId == 60)) {
                return new Activity1_TypedDataContext6_ForReadOnly(locationReferences).@__Expr60GetTree();
            }
            if ((expressionId == 61)) {
                return new Activity1_TypedDataContext6_ForReadOnly(locationReferences).@__Expr61GetTree();
            }
            if ((expressionId == 62)) {
                return new Activity1_TypedDataContext6(locationReferences).@__Expr62GetTree();
            }
            if ((expressionId == 63)) {
                return new Activity1_TypedDataContext6_ForReadOnly(locationReferences).@__Expr63GetTree();
            }
            if ((expressionId == 64)) {
                return new Activity1_TypedDataContext6_ForReadOnly(locationReferences).@__Expr64GetTree();
            }
            if ((expressionId == 65)) {
                return new Activity1_TypedDataContext6_ForReadOnly(locationReferences).@__Expr65GetTree();
            }
            if ((expressionId == 66)) {
                return new Activity1_TypedDataContext6_ForReadOnly(locationReferences).@__Expr66GetTree();
            }
            if ((expressionId == 67)) {
                return new Activity1_TypedDataContext6_ForReadOnly(locationReferences).@__Expr67GetTree();
            }
            if ((expressionId == 68)) {
                return new Activity1_TypedDataContext6_ForReadOnly(locationReferences).@__Expr68GetTree();
            }
            if ((expressionId == 69)) {
                return new Activity1_TypedDataContext6_ForReadOnly(locationReferences).@__Expr69GetTree();
            }
            if ((expressionId == 70)) {
                return new Activity1_TypedDataContext6_ForReadOnly(locationReferences).@__Expr70GetTree();
            }
            if ((expressionId == 71)) {
                return new Activity1_TypedDataContext6_ForReadOnly(locationReferences).@__Expr71GetTree();
            }
            if ((expressionId == 72)) {
                return new Activity1_TypedDataContext6_ForReadOnly(locationReferences).@__Expr72GetTree();
            }
            if ((expressionId == 73)) {
                return new Activity1_TypedDataContext6(locationReferences).@__Expr73GetTree();
            }
            if ((expressionId == 74)) {
                return new Activity1_TypedDataContext6_ForReadOnly(locationReferences).@__Expr74GetTree();
            }
            if ((expressionId == 75)) {
                return new Activity1_TypedDataContext6_ForReadOnly(locationReferences).@__Expr75GetTree();
            }
            if ((expressionId == 76)) {
                return new Activity1_TypedDataContext6_ForReadOnly(locationReferences).@__Expr76GetTree();
            }
            if ((expressionId == 77)) {
                return new Activity1_TypedDataContext6_ForReadOnly(locationReferences).@__Expr77GetTree();
            }
            if ((expressionId == 78)) {
                return new Activity1_TypedDataContext6(locationReferences).@__Expr78GetTree();
            }
            if ((expressionId == 79)) {
                return new Activity1_TypedDataContext6(locationReferences).@__Expr79GetTree();
            }
            if ((expressionId == 80)) {
                return new Activity1_TypedDataContext6_ForReadOnly(locationReferences).@__Expr80GetTree();
            }
            if ((expressionId == 81)) {
                return new Activity1_TypedDataContext6_ForReadOnly(locationReferences).@__Expr81GetTree();
            }
            if ((expressionId == 82)) {
                return new Activity1_TypedDataContext6_ForReadOnly(locationReferences).@__Expr82GetTree();
            }
            if ((expressionId == 83)) {
                return new Activity1_TypedDataContext6_ForReadOnly(locationReferences).@__Expr83GetTree();
            }
            if ((expressionId == 84)) {
                return new Activity1_TypedDataContext7_ForReadOnly(locationReferences).@__Expr84GetTree();
            }
            if ((expressionId == 85)) {
                return new Activity1_TypedDataContext7_ForReadOnly(locationReferences).@__Expr85GetTree();
            }
            if ((expressionId == 86)) {
                return new Activity1_TypedDataContext7(locationReferences).@__Expr86GetTree();
            }
            if ((expressionId == 87)) {
                return new Activity1_TypedDataContext7_ForReadOnly(locationReferences).@__Expr87GetTree();
            }
            if ((expressionId == 88)) {
                return new Activity1_TypedDataContext7_ForReadOnly(locationReferences).@__Expr88GetTree();
            }
            if ((expressionId == 89)) {
                return new Activity1_TypedDataContext7_ForReadOnly(locationReferences).@__Expr89GetTree();
            }
            if ((expressionId == 90)) {
                return new Activity1_TypedDataContext7_ForReadOnly(locationReferences).@__Expr90GetTree();
            }
            if ((expressionId == 91)) {
                return new Activity1_TypedDataContext7_ForReadOnly(locationReferences).@__Expr91GetTree();
            }
            if ((expressionId == 92)) {
                return new Activity1_TypedDataContext7(locationReferences).@__Expr92GetTree();
            }
            if ((expressionId == 93)) {
                return new Activity1_TypedDataContext7_ForReadOnly(locationReferences).@__Expr93GetTree();
            }
            if ((expressionId == 94)) {
                return new Activity1_TypedDataContext7_ForReadOnly(locationReferences).@__Expr94GetTree();
            }
            if ((expressionId == 95)) {
                return new Activity1_TypedDataContext7(locationReferences).@__Expr95GetTree();
            }
            if ((expressionId == 96)) {
                return new Activity1_TypedDataContext7_ForReadOnly(locationReferences).@__Expr96GetTree();
            }
            if ((expressionId == 97)) {
                return new Activity1_TypedDataContext7(locationReferences).@__Expr97GetTree();
            }
            if ((expressionId == 98)) {
                return new Activity1_TypedDataContext7_ForReadOnly(locationReferences).@__Expr98GetTree();
            }
            if ((expressionId == 99)) {
                return new Activity1_TypedDataContext8_ForReadOnly(locationReferences).@__Expr99GetTree();
            }
            if ((expressionId == 100)) {
                return new Activity1_TypedDataContext8_ForReadOnly(locationReferences).@__Expr100GetTree();
            }
            if ((expressionId == 101)) {
                return new Activity1_TypedDataContext8_ForReadOnly(locationReferences).@__Expr101GetTree();
            }
            if ((expressionId == 102)) {
                return new Activity1_TypedDataContext8_ForReadOnly(locationReferences).@__Expr102GetTree();
            }
            if ((expressionId == 103)) {
                return new Activity1_TypedDataContext9_ForReadOnly(locationReferences).@__Expr103GetTree();
            }
            if ((expressionId == 104)) {
                return new Activity1_TypedDataContext9_ForReadOnly(locationReferences).@__Expr104GetTree();
            }
            if ((expressionId == 105)) {
                return new Activity1_TypedDataContext9_ForReadOnly(locationReferences).@__Expr105GetTree();
            }
            if ((expressionId == 106)) {
                return new Activity1_TypedDataContext9_ForReadOnly(locationReferences).@__Expr106GetTree();
            }
            if ((expressionId == 107)) {
                return new Activity1_TypedDataContext9_ForReadOnly(locationReferences).@__Expr107GetTree();
            }
            if ((expressionId == 108)) {
                return new Activity1_TypedDataContext9_ForReadOnly(locationReferences).@__Expr108GetTree();
            }
            if ((expressionId == 109)) {
                return new Activity1_TypedDataContext9_ForReadOnly(locationReferences).@__Expr109GetTree();
            }
            if ((expressionId == 110)) {
                return new Activity1_TypedDataContext9_ForReadOnly(locationReferences).@__Expr110GetTree();
            }
            if ((expressionId == 111)) {
                return new Activity1_TypedDataContext9_ForReadOnly(locationReferences).@__Expr111GetTree();
            }
            if ((expressionId == 112)) {
                return new Activity1_TypedDataContext9_ForReadOnly(locationReferences).@__Expr112GetTree();
            }
            if ((expressionId == 113)) {
                return new Activity1_TypedDataContext9_ForReadOnly(locationReferences).@__Expr113GetTree();
            }
            if ((expressionId == 114)) {
                return new Activity1_TypedDataContext9_ForReadOnly(locationReferences).@__Expr114GetTree();
            }
            if ((expressionId == 115)) {
                return new Activity1_TypedDataContext9_ForReadOnly(locationReferences).@__Expr115GetTree();
            }
            if ((expressionId == 116)) {
                return new Activity1_TypedDataContext9_ForReadOnly(locationReferences).@__Expr116GetTree();
            }
            if ((expressionId == 117)) {
                return new Activity1_TypedDataContext9_ForReadOnly(locationReferences).@__Expr117GetTree();
            }
            if ((expressionId == 118)) {
                return new Activity1_TypedDataContext9_ForReadOnly(locationReferences).@__Expr118GetTree();
            }
            if ((expressionId == 119)) {
                return new Activity1_TypedDataContext9_ForReadOnly(locationReferences).@__Expr119GetTree();
            }
            if ((expressionId == 120)) {
                return new Activity1_TypedDataContext9_ForReadOnly(locationReferences).@__Expr120GetTree();
            }
            if ((expressionId == 121)) {
                return new Activity1_TypedDataContext9_ForReadOnly(locationReferences).@__Expr121GetTree();
            }
            if ((expressionId == 122)) {
                return new Activity1_TypedDataContext9(locationReferences).@__Expr122GetTree();
            }
            if ((expressionId == 123)) {
                return new Activity1_TypedDataContext9_ForReadOnly(locationReferences).@__Expr123GetTree();
            }
            if ((expressionId == 124)) {
                return new Activity1_TypedDataContext9(locationReferences).@__Expr124GetTree();
            }
            if ((expressionId == 125)) {
                return new Activity1_TypedDataContext9_ForReadOnly(locationReferences).@__Expr125GetTree();
            }
            if ((expressionId == 126)) {
                return new Activity1_TypedDataContext9_ForReadOnly(locationReferences).@__Expr126GetTree();
            }
            if ((expressionId == 127)) {
                return new Activity1_TypedDataContext10_ForReadOnly(locationReferences).@__Expr127GetTree();
            }
            if ((expressionId == 128)) {
                return new Activity1_TypedDataContext10_ForReadOnly(locationReferences).@__Expr128GetTree();
            }
            if ((expressionId == 129)) {
                return new Activity1_TypedDataContext10(locationReferences).@__Expr129GetTree();
            }
            if ((expressionId == 130)) {
                return new Activity1_TypedDataContext10_ForReadOnly(locationReferences).@__Expr130GetTree();
            }
            if ((expressionId == 131)) {
                return new Activity1_TypedDataContext10_ForReadOnly(locationReferences).@__Expr131GetTree();
            }
            if ((expressionId == 132)) {
                return new Activity1_TypedDataContext10_ForReadOnly(locationReferences).@__Expr132GetTree();
            }
            if ((expressionId == 133)) {
                return new Activity1_TypedDataContext10_ForReadOnly(locationReferences).@__Expr133GetTree();
            }
            if ((expressionId == 134)) {
                return new Activity1_TypedDataContext10_ForReadOnly(locationReferences).@__Expr134GetTree();
            }
            if ((expressionId == 135)) {
                return new Activity1_TypedDataContext10(locationReferences).@__Expr135GetTree();
            }
            if ((expressionId == 136)) {
                return new Activity1_TypedDataContext10_ForReadOnly(locationReferences).@__Expr136GetTree();
            }
            if ((expressionId == 137)) {
                return new Activity1_TypedDataContext10_ForReadOnly(locationReferences).@__Expr137GetTree();
            }
            if ((expressionId == 138)) {
                return new Activity1_TypedDataContext10_ForReadOnly(locationReferences).@__Expr138GetTree();
            }
            if ((expressionId == 139)) {
                return new Activity1_TypedDataContext10_ForReadOnly(locationReferences).@__Expr139GetTree();
            }
            if ((expressionId == 140)) {
                return new Activity1_TypedDataContext10_ForReadOnly(locationReferences).@__Expr140GetTree();
            }
            if ((expressionId == 141)) {
                return new Activity1_TypedDataContext10_ForReadOnly(locationReferences).@__Expr141GetTree();
            }
            if ((expressionId == 142)) {
                return new Activity1_TypedDataContext10_ForReadOnly(locationReferences).@__Expr142GetTree();
            }
            if ((expressionId == 143)) {
                return new Activity1_TypedDataContext10(locationReferences).@__Expr143GetTree();
            }
            if ((expressionId == 144)) {
                return new Activity1_TypedDataContext11_ForReadOnly(locationReferences).@__Expr144GetTree();
            }
            if ((expressionId == 145)) {
                return new Activity1_TypedDataContext11_ForReadOnly(locationReferences).@__Expr145GetTree();
            }
            if ((expressionId == 146)) {
                return new Activity1_TypedDataContext11(locationReferences).@__Expr146GetTree();
            }
            if ((expressionId == 147)) {
                return new Activity1_TypedDataContext11_ForReadOnly(locationReferences).@__Expr147GetTree();
            }
            if ((expressionId == 148)) {
                return new Activity1_TypedDataContext11_ForReadOnly(locationReferences).@__Expr148GetTree();
            }
            if ((expressionId == 149)) {
                return new Activity1_TypedDataContext11_ForReadOnly(locationReferences).@__Expr149GetTree();
            }
            if ((expressionId == 150)) {
                return new Activity1_TypedDataContext11(locationReferences).@__Expr150GetTree();
            }
            if ((expressionId == 151)) {
                return new Activity1_TypedDataContext11_ForReadOnly(locationReferences).@__Expr151GetTree();
            }
            if ((expressionId == 152)) {
                return new Activity1_TypedDataContext11_ForReadOnly(locationReferences).@__Expr152GetTree();
            }
            if ((expressionId == 153)) {
                return new Activity1_TypedDataContext11_ForReadOnly(locationReferences).@__Expr153GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Activity1_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Activity1_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class Activity1_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Activity1_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class Activity1_TypedDataContext1 : Activity1_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int Separacion;
            
            protected int NroProtocolo;
            
            protected int Radio;
            
            public Activity1_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
            
            protected string IdSujeto {
                get {
                    return ((string)(this.GetVariableValue((3 + locationsOffset))));
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
            
            protected System.Collections.Generic.List<string> Archivo {
                get {
                    return ((System.Collections.Generic.List<string>)(this.GetVariableValue((6 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((6 + locationsOffset), value);
                }
            }
            
            protected string TestMemoria {
                get {
                    return ((string)(this.GetVariableValue((7 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((7 + locationsOffset), value);
                }
            }
            
            protected string ColorSeleccion {
                get {
                    return ((string)(this.GetVariableValue((8 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((8 + locationsOffset), value);
                }
            }
            
            protected string Escenario {
                get {
                    return ((string)(this.GetVariableValue((11 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((11 + locationsOffset), value);
                }
            }
            
            protected int[] Angulo {
                get {
                    return ((int[])(this.GetVariableValue((12 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((12 + locationsOffset), value);
                }
            }
            
            protected int[] Protocolo_P1 {
                get {
                    return ((int[])(this.GetVariableValue((13 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((13 + locationsOffset), value);
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
                this.NroProtocolo = ((int)(this.GetVariableValue((9 + locationsOffset))));
                this.Radio = ((int)(this.GetVariableValue((10 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((4 + locationsOffset), this.Separacion);
                this.SetVariableValue((9 + locationsOffset), this.NroProtocolo);
                this.SetVariableValue((10 + locationsOffset), this.Radio);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 14))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 14);
                }
                expectedLocationsCount = 14;
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
                if (((locationReferences[(offset + 3)].Name != "IdSujeto") 
                            || (locationReferences[(offset + 3)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "ColorBandera") 
                            || (locationReferences[(offset + 5)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "Archivo") 
                            || (locationReferences[(offset + 6)].Type != typeof(System.Collections.Generic.List<string>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "TestMemoria") 
                            || (locationReferences[(offset + 7)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "ColorSeleccion") 
                            || (locationReferences[(offset + 8)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 11)].Name != "Escenario") 
                            || (locationReferences[(offset + 11)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 12)].Name != "Angulo") 
                            || (locationReferences[(offset + 12)].Type != typeof(int[])))) {
                    return false;
                }
                if (((locationReferences[(offset + 13)].Name != "Protocolo_P1") 
                            || (locationReferences[(offset + 13)].Type != typeof(int[])))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "Separacion") 
                            || (locationReferences[(offset + 4)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "NroProtocolo") 
                            || (locationReferences[(offset + 9)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 10)].Name != "Radio") 
                            || (locationReferences[(offset + 10)].Type != typeof(int)))) {
                    return false;
                }
                return Activity1_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Activity1_TypedDataContext1_ForReadOnly : Activity1_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int Separacion;
            
            protected int NroProtocolo;
            
            protected int Radio;
            
            public Activity1_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
            
            protected string IdSujeto {
                get {
                    return ((string)(this.GetVariableValue((3 + locationsOffset))));
                }
            }
            
            protected string ColorBandera {
                get {
                    return ((string)(this.GetVariableValue((5 + locationsOffset))));
                }
            }
            
            protected System.Collections.Generic.List<string> Archivo {
                get {
                    return ((System.Collections.Generic.List<string>)(this.GetVariableValue((6 + locationsOffset))));
                }
            }
            
            protected string TestMemoria {
                get {
                    return ((string)(this.GetVariableValue((7 + locationsOffset))));
                }
            }
            
            protected string ColorSeleccion {
                get {
                    return ((string)(this.GetVariableValue((8 + locationsOffset))));
                }
            }
            
            protected string Escenario {
                get {
                    return ((string)(this.GetVariableValue((11 + locationsOffset))));
                }
            }
            
            protected int[] Angulo {
                get {
                    return ((int[])(this.GetVariableValue((12 + locationsOffset))));
                }
            }
            
            protected int[] Protocolo_P1 {
                get {
                    return ((int[])(this.GetVariableValue((13 + locationsOffset))));
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
                this.NroProtocolo = ((int)(this.GetVariableValue((9 + locationsOffset))));
                this.Radio = ((int)(this.GetVariableValue((10 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 14))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 14);
                }
                expectedLocationsCount = 14;
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
                if (((locationReferences[(offset + 3)].Name != "IdSujeto") 
                            || (locationReferences[(offset + 3)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "ColorBandera") 
                            || (locationReferences[(offset + 5)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "Archivo") 
                            || (locationReferences[(offset + 6)].Type != typeof(System.Collections.Generic.List<string>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "TestMemoria") 
                            || (locationReferences[(offset + 7)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "ColorSeleccion") 
                            || (locationReferences[(offset + 8)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 11)].Name != "Escenario") 
                            || (locationReferences[(offset + 11)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 12)].Name != "Angulo") 
                            || (locationReferences[(offset + 12)].Type != typeof(int[])))) {
                    return false;
                }
                if (((locationReferences[(offset + 13)].Name != "Protocolo_P1") 
                            || (locationReferences[(offset + 13)].Type != typeof(int[])))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "Separacion") 
                            || (locationReferences[(offset + 4)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "NroProtocolo") 
                            || (locationReferences[(offset + 9)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 10)].Name != "Radio") 
                            || (locationReferences[(offset + 10)].Type != typeof(int)))) {
                    return false;
                }
                return Activity1_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Activity1_TypedDataContext2 : Activity1_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected System.Drawing.PointF Coordenadas;
            
            protected int NroPrueba;
            
            protected int IBanderaPar;
            
            protected int Cercania;
            
            protected int medio;
            
            protected int Cursor;
            
            protected System.Drawing.PointF Cruz;
            
            protected int idNueva;
            
            public Activity1_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string RtaCave {
                get {
                    return ((string)(this.GetVariableValue((14 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((14 + locationsOffset), value);
                }
            }
            
            protected int[] BanderasExperimento {
                get {
                    return ((int[])(this.GetVariableValue((18 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((18 + locationsOffset), value);
                }
            }
            
            protected bool[] BanderasVisibles {
                get {
                    return ((bool[])(this.GetVariableValue((19 + locationsOffset))));
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
            
            protected override void GetValueTypeValues() {
                this.Coordenadas = ((System.Drawing.PointF)(this.GetVariableValue((15 + locationsOffset))));
                this.NroPrueba = ((int)(this.GetVariableValue((16 + locationsOffset))));
                this.IBanderaPar = ((int)(this.GetVariableValue((17 + locationsOffset))));
                this.Cercania = ((int)(this.GetVariableValue((20 + locationsOffset))));
                this.medio = ((int)(this.GetVariableValue((21 + locationsOffset))));
                this.Cursor = ((int)(this.GetVariableValue((22 + locationsOffset))));
                this.Cruz = ((System.Drawing.PointF)(this.GetVariableValue((23 + locationsOffset))));
                this.idNueva = ((int)(this.GetVariableValue((24 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((15 + locationsOffset), this.Coordenadas);
                this.SetVariableValue((16 + locationsOffset), this.NroPrueba);
                this.SetVariableValue((17 + locationsOffset), this.IBanderaPar);
                this.SetVariableValue((20 + locationsOffset), this.Cercania);
                this.SetVariableValue((21 + locationsOffset), this.medio);
                this.SetVariableValue((22 + locationsOffset), this.Cursor);
                this.SetVariableValue((23 + locationsOffset), this.Cruz);
                this.SetVariableValue((24 + locationsOffset), this.idNueva);
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
                if (((locationReferences[(offset + 14)].Name != "RtaCave") 
                            || (locationReferences[(offset + 14)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 18)].Name != "BanderasExperimento") 
                            || (locationReferences[(offset + 18)].Type != typeof(int[])))) {
                    return false;
                }
                if (((locationReferences[(offset + 19)].Name != "BanderasVisibles") 
                            || (locationReferences[(offset + 19)].Type != typeof(bool[])))) {
                    return false;
                }
                if (((locationReferences[(offset + 15)].Name != "Coordenadas") 
                            || (locationReferences[(offset + 15)].Type != typeof(System.Drawing.PointF)))) {
                    return false;
                }
                if (((locationReferences[(offset + 16)].Name != "NroPrueba") 
                            || (locationReferences[(offset + 16)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 17)].Name != "IBanderaPar") 
                            || (locationReferences[(offset + 17)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 20)].Name != "Cercania") 
                            || (locationReferences[(offset + 20)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 21)].Name != "medio") 
                            || (locationReferences[(offset + 21)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 22)].Name != "Cursor") 
                            || (locationReferences[(offset + 22)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 23)].Name != "Cruz") 
                            || (locationReferences[(offset + 23)].Type != typeof(System.Drawing.PointF)))) {
                    return false;
                }
                if (((locationReferences[(offset + 24)].Name != "idNueva") 
                            || (locationReferences[(offset + 24)].Type != typeof(int)))) {
                    return false;
                }
                return Activity1_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Activity1_TypedDataContext2_ForReadOnly : Activity1_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected System.Drawing.PointF Coordenadas;
            
            protected int NroPrueba;
            
            protected int IBanderaPar;
            
            protected int Cercania;
            
            protected int medio;
            
            protected int Cursor;
            
            protected System.Drawing.PointF Cruz;
            
            protected int idNueva;
            
            public Activity1_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string RtaCave {
                get {
                    return ((string)(this.GetVariableValue((14 + locationsOffset))));
                }
            }
            
            protected int[] BanderasExperimento {
                get {
                    return ((int[])(this.GetVariableValue((18 + locationsOffset))));
                }
            }
            
            protected bool[] BanderasVisibles {
                get {
                    return ((bool[])(this.GetVariableValue((19 + locationsOffset))));
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
                this.Coordenadas = ((System.Drawing.PointF)(this.GetVariableValue((15 + locationsOffset))));
                this.NroPrueba = ((int)(this.GetVariableValue((16 + locationsOffset))));
                this.IBanderaPar = ((int)(this.GetVariableValue((17 + locationsOffset))));
                this.Cercania = ((int)(this.GetVariableValue((20 + locationsOffset))));
                this.medio = ((int)(this.GetVariableValue((21 + locationsOffset))));
                this.Cursor = ((int)(this.GetVariableValue((22 + locationsOffset))));
                this.Cruz = ((System.Drawing.PointF)(this.GetVariableValue((23 + locationsOffset))));
                this.idNueva = ((int)(this.GetVariableValue((24 + locationsOffset))));
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
                if (((locationReferences[(offset + 14)].Name != "RtaCave") 
                            || (locationReferences[(offset + 14)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 18)].Name != "BanderasExperimento") 
                            || (locationReferences[(offset + 18)].Type != typeof(int[])))) {
                    return false;
                }
                if (((locationReferences[(offset + 19)].Name != "BanderasVisibles") 
                            || (locationReferences[(offset + 19)].Type != typeof(bool[])))) {
                    return false;
                }
                if (((locationReferences[(offset + 15)].Name != "Coordenadas") 
                            || (locationReferences[(offset + 15)].Type != typeof(System.Drawing.PointF)))) {
                    return false;
                }
                if (((locationReferences[(offset + 16)].Name != "NroPrueba") 
                            || (locationReferences[(offset + 16)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 17)].Name != "IBanderaPar") 
                            || (locationReferences[(offset + 17)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 20)].Name != "Cercania") 
                            || (locationReferences[(offset + 20)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 21)].Name != "medio") 
                            || (locationReferences[(offset + 21)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 22)].Name != "Cursor") 
                            || (locationReferences[(offset + 22)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 23)].Name != "Cruz") 
                            || (locationReferences[(offset + 23)].Type != typeof(System.Drawing.PointF)))) {
                    return false;
                }
                if (((locationReferences[(offset + 24)].Name != "idNueva") 
                            || (locationReferences[(offset + 24)].Type != typeof(int)))) {
                    return false;
                }
                return Activity1_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Activity1_TypedDataContext3 : Activity1_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Activity1_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext3(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                
                #line 68 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                  Cercania;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr0Get() {
                
                #line 68 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                  Cercania;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr0Set(int value) {
                
                #line 68 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                
                  Cercania = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr0Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr0Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 78 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<string>>> expression = () => 
                  Archivo;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<string> @__Expr2Get() {
                
                #line 78 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                  Archivo;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<string> ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr2Set(System.Collections.Generic.List<string> value) {
                
                #line 78 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                
                  Archivo = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr2Set(System.Collections.Generic.List<string> value) {
                this.GetValueTypeValues();
                this.@__Expr2Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 90 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                  NroPrueba;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr3Get() {
                
                #line 90 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                  NroPrueba;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr3Set(int value) {
                
                #line 90 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                
                  NroPrueba = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr3Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr3Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 100 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                  IBanderaPar;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr4Get() {
                
                #line 100 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                  IBanderaPar;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr4Set(int value) {
                
                #line 100 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                
                  IBanderaPar = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr4Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr4Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 110 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<int[]>> expression = () => 
                  BanderasExperimento;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int[] @__Expr6Get() {
                
                #line 110 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                  BanderasExperimento;
                
                #line default
                #line hidden
            }
            
            public int[] ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr6Set(int[] value) {
                
                #line 110 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                
                  BanderasExperimento = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr6Set(int[] value) {
                this.GetValueTypeValues();
                this.@__Expr6Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 122 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool[]>> expression = () => 
                  BanderasVisibles;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool[] @__Expr8Get() {
                
                #line 122 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                  BanderasVisibles;
                
                #line default
                #line hidden
            }
            
            public bool[] ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr8Set(bool[] value) {
                
                #line 122 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                
                  BanderasVisibles = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr8Set(bool[] value) {
                this.GetValueTypeValues();
                this.@__Expr8Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 134 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                  Cruz;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr10Get() {
                
                #line 134 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                  Cruz;
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr10Set(System.Drawing.PointF value) {
                
                #line 134 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                
                  Cruz = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr10Set(System.Drawing.PointF value) {
                this.GetValueTypeValues();
                this.@__Expr10Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 146 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                  idNueva;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr11Get() {
                
                #line 146 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                  idNueva;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr11Set(int value) {
                
                #line 146 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                
                  idNueva = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr11Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr11Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 162 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                      RtaCave;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr12Get() {
                
                #line 162 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
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
                
                #line 162 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                
                      RtaCave = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr12Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr12Set(value);
                this.SetValueTypeValues();
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
                return Activity1_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Activity1_TypedDataContext3_ForReadOnly : Activity1_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Activity1_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                
                #line 83 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<string>>> expression = () => 
                  new List<string>();;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<string> @__Expr1Get() {
                
                #line 83 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                  new List<string>();;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<string> ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 115 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<int[]>> expression = () => 
                  new int[2];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int[] @__Expr5Get() {
                
                #line 115 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                  new int[2];
                
                #line default
                #line hidden
            }
            
            public int[] ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 127 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool[]>> expression = () => 
                  new bool[2];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool[] @__Expr7Get() {
                
                #line 127 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                  new bool[2];
                
                #line default
                #line hidden
            }
            
            public bool[] ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 139 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                  new PointF(0,0);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr9Get() {
                
                #line 139 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                  new PointF(0,0);
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 1207 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                    Agregar180;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr13Get() {
                
                #line 1207 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                    Agregar180;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 1212 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                    "L{ \"id\":\""+Escenario+"\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr14Get() {
                
                #line 1212 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                    "L{ \"id\":\""+Escenario+"\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
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
                return Activity1_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Activity1_TypedDataContext4 : Activity1_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Activity1_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext4(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                
                #line 192 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                              RtaCave;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr17Get() {
                
                #line 192 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                              RtaCave;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr17Get() {
                this.GetValueTypeValues();
                return this.@__Expr17Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr17Set(string value) {
                
                #line 192 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                
                              RtaCave = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr17Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr17Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr19GetTree() {
                
                #line 199 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                              Coordenadas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr19Get() {
                
                #line 199 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                              Coordenadas;
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr19Get() {
                this.GetValueTypeValues();
                return this.@__Expr19Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr19Set(System.Drawing.PointF value) {
                
                #line 199 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                
                              Coordenadas = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr19Set(System.Drawing.PointF value) {
                this.GetValueTypeValues();
                this.@__Expr19Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr23GetTree() {
                
                #line 1135 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                    BanderasExperimento[0];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr23Get() {
                
                #line 1135 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                    BanderasExperimento[0];
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr23Get() {
                this.GetValueTypeValues();
                return this.@__Expr23Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr23Set(int value) {
                
                #line 1135 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                
                                    BanderasExperimento[0] = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr23Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr23Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr25GetTree() {
                
                #line 1152 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                    BanderasVisibles[0];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr25Get() {
                
                #line 1152 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                    BanderasVisibles[0];
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr25Get() {
                this.GetValueTypeValues();
                return this.@__Expr25Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr25Set(bool value) {
                
                #line 1152 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                
                                    BanderasVisibles[0] = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr25Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr25Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr26GetTree() {
                
                #line 1162 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                    BanderasVisibles[1];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr26Get() {
                
                #line 1162 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                    BanderasVisibles[1];
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr26Get() {
                this.GetValueTypeValues();
                return this.@__Expr26Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr26Set(bool value) {
                
                #line 1162 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                
                                    BanderasVisibles[1] = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr26Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr26Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr28GetTree() {
                
                #line 1172 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                    BanderasExperimento[1];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr28Get() {
                
                #line 1172 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                    BanderasExperimento[1];
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr28Get() {
                this.GetValueTypeValues();
                return this.@__Expr28Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr28Set(int value) {
                
                #line 1172 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                
                                    BanderasExperimento[1] = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr28Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr28Set(value);
                this.SetValueTypeValues();
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
                return Activity1_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Activity1_TypedDataContext4_ForReadOnly : Activity1_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Activity1_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr15GetTree() {
                
                #line 181 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                      Archivo;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr15Get() {
                
                #line 181 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                      Archivo;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr15Get() {
                this.GetValueTypeValues();
                return this.@__Expr15Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr16GetTree() {
                
                #line 177 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                        DateTime.Now.ToString()+";"+Coordenadas.X+";"+Coordenadas.Y+";NULL;NULL;NULL;DET";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr16Get() {
                
                #line 177 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                        DateTime.Now.ToString()+";"+Coordenadas.X+";"+Coordenadas.Y+";NULL;NULL;NULL;DET";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr16Get() {
                this.GetValueTypeValues();
                return this.@__Expr16Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr18GetTree() {
                
                #line 204 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                              new PointF(Single.Parse(RtaCave.Split(';')[0].Replace(".", ",")), Single.Parse(RtaCave.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr18Get() {
                
                #line 204 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                              new PointF(Single.Parse(RtaCave.Split(';')[0].Replace(".", ",")), Single.Parse(RtaCave.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr18Get() {
                this.GetValueTypeValues();
                return this.@__Expr18Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr20GetTree() {
                
                #line 1197 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      (IBanderaPar<2)&&(Angulo.Length > NroPrueba);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr20Get() {
                
                #line 1197 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                      (IBanderaPar<2)&&(Angulo.Length > NroPrueba);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr20Get() {
                this.GetValueTypeValues();
                return this.@__Expr20Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr21GetTree() {
                
                #line 1127 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              IBanderaPar==0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr21Get() {
                
                #line 1127 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                              IBanderaPar==0;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr21Get() {
                this.GetValueTypeValues();
                return this.@__Expr21Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr22GetTree() {
                
                #line 1140 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                    new Random().Next(0, BanderasCircunferencia.Count-1);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr22Get() {
                
                #line 1140 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                    new Random().Next(0, BanderasCircunferencia.Count-1);
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr22Get() {
                this.GetValueTypeValues();
                return this.@__Expr22Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr24GetTree() {
                
                #line 1146 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  (BanderasCircunferencia.Count - 1).ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr24Get() {
                
                #line 1146 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                  (BanderasCircunferencia.Count - 1).ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr24Get() {
                this.GetValueTypeValues();
                return this.@__Expr24Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr27GetTree() {
                
                #line 1177 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                    (BanderasExperimento[0] + (int)(Angulo[NroPrueba] / Separacion)) % BanderasCircunferencia.Count;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr27Get() {
                
                #line 1177 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                    (BanderasExperimento[0] + (int)(Angulo[NroPrueba] / Separacion)) % BanderasCircunferencia.Count;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr27Get() {
                this.GetValueTypeValues();
                return this.@__Expr27Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr29GetTree() {
                
                #line 1183 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  "H{ \"id\":\"" + (int)(BanderasExperimento[0]) + "\", \"visible\":\"true\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr29Get() {
                
                #line 1183 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                  "H{ \"id\":\"" + (int)(BanderasExperimento[0]) + "\", \"visible\":\"true\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr29Get() {
                this.GetValueTypeValues();
                return this.@__Expr29Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr30GetTree() {
                
                #line 1188 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  "H{ \"id\":\"" + (int)(BanderasExperimento[1]) + "\", \"visible\":\"true\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr30Get() {
                
                #line 1188 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                  "H{ \"id\":\"" + (int)(BanderasExperimento[1]) + "\", \"visible\":\"true\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr30Get() {
                this.GetValueTypeValues();
                return this.@__Expr30Get();
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
                return Activity1_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Activity1_TypedDataContext5 : Activity1_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Activity1_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext5(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr33GetTree() {
                
                #line 231 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                      RtaCave;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr33Get() {
                
                #line 231 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                      RtaCave;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr33Get() {
                this.GetValueTypeValues();
                return this.@__Expr33Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr33Set(string value) {
                
                #line 231 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                
                                      RtaCave = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr33Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr33Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr35GetTree() {
                
                #line 238 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                                      Coordenadas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr35Get() {
                
                #line 238 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                      Coordenadas;
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr35Get() {
                this.GetValueTypeValues();
                return this.@__Expr35Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr35Set(System.Drawing.PointF value) {
                
                #line 238 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                
                                      Coordenadas = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr35Set(System.Drawing.PointF value) {
                this.GetValueTypeValues();
                this.@__Expr35Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr39GetTree() {
                
                #line 1039 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                      IBanderaPar;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr39Get() {
                
                #line 1039 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                      IBanderaPar;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr39Get() {
                this.GetValueTypeValues();
                return this.@__Expr39Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr39Set(int value) {
                
                #line 1039 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                
                                      IBanderaPar = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr39Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr39Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr44GetTree() {
                
                #line 1074 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                            BanderasVisibles[0];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr44Get() {
                
                #line 1074 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                            BanderasVisibles[0];
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr44Get() {
                this.GetValueTypeValues();
                return this.@__Expr44Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr44Set(bool value) {
                
                #line 1074 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                
                                            BanderasVisibles[0] = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr44Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr44Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr48GetTree() {
                
                #line 1103 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                            BanderasVisibles[1];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr48Get() {
                
                #line 1103 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                            BanderasVisibles[1];
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr48Get() {
                this.GetValueTypeValues();
                return this.@__Expr48Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr48Set(bool value) {
                
                #line 1103 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                
                                            BanderasVisibles[1] = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr48Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr48Set(value);
                this.SetValueTypeValues();
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
                return Activity1_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Activity1_TypedDataContext5_ForReadOnly : Activity1_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Activity1_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr31GetTree() {
                
                #line 220 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                              Archivo;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr31Get() {
                
                #line 220 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                              Archivo;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr31Get() {
                this.GetValueTypeValues();
                return this.@__Expr31Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr32GetTree() {
                
                #line 216 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                DateTime.Now.ToString()+";"+Coordenadas.X+";"+Coordenadas.Y+";"+"NULL;NULL;NULL;BUS";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr32Get() {
                
                #line 216 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                DateTime.Now.ToString()+";"+Coordenadas.X+";"+Coordenadas.Y+";"+"NULL;NULL;NULL;BUS";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr32Get() {
                this.GetValueTypeValues();
                return this.@__Expr32Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr34GetTree() {
                
                #line 243 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                                      new PointF(Single.Parse(RtaCave.Split(';')[0].Replace(".", ",")), Single.Parse(RtaCave.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr34Get() {
                
                #line 243 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                      new PointF(Single.Parse(RtaCave.Split(';')[0].Replace(".", ",")), Single.Parse(RtaCave.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr34Get() {
                this.GetValueTypeValues();
                return this.@__Expr34Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr36GetTree() {
                
                #line 253 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              !((((Math.Pow(BanderasCircunferencia[BanderasExperimento[0]].X - Coordenadas.X, 2) + Math.Pow(BanderasCircunferencia[BanderasExperimento[0]].Y - Coordenadas.Y, 2)) < Cercania) && (BanderasVisibles[0])) || (((Math.Pow(BanderasCircunferencia[BanderasExperimento[1]].X - Coordenadas.X, 2) + Math.Pow(BanderasCircunferencia[BanderasExperimento[1]].Y - Coordenadas.Y, 2)) < Cercania) && (BanderasVisibles[1])));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr36Get() {
                
                #line 253 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                              !((((Math.Pow(BanderasCircunferencia[BanderasExperimento[0]].X - Coordenadas.X, 2) + Math.Pow(BanderasCircunferencia[BanderasExperimento[0]].Y - Coordenadas.Y, 2)) < Cercania) && (BanderasVisibles[0])) || (((Math.Pow(BanderasCircunferencia[BanderasExperimento[1]].X - Coordenadas.X, 2) + Math.Pow(BanderasCircunferencia[BanderasExperimento[1]].Y - Coordenadas.Y, 2)) < Cercania) && (BanderasVisibles[1])));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr36Get() {
                this.GetValueTypeValues();
                return this.@__Expr36Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr37GetTree() {
                
                #line 1116 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              (((Math.Pow(BanderasCircunferencia[BanderasExperimento[0]].X - Coordenadas.X, 2) + Math.Pow(BanderasCircunferencia[BanderasExperimento[0]].Y - Coordenadas.Y, 2)) < Cercania) && (BanderasVisibles[0])) || (((Math.Pow(BanderasCircunferencia[BanderasExperimento[1]].X - Coordenadas.X, 2) + Math.Pow(BanderasCircunferencia[BanderasExperimento[1]].Y - Coordenadas.Y, 2)) < Cercania) && (BanderasVisibles[1]));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr37Get() {
                
                #line 1116 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                              (((Math.Pow(BanderasCircunferencia[BanderasExperimento[0]].X - Coordenadas.X, 2) + Math.Pow(BanderasCircunferencia[BanderasExperimento[0]].Y - Coordenadas.Y, 2)) < Cercania) && (BanderasVisibles[0])) || (((Math.Pow(BanderasCircunferencia[BanderasExperimento[1]].X - Coordenadas.X, 2) + Math.Pow(BanderasCircunferencia[BanderasExperimento[1]].Y - Coordenadas.Y, 2)) < Cercania) && (BanderasVisibles[1]));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr37Get() {
                this.GetValueTypeValues();
                return this.@__Expr37Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr38GetTree() {
                
                #line 1044 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                      IBanderaPar+1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr38Get() {
                
                #line 1044 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                      IBanderaPar+1;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr38Get() {
                this.GetValueTypeValues();
                return this.@__Expr38Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr40GetTree() {
                
                #line 1051 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                      (((Math.Pow(BanderasCircunferencia[BanderasExperimento[0]].X - Coordenadas.X, 2) + Math.Pow(BanderasCircunferencia[BanderasExperimento[0]].Y - Coordenadas.Y, 2)) < Cercania) && (BanderasVisibles[0]));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr40Get() {
                
                #line 1051 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                      (((Math.Pow(BanderasCircunferencia[BanderasExperimento[0]].X - Coordenadas.X, 2) + Math.Pow(BanderasCircunferencia[BanderasExperimento[0]].Y - Coordenadas.Y, 2)) < Cercania) && (BanderasVisibles[0]));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr40Get() {
                this.GetValueTypeValues();
                return this.@__Expr40Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr41GetTree() {
                
                #line 1058 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                          "H{ \"id\":\"" + (int)(BanderasExperimento[0]) + "\", \"visible\":\"false\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr41Get() {
                
                #line 1058 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                          "H{ \"id\":\"" + (int)(BanderasExperimento[0]) + "\", \"visible\":\"false\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr41Get() {
                this.GetValueTypeValues();
                return this.@__Expr41Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr42GetTree() {
                
                #line 1068 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                                          Archivo;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr42Get() {
                
                #line 1068 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                          Archivo;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr42Get() {
                this.GetValueTypeValues();
                return this.@__Expr42Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr43GetTree() {
                
                #line 1064 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                            DateTime.Now.ToString() + ";" + Coordenadas.X + ";" + Coordenadas.Y + ";" + BanderasCircunferencia[BanderasExperimento[0]].X + ";" + BanderasCircunferencia[BanderasExperimento[0]].Y + ";" + BanderasExperimento[0]+";CAP";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr43Get() {
                
                #line 1064 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                            DateTime.Now.ToString() + ";" + Coordenadas.X + ";" + Coordenadas.Y + ";" + BanderasCircunferencia[BanderasExperimento[0]].X + ";" + BanderasCircunferencia[BanderasExperimento[0]].Y + ";" + BanderasExperimento[0]+";CAP";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr43Get() {
                this.GetValueTypeValues();
                return this.@__Expr43Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr45GetTree() {
                
                #line 1087 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                          "H{ \"id\":\"" + (int)(BanderasExperimento[1]) + "\", \"visible\":\"false\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr45Get() {
                
                #line 1087 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                          "H{ \"id\":\"" + (int)(BanderasExperimento[1]) + "\", \"visible\":\"false\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr45Get() {
                this.GetValueTypeValues();
                return this.@__Expr45Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr46GetTree() {
                
                #line 1097 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                                          Archivo;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr46Get() {
                
                #line 1097 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                          Archivo;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr46Get() {
                this.GetValueTypeValues();
                return this.@__Expr46Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr47GetTree() {
                
                #line 1093 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                            DateTime.Now.ToString() + ";" + Coordenadas.X + ";" + Coordenadas.Y + ";" + BanderasCircunferencia[BanderasExperimento[1]].X + ";" + BanderasCircunferencia[BanderasExperimento[1]].Y + ";" + BanderasExperimento[1]+";CAP";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr47Get() {
                
                #line 1093 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                            DateTime.Now.ToString() + ";" + Coordenadas.X + ";" + Coordenadas.Y + ";" + BanderasCircunferencia[BanderasExperimento[1]].X + ";" + BanderasCircunferencia[BanderasExperimento[1]].Y + ";" + BanderasExperimento[1]+";CAP";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr47Get() {
                this.GetValueTypeValues();
                return this.@__Expr47Get();
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
                return Activity1_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Activity1_TypedDataContext6 : Activity1_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Activity1_TypedDataContext6(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext6(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext6(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr51GetTree() {
                
                #line 278 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                              RtaCave;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr51Get() {
                
                #line 278 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                              RtaCave;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr51Get() {
                this.GetValueTypeValues();
                return this.@__Expr51Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr51Set(string value) {
                
                #line 278 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                
                                              RtaCave = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr51Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr51Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr53GetTree() {
                
                #line 285 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                                              Coordenadas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr53Get() {
                
                #line 285 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                              Coordenadas;
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr53Get() {
                this.GetValueTypeValues();
                return this.@__Expr53Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr53Set(System.Drawing.PointF value) {
                
                #line 285 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                
                                              Coordenadas = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr53Set(System.Drawing.PointF value) {
                this.GetValueTypeValues();
                this.@__Expr53Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr62GetTree() {
                
                #line 687 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                    Cursor;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr62Get() {
                
                #line 687 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                    Cursor;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr62Get() {
                this.GetValueTypeValues();
                return this.@__Expr62Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr62Set(int value) {
                
                #line 687 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                
                                                    Cursor = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr62Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr62Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr73GetTree() {
                
                #line 754 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                          medio;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr73Get() {
                
                #line 754 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                          medio;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr73Get() {
                this.GetValueTypeValues();
                return this.@__Expr73Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr73Set(int value) {
                
                #line 754 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                
                                                          medio = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr73Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr73Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr78GetTree() {
                
                #line 787 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                              NroPrueba;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr78Get() {
                
                #line 787 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                              NroPrueba;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr78Get() {
                this.GetValueTypeValues();
                return this.@__Expr78Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr78Set(int value) {
                
                #line 787 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                
                                              NroPrueba = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr78Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr78Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr79GetTree() {
                
                #line 799 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                              IBanderaPar;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr79Get() {
                
                #line 799 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                              IBanderaPar;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr79Get() {
                this.GetValueTypeValues();
                return this.@__Expr79Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr79Set(int value) {
                
                #line 799 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                
                                              IBanderaPar = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr79Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr79Set(value);
                this.SetValueTypeValues();
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
                return Activity1_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Activity1_TypedDataContext6_ForReadOnly : Activity1_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Activity1_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr49GetTree() {
                
                #line 267 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                                      Archivo;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr49Get() {
                
                #line 267 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
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
                
                #line 263 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                        DateTime.Now.ToString()+";"+Coordenadas.X+";"+Coordenadas.Y+";"+"NULL;NULL;NULL;CEN";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr50Get() {
                
                #line 263 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                        DateTime.Now.ToString()+";"+Coordenadas.X+";"+Coordenadas.Y+";"+"NULL;NULL;NULL;CEN";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr50Get() {
                this.GetValueTypeValues();
                return this.@__Expr50Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr52GetTree() {
                
                #line 290 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                                              new PointF(Single.Parse(RtaCave.Split(';')[0].Replace(".", ",")), Single.Parse(RtaCave.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr52Get() {
                
                #line 290 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                              new PointF(Single.Parse(RtaCave.Split(';')[0].Replace(".", ",")), Single.Parse(RtaCave.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr52Get() {
                this.GetValueTypeValues();
                return this.@__Expr52Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr54GetTree() {
                
                #line 300 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                      !((Math.Pow(Coordenadas.X-Cruz.X, 2) + Math.Pow(Coordenadas.Y-Cruz.Y, 2)) < Cercania);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr54Get() {
                
                #line 300 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                      !((Math.Pow(Coordenadas.X-Cruz.X, 2) + Math.Pow(Coordenadas.Y-Cruz.Y, 2)) < Cercania);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr54Get() {
                this.GetValueTypeValues();
                return this.@__Expr54Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr55GetTree() {
                
                #line 324 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                      ((Math.Pow(Coordenadas.X - Cruz.X, 2) + Math.Pow(Coordenadas.Y - Cruz.Y, 2)) < Cercania) && (NroPrueba < Angulo.Length) && (IBanderaPar < 2);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr55Get() {
                
                #line 324 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                      ((Math.Pow(Coordenadas.X - Cruz.X, 2) + Math.Pow(Coordenadas.Y - Cruz.Y, 2)) < Cercania) && (NroPrueba < Angulo.Length) && (IBanderaPar < 2);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr55Get() {
                this.GetValueTypeValues();
                return this.@__Expr55Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr56GetTree() {
                
                #line 308 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                            "X{ \"value\":\"rojo\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr56Get() {
                
                #line 308 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                            "X{ \"value\":\"rojo\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr56Get() {
                this.GetValueTypeValues();
                return this.@__Expr56Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr57GetTree() {
                
                #line 313 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<System.TimeSpan>> expression = () => 
                                            TimeSpan.FromSeconds(2);;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.TimeSpan @__Expr57Get() {
                
                #line 313 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                            TimeSpan.FromSeconds(2);;
                
                #line default
                #line hidden
            }
            
            public System.TimeSpan ValueType___Expr57Get() {
                this.GetValueTypeValues();
                return this.@__Expr57Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr58GetTree() {
                
                #line 318 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                            "X{ \"value\":\"negro\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr58Get() {
                
                #line 318 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                            "X{ \"value\":\"negro\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr58Get() {
                this.GetValueTypeValues();
                return this.@__Expr58Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr59GetTree() {
                
                #line 329 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                      ((Math.Pow(Coordenadas.X-Cruz.X, 2) + Math.Pow(Coordenadas.Y-Cruz.Y, 2)) < Cercania) && (TestMemoria.Equals("N")) && (IBanderaPar==2);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr59Get() {
                
                #line 329 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                      ((Math.Pow(Coordenadas.X-Cruz.X, 2) + Math.Pow(Coordenadas.Y-Cruz.Y, 2)) < Cercania) && (TestMemoria.Equals("N")) && (IBanderaPar==2);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr59Get() {
                this.GetValueTypeValues();
                return this.@__Expr59Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr60GetTree() {
                
                #line 809 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                      ((Math.Pow(Coordenadas.X-Cruz.X, 2) + Math.Pow(Coordenadas.Y-Cruz.Y, 2)) < Cercania)&&(IBanderaPar == 2) && (Angulo.Length > NroPrueba) && (NroProtocolo!=3);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr60Get() {
                
                #line 809 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                      ((Math.Pow(Coordenadas.X-Cruz.X, 2) + Math.Pow(Coordenadas.Y-Cruz.Y, 2)) < Cercania)&&(IBanderaPar == 2) && (Angulo.Length > NroPrueba) && (NroProtocolo!=3);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr60Get() {
                this.GetValueTypeValues();
                return this.@__Expr60Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr61GetTree() {
                
                #line 679 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                              NroProtocolo.Equals(2);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr61Get() {
                
                #line 679 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                              NroProtocolo.Equals(2);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr61Get() {
                this.GetValueTypeValues();
                return this.@__Expr61Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr63GetTree() {
                
                #line 696 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                  "Q{ \"text\":\"Escucha la consigna\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr63Get() {
                
                #line 696 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                  "Q{ \"text\":\"Escucha la consigna\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr63Get() {
                this.GetValueTypeValues();
                return this.@__Expr63Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr64GetTree() {
                
                #line 701 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<System.TimeSpan>> expression = () => 
                                                  TimeSpan.FromSeconds(4);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.TimeSpan @__Expr64Get() {
                
                #line 701 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                  TimeSpan.FromSeconds(4);
                
                #line default
                #line hidden
            }
            
            public System.TimeSpan ValueType___Expr64Get() {
                this.GetValueTypeValues();
                return this.@__Expr64Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr65GetTree() {
                
                #line 707 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                  "Q{ \"text\":\" \" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr65Get() {
                
                #line 707 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                  "Q{ \"text\":\" \" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr65Get() {
                this.GetValueTypeValues();
                return this.@__Expr65Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr66GetTree() {
                
                #line 712 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                  Mostrar180;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr66Get() {
                
                #line 712 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                  Mostrar180;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr66Get() {
                this.GetValueTypeValues();
                return this.@__Expr66Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr67GetTree() {
                
                #line 721 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                  "Q{ \"text\":\"Esta la bandera en una nueva posicion?\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr67Get() {
                
                #line 721 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                  "Q{ \"text\":\"Esta la bandera en una nueva posicion?\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr67Get() {
                this.GetValueTypeValues();
                return this.@__Expr67Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr68GetTree() {
                
                #line 727 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                    Protocolo_P1[NroPrueba]==1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr68Get() {
                
                #line 727 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                    Protocolo_P1[NroPrueba]==1;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr68Get() {
                this.GetValueTypeValues();
                return this.@__Expr68Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr69GetTree() {
                
                #line 739 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                                                        Archivo;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr69Get() {
                
                #line 739 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                        Archivo;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr69Get() {
                this.GetValueTypeValues();
                return this.@__Expr69Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr70GetTree() {
                
                #line 735 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                          DateTime.Now.ToString() + ";" + Coordenadas.X + ";" + Coordenadas.Y + ";" + BanderasCircunferencia[BanderasExperimento[0]].X + ";" + BanderasCircunferencia[BanderasExperimento[0]].Y + ";" + BanderasExperimento[0] + ";MOS";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr70Get() {
                
                #line 735 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                          DateTime.Now.ToString() + ";" + Coordenadas.X + ";" + Coordenadas.Y + ";" + BanderasCircunferencia[BanderasExperimento[0]].X + ";" + BanderasCircunferencia[BanderasExperimento[0]].Y + ";" + BanderasExperimento[0] + ";MOS";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr70Get() {
                this.GetValueTypeValues();
                return this.@__Expr70Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr71GetTree() {
                
                #line 744 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                        "H{ \"id\":\"" + (int)(BanderasExperimento[0]) + "\", \"visible\":\"true\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr71Get() {
                
                #line 744 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                        "H{ \"id\":\"" + (int)(BanderasExperimento[0]) + "\", \"visible\":\"true\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr71Get() {
                this.GetValueTypeValues();
                return this.@__Expr71Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr72GetTree() {
                
                #line 759 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                          Math.Abs(BanderasExperimento[0] + BanderasExperimento[1]) / 2;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr72Get() {
                
                #line 759 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                          Math.Abs(BanderasExperimento[0] + BanderasExperimento[1]) / 2;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr72Get() {
                this.GetValueTypeValues();
                return this.@__Expr72Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr74GetTree() {
                
                #line 770 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                                                        Archivo;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr74Get() {
                
                #line 770 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                        Archivo;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr74Get() {
                this.GetValueTypeValues();
                return this.@__Expr74Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr75GetTree() {
                
                #line 766 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                          DateTime.Now.ToString() + ";" + Coordenadas.X + ";" + Coordenadas.Y + ";" + BanderasCircunferencia[medio].X + ";" + BanderasCircunferencia[medio].Y + ";" + medio+ ";MOS";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr75Get() {
                
                #line 766 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                          DateTime.Now.ToString() + ";" + Coordenadas.X + ";" + Coordenadas.Y + ";" + BanderasCircunferencia[medio].X + ";" + BanderasCircunferencia[medio].Y + ";" + medio+ ";MOS";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr75Get() {
                this.GetValueTypeValues();
                return this.@__Expr75Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr76GetTree() {
                
                #line 775 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                        "H{ \"id\":\"" + (int)(medio) + "\", \"visible\":\"true\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr76Get() {
                
                #line 775 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                        "H{ \"id\":\"" + (int)(medio) + "\", \"visible\":\"true\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr76Get() {
                this.GetValueTypeValues();
                return this.@__Expr76Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr77GetTree() {
                
                #line 792 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                              NroPrueba+1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr77Get() {
                
                #line 792 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                              NroPrueba+1;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr77Get() {
                this.GetValueTypeValues();
                return this.@__Expr77Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr80GetTree() {
                
                #line 1028 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                      ((Math.Pow(Coordenadas.X - Cruz.X, 2) + Math.Pow(Coordenadas.Y - Cruz.Y, 2)) < Cercania) && (IBanderaPar == 2) && (Angulo.Length > NroPrueba) && (NroProtocolo.Equals(3));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr80Get() {
                
                #line 1028 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                      ((Math.Pow(Coordenadas.X - Cruz.X, 2) + Math.Pow(Coordenadas.Y - Cruz.Y, 2)) < Cercania) && (IBanderaPar == 2) && (Angulo.Length > NroPrueba) && (NroProtocolo.Equals(3));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr80Get() {
                this.GetValueTypeValues();
                return this.@__Expr80Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr81GetTree() {
                
                #line 1011 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                            "Q{ \"text\":\"Coloca la bandera\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr81Get() {
                
                #line 1011 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                            "Q{ \"text\":\"Coloca la bandera\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr81Get() {
                this.GetValueTypeValues();
                return this.@__Expr81Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr82GetTree() {
                
                #line 1016 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<System.TimeSpan>> expression = () => 
                                            TimeSpan.FromSeconds(4);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.TimeSpan @__Expr82Get() {
                
                #line 1016 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                            TimeSpan.FromSeconds(4);
                
                #line default
                #line hidden
            }
            
            public System.TimeSpan ValueType___Expr82Get() {
                this.GetValueTypeValues();
                return this.@__Expr82Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr83GetTree() {
                
                #line 1022 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                            "Q{ \"text\":\" \" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr83Get() {
                
                #line 1022 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                            "Q{ \"text\":\" \" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr83Get() {
                this.GetValueTypeValues();
                return this.@__Expr83Get();
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
                return Activity1_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Activity1_TypedDataContext7 : Activity1_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Activity1_TypedDataContext7(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext7(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext7(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                
                #line 389 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                      RtaCave;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr86Get() {
                
                #line 389 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
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
                
                #line 389 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                
                                                      RtaCave = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr86Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr86Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr92GetTree() {
                
                #line 423 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                Cursor;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr92Get() {
                
                #line 423 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                                Cursor;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr92Get() {
                this.GetValueTypeValues();
                return this.@__Expr92Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr92Set(int value) {
                
                #line 423 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                
                                                                Cursor = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr92Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr92Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr95GetTree() {
                
                #line 442 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                    Cursor;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr95Get() {
                
                #line 442 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                                    Cursor;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr95Get() {
                this.GetValueTypeValues();
                return this.@__Expr95Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr95Set(int value) {
                
                #line 442 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                
                                                                    Cursor = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr95Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr95Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr97GetTree() {
                
                #line 459 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                              Cursor;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr97Get() {
                
                #line 459 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                              Cursor;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr97Get() {
                this.GetValueTypeValues();
                return this.@__Expr97Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr97Set(int value) {
                
                #line 459 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                
                                                              Cursor = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr97Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr97Set(value);
                this.SetValueTypeValues();
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
                return Activity1_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Activity1_TypedDataContext7_ForReadOnly : Activity1_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Activity1_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr84GetTree() {
                
                #line 368 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                NroProtocolo.Equals(2);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr84Get() {
                
                #line 368 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                NroProtocolo.Equals(2);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr84Get() {
                this.GetValueTypeValues();
                return this.@__Expr84Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr85GetTree() {
                
                #line 375 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    "C{ \"id\":\"" + (int)(Cursor) + "\", \"color\":\"" + ColorSeleccion + "\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr85Get() {
                
                #line 375 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
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
                
                #line 475 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                              (RtaCave.Equals("1") && (NroProtocolo == 2)) || RtaCave.Equals("3");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr87Get() {
                
                #line 475 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                              (RtaCave.Equals("1") && (NroProtocolo == 2)) || RtaCave.Equals("3");
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr87Get() {
                this.GetValueTypeValues();
                return this.@__Expr87Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr88GetTree() {
                
                #line 402 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                    NroProtocolo==2;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr88Get() {
                
                #line 402 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                    NroProtocolo==2;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr88Get() {
                this.GetValueTypeValues();
                return this.@__Expr88Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr89GetTree() {
                
                #line 409 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                        "C{ \"id\":\"" + (int)(Cursor) + "\", \"color\":\"" + ColorBandera + "\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr89Get() {
                
                #line 409 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                        "C{ \"id\":\"" + (int)(Cursor) + "\", \"color\":\"" + ColorBandera + "\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr89Get() {
                this.GetValueTypeValues();
                return this.@__Expr89Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr90GetTree() {
                
                #line 415 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                          RtaCave.Equals("1");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr90Get() {
                
                #line 415 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                          RtaCave.Equals("1");
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr90Get() {
                this.GetValueTypeValues();
                return this.@__Expr90Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr91GetTree() {
                
                #line 428 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                (Cursor - 1) % BanderasCircunferencia.Count;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr91Get() {
                
                #line 428 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                                (Cursor - 1) % BanderasCircunferencia.Count;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr91Get() {
                this.GetValueTypeValues();
                return this.@__Expr91Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr93GetTree() {
                
                #line 435 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                Cursor<0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr93Get() {
                
                #line 435 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                                Cursor<0;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr93Get() {
                this.GetValueTypeValues();
                return this.@__Expr93Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr94GetTree() {
                
                #line 447 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                    BanderasCircunferencia.Count-1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr94Get() {
                
                #line 447 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                                    BanderasCircunferencia.Count-1;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr94Get() {
                this.GetValueTypeValues();
                return this.@__Expr94Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr96GetTree() {
                
                #line 464 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                              (Cursor + 1) % BanderasCircunferencia.Count;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr96Get() {
                
                #line 464 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                              (Cursor + 1) % BanderasCircunferencia.Count;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr96Get() {
                this.GetValueTypeValues();
                return this.@__Expr96Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr98GetTree() {
                
                #line 480 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                              (RtaCave.Equals("2") || ((RtaCave.Equals("1") && NroProtocolo == 1)));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr98Get() {
                
                #line 480 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                              (RtaCave.Equals("2") || ((RtaCave.Equals("1") && NroProtocolo == 1)));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr98Get() {
                this.GetValueTypeValues();
                return this.@__Expr98Get();
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
                return Activity1_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Activity1_TypedDataContext8 : Activity1_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Activity1_TypedDataContext8(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext8(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext8(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                            && (locationReferences.Count < 25))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 25);
                }
                expectedLocationsCount = 25;
                return Activity1_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Activity1_TypedDataContext8_ForReadOnly : Activity1_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Activity1_TypedDataContext8_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext8_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext8_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr99GetTree() {
                
                #line 337 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                "Q{ \"text\":\"Fin del experimento\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr99Get() {
                
                #line 337 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                "Q{ \"text\":\"Fin del experimento\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr99Get() {
                this.GetValueTypeValues();
                return this.@__Expr99Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr100GetTree() {
                
                #line 347 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                                                Archivo;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr100Get() {
                
                #line 347 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                Archivo;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr100Get() {
                this.GetValueTypeValues();
                return this.@__Expr100Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr101GetTree() {
                
                #line 343 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                  DateTime.Now.ToString()+";"+Coordenadas.X+";"+Coordenadas.Y+";"+"NULL;NULL;NULL;FIN";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr101Get() {
                
                #line 343 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                  DateTime.Now.ToString()+";"+Coordenadas.X+";"+Coordenadas.Y+";"+"NULL;NULL;NULL;FIN";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr101Get() {
                this.GetValueTypeValues();
                return this.@__Expr101Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr102GetTree() {
                
                #line 352 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<System.TimeSpan>> expression = () => 
                                                TimeSpan.FromSeconds(5);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.TimeSpan @__Expr102Get() {
                
                #line 352 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                TimeSpan.FromSeconds(5);
                
                #line default
                #line hidden
            }
            
            public System.TimeSpan ValueType___Expr102Get() {
                this.GetValueTypeValues();
                return this.@__Expr102Get();
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
                return Activity1_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Activity1_TypedDataContext9 : Activity1_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Activity1_TypedDataContext9(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext9(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext9(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr122GetTree() {
                
                #line 637 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                              RtaCave;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr122Get() {
                
                #line 637 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                              RtaCave;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr122Get() {
                this.GetValueTypeValues();
                return this.@__Expr122Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr122Set(string value) {
                
                #line 637 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                
                                                              RtaCave = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr122Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr122Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr124GetTree() {
                
                #line 644 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                                                              Coordenadas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr124Get() {
                
                #line 644 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                              Coordenadas;
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr124Get() {
                this.GetValueTypeValues();
                return this.@__Expr124Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr124Set(System.Drawing.PointF value) {
                
                #line 644 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                
                                                              Coordenadas = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr124Set(System.Drawing.PointF value) {
                this.GetValueTypeValues();
                this.@__Expr124Set(value);
                this.SetValueTypeValues();
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
                return Activity1_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Activity1_TypedDataContext9_ForReadOnly : Activity1_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Activity1_TypedDataContext9_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext9_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext9_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr103GetTree() {
                
                #line 489 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                          NroProtocolo.Equals(1);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr103Get() {
                
                #line 489 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                          NroProtocolo.Equals(1);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr103Get() {
                this.GetValueTypeValues();
                return this.@__Expr103Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr104GetTree() {
                
                #line 496 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                              Protocolo_P1[NroPrueba-1]==1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr104Get() {
                
                #line 496 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                              Protocolo_P1[NroPrueba-1]==1;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr104Get() {
                this.GetValueTypeValues();
                return this.@__Expr104Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr105GetTree() {
                
                #line 503 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                  "H{ \"id\":\"" + (int)(BanderasExperimento[0]) + "\", \"visible\":\"false\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr105Get() {
                
                #line 503 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                                  "H{ \"id\":\"" + (int)(BanderasExperimento[0]) + "\", \"visible\":\"false\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr105Get() {
                this.GetValueTypeValues();
                return this.@__Expr105Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr106GetTree() {
                
                #line 509 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                    RtaCave.Equals("1");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr106Get() {
                
                #line 509 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                                    RtaCave.Equals("1");
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr106Get() {
                this.GetValueTypeValues();
                return this.@__Expr106Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr107GetTree() {
                
                #line 521 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                                                                        Archivo;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr107Get() {
                
                #line 521 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                                        Archivo;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr107Get() {
                this.GetValueTypeValues();
                return this.@__Expr107Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr108GetTree() {
                
                #line 517 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                          DateTime.Now.ToString() + ";" + Coordenadas.X + ";" + Coordenadas.Y + ";NULL;NULL;NO;SEL";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr108Get() {
                
                #line 517 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                                          DateTime.Now.ToString() + ";" + Coordenadas.X + ";" + Coordenadas.Y + ";NULL;NULL;NO;SEL";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr108Get() {
                this.GetValueTypeValues();
                return this.@__Expr108Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr109GetTree() {
                
                #line 535 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                                                                        Archivo;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr109Get() {
                
                #line 535 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                                        Archivo;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr109Get() {
                this.GetValueTypeValues();
                return this.@__Expr109Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr110GetTree() {
                
                #line 531 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                          DateTime.Now.ToString()+";"+Coordenadas.X+";"+Coordenadas.Y+";NULL;NULL;OK;SEL";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr110Get() {
                
                #line 531 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                                          DateTime.Now.ToString()+";"+Coordenadas.X+";"+Coordenadas.Y+";NULL;NULL;OK;SEL";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr110Get() {
                this.GetValueTypeValues();
                return this.@__Expr110Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr111GetTree() {
                
                #line 547 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                  "H{ \"id\":\"" + (int)(medio) + "\", \"visible\":\"false\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr111Get() {
                
                #line 547 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                                  "H{ \"id\":\"" + (int)(medio) + "\", \"visible\":\"false\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr111Get() {
                this.GetValueTypeValues();
                return this.@__Expr111Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr112GetTree() {
                
                #line 553 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                    RtaCave.Equals("2");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr112Get() {
                
                #line 553 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                                    RtaCave.Equals("2");
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr112Get() {
                this.GetValueTypeValues();
                return this.@__Expr112Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr113GetTree() {
                
                #line 565 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                                                                        Archivo;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr113Get() {
                
                #line 565 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                                        Archivo;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr113Get() {
                this.GetValueTypeValues();
                return this.@__Expr113Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr114GetTree() {
                
                #line 561 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                          DateTime.Now.ToString()+";"+Coordenadas.X+";"+Coordenadas.Y+";NULL;NULL;OK;SEL";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr114Get() {
                
                #line 561 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                                          DateTime.Now.ToString()+";"+Coordenadas.X+";"+Coordenadas.Y+";NULL;NULL;OK;SEL";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr114Get() {
                this.GetValueTypeValues();
                return this.@__Expr114Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr115GetTree() {
                
                #line 579 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                                                                        Archivo;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr115Get() {
                
                #line 579 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                                        Archivo;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr115Get() {
                this.GetValueTypeValues();
                return this.@__Expr115Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr116GetTree() {
                
                #line 575 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                          DateTime.Now.ToString()+";"+Coordenadas.X+";"+Coordenadas.Y+";NULL;NULL;NO;SEL";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr116Get() {
                
                #line 575 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                                          DateTime.Now.ToString()+";"+Coordenadas.X+";"+Coordenadas.Y+";NULL;NULL;NO;SEL";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr116Get() {
                this.GetValueTypeValues();
                return this.@__Expr116Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr117GetTree() {
                
                #line 594 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                NroProtocolo.Equals(2);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr117Get() {
                
                #line 594 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                                NroProtocolo.Equals(2);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr117Get() {
                this.GetValueTypeValues();
                return this.@__Expr117Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr118GetTree() {
                
                #line 606 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                                                                    Archivo;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr118Get() {
                
                #line 606 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                                    Archivo;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr118Get() {
                this.GetValueTypeValues();
                return this.@__Expr118Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr119GetTree() {
                
                #line 602 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                      DateTime.Now.ToString() + ";" + Coordenadas.X + ";" + Coordenadas.Y + ";" + BanderasCircunferencia.ElementAt(Cursor).X + ";" + BanderasCircunferencia.ElementAt(Cursor).Y + ";" + Cursor + ";SEL";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr119Get() {
                
                #line 602 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                                      DateTime.Now.ToString() + ";" + Coordenadas.X + ";" + Coordenadas.Y + ";" + BanderasCircunferencia.ElementAt(Cursor).X + ";" + BanderasCircunferencia.ElementAt(Cursor).Y + ";" + Cursor + ";SEL";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr119Get() {
                this.GetValueTypeValues();
                return this.@__Expr119Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr120GetTree() {
                
                #line 611 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                    "C{ \"id\":\"" + (int)(Cursor) + "\", \"color\":\"" + ColorBandera + "\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr120Get() {
                
                #line 611 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                                    "C{ \"id\":\"" + (int)(Cursor) + "\", \"color\":\"" + ColorBandera + "\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr120Get() {
                this.GetValueTypeValues();
                return this.@__Expr120Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr121GetTree() {
                
                #line 616 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                    Mostrar180.Replace("true", "false");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr121Get() {
                
                #line 616 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                                    Mostrar180.Replace("true", "false");
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr121Get() {
                this.GetValueTypeValues();
                return this.@__Expr121Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr123GetTree() {
                
                #line 649 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                                                              new PointF(Single.Parse(RtaCave.Split(';')[0].Replace(".", ",")), Single.Parse(RtaCave.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr123Get() {
                
                #line 649 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                              new PointF(Single.Parse(RtaCave.Split(';')[0].Replace(".", ",")), Single.Parse(RtaCave.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr123Get() {
                this.GetValueTypeValues();
                return this.@__Expr123Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr125GetTree() {
                
                #line 659 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                      (Angulo.Length > NroPrueba);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr125Get() {
                
                #line 659 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                      (Angulo.Length > NroPrueba);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr125Get() {
                this.GetValueTypeValues();
                return this.@__Expr125Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr126GetTree() {
                
                #line 664 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                      (Angulo.Length <= NroPrueba);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr126Get() {
                
                #line 664 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                      (Angulo.Length <= NroPrueba);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr126Get() {
                this.GetValueTypeValues();
                return this.@__Expr126Get();
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
                return Activity1_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Activity1_TypedDataContext10 : Activity1_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Activity1_TypedDataContext10(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext10(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext10(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr129GetTree() {
                
                #line 834 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                      RtaCave;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr129Get() {
                
                #line 834 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                      RtaCave;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr129Get() {
                this.GetValueTypeValues();
                return this.@__Expr129Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr129Set(string value) {
                
                #line 834 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                
                                                      RtaCave = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr129Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr129Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr135GetTree() {
                
                #line 935 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                      idNueva;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr135Get() {
                
                #line 935 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                      idNueva;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr135Get() {
                this.GetValueTypeValues();
                return this.@__Expr135Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr135Set(int value) {
                
                #line 935 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                
                                                      idNueva = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr135Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr135Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr143GetTree() {
                
                #line 986 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                                                            Coordenadas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr143Get() {
                
                #line 986 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                            Coordenadas;
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr143Get() {
                this.GetValueTypeValues();
                return this.@__Expr143Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr143Set(System.Drawing.PointF value) {
                
                #line 986 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                
                                                            Coordenadas = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr143Set(System.Drawing.PointF value) {
                this.GetValueTypeValues();
                this.@__Expr143Set(value);
                this.SetValueTypeValues();
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
                return Activity1_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Activity1_TypedDataContext10_ForReadOnly : Activity1_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Activity1_TypedDataContext10_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext10_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext10_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr127GetTree() {
                
                #line 823 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                                              Archivo;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr127Get() {
                
                #line 823 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                              Archivo;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr127Get() {
                this.GetValueTypeValues();
                return this.@__Expr127Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr128GetTree() {
                
                #line 819 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                DateTime.Now.ToString()+";"+Coordenadas.X+";"+Coordenadas.Y+";NULL;NULL;NULL;DEP";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr128Get() {
                
                #line 819 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                DateTime.Now.ToString()+";"+Coordenadas.X+";"+Coordenadas.Y+";NULL;NULL;NULL;DEP";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr128Get() {
                this.GetValueTypeValues();
                return this.@__Expr128Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr130GetTree() {
                
                #line 969 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                              RtaCave.Equals("2");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr130Get() {
                
                #line 969 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                              RtaCave.Equals("2");
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr130Get() {
                this.GetValueTypeValues();
                return this.@__Expr130Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr131GetTree() {
                
                #line 924 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                                                    Archivo;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr131Get() {
                
                #line 924 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                    Archivo;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr131Get() {
                this.GetValueTypeValues();
                return this.@__Expr131Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr132GetTree() {
                
                #line 920 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                      DateTime.Now.ToString() + ";" + Coordenadas.X + ";" + Coordenadas.Y + ";" + Coordenadas.X + ";" + Coordenadas.Y + ";null;COL";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr132Get() {
                
                #line 920 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                      DateTime.Now.ToString() + ";" + Coordenadas.X + ";" + Coordenadas.Y + ";" + Coordenadas.X + ";" + Coordenadas.Y + ";null;COL";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr132Get() {
                this.GetValueTypeValues();
                return this.@__Expr132Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr133GetTree() {
                
                #line 929 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    "A{ \"id\":\"" + idNueva + "\", \"color\":\"" + ColorBandera + "\", \"x\":\"" + Coordenadas.X.ToString(System.Globalization.CultureInfo.InvariantCulture).Replace(",", ".") + "\", \"y\":\"" + Coordenadas.Y.ToString(System.Globalization.CultureInfo.InvariantCulture).Replace(",", ".") + "\", \"visible\":\"true\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr133Get() {
                
                #line 929 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                    "A{ \"id\":\"" + idNueva + "\", \"color\":\"" + ColorBandera + "\", \"x\":\"" + Coordenadas.X.ToString(System.Globalization.CultureInfo.InvariantCulture).Replace(",", ".") + "\", \"y\":\"" + Coordenadas.Y.ToString(System.Globalization.CultureInfo.InvariantCulture).Replace(",", ".") + "\", \"visible\":\"true\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr133Get() {
                this.GetValueTypeValues();
                return this.@__Expr133Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr134GetTree() {
                
                #line 940 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                      idNueva+1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr134Get() {
                
                #line 940 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                      idNueva+1;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr134Get() {
                this.GetValueTypeValues();
                return this.@__Expr134Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr136GetTree() {
                
                #line 947 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<System.TimeSpan>> expression = () => 
                                                    TimeSpan.FromSeconds(2);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.TimeSpan @__Expr136Get() {
                
                #line 947 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                    TimeSpan.FromSeconds(2);
                
                #line default
                #line hidden
            }
            
            public System.TimeSpan ValueType___Expr136Get() {
                this.GetValueTypeValues();
                return this.@__Expr136Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr137GetTree() {
                
                #line 952 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    "Q{ \"text\":\"Confirma la posicion (Y)\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr137Get() {
                
                #line 952 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                    "Q{ \"text\":\"Confirma la posicion (Y)\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr137Get() {
                this.GetValueTypeValues();
                return this.@__Expr137Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr138GetTree() {
                
                #line 957 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<System.TimeSpan>> expression = () => 
                                                    TimeSpan.FromSeconds(2);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.TimeSpan @__Expr138Get() {
                
                #line 957 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                    TimeSpan.FromSeconds(2);
                
                #line default
                #line hidden
            }
            
            public System.TimeSpan ValueType___Expr138Get() {
                this.GetValueTypeValues();
                return this.@__Expr138Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr139GetTree() {
                
                #line 963 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    "Q{ \"text\":\" \" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr139Get() {
                
                #line 963 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                    "Q{ \"text\":\" \" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr139Get() {
                this.GetValueTypeValues();
                return this.@__Expr139Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr140GetTree() {
                
                #line 1001 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                              !RtaCave.Equals("2");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr140Get() {
                
                #line 1001 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                              !RtaCave.Equals("2");
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr140Get() {
                this.GetValueTypeValues();
                return this.@__Expr140Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr141GetTree() {
                
                #line 978 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                      !RtaCave.Equals("1") && !RtaCave.Equals("3") && !RtaCave.Equals("4");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr141Get() {
                
                #line 978 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                      !RtaCave.Equals("1") && !RtaCave.Equals("3") && !RtaCave.Equals("4");
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr141Get() {
                this.GetValueTypeValues();
                return this.@__Expr141Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr142GetTree() {
                
                #line 991 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                                                            new PointF(Single.Parse(RtaCave.Split(';')[0].Replace(".", ",")), Single.Parse(RtaCave.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr142Get() {
                
                #line 991 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                            new PointF(Single.Parse(RtaCave.Split(';')[0].Replace(".", ",")), Single.Parse(RtaCave.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr142Get() {
                this.GetValueTypeValues();
                return this.@__Expr142Get();
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
                return Activity1_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Activity1_TypedDataContext11 : Activity1_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Activity1_TypedDataContext11(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext11(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext11(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr146GetTree() {
                
                #line 861 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                              RtaCave;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr146Get() {
                
                #line 861 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
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
                
                #line 861 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                
                                                              RtaCave = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr146Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr146Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr150GetTree() {
                
                #line 880 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                              NroPrueba;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr150Get() {
                
                #line 880 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                              NroPrueba;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr150Get() {
                this.GetValueTypeValues();
                return this.@__Expr150Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr150Set(int value) {
                
                #line 880 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                
                                                              NroPrueba = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr150Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr150Set(value);
                this.SetValueTypeValues();
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
                return Activity1_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Activity1_TypedDataContext11_ForReadOnly : Activity1_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Activity1_TypedDataContext11_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext11_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext11_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr144GetTree() {
                
                #line 850 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                                                      Archivo;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr144Get() {
                
                #line 850 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                      Archivo;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr144Get() {
                this.GetValueTypeValues();
                return this.@__Expr144Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr145GetTree() {
                
                #line 846 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                        DateTime.Now.ToString() + ";" + Coordenadas.X + ";" + Coordenadas.Y + ";" + BanderasCircunferencia.ElementAt(Cursor).X + ";" + BanderasCircunferencia.ElementAt(Cursor).Y + ";" + Cursor + ";CON";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr145Get() {
                
                #line 846 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                        DateTime.Now.ToString() + ";" + Coordenadas.X + ";" + Coordenadas.Y + ";" + BanderasCircunferencia.ElementAt(Cursor).X + ";" + BanderasCircunferencia.ElementAt(Cursor).Y + ";" + Cursor + ";CON";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr145Get() {
                this.GetValueTypeValues();
                return this.@__Expr145Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr147GetTree() {
                
                #line 892 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                      (RtaCave.Equals("1"));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr147Get() {
                
                #line 892 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                      (RtaCave.Equals("1"));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr147Get() {
                this.GetValueTypeValues();
                return this.@__Expr147Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr148GetTree() {
                
                #line 874 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                            "H{ \"id\":\"" + (int)(idNueva-1) + "\", \"visible\":\"false\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr148Get() {
                
                #line 874 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                            "H{ \"id\":\"" + (int)(idNueva-1) + "\", \"visible\":\"false\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr148Get() {
                this.GetValueTypeValues();
                return this.@__Expr148Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr149GetTree() {
                
                #line 885 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                              NroPrueba+1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr149Get() {
                
                #line 885 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                              NroPrueba+1;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr149Get() {
                this.GetValueTypeValues();
                return this.@__Expr149Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr151GetTree() {
                
                #line 904 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                      (RtaCave.Equals("2"));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr151Get() {
                
                #line 904 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                      (RtaCave.Equals("2"));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr151Get() {
                this.GetValueTypeValues();
                return this.@__Expr151Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr152GetTree() {
                
                #line 899 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                          "H{ \"id\":\"" + (int)(idNueva-1) + "\", \"visible\":\"false\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr152Get() {
                
                #line 899 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                          "H{ \"id\":\"" + (int)(idNueva-1) + "\", \"visible\":\"false\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr152Get() {
                this.GetValueTypeValues();
                return this.@__Expr152Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr153GetTree() {
                
                #line 909 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                      !(RtaCave.Equals("2")) && !(RtaCave.Equals("1"));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr153Get() {
                
                #line 909 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\PROTOCOLOSIMPLE\ACTIVITY1.XAML"
                return 
                                                      !(RtaCave.Equals("2")) && !(RtaCave.Equals("1"));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr153Get() {
                this.GetValueTypeValues();
                return this.@__Expr153Get();
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
                return Activity1_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
