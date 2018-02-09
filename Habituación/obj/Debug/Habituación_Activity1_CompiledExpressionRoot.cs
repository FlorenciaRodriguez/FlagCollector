namespace Habituación {
    
    #line 27 "C:\Users\DellPladema\Desktop\Nueva carpeta (2)\VFinal\WFFlagCollector\FlagCollector\Habituación\HabituacionWF.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\DellPladema\Desktop\Nueva carpeta (2)\VFinal\WFFlagCollector\FlagCollector\Habituación\HabituacionWF.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 28 "C:\Users\DellPladema\Desktop\Nueva carpeta (2)\VFinal\WFFlagCollector\FlagCollector\Habituación\HabituacionWF.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\DellPladema\Desktop\Nueva carpeta (2)\VFinal\WFFlagCollector\FlagCollector\Habituación\HabituacionWF.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\DellPladema\Desktop\Nueva carpeta (2)\VFinal\WFFlagCollector\FlagCollector\Habituación\HabituacionWF.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\DellPladema\Desktop\Nueva carpeta (2)\VFinal\WFFlagCollector\FlagCollector\Habituación\HabituacionWF.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 29 "C:\Users\DellPladema\Desktop\Nueva carpeta (2)\VFinal\WFFlagCollector\FlagCollector\Habituación\HabituacionWF.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 30 "C:\Users\DellPladema\Desktop\Nueva carpeta (2)\VFinal\WFFlagCollector\FlagCollector\Habituación\HabituacionWF.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 31 "C:\Users\DellPladema\Desktop\Nueva carpeta (2)\VFinal\WFFlagCollector\FlagCollector\Habituación\HabituacionWF.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 32 "C:\Users\DellPladema\Desktop\Nueva carpeta (2)\VFinal\WFFlagCollector\FlagCollector\Habituación\HabituacionWF.xaml"
    using System.Drawing;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\DellPladema\Desktop\Nueva carpeta (2)\VFinal\WFFlagCollector\FlagCollector\Habituación\HabituacionWF.xaml"
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
                this.dataContextActivities = Activity1_TypedDataContext4.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Activity1_TypedDataContext4(locations, activityContext, true);
                }
                Activity1_TypedDataContext4 refDataContext0 = ((Activity1_TypedDataContext4)(cachedCompiledDataContext[0]));
                return refDataContext0.GetLocation<int>(refDataContext0.ValueType___Expr0Get, refDataContext0.ValueType___Expr0Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Activity1_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext5_ForReadOnly valDataContext1 = ((Activity1_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Activity1_TypedDataContext5(locations, activityContext, true);
                }
                Activity1_TypedDataContext5 refDataContext2 = ((Activity1_TypedDataContext5)(cachedCompiledDataContext[2]));
                return refDataContext2.GetLocation<System.Collections.Generic.LinkedList<int>>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Activity1_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext5_ForReadOnly valDataContext3 = ((Activity1_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Activity1_TypedDataContext5(locations, activityContext, true);
                }
                Activity1_TypedDataContext5 refDataContext4 = ((Activity1_TypedDataContext5)(cachedCompiledDataContext[2]));
                return refDataContext4.GetLocation<System.Collections.Generic.LinkedList<System.Drawing.PointF>>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Activity1_TypedDataContext5(locations, activityContext, true);
                }
                Activity1_TypedDataContext5 refDataContext5 = ((Activity1_TypedDataContext5)(cachedCompiledDataContext[2]));
                return refDataContext5.GetLocation<int>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Activity1_TypedDataContext5(locations, activityContext, true);
                }
                Activity1_TypedDataContext5 refDataContext6 = ((Activity1_TypedDataContext5)(cachedCompiledDataContext[2]));
                return refDataContext6.GetLocation<int>(refDataContext6.ValueType___Expr6Get, refDataContext6.ValueType___Expr6Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Activity1_TypedDataContext5(locations, activityContext, true);
                }
                Activity1_TypedDataContext5 refDataContext7 = ((Activity1_TypedDataContext5)(cachedCompiledDataContext[2]));
                return refDataContext7.GetLocation<string>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Activity1_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext5_ForReadOnly valDataContext8 = ((Activity1_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Activity1_TypedDataContext5(locations, activityContext, true);
                }
                Activity1_TypedDataContext5 refDataContext9 = ((Activity1_TypedDataContext5)(cachedCompiledDataContext[2]));
                return refDataContext9.GetLocation<float>(refDataContext9.ValueType___Expr9Get, refDataContext9.ValueType___Expr9Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Activity1_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext5_ForReadOnly valDataContext10 = ((Activity1_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Activity1_TypedDataContext5(locations, activityContext, true);
                }
                Activity1_TypedDataContext5 refDataContext11 = ((Activity1_TypedDataContext5)(cachedCompiledDataContext[2]));
                return refDataContext11.GetLocation<float>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Activity1_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext5_ForReadOnly valDataContext12 = ((Activity1_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Activity1_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext5_ForReadOnly valDataContext13 = ((Activity1_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Activity1_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext5_ForReadOnly valDataContext14 = ((Activity1_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Activity1_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext5_ForReadOnly valDataContext15 = ((Activity1_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Activity1_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext5_ForReadOnly valDataContext16 = ((Activity1_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Activity1_TypedDataContext5(locations, activityContext, true);
                }
                Activity1_TypedDataContext5 refDataContext17 = ((Activity1_TypedDataContext5)(cachedCompiledDataContext[2]));
                return refDataContext17.GetLocation<string>(refDataContext17.ValueType___Expr17Get, refDataContext17.ValueType___Expr17Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 18)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Activity1_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext5_ForReadOnly valDataContext18 = ((Activity1_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext18.ValueType___Expr18Get();
            }
            if ((expressionId == 19)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Activity1_TypedDataContext5(locations, activityContext, true);
                }
                Activity1_TypedDataContext5 refDataContext19 = ((Activity1_TypedDataContext5)(cachedCompiledDataContext[2]));
                return refDataContext19.GetLocation<int>(refDataContext19.ValueType___Expr19Get, refDataContext19.ValueType___Expr19Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 20)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Activity1_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext5_ForReadOnly valDataContext20 = ((Activity1_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Activity1_TypedDataContext5(locations, activityContext, true);
                }
                Activity1_TypedDataContext5 refDataContext21 = ((Activity1_TypedDataContext5)(cachedCompiledDataContext[2]));
                return refDataContext21.GetLocation<int>(refDataContext21.ValueType___Expr21Get, refDataContext21.ValueType___Expr21Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 22)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Activity1_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext5_ForReadOnly valDataContext22 = ((Activity1_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Activity1_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext5_ForReadOnly valDataContext23 = ((Activity1_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext23.ValueType___Expr23Get();
            }
            if ((expressionId == 24)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Activity1_TypedDataContext5(locations, activityContext, true);
                }
                Activity1_TypedDataContext5 refDataContext24 = ((Activity1_TypedDataContext5)(cachedCompiledDataContext[2]));
                return refDataContext24.GetLocation<string>(refDataContext24.ValueType___Expr24Get, refDataContext24.ValueType___Expr24Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 25)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Activity1_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext5_ForReadOnly valDataContext25 = ((Activity1_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext25.ValueType___Expr25Get();
            }
            if ((expressionId == 26)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Activity1_TypedDataContext5(locations, activityContext, true);
                }
                Activity1_TypedDataContext5 refDataContext26 = ((Activity1_TypedDataContext5)(cachedCompiledDataContext[2]));
                return refDataContext26.GetLocation<string>(refDataContext26.ValueType___Expr26Get, refDataContext26.ValueType___Expr26Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 27)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Activity1_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext5_ForReadOnly valDataContext27 = ((Activity1_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext27.ValueType___Expr27Get();
            }
            if ((expressionId == 28)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Activity1_TypedDataContext5(locations, activityContext, true);
                }
                Activity1_TypedDataContext5 refDataContext28 = ((Activity1_TypedDataContext5)(cachedCompiledDataContext[2]));
                return refDataContext28.GetLocation<System.Collections.Generic.List<string>>(refDataContext28.ValueType___Expr28Get, refDataContext28.ValueType___Expr28Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 29)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Activity1_TypedDataContext6(locations, activityContext, true);
                }
                Activity1_TypedDataContext6 refDataContext29 = ((Activity1_TypedDataContext6)(cachedCompiledDataContext[3]));
                return refDataContext29.GetLocation<string>(refDataContext29.ValueType___Expr29Get, refDataContext29.ValueType___Expr29Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 30)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Activity1_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext6_ForReadOnly valDataContext30 = ((Activity1_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext30.ValueType___Expr30Get();
            }
            if ((expressionId == 31)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Activity1_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext6_ForReadOnly valDataContext31 = ((Activity1_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext31.ValueType___Expr31Get();
            }
            if ((expressionId == 32)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Activity1_TypedDataContext6(locations, activityContext, true);
                }
                Activity1_TypedDataContext6 refDataContext32 = ((Activity1_TypedDataContext6)(cachedCompiledDataContext[3]));
                return refDataContext32.GetLocation<System.Drawing.PointF>(refDataContext32.ValueType___Expr32Get, refDataContext32.ValueType___Expr32Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 33)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Activity1_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext4_ForReadOnly valDataContext33 = ((Activity1_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext33.ValueType___Expr33Get();
            }
            if ((expressionId == 34)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Activity1_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext7_ForReadOnly valDataContext34 = ((Activity1_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext34.ValueType___Expr34Get();
            }
            if ((expressionId == 35)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Activity1_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext7_ForReadOnly valDataContext35 = ((Activity1_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext35.ValueType___Expr35Get();
            }
            if ((expressionId == 36)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new Activity1_TypedDataContext8(locations, activityContext, true);
                }
                Activity1_TypedDataContext8 refDataContext36 = ((Activity1_TypedDataContext8)(cachedCompiledDataContext[7]));
                return refDataContext36.GetLocation<string>(refDataContext36.ValueType___Expr36Get, refDataContext36.ValueType___Expr36Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 37)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new Activity1_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext8_ForReadOnly valDataContext37 = ((Activity1_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext37.ValueType___Expr37Get();
            }
            if ((expressionId == 38)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new Activity1_TypedDataContext8(locations, activityContext, true);
                }
                Activity1_TypedDataContext8 refDataContext38 = ((Activity1_TypedDataContext8)(cachedCompiledDataContext[7]));
                return refDataContext38.GetLocation<System.Drawing.PointF>(refDataContext38.ValueType___Expr38Get, refDataContext38.ValueType___Expr38Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 39)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Activity1_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext7_ForReadOnly valDataContext39 = ((Activity1_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext39.ValueType___Expr39Get();
            }
            if ((expressionId == 40)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new Activity1_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext9_ForReadOnly valDataContext40 = ((Activity1_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext40.ValueType___Expr40Get();
            }
            if ((expressionId == 41)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new Activity1_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext9_ForReadOnly valDataContext41 = ((Activity1_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext41.ValueType___Expr41Get();
            }
            if ((expressionId == 42)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new Activity1_TypedDataContext9(locations, activityContext, true);
                }
                Activity1_TypedDataContext9 refDataContext42 = ((Activity1_TypedDataContext9)(cachedCompiledDataContext[10]));
                return refDataContext42.GetLocation<string>(refDataContext42.ValueType___Expr42Get, refDataContext42.ValueType___Expr42Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 43)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext10.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Activity1_TypedDataContext10(locations, activityContext, true);
                }
                Activity1_TypedDataContext10 refDataContext43 = ((Activity1_TypedDataContext10)(cachedCompiledDataContext[11]));
                return refDataContext43.GetLocation<int>(refDataContext43.ValueType___Expr43Get, refDataContext43.ValueType___Expr43Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 44)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext11_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new Activity1_TypedDataContext11_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext11_ForReadOnly valDataContext44 = ((Activity1_TypedDataContext11_ForReadOnly)(cachedCompiledDataContext[12]));
                return valDataContext44.ValueType___Expr44Get();
            }
            if ((expressionId == 45)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext11.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new Activity1_TypedDataContext11(locations, activityContext, true);
                }
                Activity1_TypedDataContext11 refDataContext45 = ((Activity1_TypedDataContext11)(cachedCompiledDataContext[13]));
                return refDataContext45.GetLocation<System.Drawing.PointF>(refDataContext45.ValueType___Expr45Get, refDataContext45.ValueType___Expr45Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 46)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext11_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new Activity1_TypedDataContext11_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext11_ForReadOnly valDataContext46 = ((Activity1_TypedDataContext11_ForReadOnly)(cachedCompiledDataContext[12]));
                return valDataContext46.ValueType___Expr46Get();
            }
            if ((expressionId == 47)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext11.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new Activity1_TypedDataContext11(locations, activityContext, true);
                }
                Activity1_TypedDataContext11 refDataContext47 = ((Activity1_TypedDataContext11)(cachedCompiledDataContext[13]));
                return refDataContext47.GetLocation<string>(refDataContext47.ValueType___Expr47Get, refDataContext47.ValueType___Expr47Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 48)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext11_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new Activity1_TypedDataContext11_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext11_ForReadOnly valDataContext48 = ((Activity1_TypedDataContext11_ForReadOnly)(cachedCompiledDataContext[12]));
                return valDataContext48.ValueType___Expr48Get();
            }
            if ((expressionId == 49)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext11_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new Activity1_TypedDataContext11_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext11_ForReadOnly valDataContext49 = ((Activity1_TypedDataContext11_ForReadOnly)(cachedCompiledDataContext[12]));
                return valDataContext49.ValueType___Expr49Get();
            }
            if ((expressionId == 50)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext11_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new Activity1_TypedDataContext11_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext11_ForReadOnly valDataContext50 = ((Activity1_TypedDataContext11_ForReadOnly)(cachedCompiledDataContext[12]));
                return valDataContext50.ValueType___Expr50Get();
            }
            if ((expressionId == 51)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext11_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new Activity1_TypedDataContext11_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext11_ForReadOnly valDataContext51 = ((Activity1_TypedDataContext11_ForReadOnly)(cachedCompiledDataContext[12]));
                return valDataContext51.ValueType___Expr51Get();
            }
            if ((expressionId == 52)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext11_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new Activity1_TypedDataContext11_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext11_ForReadOnly valDataContext52 = ((Activity1_TypedDataContext11_ForReadOnly)(cachedCompiledDataContext[12]));
                return valDataContext52.ValueType___Expr52Get();
            }
            if ((expressionId == 53)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext11_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new Activity1_TypedDataContext11_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext11_ForReadOnly valDataContext53 = ((Activity1_TypedDataContext11_ForReadOnly)(cachedCompiledDataContext[12]));
                return valDataContext53.ValueType___Expr53Get();
            }
            if ((expressionId == 54)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext11.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new Activity1_TypedDataContext11(locations, activityContext, true);
                }
                Activity1_TypedDataContext11 refDataContext54 = ((Activity1_TypedDataContext11)(cachedCompiledDataContext[13]));
                return refDataContext54.GetLocation<int>(refDataContext54.ValueType___Expr54Get, refDataContext54.ValueType___Expr54Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 55)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[14] == null)) {
                    cachedCompiledDataContext[14] = new Activity1_TypedDataContext10_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext10_ForReadOnly valDataContext55 = ((Activity1_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[14]));
                return valDataContext55.ValueType___Expr55Get();
            }
            if ((expressionId == 56)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[15] == null)) {
                    cachedCompiledDataContext[15] = new Activity1_TypedDataContext12(locations, activityContext, true);
                }
                Activity1_TypedDataContext12 refDataContext56 = ((Activity1_TypedDataContext12)(cachedCompiledDataContext[15]));
                return refDataContext56.GetLocation<string>(refDataContext56.ValueType___Expr56Get, refDataContext56.ValueType___Expr56Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 57)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new Activity1_TypedDataContext12_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext12_ForReadOnly valDataContext57 = ((Activity1_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[16]));
                return valDataContext57.ValueType___Expr57Get();
            }
            if ((expressionId == 58)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[15] == null)) {
                    cachedCompiledDataContext[15] = new Activity1_TypedDataContext12(locations, activityContext, true);
                }
                Activity1_TypedDataContext12 refDataContext58 = ((Activity1_TypedDataContext12)(cachedCompiledDataContext[15]));
                return refDataContext58.GetLocation<System.Drawing.PointF>(refDataContext58.ValueType___Expr58Get, refDataContext58.ValueType___Expr58Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 59)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new Activity1_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext9_ForReadOnly valDataContext59 = ((Activity1_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext59.ValueType___Expr59Get();
            }
            if ((expressionId == 60)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new Activity1_TypedDataContext9(locations, activityContext, true);
                }
                Activity1_TypedDataContext9 refDataContext60 = ((Activity1_TypedDataContext9)(cachedCompiledDataContext[10]));
                return refDataContext60.GetLocation<string>(refDataContext60.ValueType___Expr60Get, refDataContext60.ValueType___Expr60Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 61)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new Activity1_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext9_ForReadOnly valDataContext61 = ((Activity1_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext61.ValueType___Expr61Get();
            }
            if ((expressionId == 62)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext13_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[17] == null)) {
                    cachedCompiledDataContext[17] = new Activity1_TypedDataContext13_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext13_ForReadOnly valDataContext62 = ((Activity1_TypedDataContext13_ForReadOnly)(cachedCompiledDataContext[17]));
                return valDataContext62.ValueType___Expr62Get();
            }
            if ((expressionId == 63)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext13_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[17] == null)) {
                    cachedCompiledDataContext[17] = new Activity1_TypedDataContext13_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext13_ForReadOnly valDataContext63 = ((Activity1_TypedDataContext13_ForReadOnly)(cachedCompiledDataContext[17]));
                return valDataContext63.ValueType___Expr63Get();
            }
            if ((expressionId == 64)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext14.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[18] == null)) {
                    cachedCompiledDataContext[18] = new Activity1_TypedDataContext14(locations, activityContext, true);
                }
                Activity1_TypedDataContext14 refDataContext64 = ((Activity1_TypedDataContext14)(cachedCompiledDataContext[18]));
                return refDataContext64.GetLocation<string>(refDataContext64.ValueType___Expr64Get, refDataContext64.ValueType___Expr64Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 65)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[19] == null)) {
                    cachedCompiledDataContext[19] = new Activity1_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext14_ForReadOnly valDataContext65 = ((Activity1_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[19]));
                return valDataContext65.ValueType___Expr65Get();
            }
            if ((expressionId == 66)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext14.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[18] == null)) {
                    cachedCompiledDataContext[18] = new Activity1_TypedDataContext14(locations, activityContext, true);
                }
                Activity1_TypedDataContext14 refDataContext66 = ((Activity1_TypedDataContext14)(cachedCompiledDataContext[18]));
                return refDataContext66.GetLocation<System.Drawing.PointF>(refDataContext66.ValueType___Expr66Get, refDataContext66.ValueType___Expr66Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 67)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext13_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[17] == null)) {
                    cachedCompiledDataContext[17] = new Activity1_TypedDataContext13_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext13_ForReadOnly valDataContext67 = ((Activity1_TypedDataContext13_ForReadOnly)(cachedCompiledDataContext[17]));
                return valDataContext67.ValueType___Expr67Get();
            }
            if ((expressionId == 68)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext13_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[17] == null)) {
                    cachedCompiledDataContext[17] = new Activity1_TypedDataContext13_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext13_ForReadOnly valDataContext68 = ((Activity1_TypedDataContext13_ForReadOnly)(cachedCompiledDataContext[17]));
                return valDataContext68.ValueType___Expr68Get();
            }
            if ((expressionId == 69)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext13_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[17] == null)) {
                    cachedCompiledDataContext[17] = new Activity1_TypedDataContext13_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext13_ForReadOnly valDataContext69 = ((Activity1_TypedDataContext13_ForReadOnly)(cachedCompiledDataContext[17]));
                return valDataContext69.ValueType___Expr69Get();
            }
            if ((expressionId == 70)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext15_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[20] == null)) {
                    cachedCompiledDataContext[20] = new Activity1_TypedDataContext15_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext15_ForReadOnly valDataContext70 = ((Activity1_TypedDataContext15_ForReadOnly)(cachedCompiledDataContext[20]));
                return valDataContext70.ValueType___Expr70Get();
            }
            if ((expressionId == 71)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext15_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[20] == null)) {
                    cachedCompiledDataContext[20] = new Activity1_TypedDataContext15_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext15_ForReadOnly valDataContext71 = ((Activity1_TypedDataContext15_ForReadOnly)(cachedCompiledDataContext[20]));
                return valDataContext71.ValueType___Expr71Get();
            }
            if ((expressionId == 72)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext15_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[20] == null)) {
                    cachedCompiledDataContext[20] = new Activity1_TypedDataContext15_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext15_ForReadOnly valDataContext72 = ((Activity1_TypedDataContext15_ForReadOnly)(cachedCompiledDataContext[20]));
                return valDataContext72.ValueType___Expr72Get();
            }
            if ((expressionId == 73)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity1_TypedDataContext15_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[20] == null)) {
                    cachedCompiledDataContext[20] = new Activity1_TypedDataContext15_ForReadOnly(locations, activityContext, true);
                }
                Activity1_TypedDataContext15_ForReadOnly valDataContext73 = ((Activity1_TypedDataContext15_ForReadOnly)(cachedCompiledDataContext[20]));
                return valDataContext73.ValueType___Expr73Get();
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
                Activity1_TypedDataContext4 refDataContext0 = new Activity1_TypedDataContext4(locations, true);
                return refDataContext0.GetLocation<int>(refDataContext0.ValueType___Expr0Get, refDataContext0.ValueType___Expr0Set);
            }
            if ((expressionId == 1)) {
                Activity1_TypedDataContext5_ForReadOnly valDataContext1 = new Activity1_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                Activity1_TypedDataContext5 refDataContext2 = new Activity1_TypedDataContext5(locations, true);
                return refDataContext2.GetLocation<System.Collections.Generic.LinkedList<int>>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set);
            }
            if ((expressionId == 3)) {
                Activity1_TypedDataContext5_ForReadOnly valDataContext3 = new Activity1_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                Activity1_TypedDataContext5 refDataContext4 = new Activity1_TypedDataContext5(locations, true);
                return refDataContext4.GetLocation<System.Collections.Generic.LinkedList<System.Drawing.PointF>>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set);
            }
            if ((expressionId == 5)) {
                Activity1_TypedDataContext5 refDataContext5 = new Activity1_TypedDataContext5(locations, true);
                return refDataContext5.GetLocation<int>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set);
            }
            if ((expressionId == 6)) {
                Activity1_TypedDataContext5 refDataContext6 = new Activity1_TypedDataContext5(locations, true);
                return refDataContext6.GetLocation<int>(refDataContext6.ValueType___Expr6Get, refDataContext6.ValueType___Expr6Set);
            }
            if ((expressionId == 7)) {
                Activity1_TypedDataContext5 refDataContext7 = new Activity1_TypedDataContext5(locations, true);
                return refDataContext7.GetLocation<string>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set);
            }
            if ((expressionId == 8)) {
                Activity1_TypedDataContext5_ForReadOnly valDataContext8 = new Activity1_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                Activity1_TypedDataContext5 refDataContext9 = new Activity1_TypedDataContext5(locations, true);
                return refDataContext9.GetLocation<float>(refDataContext9.ValueType___Expr9Get, refDataContext9.ValueType___Expr9Set);
            }
            if ((expressionId == 10)) {
                Activity1_TypedDataContext5_ForReadOnly valDataContext10 = new Activity1_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                Activity1_TypedDataContext5 refDataContext11 = new Activity1_TypedDataContext5(locations, true);
                return refDataContext11.GetLocation<float>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set);
            }
            if ((expressionId == 12)) {
                Activity1_TypedDataContext5_ForReadOnly valDataContext12 = new Activity1_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                Activity1_TypedDataContext5_ForReadOnly valDataContext13 = new Activity1_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                Activity1_TypedDataContext5_ForReadOnly valDataContext14 = new Activity1_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                Activity1_TypedDataContext5_ForReadOnly valDataContext15 = new Activity1_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                Activity1_TypedDataContext5_ForReadOnly valDataContext16 = new Activity1_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                Activity1_TypedDataContext5 refDataContext17 = new Activity1_TypedDataContext5(locations, true);
                return refDataContext17.GetLocation<string>(refDataContext17.ValueType___Expr17Get, refDataContext17.ValueType___Expr17Set);
            }
            if ((expressionId == 18)) {
                Activity1_TypedDataContext5_ForReadOnly valDataContext18 = new Activity1_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext18.ValueType___Expr18Get();
            }
            if ((expressionId == 19)) {
                Activity1_TypedDataContext5 refDataContext19 = new Activity1_TypedDataContext5(locations, true);
                return refDataContext19.GetLocation<int>(refDataContext19.ValueType___Expr19Get, refDataContext19.ValueType___Expr19Set);
            }
            if ((expressionId == 20)) {
                Activity1_TypedDataContext5_ForReadOnly valDataContext20 = new Activity1_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                Activity1_TypedDataContext5 refDataContext21 = new Activity1_TypedDataContext5(locations, true);
                return refDataContext21.GetLocation<int>(refDataContext21.ValueType___Expr21Get, refDataContext21.ValueType___Expr21Set);
            }
            if ((expressionId == 22)) {
                Activity1_TypedDataContext5_ForReadOnly valDataContext22 = new Activity1_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                Activity1_TypedDataContext5_ForReadOnly valDataContext23 = new Activity1_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext23.ValueType___Expr23Get();
            }
            if ((expressionId == 24)) {
                Activity1_TypedDataContext5 refDataContext24 = new Activity1_TypedDataContext5(locations, true);
                return refDataContext24.GetLocation<string>(refDataContext24.ValueType___Expr24Get, refDataContext24.ValueType___Expr24Set);
            }
            if ((expressionId == 25)) {
                Activity1_TypedDataContext5_ForReadOnly valDataContext25 = new Activity1_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext25.ValueType___Expr25Get();
            }
            if ((expressionId == 26)) {
                Activity1_TypedDataContext5 refDataContext26 = new Activity1_TypedDataContext5(locations, true);
                return refDataContext26.GetLocation<string>(refDataContext26.ValueType___Expr26Get, refDataContext26.ValueType___Expr26Set);
            }
            if ((expressionId == 27)) {
                Activity1_TypedDataContext5_ForReadOnly valDataContext27 = new Activity1_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext27.ValueType___Expr27Get();
            }
            if ((expressionId == 28)) {
                Activity1_TypedDataContext5 refDataContext28 = new Activity1_TypedDataContext5(locations, true);
                return refDataContext28.GetLocation<System.Collections.Generic.List<string>>(refDataContext28.ValueType___Expr28Get, refDataContext28.ValueType___Expr28Set);
            }
            if ((expressionId == 29)) {
                Activity1_TypedDataContext6 refDataContext29 = new Activity1_TypedDataContext6(locations, true);
                return refDataContext29.GetLocation<string>(refDataContext29.ValueType___Expr29Get, refDataContext29.ValueType___Expr29Set);
            }
            if ((expressionId == 30)) {
                Activity1_TypedDataContext6_ForReadOnly valDataContext30 = new Activity1_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext30.ValueType___Expr30Get();
            }
            if ((expressionId == 31)) {
                Activity1_TypedDataContext6_ForReadOnly valDataContext31 = new Activity1_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext31.ValueType___Expr31Get();
            }
            if ((expressionId == 32)) {
                Activity1_TypedDataContext6 refDataContext32 = new Activity1_TypedDataContext6(locations, true);
                return refDataContext32.GetLocation<System.Drawing.PointF>(refDataContext32.ValueType___Expr32Get, refDataContext32.ValueType___Expr32Set);
            }
            if ((expressionId == 33)) {
                Activity1_TypedDataContext4_ForReadOnly valDataContext33 = new Activity1_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext33.ValueType___Expr33Get();
            }
            if ((expressionId == 34)) {
                Activity1_TypedDataContext7_ForReadOnly valDataContext34 = new Activity1_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext34.ValueType___Expr34Get();
            }
            if ((expressionId == 35)) {
                Activity1_TypedDataContext7_ForReadOnly valDataContext35 = new Activity1_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext35.ValueType___Expr35Get();
            }
            if ((expressionId == 36)) {
                Activity1_TypedDataContext8 refDataContext36 = new Activity1_TypedDataContext8(locations, true);
                return refDataContext36.GetLocation<string>(refDataContext36.ValueType___Expr36Get, refDataContext36.ValueType___Expr36Set);
            }
            if ((expressionId == 37)) {
                Activity1_TypedDataContext8_ForReadOnly valDataContext37 = new Activity1_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext37.ValueType___Expr37Get();
            }
            if ((expressionId == 38)) {
                Activity1_TypedDataContext8 refDataContext38 = new Activity1_TypedDataContext8(locations, true);
                return refDataContext38.GetLocation<System.Drawing.PointF>(refDataContext38.ValueType___Expr38Get, refDataContext38.ValueType___Expr38Set);
            }
            if ((expressionId == 39)) {
                Activity1_TypedDataContext7_ForReadOnly valDataContext39 = new Activity1_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext39.ValueType___Expr39Get();
            }
            if ((expressionId == 40)) {
                Activity1_TypedDataContext9_ForReadOnly valDataContext40 = new Activity1_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext40.ValueType___Expr40Get();
            }
            if ((expressionId == 41)) {
                Activity1_TypedDataContext9_ForReadOnly valDataContext41 = new Activity1_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext41.ValueType___Expr41Get();
            }
            if ((expressionId == 42)) {
                Activity1_TypedDataContext9 refDataContext42 = new Activity1_TypedDataContext9(locations, true);
                return refDataContext42.GetLocation<string>(refDataContext42.ValueType___Expr42Get, refDataContext42.ValueType___Expr42Set);
            }
            if ((expressionId == 43)) {
                Activity1_TypedDataContext10 refDataContext43 = new Activity1_TypedDataContext10(locations, true);
                return refDataContext43.GetLocation<int>(refDataContext43.ValueType___Expr43Get, refDataContext43.ValueType___Expr43Set);
            }
            if ((expressionId == 44)) {
                Activity1_TypedDataContext11_ForReadOnly valDataContext44 = new Activity1_TypedDataContext11_ForReadOnly(locations, true);
                return valDataContext44.ValueType___Expr44Get();
            }
            if ((expressionId == 45)) {
                Activity1_TypedDataContext11 refDataContext45 = new Activity1_TypedDataContext11(locations, true);
                return refDataContext45.GetLocation<System.Drawing.PointF>(refDataContext45.ValueType___Expr45Get, refDataContext45.ValueType___Expr45Set);
            }
            if ((expressionId == 46)) {
                Activity1_TypedDataContext11_ForReadOnly valDataContext46 = new Activity1_TypedDataContext11_ForReadOnly(locations, true);
                return valDataContext46.ValueType___Expr46Get();
            }
            if ((expressionId == 47)) {
                Activity1_TypedDataContext11 refDataContext47 = new Activity1_TypedDataContext11(locations, true);
                return refDataContext47.GetLocation<string>(refDataContext47.ValueType___Expr47Get, refDataContext47.ValueType___Expr47Set);
            }
            if ((expressionId == 48)) {
                Activity1_TypedDataContext11_ForReadOnly valDataContext48 = new Activity1_TypedDataContext11_ForReadOnly(locations, true);
                return valDataContext48.ValueType___Expr48Get();
            }
            if ((expressionId == 49)) {
                Activity1_TypedDataContext11_ForReadOnly valDataContext49 = new Activity1_TypedDataContext11_ForReadOnly(locations, true);
                return valDataContext49.ValueType___Expr49Get();
            }
            if ((expressionId == 50)) {
                Activity1_TypedDataContext11_ForReadOnly valDataContext50 = new Activity1_TypedDataContext11_ForReadOnly(locations, true);
                return valDataContext50.ValueType___Expr50Get();
            }
            if ((expressionId == 51)) {
                Activity1_TypedDataContext11_ForReadOnly valDataContext51 = new Activity1_TypedDataContext11_ForReadOnly(locations, true);
                return valDataContext51.ValueType___Expr51Get();
            }
            if ((expressionId == 52)) {
                Activity1_TypedDataContext11_ForReadOnly valDataContext52 = new Activity1_TypedDataContext11_ForReadOnly(locations, true);
                return valDataContext52.ValueType___Expr52Get();
            }
            if ((expressionId == 53)) {
                Activity1_TypedDataContext11_ForReadOnly valDataContext53 = new Activity1_TypedDataContext11_ForReadOnly(locations, true);
                return valDataContext53.ValueType___Expr53Get();
            }
            if ((expressionId == 54)) {
                Activity1_TypedDataContext11 refDataContext54 = new Activity1_TypedDataContext11(locations, true);
                return refDataContext54.GetLocation<int>(refDataContext54.ValueType___Expr54Get, refDataContext54.ValueType___Expr54Set);
            }
            if ((expressionId == 55)) {
                Activity1_TypedDataContext10_ForReadOnly valDataContext55 = new Activity1_TypedDataContext10_ForReadOnly(locations, true);
                return valDataContext55.ValueType___Expr55Get();
            }
            if ((expressionId == 56)) {
                Activity1_TypedDataContext12 refDataContext56 = new Activity1_TypedDataContext12(locations, true);
                return refDataContext56.GetLocation<string>(refDataContext56.ValueType___Expr56Get, refDataContext56.ValueType___Expr56Set);
            }
            if ((expressionId == 57)) {
                Activity1_TypedDataContext12_ForReadOnly valDataContext57 = new Activity1_TypedDataContext12_ForReadOnly(locations, true);
                return valDataContext57.ValueType___Expr57Get();
            }
            if ((expressionId == 58)) {
                Activity1_TypedDataContext12 refDataContext58 = new Activity1_TypedDataContext12(locations, true);
                return refDataContext58.GetLocation<System.Drawing.PointF>(refDataContext58.ValueType___Expr58Get, refDataContext58.ValueType___Expr58Set);
            }
            if ((expressionId == 59)) {
                Activity1_TypedDataContext9_ForReadOnly valDataContext59 = new Activity1_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext59.ValueType___Expr59Get();
            }
            if ((expressionId == 60)) {
                Activity1_TypedDataContext9 refDataContext60 = new Activity1_TypedDataContext9(locations, true);
                return refDataContext60.GetLocation<string>(refDataContext60.ValueType___Expr60Get, refDataContext60.ValueType___Expr60Set);
            }
            if ((expressionId == 61)) {
                Activity1_TypedDataContext9_ForReadOnly valDataContext61 = new Activity1_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext61.ValueType___Expr61Get();
            }
            if ((expressionId == 62)) {
                Activity1_TypedDataContext13_ForReadOnly valDataContext62 = new Activity1_TypedDataContext13_ForReadOnly(locations, true);
                return valDataContext62.ValueType___Expr62Get();
            }
            if ((expressionId == 63)) {
                Activity1_TypedDataContext13_ForReadOnly valDataContext63 = new Activity1_TypedDataContext13_ForReadOnly(locations, true);
                return valDataContext63.ValueType___Expr63Get();
            }
            if ((expressionId == 64)) {
                Activity1_TypedDataContext14 refDataContext64 = new Activity1_TypedDataContext14(locations, true);
                return refDataContext64.GetLocation<string>(refDataContext64.ValueType___Expr64Get, refDataContext64.ValueType___Expr64Set);
            }
            if ((expressionId == 65)) {
                Activity1_TypedDataContext14_ForReadOnly valDataContext65 = new Activity1_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext65.ValueType___Expr65Get();
            }
            if ((expressionId == 66)) {
                Activity1_TypedDataContext14 refDataContext66 = new Activity1_TypedDataContext14(locations, true);
                return refDataContext66.GetLocation<System.Drawing.PointF>(refDataContext66.ValueType___Expr66Get, refDataContext66.ValueType___Expr66Set);
            }
            if ((expressionId == 67)) {
                Activity1_TypedDataContext13_ForReadOnly valDataContext67 = new Activity1_TypedDataContext13_ForReadOnly(locations, true);
                return valDataContext67.ValueType___Expr67Get();
            }
            if ((expressionId == 68)) {
                Activity1_TypedDataContext13_ForReadOnly valDataContext68 = new Activity1_TypedDataContext13_ForReadOnly(locations, true);
                return valDataContext68.ValueType___Expr68Get();
            }
            if ((expressionId == 69)) {
                Activity1_TypedDataContext13_ForReadOnly valDataContext69 = new Activity1_TypedDataContext13_ForReadOnly(locations, true);
                return valDataContext69.ValueType___Expr69Get();
            }
            if ((expressionId == 70)) {
                Activity1_TypedDataContext15_ForReadOnly valDataContext70 = new Activity1_TypedDataContext15_ForReadOnly(locations, true);
                return valDataContext70.ValueType___Expr70Get();
            }
            if ((expressionId == 71)) {
                Activity1_TypedDataContext15_ForReadOnly valDataContext71 = new Activity1_TypedDataContext15_ForReadOnly(locations, true);
                return valDataContext71.ValueType___Expr71Get();
            }
            if ((expressionId == 72)) {
                Activity1_TypedDataContext15_ForReadOnly valDataContext72 = new Activity1_TypedDataContext15_ForReadOnly(locations, true);
                return valDataContext72.ValueType___Expr72Get();
            }
            if ((expressionId == 73)) {
                Activity1_TypedDataContext15_ForReadOnly valDataContext73 = new Activity1_TypedDataContext15_ForReadOnly(locations, true);
                return valDataContext73.ValueType___Expr73Get();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == true) 
                        && ((expressionText == "DistanciaPermitida") 
                        && (Activity1_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new LinkedList<int>()") 
                        && (Activity1_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IdBandera") 
                        && (Activity1_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new LinkedList<PointF>()") 
                        && (Activity1_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "UbicacionBanderas") 
                        && (Activity1_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "i") 
                        && (Activity1_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "angulo") 
                        && (Activity1_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "VarBanderas") 
                        && (Activity1_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Radio * (float)(Math.Cos((Math.PI * angulo / 180)))") 
                        && (Activity1_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "x") 
                        && (Activity1_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Radio * (float)(Math.Sin((Math.PI * angulo / 180)))") 
                        && (Activity1_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "y") 
                        && (Activity1_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "UbicacionBanderas") 
                        && (Activity1_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new PointF(x,y)") 
                        && (Activity1_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "IdBandera") 
                        && (Activity1_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "i") 
                        && (Activity1_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 15;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "VarBanderas + \" { \\\"id\\\":\\\"\" + i.ToString() + \"\\\", \\\"color\\\":\\\"\" + Color + \"\\\", \\" +
                            "\"x\\\":\\\"\" + x.ToString().Replace(\",\", \".\") + \"\\\", \\\"y\\\":\\\"\" + y.ToString().Replac" +
                            "e(\",\", \".\") + \"\\\", \\\"visible\\\":\\\"true\\\" },\"") 
                        && (Activity1_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 16;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "VarBanderas") 
                        && (Activity1_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 17;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "angulo+Separacion") 
                        && (Activity1_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 18;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "angulo") 
                        && (Activity1_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 19;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "i+1") 
                        && (Activity1_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 20;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "i") 
                        && (Activity1_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 21;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "i<TotalBanderas") 
                        && (Activity1_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 22;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "VarBanderas.Substring(0, VarBanderas.Length - 1)") 
                        && (Activity1_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 23;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "VarBanderas") 
                        && (Activity1_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 24;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "VarBanderas + \" ]\"") 
                        && (Activity1_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 25;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "VarBanderas") 
                        && (Activity1_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 26;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new List<String>()") 
                        && (Activity1_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 27;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Archivo") 
                        && (Activity1_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 28;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Coordenadas") 
                        && (Activity1_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 29;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"L{ \\\"id\\\":\\\"\"+Escenario+\"\\\" }\"") 
                        && (Activity1_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 30;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new PointF(Single.Parse(Coordenadas.Split(\';\')[0].Replace(\".\", \",\")), Single.Pars" +
                            "e(Coordenadas.Split(\';\')[1].Replace(\".\", \",\")))") 
                        && (Activity1_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 31;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "PosicionActual") 
                        && (Activity1_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 32;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "VarBanderas") 
                        && (Activity1_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 33;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Archivo") 
                        && (Activity1_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 34;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DateTime.Now.ToString() + \";\" + PosicionActual.X.ToString().Replace(\",\", \".\") + \"" +
                            ";\" + PosicionActual.Y.ToString().Replace(\",\", \".\") + \",DET\"") 
                        && (Activity1_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 35;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Coordenadas") 
                        && (Activity1_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 36;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new PointF(Single.Parse(Coordenadas.Split(\';\')[0].Replace(\".\", \",\")), Single.Pars" +
                            "e(Coordenadas.Split(\';\')[1].Replace(\".\", \",\")))") 
                        && (Activity1_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 37;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "PosicionActual") 
                        && (Activity1_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 38;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Math.Sqrt(Math.Pow(PosicionActual.X, 2) + Math.Pow(PosicionActual.Y, 2))) <= Dis" +
                            "tanciaPermitida") 
                        && (Activity1_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 39;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Archivo") 
                        && (Activity1_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 40;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DateTime.Now.ToString() + \";\" \n                + PosicionActual.X.ToString().Repl" +
                            "ace(\",\", \".\") \n                + \";\" + PosicionActual.Y.ToString().Replace(\",\", " +
                            "\".\") \n                + \";BUS\"") 
                        && (Activity1_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 41;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "captura") 
                        && (Activity1_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 42;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "i") 
                        && (Activity1_TypedDataContext10.Validate(locations, true, 0) == true)))) {
                expressionId = 43;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "UbicacionBanderas.ElementAt(i)") 
                        && (Activity1_TypedDataContext11_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 44;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "item") 
                        && (Activity1_TypedDataContext11.Validate(locations, true, 0) == true)))) {
                expressionId = 45;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Math.Sqrt(Math.Pow(PosicionActual.X - item.X, 2) + Math.Pow(PosicionActual.Y - it" +
                            "em.Y, 2))<DistanciaPermitida") 
                        && (Activity1_TypedDataContext11_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 46;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "captura") 
                        && (Activity1_TypedDataContext11.Validate(locations, true, 0) == true)))) {
                expressionId = 47;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"H{ \\\"id\\\":\\\"\" + IdBandera.ElementAt(i) + \"\\\", \\\"visible\\\":\\\"false\\\" }\"") 
                        && (Activity1_TypedDataContext11_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 48;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "UbicacionBanderas") 
                        && (Activity1_TypedDataContext11_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 49;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "item") 
                        && (Activity1_TypedDataContext11_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 50;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "IdBandera") 
                        && (Activity1_TypedDataContext11_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 51;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "IdBandera.ElementAt(i)") 
                        && (Activity1_TypedDataContext11_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 52;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "i+1") 
                        && (Activity1_TypedDataContext11_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 53;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "i") 
                        && (Activity1_TypedDataContext11.Validate(locations, true, 0) == true)))) {
                expressionId = 54;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "captura.Equals(\"N\") && i<UbicacionBanderas.Count") 
                        && (Activity1_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 55;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Coordenadas") 
                        && (Activity1_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 56;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new PointF(Single.Parse(Coordenadas.Split(\';\')[0].Replace(\".\", \",\")), Single.Pars" +
                            "e(Coordenadas.Split(\';\')[1].Replace(\".\", \",\")))") 
                        && (Activity1_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 57;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "PosicionActual") 
                        && (Activity1_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 58;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "captura.Equals(\"S\")") 
                        && (Activity1_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 59;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "captura") 
                        && (Activity1_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 60;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "!((UbicacionBanderas.Count >= 1) && captura.Equals(\"S\"))") 
                        && (Activity1_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 61;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Archivo") 
                        && (Activity1_TypedDataContext13_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 62;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DateTime.Now.ToString() + \";\" \n                + PosicionActual.X.ToString().Repl" +
                            "ace(\",\", \".\") + \";\" \n                + PosicionActual.Y.ToString().Replace(\",\", " +
                            "\".\") + \";CEN\"") 
                        && (Activity1_TypedDataContext13_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 63;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Coordenadas") 
                        && (Activity1_TypedDataContext14.Validate(locations, true, 0) == true)))) {
                expressionId = 64;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new PointF(Single.Parse(Coordenadas.Split(\';\')[0].Replace(\".\", \",\")), Single.Pars" +
                            "e(Coordenadas.Split(\';\')[1].Replace(\".\", \",\")))") 
                        && (Activity1_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 65;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "PosicionActual") 
                        && (Activity1_TypedDataContext14.Validate(locations, true, 0) == true)))) {
                expressionId = 66;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "((Math.Sqrt(Math.Pow(PosicionActual.X, 2) + Math.Pow(PosicionActual.Y, 2))) <= Di" +
                            "stanciaPermitida) && ((UbicacionBanderas.Count != 0))") 
                        && (Activity1_TypedDataContext13_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 67;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Math.Sqrt(Math.Pow(PosicionActual.X, 2) + Math.Pow(PosicionActual.Y, 2))) > Dist" +
                            "anciaPermitida") 
                        && (Activity1_TypedDataContext13_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 68;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "((Math.Sqrt(Math.Pow(PosicionActual.X, 2) + Math.Pow(PosicionActual.Y, 2))) <= Di" +
                            "stanciaPermitida)&&(UbicacionBanderas.Count == 0)") 
                        && (Activity1_TypedDataContext13_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 69;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Archivo") 
                        && (Activity1_TypedDataContext15_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 70;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DateTime.Now.ToString() + \";\" \n                + PosicionActual.X.ToString().Repl" +
                            "ace(\",\", \".\") + \";\" \n                + PosicionActual.Y.ToString().Replace(\",\", " +
                            "\".\") + \";FIN\"") 
                        && (Activity1_TypedDataContext15_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 71;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Q{ \\\"text\\\":\\\"Fin del experimento\\\" }\"") 
                        && (Activity1_TypedDataContext15_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 72;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TimeSpan.FromSeconds(5)") 
                        && (Activity1_TypedDataContext15_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 73;
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
                return new Activity1_TypedDataContext4(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new Activity1_TypedDataContext5_ForReadOnly(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new Activity1_TypedDataContext5(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new Activity1_TypedDataContext5_ForReadOnly(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new Activity1_TypedDataContext5(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new Activity1_TypedDataContext5(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new Activity1_TypedDataContext5(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new Activity1_TypedDataContext5(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new Activity1_TypedDataContext5_ForReadOnly(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new Activity1_TypedDataContext5(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new Activity1_TypedDataContext5_ForReadOnly(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new Activity1_TypedDataContext5(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new Activity1_TypedDataContext5_ForReadOnly(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new Activity1_TypedDataContext5_ForReadOnly(locationReferences).@__Expr13GetTree();
            }
            if ((expressionId == 14)) {
                return new Activity1_TypedDataContext5_ForReadOnly(locationReferences).@__Expr14GetTree();
            }
            if ((expressionId == 15)) {
                return new Activity1_TypedDataContext5_ForReadOnly(locationReferences).@__Expr15GetTree();
            }
            if ((expressionId == 16)) {
                return new Activity1_TypedDataContext5_ForReadOnly(locationReferences).@__Expr16GetTree();
            }
            if ((expressionId == 17)) {
                return new Activity1_TypedDataContext5(locationReferences).@__Expr17GetTree();
            }
            if ((expressionId == 18)) {
                return new Activity1_TypedDataContext5_ForReadOnly(locationReferences).@__Expr18GetTree();
            }
            if ((expressionId == 19)) {
                return new Activity1_TypedDataContext5(locationReferences).@__Expr19GetTree();
            }
            if ((expressionId == 20)) {
                return new Activity1_TypedDataContext5_ForReadOnly(locationReferences).@__Expr20GetTree();
            }
            if ((expressionId == 21)) {
                return new Activity1_TypedDataContext5(locationReferences).@__Expr21GetTree();
            }
            if ((expressionId == 22)) {
                return new Activity1_TypedDataContext5_ForReadOnly(locationReferences).@__Expr22GetTree();
            }
            if ((expressionId == 23)) {
                return new Activity1_TypedDataContext5_ForReadOnly(locationReferences).@__Expr23GetTree();
            }
            if ((expressionId == 24)) {
                return new Activity1_TypedDataContext5(locationReferences).@__Expr24GetTree();
            }
            if ((expressionId == 25)) {
                return new Activity1_TypedDataContext5_ForReadOnly(locationReferences).@__Expr25GetTree();
            }
            if ((expressionId == 26)) {
                return new Activity1_TypedDataContext5(locationReferences).@__Expr26GetTree();
            }
            if ((expressionId == 27)) {
                return new Activity1_TypedDataContext5_ForReadOnly(locationReferences).@__Expr27GetTree();
            }
            if ((expressionId == 28)) {
                return new Activity1_TypedDataContext5(locationReferences).@__Expr28GetTree();
            }
            if ((expressionId == 29)) {
                return new Activity1_TypedDataContext6(locationReferences).@__Expr29GetTree();
            }
            if ((expressionId == 30)) {
                return new Activity1_TypedDataContext6_ForReadOnly(locationReferences).@__Expr30GetTree();
            }
            if ((expressionId == 31)) {
                return new Activity1_TypedDataContext6_ForReadOnly(locationReferences).@__Expr31GetTree();
            }
            if ((expressionId == 32)) {
                return new Activity1_TypedDataContext6(locationReferences).@__Expr32GetTree();
            }
            if ((expressionId == 33)) {
                return new Activity1_TypedDataContext4_ForReadOnly(locationReferences).@__Expr33GetTree();
            }
            if ((expressionId == 34)) {
                return new Activity1_TypedDataContext7_ForReadOnly(locationReferences).@__Expr34GetTree();
            }
            if ((expressionId == 35)) {
                return new Activity1_TypedDataContext7_ForReadOnly(locationReferences).@__Expr35GetTree();
            }
            if ((expressionId == 36)) {
                return new Activity1_TypedDataContext8(locationReferences).@__Expr36GetTree();
            }
            if ((expressionId == 37)) {
                return new Activity1_TypedDataContext8_ForReadOnly(locationReferences).@__Expr37GetTree();
            }
            if ((expressionId == 38)) {
                return new Activity1_TypedDataContext8(locationReferences).@__Expr38GetTree();
            }
            if ((expressionId == 39)) {
                return new Activity1_TypedDataContext7_ForReadOnly(locationReferences).@__Expr39GetTree();
            }
            if ((expressionId == 40)) {
                return new Activity1_TypedDataContext9_ForReadOnly(locationReferences).@__Expr40GetTree();
            }
            if ((expressionId == 41)) {
                return new Activity1_TypedDataContext9_ForReadOnly(locationReferences).@__Expr41GetTree();
            }
            if ((expressionId == 42)) {
                return new Activity1_TypedDataContext9(locationReferences).@__Expr42GetTree();
            }
            if ((expressionId == 43)) {
                return new Activity1_TypedDataContext10(locationReferences).@__Expr43GetTree();
            }
            if ((expressionId == 44)) {
                return new Activity1_TypedDataContext11_ForReadOnly(locationReferences).@__Expr44GetTree();
            }
            if ((expressionId == 45)) {
                return new Activity1_TypedDataContext11(locationReferences).@__Expr45GetTree();
            }
            if ((expressionId == 46)) {
                return new Activity1_TypedDataContext11_ForReadOnly(locationReferences).@__Expr46GetTree();
            }
            if ((expressionId == 47)) {
                return new Activity1_TypedDataContext11(locationReferences).@__Expr47GetTree();
            }
            if ((expressionId == 48)) {
                return new Activity1_TypedDataContext11_ForReadOnly(locationReferences).@__Expr48GetTree();
            }
            if ((expressionId == 49)) {
                return new Activity1_TypedDataContext11_ForReadOnly(locationReferences).@__Expr49GetTree();
            }
            if ((expressionId == 50)) {
                return new Activity1_TypedDataContext11_ForReadOnly(locationReferences).@__Expr50GetTree();
            }
            if ((expressionId == 51)) {
                return new Activity1_TypedDataContext11_ForReadOnly(locationReferences).@__Expr51GetTree();
            }
            if ((expressionId == 52)) {
                return new Activity1_TypedDataContext11_ForReadOnly(locationReferences).@__Expr52GetTree();
            }
            if ((expressionId == 53)) {
                return new Activity1_TypedDataContext11_ForReadOnly(locationReferences).@__Expr53GetTree();
            }
            if ((expressionId == 54)) {
                return new Activity1_TypedDataContext11(locationReferences).@__Expr54GetTree();
            }
            if ((expressionId == 55)) {
                return new Activity1_TypedDataContext10_ForReadOnly(locationReferences).@__Expr55GetTree();
            }
            if ((expressionId == 56)) {
                return new Activity1_TypedDataContext12(locationReferences).@__Expr56GetTree();
            }
            if ((expressionId == 57)) {
                return new Activity1_TypedDataContext12_ForReadOnly(locationReferences).@__Expr57GetTree();
            }
            if ((expressionId == 58)) {
                return new Activity1_TypedDataContext12(locationReferences).@__Expr58GetTree();
            }
            if ((expressionId == 59)) {
                return new Activity1_TypedDataContext9_ForReadOnly(locationReferences).@__Expr59GetTree();
            }
            if ((expressionId == 60)) {
                return new Activity1_TypedDataContext9(locationReferences).@__Expr60GetTree();
            }
            if ((expressionId == 61)) {
                return new Activity1_TypedDataContext9_ForReadOnly(locationReferences).@__Expr61GetTree();
            }
            if ((expressionId == 62)) {
                return new Activity1_TypedDataContext13_ForReadOnly(locationReferences).@__Expr62GetTree();
            }
            if ((expressionId == 63)) {
                return new Activity1_TypedDataContext13_ForReadOnly(locationReferences).@__Expr63GetTree();
            }
            if ((expressionId == 64)) {
                return new Activity1_TypedDataContext14(locationReferences).@__Expr64GetTree();
            }
            if ((expressionId == 65)) {
                return new Activity1_TypedDataContext14_ForReadOnly(locationReferences).@__Expr65GetTree();
            }
            if ((expressionId == 66)) {
                return new Activity1_TypedDataContext14(locationReferences).@__Expr66GetTree();
            }
            if ((expressionId == 67)) {
                return new Activity1_TypedDataContext13_ForReadOnly(locationReferences).@__Expr67GetTree();
            }
            if ((expressionId == 68)) {
                return new Activity1_TypedDataContext13_ForReadOnly(locationReferences).@__Expr68GetTree();
            }
            if ((expressionId == 69)) {
                return new Activity1_TypedDataContext13_ForReadOnly(locationReferences).@__Expr69GetTree();
            }
            if ((expressionId == 70)) {
                return new Activity1_TypedDataContext15_ForReadOnly(locationReferences).@__Expr70GetTree();
            }
            if ((expressionId == 71)) {
                return new Activity1_TypedDataContext15_ForReadOnly(locationReferences).@__Expr71GetTree();
            }
            if ((expressionId == 72)) {
                return new Activity1_TypedDataContext15_ForReadOnly(locationReferences).@__Expr72GetTree();
            }
            if ((expressionId == 73)) {
                return new Activity1_TypedDataContext15_ForReadOnly(locationReferences).@__Expr73GetTree();
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
            
            protected int Radio;
            
            protected int TotalBanderas;
            
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
            
            protected System.Collections.Generic.List<string> Archivo {
                get {
                    return ((System.Collections.Generic.List<string>)(this.GetVariableValue((1 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((1 + locationsOffset), value);
                }
            }
            
            protected string Color {
                get {
                    return ((string)(this.GetVariableValue((2 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((2 + locationsOffset), value);
                }
            }
            
            protected string Escenario {
                get {
                    return ((string)(this.GetVariableValue((5 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((5 + locationsOffset), value);
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
                this.Separacion = ((int)(this.GetVariableValue((0 + locationsOffset))));
                this.Radio = ((int)(this.GetVariableValue((3 + locationsOffset))));
                this.TotalBanderas = ((int)(this.GetVariableValue((4 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((0 + locationsOffset), this.Separacion);
                this.SetVariableValue((3 + locationsOffset), this.Radio);
                this.SetVariableValue((4 + locationsOffset), this.TotalBanderas);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 6))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 6);
                }
                expectedLocationsCount = 6;
                if (((locationReferences[(offset + 1)].Name != "Archivo") 
                            || (locationReferences[(offset + 1)].Type != typeof(System.Collections.Generic.List<string>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "Color") 
                            || (locationReferences[(offset + 2)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "Escenario") 
                            || (locationReferences[(offset + 5)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 0)].Name != "Separacion") 
                            || (locationReferences[(offset + 0)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "Radio") 
                            || (locationReferences[(offset + 3)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "TotalBanderas") 
                            || (locationReferences[(offset + 4)].Type != typeof(int)))) {
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
            
            protected int Radio;
            
            protected int TotalBanderas;
            
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
            
            protected System.Collections.Generic.List<string> Archivo {
                get {
                    return ((System.Collections.Generic.List<string>)(this.GetVariableValue((1 + locationsOffset))));
                }
            }
            
            protected string Color {
                get {
                    return ((string)(this.GetVariableValue((2 + locationsOffset))));
                }
            }
            
            protected string Escenario {
                get {
                    return ((string)(this.GetVariableValue((5 + locationsOffset))));
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
                this.Separacion = ((int)(this.GetVariableValue((0 + locationsOffset))));
                this.Radio = ((int)(this.GetVariableValue((3 + locationsOffset))));
                this.TotalBanderas = ((int)(this.GetVariableValue((4 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 6))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 6);
                }
                expectedLocationsCount = 6;
                if (((locationReferences[(offset + 1)].Name != "Archivo") 
                            || (locationReferences[(offset + 1)].Type != typeof(System.Collections.Generic.List<string>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "Color") 
                            || (locationReferences[(offset + 2)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "Escenario") 
                            || (locationReferences[(offset + 5)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 0)].Name != "Separacion") 
                            || (locationReferences[(offset + 0)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "Radio") 
                            || (locationReferences[(offset + 3)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "TotalBanderas") 
                            || (locationReferences[(offset + 4)].Type != typeof(int)))) {
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
            
            protected System.Drawing.PointF PosicionActual;
            
            protected int DistanciaPermitida;
            
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
            
            protected System.Collections.Generic.LinkedList<System.Drawing.PointF> UbicacionBanderas {
                get {
                    return ((System.Collections.Generic.LinkedList<System.Drawing.PointF>)(this.GetVariableValue((6 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((6 + locationsOffset), value);
                }
            }
            
            protected System.Collections.Generic.LinkedList<int> IdBandera {
                get {
                    return ((System.Collections.Generic.LinkedList<int>)(this.GetVariableValue((8 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((8 + locationsOffset), value);
                }
            }
            
            protected string captura {
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
                this.PosicionActual = ((System.Drawing.PointF)(this.GetVariableValue((7 + locationsOffset))));
                this.DistanciaPermitida = ((int)(this.GetVariableValue((9 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((7 + locationsOffset), this.PosicionActual);
                this.SetVariableValue((9 + locationsOffset), this.DistanciaPermitida);
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
                if (((locationReferences[(offset + 6)].Name != "UbicacionBanderas") 
                            || (locationReferences[(offset + 6)].Type != typeof(System.Collections.Generic.LinkedList<System.Drawing.PointF>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "IdBandera") 
                            || (locationReferences[(offset + 8)].Type != typeof(System.Collections.Generic.LinkedList<int>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 10)].Name != "captura") 
                            || (locationReferences[(offset + 10)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "PosicionActual") 
                            || (locationReferences[(offset + 7)].Type != typeof(System.Drawing.PointF)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "DistanciaPermitida") 
                            || (locationReferences[(offset + 9)].Type != typeof(int)))) {
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
            
            protected System.Drawing.PointF PosicionActual;
            
            protected int DistanciaPermitida;
            
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
            
            protected System.Collections.Generic.LinkedList<System.Drawing.PointF> UbicacionBanderas {
                get {
                    return ((System.Collections.Generic.LinkedList<System.Drawing.PointF>)(this.GetVariableValue((6 + locationsOffset))));
                }
            }
            
            protected System.Collections.Generic.LinkedList<int> IdBandera {
                get {
                    return ((System.Collections.Generic.LinkedList<int>)(this.GetVariableValue((8 + locationsOffset))));
                }
            }
            
            protected string captura {
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
                this.PosicionActual = ((System.Drawing.PointF)(this.GetVariableValue((7 + locationsOffset))));
                this.DistanciaPermitida = ((int)(this.GetVariableValue((9 + locationsOffset))));
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
                if (((locationReferences[(offset + 6)].Name != "UbicacionBanderas") 
                            || (locationReferences[(offset + 6)].Type != typeof(System.Collections.Generic.LinkedList<System.Drawing.PointF>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "IdBandera") 
                            || (locationReferences[(offset + 8)].Type != typeof(System.Collections.Generic.LinkedList<int>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 10)].Name != "captura") 
                            || (locationReferences[(offset + 10)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "PosicionActual") 
                            || (locationReferences[(offset + 7)].Type != typeof(System.Drawing.PointF)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "DistanciaPermitida") 
                            || (locationReferences[(offset + 9)].Type != typeof(int)))) {
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
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 11))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 11);
                }
                expectedLocationsCount = 11;
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
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 11))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 11);
                }
                expectedLocationsCount = 11;
                return Activity1_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Activity1_TypedDataContext4 : Activity1_TypedDataContext3 {
            
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
            
            protected string VarBanderas {
                get {
                    return ((string)(this.GetVariableValue((11 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((11 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr0GetTree() {
                
                #line 61 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                  DistanciaPermitida;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr0Get() {
                
                #line 61 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                  DistanciaPermitida;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr0Set(int value) {
                
                #line 61 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                
                  DistanciaPermitida = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr0Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr0Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 12))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 12);
                }
                expectedLocationsCount = 12;
                if (((locationReferences[(offset + 11)].Name != "VarBanderas") 
                            || (locationReferences[(offset + 11)].Type != typeof(string)))) {
                    return false;
                }
                return Activity1_TypedDataContext3.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Activity1_TypedDataContext4_ForReadOnly : Activity1_TypedDataContext3_ForReadOnly {
            
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
            
            protected string VarBanderas {
                get {
                    return ((string)(this.GetVariableValue((11 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr33GetTree() {
                
                #line 613 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                  VarBanderas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr33Get() {
                
                #line 613 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                  VarBanderas;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr33Get() {
                this.GetValueTypeValues();
                return this.@__Expr33Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 12))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 12);
                }
                expectedLocationsCount = 12;
                if (((locationReferences[(offset + 11)].Name != "VarBanderas") 
                            || (locationReferences[(offset + 11)].Type != typeof(string)))) {
                    return false;
                }
                return Activity1_TypedDataContext3_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Activity1_TypedDataContext5 : Activity1_TypedDataContext4 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected float y;
            
            protected float x;
            
            protected int i;
            
            protected int angulo;
            
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
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 78 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.LinkedList<int>>> expression = () => 
                    IdBandera;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.LinkedList<int> @__Expr2Get() {
                
                #line 78 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                    IdBandera;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.LinkedList<int> ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr2Set(System.Collections.Generic.LinkedList<int> value) {
                
                #line 78 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                
                    IdBandera = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr2Set(System.Collections.Generic.LinkedList<int> value) {
                this.GetValueTypeValues();
                this.@__Expr2Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 90 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.LinkedList<System.Drawing.PointF>>> expression = () => 
                    UbicacionBanderas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.LinkedList<System.Drawing.PointF> @__Expr4Get() {
                
                #line 90 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                    UbicacionBanderas;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.LinkedList<System.Drawing.PointF> ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr4Set(System.Collections.Generic.LinkedList<System.Drawing.PointF> value) {
                
                #line 90 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                
                    UbicacionBanderas = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr4Set(System.Collections.Generic.LinkedList<System.Drawing.PointF> value) {
                this.GetValueTypeValues();
                this.@__Expr4Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 102 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                    i;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr5Get() {
                
                #line 102 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                    i;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr5Set(int value) {
                
                #line 102 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                
                    i = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr5Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr5Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 112 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                    angulo;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr6Get() {
                
                #line 112 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                    angulo;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr6Set(int value) {
                
                #line 112 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                
                    angulo = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr6Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr6Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 122 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                    VarBanderas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr7Get() {
                
                #line 122 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                    VarBanderas;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr7Set(string value) {
                
                #line 122 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                
                    VarBanderas = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr7Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr7Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 137 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<float>> expression = () => 
                        x;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public float @__Expr9Get() {
                
                #line 137 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                        x;
                
                #line default
                #line hidden
            }
            
            public float ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr9Set(float value) {
                
                #line 137 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                
                        x = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr9Set(float value) {
                this.GetValueTypeValues();
                this.@__Expr9Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 149 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<float>> expression = () => 
                        y;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public float @__Expr11Get() {
                
                #line 149 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                        y;
                
                #line default
                #line hidden
            }
            
            public float ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr11Set(float value) {
                
                #line 149 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                
                        y = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr11Set(float value) {
                this.GetValueTypeValues();
                this.@__Expr11Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr17GetTree() {
                
                #line 181 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                        VarBanderas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr17Get() {
                
                #line 181 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                        VarBanderas;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr17Get() {
                this.GetValueTypeValues();
                return this.@__Expr17Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr17Set(string value) {
                
                #line 181 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                
                        VarBanderas = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr17Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr17Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr19GetTree() {
                
                #line 193 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                        angulo;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr19Get() {
                
                #line 193 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                        angulo;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr19Get() {
                this.GetValueTypeValues();
                return this.@__Expr19Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr19Set(int value) {
                
                #line 193 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                
                        angulo = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr19Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr19Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr21GetTree() {
                
                #line 205 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                        i;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr21Get() {
                
                #line 205 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                        i;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr21Get() {
                this.GetValueTypeValues();
                return this.@__Expr21Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr21Set(int value) {
                
                #line 205 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                
                        i = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr21Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr21Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr24GetTree() {
                
                #line 219 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                    VarBanderas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr24Get() {
                
                #line 219 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                    VarBanderas;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr24Get() {
                this.GetValueTypeValues();
                return this.@__Expr24Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr24Set(string value) {
                
                #line 219 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                
                    VarBanderas = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr24Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr24Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr26GetTree() {
                
                #line 231 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                    VarBanderas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr26Get() {
                
                #line 231 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                    VarBanderas;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr26Get() {
                this.GetValueTypeValues();
                return this.@__Expr26Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr26Set(string value) {
                
                #line 231 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                
                    VarBanderas = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr26Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr26Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr28GetTree() {
                
                #line 243 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<string>>> expression = () => 
                    Archivo;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<string> @__Expr28Get() {
                
                #line 243 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                    Archivo;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<string> ValueType___Expr28Get() {
                this.GetValueTypeValues();
                return this.@__Expr28Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr28Set(System.Collections.Generic.List<string> value) {
                
                #line 243 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                
                    Archivo = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr28Set(System.Collections.Generic.List<string> value) {
                this.GetValueTypeValues();
                this.@__Expr28Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.y = ((float)(this.GetVariableValue((12 + locationsOffset))));
                this.x = ((float)(this.GetVariableValue((13 + locationsOffset))));
                this.i = ((int)(this.GetVariableValue((14 + locationsOffset))));
                this.angulo = ((int)(this.GetVariableValue((15 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((12 + locationsOffset), this.y);
                this.SetVariableValue((13 + locationsOffset), this.x);
                this.SetVariableValue((14 + locationsOffset), this.i);
                this.SetVariableValue((15 + locationsOffset), this.angulo);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 16))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 16);
                }
                expectedLocationsCount = 16;
                if (((locationReferences[(offset + 12)].Name != "y") 
                            || (locationReferences[(offset + 12)].Type != typeof(float)))) {
                    return false;
                }
                if (((locationReferences[(offset + 13)].Name != "x") 
                            || (locationReferences[(offset + 13)].Type != typeof(float)))) {
                    return false;
                }
                if (((locationReferences[(offset + 14)].Name != "i") 
                            || (locationReferences[(offset + 14)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 15)].Name != "angulo") 
                            || (locationReferences[(offset + 15)].Type != typeof(int)))) {
                    return false;
                }
                return Activity1_TypedDataContext4.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Activity1_TypedDataContext5_ForReadOnly : Activity1_TypedDataContext4_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected float y;
            
            protected float x;
            
            protected int i;
            
            protected int angulo;
            
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
            
            internal System.Linq.Expressions.Expression @__Expr1GetTree() {
                
                #line 83 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.LinkedList<int>>> expression = () => 
                    new LinkedList<int>();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.LinkedList<int> @__Expr1Get() {
                
                #line 83 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                    new LinkedList<int>();
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.LinkedList<int> ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 95 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.LinkedList<System.Drawing.PointF>>> expression = () => 
                    new LinkedList<PointF>();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.LinkedList<System.Drawing.PointF> @__Expr3Get() {
                
                #line 95 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                    new LinkedList<PointF>();
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.LinkedList<System.Drawing.PointF> ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 142 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<float>> expression = () => 
                        Radio * (float)(Math.Cos((Math.PI * angulo / 180)));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public float @__Expr8Get() {
                
                #line 142 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                        Radio * (float)(Math.Cos((Math.PI * angulo / 180)));
                
                #line default
                #line hidden
            }
            
            public float ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 154 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<float>> expression = () => 
                        Radio * (float)(Math.Sin((Math.PI * angulo / 180)));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public float @__Expr10Get() {
                
                #line 154 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                        Radio * (float)(Math.Sin((Math.PI * angulo / 180)));
                
                #line default
                #line hidden
            }
            
            public float ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 165 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<System.Drawing.PointF>>> expression = () => 
                      UbicacionBanderas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<System.Drawing.PointF> @__Expr12Get() {
                
                #line 165 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                      UbicacionBanderas;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<System.Drawing.PointF> ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 161 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                        new PointF(x,y);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr13Get() {
                
                #line 161 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                        new PointF(x,y);
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 175 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<int>>> expression = () => 
                      IdBandera;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<int> @__Expr14Get() {
                
                #line 175 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                      IdBandera;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<int> ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr15GetTree() {
                
                #line 171 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                        i;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr15Get() {
                
                #line 171 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                        i;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr15Get() {
                this.GetValueTypeValues();
                return this.@__Expr15Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr16GetTree() {
                
                #line 186 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                        VarBanderas + " { \"id\":\"" + i.ToString() + "\", \"color\":\"" + Color + "\", \"x\":\"" + x.ToString().Replace(",", ".") + "\", \"y\":\"" + y.ToString().Replace(",", ".") + "\", \"visible\":\"true\" },";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr16Get() {
                
                #line 186 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                        VarBanderas + " { \"id\":\"" + i.ToString() + "\", \"color\":\"" + Color + "\", \"x\":\"" + x.ToString().Replace(",", ".") + "\", \"y\":\"" + y.ToString().Replace(",", ".") + "\", \"visible\":\"true\" },";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr16Get() {
                this.GetValueTypeValues();
                return this.@__Expr16Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr18GetTree() {
                
                #line 198 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                        angulo+Separacion;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr18Get() {
                
                #line 198 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                        angulo+Separacion;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr18Get() {
                this.GetValueTypeValues();
                return this.@__Expr18Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr20GetTree() {
                
                #line 210 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                        i+1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr20Get() {
                
                #line 210 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                        i+1;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr20Get() {
                this.GetValueTypeValues();
                return this.@__Expr20Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr22GetTree() {
                
                #line 131 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                  i<TotalBanderas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr22Get() {
                
                #line 131 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                  i<TotalBanderas;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr22Get() {
                this.GetValueTypeValues();
                return this.@__Expr22Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr23GetTree() {
                
                #line 224 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                    VarBanderas.Substring(0, VarBanderas.Length - 1);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr23Get() {
                
                #line 224 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                    VarBanderas.Substring(0, VarBanderas.Length - 1);
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr23Get() {
                this.GetValueTypeValues();
                return this.@__Expr23Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr25GetTree() {
                
                #line 236 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                    VarBanderas + " ]";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr25Get() {
                
                #line 236 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                    VarBanderas + " ]";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr25Get() {
                this.GetValueTypeValues();
                return this.@__Expr25Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr27GetTree() {
                
                #line 248 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<string>>> expression = () => 
                    new List<String>();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<string> @__Expr27Get() {
                
                #line 248 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                    new List<String>();
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<string> ValueType___Expr27Get() {
                this.GetValueTypeValues();
                return this.@__Expr27Get();
            }
            
            protected override void GetValueTypeValues() {
                this.y = ((float)(this.GetVariableValue((12 + locationsOffset))));
                this.x = ((float)(this.GetVariableValue((13 + locationsOffset))));
                this.i = ((int)(this.GetVariableValue((14 + locationsOffset))));
                this.angulo = ((int)(this.GetVariableValue((15 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 16))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 16);
                }
                expectedLocationsCount = 16;
                if (((locationReferences[(offset + 12)].Name != "y") 
                            || (locationReferences[(offset + 12)].Type != typeof(float)))) {
                    return false;
                }
                if (((locationReferences[(offset + 13)].Name != "x") 
                            || (locationReferences[(offset + 13)].Type != typeof(float)))) {
                    return false;
                }
                if (((locationReferences[(offset + 14)].Name != "i") 
                            || (locationReferences[(offset + 14)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 15)].Name != "angulo") 
                            || (locationReferences[(offset + 15)].Type != typeof(int)))) {
                    return false;
                }
                return Activity1_TypedDataContext4_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Activity1_TypedDataContext6 : Activity1_TypedDataContext4 {
            
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
            
            protected string Coordenadas {
                get {
                    return ((string)(this.GetVariableValue((12 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((12 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr29GetTree() {
                
                #line 265 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                      Coordenadas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr29Get() {
                
                #line 265 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                      Coordenadas;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr29Get() {
                this.GetValueTypeValues();
                return this.@__Expr29Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr29Set(string value) {
                
                #line 265 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                
                      Coordenadas = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr29Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr29Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr32GetTree() {
                
                #line 277 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                      PosicionActual;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr32Get() {
                
                #line 277 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                      PosicionActual;
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr32Get() {
                this.GetValueTypeValues();
                return this.@__Expr32Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr32Set(System.Drawing.PointF value) {
                
                #line 277 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                
                      PosicionActual = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr32Set(System.Drawing.PointF value) {
                this.GetValueTypeValues();
                this.@__Expr32Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 13))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 13);
                }
                expectedLocationsCount = 13;
                if (((locationReferences[(offset + 12)].Name != "Coordenadas") 
                            || (locationReferences[(offset + 12)].Type != typeof(string)))) {
                    return false;
                }
                return Activity1_TypedDataContext4.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Activity1_TypedDataContext6_ForReadOnly : Activity1_TypedDataContext4_ForReadOnly {
            
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
            
            protected string Coordenadas {
                get {
                    return ((string)(this.GetVariableValue((12 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr30GetTree() {
                
                #line 271 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                    "L{ \"id\":\""+Escenario+"\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr30Get() {
                
                #line 271 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                    "L{ \"id\":\""+Escenario+"\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr30Get() {
                this.GetValueTypeValues();
                return this.@__Expr30Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr31GetTree() {
                
                #line 282 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                      new PointF(Single.Parse(Coordenadas.Split(';')[0].Replace(".", ",")), Single.Parse(Coordenadas.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr31Get() {
                
                #line 282 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                      new PointF(Single.Parse(Coordenadas.Split(';')[0].Replace(".", ",")), Single.Parse(Coordenadas.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr31Get() {
                this.GetValueTypeValues();
                return this.@__Expr31Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 13))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 13);
                }
                expectedLocationsCount = 13;
                if (((locationReferences[(offset + 12)].Name != "Coordenadas") 
                            || (locationReferences[(offset + 12)].Type != typeof(string)))) {
                    return false;
                }
                return Activity1_TypedDataContext4_ForReadOnly.Validate(locationReferences, false, offset);
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
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 11))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 11);
                }
                expectedLocationsCount = 11;
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
            
            internal System.Linq.Expressions.Expression @__Expr34GetTree() {
                
                #line 298 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                      Archivo;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr34Get() {
                
                #line 298 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                      Archivo;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr34Get() {
                this.GetValueTypeValues();
                return this.@__Expr34Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr35GetTree() {
                
                #line 294 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                        DateTime.Now.ToString() + ";" + PosicionActual.X.ToString().Replace(",", ".") + ";" + PosicionActual.Y.ToString().Replace(",", ".") + ",DET";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr35Get() {
                
                #line 294 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                        DateTime.Now.ToString() + ";" + PosicionActual.X.ToString().Replace(",", ".") + ";" + PosicionActual.Y.ToString().Replace(",", ".") + ",DET";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr35Get() {
                this.GetValueTypeValues();
                return this.@__Expr35Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr39GetTree() {
                
                #line 331 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      (Math.Sqrt(Math.Pow(PosicionActual.X, 2) + Math.Pow(PosicionActual.Y, 2))) <= DistanciaPermitida;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr39Get() {
                
                #line 331 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                      (Math.Sqrt(Math.Pow(PosicionActual.X, 2) + Math.Pow(PosicionActual.Y, 2))) <= DistanciaPermitida;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr39Get() {
                this.GetValueTypeValues();
                return this.@__Expr39Get();
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
                return Activity1_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Activity1_TypedDataContext8 : Activity1_TypedDataContext7 {
            
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
            
            protected string Coordenadas {
                get {
                    return ((string)(this.GetVariableValue((11 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((11 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr36GetTree() {
                
                #line 312 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                              Coordenadas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr36Get() {
                
                #line 312 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                              Coordenadas;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr36Get() {
                this.GetValueTypeValues();
                return this.@__Expr36Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr36Set(string value) {
                
                #line 312 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                
                              Coordenadas = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr36Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr36Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr38GetTree() {
                
                #line 319 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                              PosicionActual;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr38Get() {
                
                #line 319 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                              PosicionActual;
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr38Get() {
                this.GetValueTypeValues();
                return this.@__Expr38Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr38Set(System.Drawing.PointF value) {
                
                #line 319 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                
                              PosicionActual = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr38Set(System.Drawing.PointF value) {
                this.GetValueTypeValues();
                this.@__Expr38Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 12))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 12);
                }
                expectedLocationsCount = 12;
                if (((locationReferences[(offset + 11)].Name != "Coordenadas") 
                            || (locationReferences[(offset + 11)].Type != typeof(string)))) {
                    return false;
                }
                return Activity1_TypedDataContext7.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Activity1_TypedDataContext8_ForReadOnly : Activity1_TypedDataContext7_ForReadOnly {
            
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
            
            protected string Coordenadas {
                get {
                    return ((string)(this.GetVariableValue((11 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr37GetTree() {
                
                #line 324 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                              new PointF(Single.Parse(Coordenadas.Split(';')[0].Replace(".", ",")), Single.Parse(Coordenadas.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr37Get() {
                
                #line 324 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                              new PointF(Single.Parse(Coordenadas.Split(';')[0].Replace(".", ",")), Single.Parse(Coordenadas.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr37Get() {
                this.GetValueTypeValues();
                return this.@__Expr37Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 12))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 12);
                }
                expectedLocationsCount = 12;
                if (((locationReferences[(offset + 11)].Name != "Coordenadas") 
                            || (locationReferences[(offset + 11)].Type != typeof(string)))) {
                    return false;
                }
                return Activity1_TypedDataContext7_ForReadOnly.Validate(locationReferences, false, offset);
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
            
            internal System.Linq.Expressions.Expression @__Expr42GetTree() {
                
                #line 353 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  captura;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr42Get() {
                
                #line 353 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                                  captura;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr42Get() {
                this.GetValueTypeValues();
                return this.@__Expr42Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr42Set(string value) {
                
                #line 353 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                
                                  captura = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr42Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr42Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr60GetTree() {
                
                #line 585 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                      captura;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr60Get() {
                
                #line 585 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                                      captura;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr60Get() {
                this.GetValueTypeValues();
                return this.@__Expr60Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr60Set(string value) {
                
                #line 585 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                
                                      captura = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr60Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr60Set(value);
                this.SetValueTypeValues();
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
            
            internal System.Linq.Expressions.Expression @__Expr40GetTree() {
                
                #line 347 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                                Archivo;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr40Get() {
                
                #line 347 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                                Archivo;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr40Get() {
                this.GetValueTypeValues();
                return this.@__Expr40Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr41GetTree() {
                
                #line 340 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  DateTime.Now.ToString() + ";" 
                + PosicionActual.X.ToString().Replace(",", ".") 
                + ";" + PosicionActual.Y.ToString().Replace(",", ".") 
                + ";BUS";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr41Get() {
                
                #line 340 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                                  DateTime.Now.ToString() + ";" 
                + PosicionActual.X.ToString().Replace(",", ".") 
                + ";" + PosicionActual.Y.ToString().Replace(",", ".") 
                + ";BUS";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr41Get() {
                this.GetValueTypeValues();
                return this.@__Expr41Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr59GetTree() {
                
                #line 595 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              captura.Equals("S");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr59Get() {
                
                #line 595 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                              captura.Equals("S");
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr59Get() {
                this.GetValueTypeValues();
                return this.@__Expr59Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr61GetTree() {
                
                #line 600 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              !((UbicacionBanderas.Count >= 1) && captura.Equals("S"));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr61Get() {
                
                #line 600 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                              !((UbicacionBanderas.Count >= 1) && captura.Equals("S"));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr61Get() {
                this.GetValueTypeValues();
                return this.@__Expr61Get();
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
                return Activity1_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Activity1_TypedDataContext10 : Activity1_TypedDataContext9 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int i;
            
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
            
            internal System.Linq.Expressions.Expression @__Expr43GetTree() {
                
                #line 367 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                    i;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr43Get() {
                
                #line 367 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                                    i;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr43Get() {
                this.GetValueTypeValues();
                return this.@__Expr43Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr43Set(int value) {
                
                #line 367 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                
                                    i = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr43Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr43Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.i = ((int)(this.GetVariableValue((11 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((11 + locationsOffset), this.i);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 12))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 12);
                }
                expectedLocationsCount = 12;
                if (((locationReferences[(offset + 11)].Name != "i") 
                            || (locationReferences[(offset + 11)].Type != typeof(int)))) {
                    return false;
                }
                return Activity1_TypedDataContext9.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Activity1_TypedDataContext10_ForReadOnly : Activity1_TypedDataContext9_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int i;
            
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
            
            internal System.Linq.Expressions.Expression @__Expr55GetTree() {
                
                #line 376 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                  captura.Equals("N") && i<UbicacionBanderas.Count;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr55Get() {
                
                #line 376 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                                  captura.Equals("N") && i<UbicacionBanderas.Count;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr55Get() {
                this.GetValueTypeValues();
                return this.@__Expr55Get();
            }
            
            protected override void GetValueTypeValues() {
                this.i = ((int)(this.GetVariableValue((11 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 12))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 12);
                }
                expectedLocationsCount = 12;
                if (((locationReferences[(offset + 11)].Name != "i") 
                            || (locationReferences[(offset + 11)].Type != typeof(int)))) {
                    return false;
                }
                return Activity1_TypedDataContext9_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Activity1_TypedDataContext11 : Activity1_TypedDataContext10 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected System.Drawing.PointF item;
            
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
            
            internal System.Linq.Expressions.Expression @__Expr45GetTree() {
                
                #line 385 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                                        item;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr45Get() {
                
                #line 385 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                                        item;
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr45Get() {
                this.GetValueTypeValues();
                return this.@__Expr45Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr45Set(System.Drawing.PointF value) {
                
                #line 385 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                
                                        item = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr45Set(System.Drawing.PointF value) {
                this.GetValueTypeValues();
                this.@__Expr45Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr47GetTree() {
                
                #line 405 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                              captura;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr47Get() {
                
                #line 405 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                                              captura;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr47Get() {
                this.GetValueTypeValues();
                return this.@__Expr47Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr47Set(string value) {
                
                #line 405 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                
                                              captura = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr47Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr47Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr54GetTree() {
                
                #line 443 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                        i;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr54Get() {
                
                #line 443 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                                        i;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr54Get() {
                this.GetValueTypeValues();
                return this.@__Expr54Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr54Set(int value) {
                
                #line 443 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                
                                        i = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr54Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr54Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.item = ((System.Drawing.PointF)(this.GetVariableValue((12 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((12 + locationsOffset), this.item);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 13))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 13);
                }
                expectedLocationsCount = 13;
                if (((locationReferences[(offset + 12)].Name != "item") 
                            || (locationReferences[(offset + 12)].Type != typeof(System.Drawing.PointF)))) {
                    return false;
                }
                return Activity1_TypedDataContext10.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Activity1_TypedDataContext11_ForReadOnly : Activity1_TypedDataContext10_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected System.Drawing.PointF item;
            
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
            
            internal System.Linq.Expressions.Expression @__Expr44GetTree() {
                
                #line 390 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                                        UbicacionBanderas.ElementAt(i);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr44Get() {
                
                #line 390 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                                        UbicacionBanderas.ElementAt(i);
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr44Get() {
                this.GetValueTypeValues();
                return this.@__Expr44Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr46GetTree() {
                
                #line 397 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                        Math.Sqrt(Math.Pow(PosicionActual.X - item.X, 2) + Math.Pow(PosicionActual.Y - item.Y, 2))<DistanciaPermitida;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr46Get() {
                
                #line 397 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                                        Math.Sqrt(Math.Pow(PosicionActual.X - item.X, 2) + Math.Pow(PosicionActual.Y - item.Y, 2))<DistanciaPermitida;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr46Get() {
                this.GetValueTypeValues();
                return this.@__Expr46Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr48GetTree() {
                
                #line 414 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                            "H{ \"id\":\"" + IdBandera.ElementAt(i) + "\", \"visible\":\"false\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr48Get() {
                
                #line 414 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                                            "H{ \"id\":\"" + IdBandera.ElementAt(i) + "\", \"visible\":\"false\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr48Get() {
                this.GetValueTypeValues();
                return this.@__Expr48Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr49GetTree() {
                
                #line 424 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<System.Drawing.PointF>>> expression = () => 
                                            UbicacionBanderas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<System.Drawing.PointF> @__Expr49Get() {
                
                #line 424 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                                            UbicacionBanderas;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<System.Drawing.PointF> ValueType___Expr49Get() {
                this.GetValueTypeValues();
                return this.@__Expr49Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr50GetTree() {
                
                #line 420 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                                              item;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr50Get() {
                
                #line 420 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                                              item;
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr50Get() {
                this.GetValueTypeValues();
                return this.@__Expr50Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr51GetTree() {
                
                #line 434 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<int>>> expression = () => 
                                            IdBandera;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<int> @__Expr51Get() {
                
                #line 434 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                                            IdBandera;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<int> ValueType___Expr51Get() {
                this.GetValueTypeValues();
                return this.@__Expr51Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr52GetTree() {
                
                #line 430 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                              IdBandera.ElementAt(i);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr52Get() {
                
                #line 430 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                                              IdBandera.ElementAt(i);
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr52Get() {
                this.GetValueTypeValues();
                return this.@__Expr52Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr53GetTree() {
                
                #line 448 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                        i+1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr53Get() {
                
                #line 448 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                                        i+1;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr53Get() {
                this.GetValueTypeValues();
                return this.@__Expr53Get();
            }
            
            protected override void GetValueTypeValues() {
                this.item = ((System.Drawing.PointF)(this.GetVariableValue((12 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 13))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 13);
                }
                expectedLocationsCount = 13;
                if (((locationReferences[(offset + 12)].Name != "item") 
                            || (locationReferences[(offset + 12)].Type != typeof(System.Drawing.PointF)))) {
                    return false;
                }
                return Activity1_TypedDataContext10_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Activity1_TypedDataContext12 : Activity1_TypedDataContext9 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Activity1_TypedDataContext12(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext12(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext12(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string Coordenadas {
                get {
                    return ((string)(this.GetVariableValue((11 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((11 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr56GetTree() {
                
                #line 467 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                      Coordenadas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr56Get() {
                
                #line 467 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                                      Coordenadas;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr56Get() {
                this.GetValueTypeValues();
                return this.@__Expr56Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr56Set(string value) {
                
                #line 467 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                
                                      Coordenadas = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr56Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr56Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr58GetTree() {
                
                #line 474 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                                      PosicionActual;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr58Get() {
                
                #line 474 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                                      PosicionActual;
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr58Get() {
                this.GetValueTypeValues();
                return this.@__Expr58Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr58Set(System.Drawing.PointF value) {
                
                #line 474 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                
                                      PosicionActual = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr58Set(System.Drawing.PointF value) {
                this.GetValueTypeValues();
                this.@__Expr58Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 12))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 12);
                }
                expectedLocationsCount = 12;
                if (((locationReferences[(offset + 11)].Name != "Coordenadas") 
                            || (locationReferences[(offset + 11)].Type != typeof(string)))) {
                    return false;
                }
                return Activity1_TypedDataContext9.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Activity1_TypedDataContext12_ForReadOnly : Activity1_TypedDataContext9_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Activity1_TypedDataContext12_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext12_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext12_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string Coordenadas {
                get {
                    return ((string)(this.GetVariableValue((11 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr57GetTree() {
                
                #line 479 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                                      new PointF(Single.Parse(Coordenadas.Split(';')[0].Replace(".", ",")), Single.Parse(Coordenadas.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr57Get() {
                
                #line 479 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                                      new PointF(Single.Parse(Coordenadas.Split(';')[0].Replace(".", ",")), Single.Parse(Coordenadas.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr57Get() {
                this.GetValueTypeValues();
                return this.@__Expr57Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 12))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 12);
                }
                expectedLocationsCount = 12;
                if (((locationReferences[(offset + 11)].Name != "Coordenadas") 
                            || (locationReferences[(offset + 11)].Type != typeof(string)))) {
                    return false;
                }
                return Activity1_TypedDataContext9_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Activity1_TypedDataContext13 : Activity1_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Activity1_TypedDataContext13(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext13(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext13(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                            && (locationReferences.Count < 11))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 11);
                }
                expectedLocationsCount = 11;
                return Activity1_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Activity1_TypedDataContext13_ForReadOnly : Activity1_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Activity1_TypedDataContext13_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext13_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext13_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr62GetTree() {
                
                #line 497 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                                      Archivo;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr62Get() {
                
                #line 497 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                                      Archivo;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr62Get() {
                this.GetValueTypeValues();
                return this.@__Expr62Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr63GetTree() {
                
                #line 491 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                        DateTime.Now.ToString() + ";" 
                + PosicionActual.X.ToString().Replace(",", ".") + ";" 
                + PosicionActual.Y.ToString().Replace(",", ".") + ";CEN";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr63Get() {
                
                #line 491 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                                        DateTime.Now.ToString() + ";" 
                + PosicionActual.X.ToString().Replace(",", ".") + ";" 
                + PosicionActual.Y.ToString().Replace(",", ".") + ";CEN";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr63Get() {
                this.GetValueTypeValues();
                return this.@__Expr63Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr67GetTree() {
                
                #line 533 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                      ((Math.Sqrt(Math.Pow(PosicionActual.X, 2) + Math.Pow(PosicionActual.Y, 2))) <= DistanciaPermitida) && ((UbicacionBanderas.Count != 0));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr67Get() {
                
                #line 533 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                                      ((Math.Sqrt(Math.Pow(PosicionActual.X, 2) + Math.Pow(PosicionActual.Y, 2))) <= DistanciaPermitida) && ((UbicacionBanderas.Count != 0));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr67Get() {
                this.GetValueTypeValues();
                return this.@__Expr67Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr68GetTree() {
                
                #line 538 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                      (Math.Sqrt(Math.Pow(PosicionActual.X, 2) + Math.Pow(PosicionActual.Y, 2))) > DistanciaPermitida;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr68Get() {
                
                #line 538 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                                      (Math.Sqrt(Math.Pow(PosicionActual.X, 2) + Math.Pow(PosicionActual.Y, 2))) > DistanciaPermitida;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr68Get() {
                this.GetValueTypeValues();
                return this.@__Expr68Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr69GetTree() {
                
                #line 543 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                      ((Math.Sqrt(Math.Pow(PosicionActual.X, 2) + Math.Pow(PosicionActual.Y, 2))) <= DistanciaPermitida)&&(UbicacionBanderas.Count == 0);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr69Get() {
                
                #line 543 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                                      ((Math.Sqrt(Math.Pow(PosicionActual.X, 2) + Math.Pow(PosicionActual.Y, 2))) <= DistanciaPermitida)&&(UbicacionBanderas.Count == 0);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr69Get() {
                this.GetValueTypeValues();
                return this.@__Expr69Get();
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
                return Activity1_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Activity1_TypedDataContext14 : Activity1_TypedDataContext13 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Activity1_TypedDataContext14(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext14(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext14(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string Coordenadas {
                get {
                    return ((string)(this.GetVariableValue((11 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((11 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr64GetTree() {
                
                #line 511 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                              Coordenadas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr64Get() {
                
                #line 511 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                                              Coordenadas;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr64Get() {
                this.GetValueTypeValues();
                return this.@__Expr64Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr64Set(string value) {
                
                #line 511 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                
                                              Coordenadas = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr64Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr64Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr66GetTree() {
                
                #line 518 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                                              PosicionActual;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr66Get() {
                
                #line 518 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                                              PosicionActual;
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr66Get() {
                this.GetValueTypeValues();
                return this.@__Expr66Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr66Set(System.Drawing.PointF value) {
                
                #line 518 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                
                                              PosicionActual = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr66Set(System.Drawing.PointF value) {
                this.GetValueTypeValues();
                this.@__Expr66Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 12))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 12);
                }
                expectedLocationsCount = 12;
                if (((locationReferences[(offset + 11)].Name != "Coordenadas") 
                            || (locationReferences[(offset + 11)].Type != typeof(string)))) {
                    return false;
                }
                return Activity1_TypedDataContext13.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Activity1_TypedDataContext14_ForReadOnly : Activity1_TypedDataContext13_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Activity1_TypedDataContext14_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext14_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext14_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string Coordenadas {
                get {
                    return ((string)(this.GetVariableValue((11 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr65GetTree() {
                
                #line 523 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                                              new PointF(Single.Parse(Coordenadas.Split(';')[0].Replace(".", ",")), Single.Parse(Coordenadas.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr65Get() {
                
                #line 523 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                                              new PointF(Single.Parse(Coordenadas.Split(';')[0].Replace(".", ",")), Single.Parse(Coordenadas.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr65Get() {
                this.GetValueTypeValues();
                return this.@__Expr65Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 12))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 12);
                }
                expectedLocationsCount = 12;
                if (((locationReferences[(offset + 11)].Name != "Coordenadas") 
                            || (locationReferences[(offset + 11)].Type != typeof(string)))) {
                    return false;
                }
                return Activity1_TypedDataContext13_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Activity1_TypedDataContext15 : Activity1_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Activity1_TypedDataContext15(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext15(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext15(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                            && (locationReferences.Count < 11))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 11);
                }
                expectedLocationsCount = 11;
                return Activity1_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Activity1_TypedDataContext15_ForReadOnly : Activity1_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Activity1_TypedDataContext15_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext15_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity1_TypedDataContext15_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr70GetTree() {
                
                #line 558 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                                                Archivo;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr70Get() {
                
                #line 558 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                                                Archivo;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr70Get() {
                this.GetValueTypeValues();
                return this.@__Expr70Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr71GetTree() {
                
                #line 552 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                  DateTime.Now.ToString() + ";" 
                + PosicionActual.X.ToString().Replace(",", ".") + ";" 
                + PosicionActual.Y.ToString().Replace(",", ".") + ";FIN";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr71Get() {
                
                #line 552 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                                                  DateTime.Now.ToString() + ";" 
                + PosicionActual.X.ToString().Replace(",", ".") + ";" 
                + PosicionActual.Y.ToString().Replace(",", ".") + ";FIN";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr71Get() {
                this.GetValueTypeValues();
                return this.@__Expr71Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr72GetTree() {
                
                #line 563 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                "Q{ \"text\":\"Fin del experimento\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr72Get() {
                
                #line 563 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                                                "Q{ \"text\":\"Fin del experimento\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr72Get() {
                this.GetValueTypeValues();
                return this.@__Expr72Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr73GetTree() {
                
                #line 568 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                System.Linq.Expressions.Expression<System.Func<System.TimeSpan>> expression = () => 
                                                TimeSpan.FromSeconds(5);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.TimeSpan @__Expr73Get() {
                
                #line 568 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\HABITUACIÓN\HABITUACIONWF.XAML"
                return 
                                                TimeSpan.FromSeconds(5);
                
                #line default
                #line hidden
            }
            
            public System.TimeSpan ValueType___Expr73Get() {
                this.GetValueTypeValues();
                return this.@__Expr73Get();
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
                return Activity1_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
