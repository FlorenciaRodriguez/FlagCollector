namespace Ejercicio {
    
    #line 36 "C:\Users\DellPladema\Desktop\Nueva carpeta (2)\VFinal\WFFlagCollector\FlagCollector\Ejercicio\Ejercicio.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\DellPladema\Desktop\Nueva carpeta (2)\VFinal\WFFlagCollector\FlagCollector\Ejercicio\Ejercicio.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 37 "C:\Users\DellPladema\Desktop\Nueva carpeta (2)\VFinal\WFFlagCollector\FlagCollector\Ejercicio\Ejercicio.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\DellPladema\Desktop\Nueva carpeta (2)\VFinal\WFFlagCollector\FlagCollector\Ejercicio\Ejercicio.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\DellPladema\Desktop\Nueva carpeta (2)\VFinal\WFFlagCollector\FlagCollector\Ejercicio\Ejercicio.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\DellPladema\Desktop\Nueva carpeta (2)\VFinal\WFFlagCollector\FlagCollector\Ejercicio\Ejercicio.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 38 "C:\Users\DellPladema\Desktop\Nueva carpeta (2)\VFinal\WFFlagCollector\FlagCollector\Ejercicio\Ejercicio.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 39 "C:\Users\DellPladema\Desktop\Nueva carpeta (2)\VFinal\WFFlagCollector\FlagCollector\Ejercicio\Ejercicio.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 40 "C:\Users\DellPladema\Desktop\Nueva carpeta (2)\VFinal\WFFlagCollector\FlagCollector\Ejercicio\Ejercicio.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 41 "C:\Users\DellPladema\Desktop\Nueva carpeta (2)\VFinal\WFFlagCollector\FlagCollector\Ejercicio\Ejercicio.xaml"
    using System.Drawing;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\DellPladema\Desktop\Nueva carpeta (2)\VFinal\WFFlagCollector\FlagCollector\Ejercicio\Ejercicio.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class Ejercicio : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
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
                this.dataContextActivities = Ejercicio_TypedDataContext3_ForReadOnly.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Ejercicio_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext3_ForReadOnly valDataContext0 = ((Ejercicio_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Ejercicio_TypedDataContext3(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext3 refDataContext1 = ((Ejercicio_TypedDataContext3)(cachedCompiledDataContext[1]));
                return refDataContext1.GetLocation<System.Collections.Generic.List<string>>(refDataContext1.ValueType___Expr1Get, refDataContext1.ValueType___Expr1Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Ejercicio_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext3_ForReadOnly valDataContext2 = ((Ejercicio_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Ejercicio_TypedDataContext3(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext3 refDataContext3 = ((Ejercicio_TypedDataContext3)(cachedCompiledDataContext[1]));
                return refDataContext3.GetLocation<System.Collections.Generic.List<string>>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Ejercicio_TypedDataContext3(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext3 refDataContext4 = ((Ejercicio_TypedDataContext3)(cachedCompiledDataContext[1]));
                return refDataContext4.GetLocation<int>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Ejercicio_TypedDataContext3(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext3 refDataContext5 = ((Ejercicio_TypedDataContext3)(cachedCompiledDataContext[1]));
                return refDataContext5.GetLocation<int>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Ejercicio_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext3_ForReadOnly valDataContext6 = ((Ejercicio_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Ejercicio_TypedDataContext3(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext3 refDataContext7 = ((Ejercicio_TypedDataContext3)(cachedCompiledDataContext[1]));
                return refDataContext7.GetLocation<int>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Ejercicio_TypedDataContext3(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext3 refDataContext8 = ((Ejercicio_TypedDataContext3)(cachedCompiledDataContext[1]));
                return refDataContext8.GetLocation<int>(refDataContext8.ValueType___Expr8Get, refDataContext8.ValueType___Expr8Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Ejercicio_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext3_ForReadOnly valDataContext9 = ((Ejercicio_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Ejercicio_TypedDataContext3(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext3 refDataContext10 = ((Ejercicio_TypedDataContext3)(cachedCompiledDataContext[1]));
                return refDataContext10.GetLocation<System.Drawing.PointF>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Ejercicio_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext3_ForReadOnly valDataContext11 = ((Ejercicio_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Ejercicio_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext3_ForReadOnly valDataContext12 = ((Ejercicio_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Ejercicio_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext3_ForReadOnly valDataContext13 = ((Ejercicio_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Ejercicio_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext3_ForReadOnly valDataContext14 = ((Ejercicio_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Ejercicio_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext3_ForReadOnly valDataContext15 = ((Ejercicio_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Ejercicio_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext3_ForReadOnly valDataContext16 = ((Ejercicio_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Ejercicio_TypedDataContext3(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext3 refDataContext17 = ((Ejercicio_TypedDataContext3)(cachedCompiledDataContext[1]));
                return refDataContext17.GetLocation<string>(refDataContext17.ValueType___Expr17Get, refDataContext17.ValueType___Expr17Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 18)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Ejercicio_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext3_ForReadOnly valDataContext18 = ((Ejercicio_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext18.ValueType___Expr18Get();
            }
            if ((expressionId == 19)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Ejercicio_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext3_ForReadOnly valDataContext19 = ((Ejercicio_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext19.ValueType___Expr19Get();
            }
            if ((expressionId == 20)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Ejercicio_TypedDataContext3(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext3 refDataContext20 = ((Ejercicio_TypedDataContext3)(cachedCompiledDataContext[1]));
                return refDataContext20.GetLocation<System.Drawing.PointF>(refDataContext20.ValueType___Expr20Get, refDataContext20.ValueType___Expr20Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 21)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Ejercicio_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext3_ForReadOnly valDataContext21 = ((Ejercicio_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext21.ValueType___Expr21Get();
            }
            if ((expressionId == 22)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Ejercicio_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext22 = ((Ejercicio_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Ejercicio_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext23 = ((Ejercicio_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext23.ValueType___Expr23Get();
            }
            if ((expressionId == 24)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Ejercicio_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext24 = ((Ejercicio_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext24.ValueType___Expr24Get();
            }
            if ((expressionId == 25)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Ejercicio_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext25 = ((Ejercicio_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext25.ValueType___Expr25Get();
            }
            if ((expressionId == 26)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Ejercicio_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext26 = ((Ejercicio_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext26.ValueType___Expr26Get();
            }
            if ((expressionId == 27)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Ejercicio_TypedDataContext4(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4 refDataContext27 = ((Ejercicio_TypedDataContext4)(cachedCompiledDataContext[3]));
                return refDataContext27.GetLocation<int>(refDataContext27.ValueType___Expr27Get, refDataContext27.ValueType___Expr27Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 28)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Ejercicio_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext28 = ((Ejercicio_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext28.ValueType___Expr28Get();
            }
            if ((expressionId == 29)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Ejercicio_TypedDataContext4(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4 refDataContext29 = ((Ejercicio_TypedDataContext4)(cachedCompiledDataContext[3]));
                return refDataContext29.GetLocation<int>(refDataContext29.ValueType___Expr29Get, refDataContext29.ValueType___Expr29Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 30)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Ejercicio_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext30 = ((Ejercicio_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext30.ValueType___Expr30Get();
            }
            if ((expressionId == 31)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Ejercicio_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext31 = ((Ejercicio_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext31.ValueType___Expr31Get();
            }
            if ((expressionId == 32)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Ejercicio_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext32 = ((Ejercicio_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext32.ValueType___Expr32Get();
            }
            if ((expressionId == 33)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Ejercicio_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext33 = ((Ejercicio_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext33.ValueType___Expr33Get();
            }
            if ((expressionId == 34)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Ejercicio_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext34 = ((Ejercicio_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext34.ValueType___Expr34Get();
            }
            if ((expressionId == 35)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Ejercicio_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext35 = ((Ejercicio_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext35.ValueType___Expr35Get();
            }
            if ((expressionId == 36)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Ejercicio_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext36 = ((Ejercicio_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext36.ValueType___Expr36Get();
            }
            if ((expressionId == 37)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Ejercicio_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext37 = ((Ejercicio_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext37.ValueType___Expr37Get();
            }
            if ((expressionId == 38)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Ejercicio_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext38 = ((Ejercicio_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext38.ValueType___Expr38Get();
            }
            if ((expressionId == 39)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Ejercicio_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext39 = ((Ejercicio_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext39.ValueType___Expr39Get();
            }
            if ((expressionId == 40)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Ejercicio_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext40 = ((Ejercicio_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext40.ValueType___Expr40Get();
            }
            if ((expressionId == 41)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Ejercicio_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext41 = ((Ejercicio_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext41.ValueType___Expr41Get();
            }
            if ((expressionId == 42)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Ejercicio_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext42 = ((Ejercicio_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext42.ValueType___Expr42Get();
            }
            if ((expressionId == 43)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Ejercicio_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext43 = ((Ejercicio_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext43.ValueType___Expr43Get();
            }
            if ((expressionId == 44)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Ejercicio_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext44 = ((Ejercicio_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext44.ValueType___Expr44Get();
            }
            if ((expressionId == 45)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Ejercicio_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext45 = ((Ejercicio_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext45.ValueType___Expr45Get();
            }
            if ((expressionId == 46)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Ejercicio_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext46 = ((Ejercicio_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext46.ValueType___Expr46Get();
            }
            if ((expressionId == 47)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Ejercicio_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext47 = ((Ejercicio_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext47.ValueType___Expr47Get();
            }
            if ((expressionId == 48)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Ejercicio_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext48 = ((Ejercicio_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext48.ValueType___Expr48Get();
            }
            if ((expressionId == 49)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Ejercicio_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext49 = ((Ejercicio_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext49.ValueType___Expr49Get();
            }
            if ((expressionId == 50)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Ejercicio_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext50 = ((Ejercicio_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext50.ValueType___Expr50Get();
            }
            if ((expressionId == 51)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Ejercicio_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext51 = ((Ejercicio_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext51.ValueType___Expr51Get();
            }
            if ((expressionId == 52)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Ejercicio_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext52 = ((Ejercicio_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext52.ValueType___Expr52Get();
            }
            if ((expressionId == 53)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Ejercicio_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext53 = ((Ejercicio_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext53.ValueType___Expr53Get();
            }
            if ((expressionId == 54)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Ejercicio_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext54 = ((Ejercicio_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext54.ValueType___Expr54Get();
            }
            if ((expressionId == 55)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Ejercicio_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext55 = ((Ejercicio_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext55.ValueType___Expr55Get();
            }
            if ((expressionId == 56)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Ejercicio_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext56 = ((Ejercicio_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext56.ValueType___Expr56Get();
            }
            if ((expressionId == 57)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Ejercicio_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext57 = ((Ejercicio_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext57.ValueType___Expr57Get();
            }
            if ((expressionId == 58)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Ejercicio_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext58 = ((Ejercicio_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext58.ValueType___Expr58Get();
            }
            if ((expressionId == 59)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Ejercicio_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext59 = ((Ejercicio_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext59.ValueType___Expr59Get();
            }
            if ((expressionId == 60)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Ejercicio_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext60 = ((Ejercicio_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext60.ValueType___Expr60Get();
            }
            if ((expressionId == 61)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Ejercicio_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext61 = ((Ejercicio_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext61.ValueType___Expr61Get();
            }
            if ((expressionId == 62)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Ejercicio_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext62 = ((Ejercicio_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext62.ValueType___Expr62Get();
            }
            if ((expressionId == 63)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Ejercicio_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext63 = ((Ejercicio_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext63.ValueType___Expr63Get();
            }
            if ((expressionId == 64)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Ejercicio_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext64 = ((Ejercicio_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext64.ValueType___Expr64Get();
            }
            if ((expressionId == 65)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Ejercicio_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext65 = ((Ejercicio_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext65.ValueType___Expr65Get();
            }
            if ((expressionId == 66)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Ejercicio_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext66 = ((Ejercicio_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext66.ValueType___Expr66Get();
            }
            if ((expressionId == 67)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Ejercicio_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext67 = ((Ejercicio_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext67.ValueType___Expr67Get();
            }
            if ((expressionId == 68)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Ejercicio_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext5_ForReadOnly valDataContext68 = ((Ejercicio_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext68.ValueType___Expr68Get();
            }
            if ((expressionId == 69)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Ejercicio_TypedDataContext5(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext5 refDataContext69 = ((Ejercicio_TypedDataContext5)(cachedCompiledDataContext[5]));
                return refDataContext69.GetLocation<int>(refDataContext69.ValueType___Expr69Get, refDataContext69.ValueType___Expr69Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 70)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Ejercicio_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext5_ForReadOnly valDataContext70 = ((Ejercicio_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext70.ValueType___Expr70Get();
            }
            if ((expressionId == 71)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Ejercicio_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext5_ForReadOnly valDataContext71 = ((Ejercicio_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext71.ValueType___Expr71Get();
            }
            if ((expressionId == 72)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Ejercicio_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext5_ForReadOnly valDataContext72 = ((Ejercicio_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext72.ValueType___Expr72Get();
            }
            if ((expressionId == 73)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Ejercicio_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext5_ForReadOnly valDataContext73 = ((Ejercicio_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext73.ValueType___Expr73Get();
            }
            if ((expressionId == 74)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Ejercicio_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext5_ForReadOnly valDataContext74 = ((Ejercicio_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext74.ValueType___Expr74Get();
            }
            if ((expressionId == 75)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Ejercicio_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext5_ForReadOnly valDataContext75 = ((Ejercicio_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext75.ValueType___Expr75Get();
            }
            if ((expressionId == 76)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Ejercicio_TypedDataContext4(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4 refDataContext76 = ((Ejercicio_TypedDataContext4)(cachedCompiledDataContext[3]));
                return refDataContext76.GetLocation<string>(refDataContext76.ValueType___Expr76Get, refDataContext76.ValueType___Expr76Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 77)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Ejercicio_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext77 = ((Ejercicio_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext77.ValueType___Expr77Get();
            }
            if ((expressionId == 78)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Ejercicio_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext78 = ((Ejercicio_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext78.ValueType___Expr78Get();
            }
            if ((expressionId == 79)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Ejercicio_TypedDataContext4(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4 refDataContext79 = ((Ejercicio_TypedDataContext4)(cachedCompiledDataContext[3]));
                return refDataContext79.GetLocation<System.Drawing.PointF>(refDataContext79.ValueType___Expr79Get, refDataContext79.ValueType___Expr79Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 80)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Ejercicio_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext80 = ((Ejercicio_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext80.ValueType___Expr80Get();
            }
            if ((expressionId == 81)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Ejercicio_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext81 = ((Ejercicio_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext81.ValueType___Expr81Get();
            }
            if ((expressionId == 82)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Ejercicio_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext82 = ((Ejercicio_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext82.ValueType___Expr82Get();
            }
            if ((expressionId == 83)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Ejercicio_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext83 = ((Ejercicio_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext83.ValueType___Expr83Get();
            }
            if ((expressionId == 84)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Ejercicio_TypedDataContext4(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4 refDataContext84 = ((Ejercicio_TypedDataContext4)(cachedCompiledDataContext[3]));
                return refDataContext84.GetLocation<int[]>(refDataContext84.ValueType___Expr84Get, refDataContext84.ValueType___Expr84Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 85)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Ejercicio_TypedDataContext4(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4 refDataContext85 = ((Ejercicio_TypedDataContext4)(cachedCompiledDataContext[3]));
                return refDataContext85.GetLocation<int>(refDataContext85.ValueType___Expr85Get, refDataContext85.ValueType___Expr85Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 86)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Ejercicio_TypedDataContext4(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4 refDataContext86 = ((Ejercicio_TypedDataContext4)(cachedCompiledDataContext[3]));
                return refDataContext86.GetLocation<int>(refDataContext86.ValueType___Expr86Get, refDataContext86.ValueType___Expr86Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 87)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Ejercicio_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext87 = ((Ejercicio_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext87.ValueType___Expr87Get();
            }
            if ((expressionId == 88)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Ejercicio_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext88 = ((Ejercicio_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext88.ValueType___Expr88Get();
            }
            if ((expressionId == 89)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Ejercicio_TypedDataContext4(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4 refDataContext89 = ((Ejercicio_TypedDataContext4)(cachedCompiledDataContext[3]));
                return refDataContext89.GetLocation<int[]>(refDataContext89.ValueType___Expr89Get, refDataContext89.ValueType___Expr89Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 90)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Ejercicio_TypedDataContext4(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4 refDataContext90 = ((Ejercicio_TypedDataContext4)(cachedCompiledDataContext[3]));
                return refDataContext90.GetLocation<int>(refDataContext90.ValueType___Expr90Get, refDataContext90.ValueType___Expr90Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 91)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Ejercicio_TypedDataContext4(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext4 refDataContext91 = ((Ejercicio_TypedDataContext4)(cachedCompiledDataContext[3]));
                return refDataContext91.GetLocation<int>(refDataContext91.ValueType___Expr91Get, refDataContext91.ValueType___Expr91Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 92)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Ejercicio_TypedDataContext6(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext6 refDataContext92 = ((Ejercicio_TypedDataContext6)(cachedCompiledDataContext[6]));
                return refDataContext92.GetLocation<string>(refDataContext92.ValueType___Expr92Get, refDataContext92.ValueType___Expr92Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 93)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new Ejercicio_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext6_ForReadOnly valDataContext93 = ((Ejercicio_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext93.ValueType___Expr93Get();
            }
            if ((expressionId == 94)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new Ejercicio_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext6_ForReadOnly valDataContext94 = ((Ejercicio_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext94.ValueType___Expr94Get();
            }
            if ((expressionId == 95)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Ejercicio_TypedDataContext6(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext6 refDataContext95 = ((Ejercicio_TypedDataContext6)(cachedCompiledDataContext[6]));
                return refDataContext95.GetLocation<System.Drawing.PointF>(refDataContext95.ValueType___Expr95Get, refDataContext95.ValueType___Expr95Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 96)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new Ejercicio_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext6_ForReadOnly valDataContext96 = ((Ejercicio_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext96.ValueType___Expr96Get();
            }
            if ((expressionId == 97)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new Ejercicio_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext6_ForReadOnly valDataContext97 = ((Ejercicio_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext97.ValueType___Expr97Get();
            }
            if ((expressionId == 98)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Ejercicio_TypedDataContext6(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext6 refDataContext98 = ((Ejercicio_TypedDataContext6)(cachedCompiledDataContext[6]));
                return refDataContext98.GetLocation<int>(refDataContext98.ValueType___Expr98Get, refDataContext98.ValueType___Expr98Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 99)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new Ejercicio_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext6_ForReadOnly valDataContext99 = ((Ejercicio_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext99.ValueType___Expr99Get();
            }
            if ((expressionId == 100)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Ejercicio_TypedDataContext6(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext6 refDataContext100 = ((Ejercicio_TypedDataContext6)(cachedCompiledDataContext[6]));
                return refDataContext100.GetLocation<int>(refDataContext100.ValueType___Expr100Get, refDataContext100.ValueType___Expr100Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 101)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new Ejercicio_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext6_ForReadOnly valDataContext101 = ((Ejercicio_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext101.ValueType___Expr101Get();
            }
            if ((expressionId == 102)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new Ejercicio_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext6_ForReadOnly valDataContext102 = ((Ejercicio_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext102.ValueType___Expr102Get();
            }
            if ((expressionId == 103)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new Ejercicio_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext6_ForReadOnly valDataContext103 = ((Ejercicio_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext103.ValueType___Expr103Get();
            }
            if ((expressionId == 104)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new Ejercicio_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext6_ForReadOnly valDataContext104 = ((Ejercicio_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext104.ValueType___Expr104Get();
            }
            if ((expressionId == 105)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Ejercicio_TypedDataContext6(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext6 refDataContext105 = ((Ejercicio_TypedDataContext6)(cachedCompiledDataContext[6]));
                return refDataContext105.GetLocation<int>(refDataContext105.ValueType___Expr105Get, refDataContext105.ValueType___Expr105Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 106)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new Ejercicio_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext6_ForReadOnly valDataContext106 = ((Ejercicio_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext106.ValueType___Expr106Get();
            }
            if ((expressionId == 107)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new Ejercicio_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext6_ForReadOnly valDataContext107 = ((Ejercicio_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext107.ValueType___Expr107Get();
            }
            if ((expressionId == 108)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new Ejercicio_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext6_ForReadOnly valDataContext108 = ((Ejercicio_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext108.ValueType___Expr108Get();
            }
            if ((expressionId == 109)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new Ejercicio_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext6_ForReadOnly valDataContext109 = ((Ejercicio_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext109.ValueType___Expr109Get();
            }
            if ((expressionId == 110)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new Ejercicio_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext7_ForReadOnly valDataContext110 = ((Ejercicio_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext110.ValueType___Expr110Get();
            }
            if ((expressionId == 111)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new Ejercicio_TypedDataContext7(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext7 refDataContext111 = ((Ejercicio_TypedDataContext7)(cachedCompiledDataContext[9]));
                return refDataContext111.GetLocation<string>(refDataContext111.ValueType___Expr111Get, refDataContext111.ValueType___Expr111Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 112)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new Ejercicio_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext7_ForReadOnly valDataContext112 = ((Ejercicio_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext112.ValueType___Expr112Get();
            }
            if ((expressionId == 113)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new Ejercicio_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext7_ForReadOnly valDataContext113 = ((Ejercicio_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext113.ValueType___Expr113Get();
            }
            if ((expressionId == 114)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new Ejercicio_TypedDataContext7(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext7 refDataContext114 = ((Ejercicio_TypedDataContext7)(cachedCompiledDataContext[9]));
                return refDataContext114.GetLocation<System.Drawing.PointF>(refDataContext114.ValueType___Expr114Get, refDataContext114.ValueType___Expr114Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 115)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new Ejercicio_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext7_ForReadOnly valDataContext115 = ((Ejercicio_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext115.ValueType___Expr115Get();
            }
            if ((expressionId == 116)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new Ejercicio_TypedDataContext7(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext7 refDataContext116 = ((Ejercicio_TypedDataContext7)(cachedCompiledDataContext[9]));
                return refDataContext116.GetLocation<int>(refDataContext116.ValueType___Expr116Get, refDataContext116.ValueType___Expr116Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 117)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new Ejercicio_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext7_ForReadOnly valDataContext117 = ((Ejercicio_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext117.ValueType___Expr117Get();
            }
            if ((expressionId == 118)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new Ejercicio_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext7_ForReadOnly valDataContext118 = ((Ejercicio_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext118.ValueType___Expr118Get();
            }
            if ((expressionId == 119)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new Ejercicio_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext7_ForReadOnly valDataContext119 = ((Ejercicio_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext119.ValueType___Expr119Get();
            }
            if ((expressionId == 120)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new Ejercicio_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext7_ForReadOnly valDataContext120 = ((Ejercicio_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext120.ValueType___Expr120Get();
            }
            if ((expressionId == 121)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new Ejercicio_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext7_ForReadOnly valDataContext121 = ((Ejercicio_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext121.ValueType___Expr121Get();
            }
            if ((expressionId == 122)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new Ejercicio_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext7_ForReadOnly valDataContext122 = ((Ejercicio_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext122.ValueType___Expr122Get();
            }
            if ((expressionId == 123)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new Ejercicio_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext7_ForReadOnly valDataContext123 = ((Ejercicio_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext123.ValueType___Expr123Get();
            }
            if ((expressionId == 124)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new Ejercicio_TypedDataContext7(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext7 refDataContext124 = ((Ejercicio_TypedDataContext7)(cachedCompiledDataContext[9]));
                return refDataContext124.GetLocation<int>(refDataContext124.ValueType___Expr124Get, refDataContext124.ValueType___Expr124Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 125)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new Ejercicio_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext7_ForReadOnly valDataContext125 = ((Ejercicio_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[8]));
                return valDataContext125.ValueType___Expr125Get();
            }
            if ((expressionId == 126)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new Ejercicio_TypedDataContext8(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext8 refDataContext126 = ((Ejercicio_TypedDataContext8)(cachedCompiledDataContext[10]));
                return refDataContext126.GetLocation<string>(refDataContext126.ValueType___Expr126Get, refDataContext126.ValueType___Expr126Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 127)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Ejercicio_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext8_ForReadOnly valDataContext127 = ((Ejercicio_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext127.ValueType___Expr127Get();
            }
            if ((expressionId == 128)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Ejercicio_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext8_ForReadOnly valDataContext128 = ((Ejercicio_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext128.ValueType___Expr128Get();
            }
            if ((expressionId == 129)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new Ejercicio_TypedDataContext8(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext8 refDataContext129 = ((Ejercicio_TypedDataContext8)(cachedCompiledDataContext[10]));
                return refDataContext129.GetLocation<System.Drawing.PointF>(refDataContext129.ValueType___Expr129Get, refDataContext129.ValueType___Expr129Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 130)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Ejercicio_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext8_ForReadOnly valDataContext130 = ((Ejercicio_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext130.ValueType___Expr130Get();
            }
            if ((expressionId == 131)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Ejercicio_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext8_ForReadOnly valDataContext131 = ((Ejercicio_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext131.ValueType___Expr131Get();
            }
            if ((expressionId == 132)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new Ejercicio_TypedDataContext8(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext8 refDataContext132 = ((Ejercicio_TypedDataContext8)(cachedCompiledDataContext[10]));
                return refDataContext132.GetLocation<int>(refDataContext132.ValueType___Expr132Get, refDataContext132.ValueType___Expr132Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 133)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Ejercicio_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext8_ForReadOnly valDataContext133 = ((Ejercicio_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext133.ValueType___Expr133Get();
            }
            if ((expressionId == 134)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Ejercicio_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext8_ForReadOnly valDataContext134 = ((Ejercicio_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext134.ValueType___Expr134Get();
            }
            if ((expressionId == 135)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Ejercicio_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext8_ForReadOnly valDataContext135 = ((Ejercicio_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext135.ValueType___Expr135Get();
            }
            if ((expressionId == 136)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Ejercicio_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext8_ForReadOnly valDataContext136 = ((Ejercicio_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext136.ValueType___Expr136Get();
            }
            if ((expressionId == 137)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Ejercicio_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext8_ForReadOnly valDataContext137 = ((Ejercicio_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext137.ValueType___Expr137Get();
            }
            if ((expressionId == 138)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Ejercicio_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext8_ForReadOnly valDataContext138 = ((Ejercicio_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext138.ValueType___Expr138Get();
            }
            if ((expressionId == 139)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Ejercicio_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext8_ForReadOnly valDataContext139 = ((Ejercicio_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext139.ValueType___Expr139Get();
            }
            if ((expressionId == 140)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Ejercicio_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext8_ForReadOnly valDataContext140 = ((Ejercicio_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[11]));
                return valDataContext140.ValueType___Expr140Get();
            }
            if ((expressionId == 141)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new Ejercicio_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext9_ForReadOnly valDataContext141 = ((Ejercicio_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[12]));
                return valDataContext141.ValueType___Expr141Get();
            }
            if ((expressionId == 142)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new Ejercicio_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext9_ForReadOnly valDataContext142 = ((Ejercicio_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[12]));
                return valDataContext142.ValueType___Expr142Get();
            }
            if ((expressionId == 143)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext11_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new Ejercicio_TypedDataContext11_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext11_ForReadOnly valDataContext143 = ((Ejercicio_TypedDataContext11_ForReadOnly)(cachedCompiledDataContext[13]));
                return valDataContext143.ValueType___Expr143Get();
            }
            if ((expressionId == 144)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext11.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[14] == null)) {
                    cachedCompiledDataContext[14] = new Ejercicio_TypedDataContext11(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext11 refDataContext144 = ((Ejercicio_TypedDataContext11)(cachedCompiledDataContext[14]));
                return refDataContext144.GetLocation<string>(refDataContext144.ValueType___Expr144Get, refDataContext144.ValueType___Expr144Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 145)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext11_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new Ejercicio_TypedDataContext11_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext11_ForReadOnly valDataContext145 = ((Ejercicio_TypedDataContext11_ForReadOnly)(cachedCompiledDataContext[13]));
                return valDataContext145.ValueType___Expr145Get();
            }
            if ((expressionId == 146)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext11_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new Ejercicio_TypedDataContext11_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext11_ForReadOnly valDataContext146 = ((Ejercicio_TypedDataContext11_ForReadOnly)(cachedCompiledDataContext[13]));
                return valDataContext146.ValueType___Expr146Get();
            }
            if ((expressionId == 147)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext11.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[14] == null)) {
                    cachedCompiledDataContext[14] = new Ejercicio_TypedDataContext11(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext11 refDataContext147 = ((Ejercicio_TypedDataContext11)(cachedCompiledDataContext[14]));
                return refDataContext147.GetLocation<System.Drawing.PointF>(refDataContext147.ValueType___Expr147Get, refDataContext147.ValueType___Expr147Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 148)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext11_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new Ejercicio_TypedDataContext11_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext11_ForReadOnly valDataContext148 = ((Ejercicio_TypedDataContext11_ForReadOnly)(cachedCompiledDataContext[13]));
                return valDataContext148.ValueType___Expr148Get();
            }
            if ((expressionId == 149)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext11_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new Ejercicio_TypedDataContext11_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext11_ForReadOnly valDataContext149 = ((Ejercicio_TypedDataContext11_ForReadOnly)(cachedCompiledDataContext[13]));
                return valDataContext149.ValueType___Expr149Get();
            }
            if ((expressionId == 150)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext11_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new Ejercicio_TypedDataContext11_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext11_ForReadOnly valDataContext150 = ((Ejercicio_TypedDataContext11_ForReadOnly)(cachedCompiledDataContext[13]));
                return valDataContext150.ValueType___Expr150Get();
            }
            if ((expressionId == 151)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext11_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new Ejercicio_TypedDataContext11_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext11_ForReadOnly valDataContext151 = ((Ejercicio_TypedDataContext11_ForReadOnly)(cachedCompiledDataContext[13]));
                return valDataContext151.ValueType___Expr151Get();
            }
            if ((expressionId == 152)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext11.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[14] == null)) {
                    cachedCompiledDataContext[14] = new Ejercicio_TypedDataContext11(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext11 refDataContext152 = ((Ejercicio_TypedDataContext11)(cachedCompiledDataContext[14]));
                return refDataContext152.GetLocation<int>(refDataContext152.ValueType___Expr152Get, refDataContext152.ValueType___Expr152Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 153)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext11_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new Ejercicio_TypedDataContext11_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext11_ForReadOnly valDataContext153 = ((Ejercicio_TypedDataContext11_ForReadOnly)(cachedCompiledDataContext[13]));
                return valDataContext153.ValueType___Expr153Get();
            }
            if ((expressionId == 154)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext11_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new Ejercicio_TypedDataContext11_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext11_ForReadOnly valDataContext154 = ((Ejercicio_TypedDataContext11_ForReadOnly)(cachedCompiledDataContext[13]));
                return valDataContext154.ValueType___Expr154Get();
            }
            if ((expressionId == 155)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext11.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[14] == null)) {
                    cachedCompiledDataContext[14] = new Ejercicio_TypedDataContext11(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext11 refDataContext155 = ((Ejercicio_TypedDataContext11)(cachedCompiledDataContext[14]));
                return refDataContext155.GetLocation<int>(refDataContext155.ValueType___Expr155Get, refDataContext155.ValueType___Expr155Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 156)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext11_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new Ejercicio_TypedDataContext11_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext11_ForReadOnly valDataContext156 = ((Ejercicio_TypedDataContext11_ForReadOnly)(cachedCompiledDataContext[13]));
                return valDataContext156.ValueType___Expr156Get();
            }
            if ((expressionId == 157)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext11.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[14] == null)) {
                    cachedCompiledDataContext[14] = new Ejercicio_TypedDataContext11(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext11 refDataContext157 = ((Ejercicio_TypedDataContext11)(cachedCompiledDataContext[14]));
                return refDataContext157.GetLocation<int>(refDataContext157.ValueType___Expr157Get, refDataContext157.ValueType___Expr157Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 158)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext11_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new Ejercicio_TypedDataContext11_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext11_ForReadOnly valDataContext158 = ((Ejercicio_TypedDataContext11_ForReadOnly)(cachedCompiledDataContext[13]));
                return valDataContext158.ValueType___Expr158Get();
            }
            if ((expressionId == 159)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext11_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new Ejercicio_TypedDataContext11_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext11_ForReadOnly valDataContext159 = ((Ejercicio_TypedDataContext11_ForReadOnly)(cachedCompiledDataContext[13]));
                return valDataContext159.ValueType___Expr159Get();
            }
            if ((expressionId == 160)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext11_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new Ejercicio_TypedDataContext11_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext11_ForReadOnly valDataContext160 = ((Ejercicio_TypedDataContext11_ForReadOnly)(cachedCompiledDataContext[13]));
                return valDataContext160.ValueType___Expr160Get();
            }
            if ((expressionId == 161)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[15] == null)) {
                    cachedCompiledDataContext[15] = new Ejercicio_TypedDataContext12_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext12_ForReadOnly valDataContext161 = ((Ejercicio_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[15]));
                return valDataContext161.ValueType___Expr161Get();
            }
            if ((expressionId == 162)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new Ejercicio_TypedDataContext12(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext12 refDataContext162 = ((Ejercicio_TypedDataContext12)(cachedCompiledDataContext[16]));
                return refDataContext162.GetLocation<int>(refDataContext162.ValueType___Expr162Get, refDataContext162.ValueType___Expr162Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 163)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new Ejercicio_TypedDataContext12(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext12 refDataContext163 = ((Ejercicio_TypedDataContext12)(cachedCompiledDataContext[16]));
                return refDataContext163.GetLocation<string>(refDataContext163.ValueType___Expr163Get, refDataContext163.ValueType___Expr163Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 164)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[15] == null)) {
                    cachedCompiledDataContext[15] = new Ejercicio_TypedDataContext12_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext12_ForReadOnly valDataContext164 = ((Ejercicio_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[15]));
                return valDataContext164.ValueType___Expr164Get();
            }
            if ((expressionId == 165)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[15] == null)) {
                    cachedCompiledDataContext[15] = new Ejercicio_TypedDataContext12_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext12_ForReadOnly valDataContext165 = ((Ejercicio_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[15]));
                return valDataContext165.ValueType___Expr165Get();
            }
            if ((expressionId == 166)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new Ejercicio_TypedDataContext12(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext12 refDataContext166 = ((Ejercicio_TypedDataContext12)(cachedCompiledDataContext[16]));
                return refDataContext166.GetLocation<System.Drawing.PointF>(refDataContext166.ValueType___Expr166Get, refDataContext166.ValueType___Expr166Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 167)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[15] == null)) {
                    cachedCompiledDataContext[15] = new Ejercicio_TypedDataContext12_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext12_ForReadOnly valDataContext167 = ((Ejercicio_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[15]));
                return valDataContext167.ValueType___Expr167Get();
            }
            if ((expressionId == 168)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[15] == null)) {
                    cachedCompiledDataContext[15] = new Ejercicio_TypedDataContext12_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext12_ForReadOnly valDataContext168 = ((Ejercicio_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[15]));
                return valDataContext168.ValueType___Expr168Get();
            }
            if ((expressionId == 169)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[15] == null)) {
                    cachedCompiledDataContext[15] = new Ejercicio_TypedDataContext12_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext12_ForReadOnly valDataContext169 = ((Ejercicio_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[15]));
                return valDataContext169.ValueType___Expr169Get();
            }
            if ((expressionId == 170)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext12.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[16] == null)) {
                    cachedCompiledDataContext[16] = new Ejercicio_TypedDataContext12(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext12 refDataContext170 = ((Ejercicio_TypedDataContext12)(cachedCompiledDataContext[16]));
                return refDataContext170.GetLocation<int>(refDataContext170.ValueType___Expr170Get, refDataContext170.ValueType___Expr170Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 171)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[15] == null)) {
                    cachedCompiledDataContext[15] = new Ejercicio_TypedDataContext12_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext12_ForReadOnly valDataContext171 = ((Ejercicio_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[15]));
                return valDataContext171.ValueType___Expr171Get();
            }
            if ((expressionId == 172)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[15] == null)) {
                    cachedCompiledDataContext[15] = new Ejercicio_TypedDataContext12_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext12_ForReadOnly valDataContext172 = ((Ejercicio_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[15]));
                return valDataContext172.ValueType___Expr172Get();
            }
            if ((expressionId == 173)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[15] == null)) {
                    cachedCompiledDataContext[15] = new Ejercicio_TypedDataContext12_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext12_ForReadOnly valDataContext173 = ((Ejercicio_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[15]));
                return valDataContext173.ValueType___Expr173Get();
            }
            if ((expressionId == 174)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[15] == null)) {
                    cachedCompiledDataContext[15] = new Ejercicio_TypedDataContext12_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext12_ForReadOnly valDataContext174 = ((Ejercicio_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[15]));
                return valDataContext174.ValueType___Expr174Get();
            }
            if ((expressionId == 175)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext12_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[15] == null)) {
                    cachedCompiledDataContext[15] = new Ejercicio_TypedDataContext12_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext12_ForReadOnly valDataContext175 = ((Ejercicio_TypedDataContext12_ForReadOnly)(cachedCompiledDataContext[15]));
                return valDataContext175.ValueType___Expr175Get();
            }
            if ((expressionId == 176)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext13_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[17] == null)) {
                    cachedCompiledDataContext[17] = new Ejercicio_TypedDataContext13_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext13_ForReadOnly valDataContext176 = ((Ejercicio_TypedDataContext13_ForReadOnly)(cachedCompiledDataContext[17]));
                return valDataContext176.ValueType___Expr176Get();
            }
            if ((expressionId == 177)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext13.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[18] == null)) {
                    cachedCompiledDataContext[18] = new Ejercicio_TypedDataContext13(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext13 refDataContext177 = ((Ejercicio_TypedDataContext13)(cachedCompiledDataContext[18]));
                return refDataContext177.GetLocation<int>(refDataContext177.ValueType___Expr177Get, refDataContext177.ValueType___Expr177Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 178)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext13_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[17] == null)) {
                    cachedCompiledDataContext[17] = new Ejercicio_TypedDataContext13_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext13_ForReadOnly valDataContext178 = ((Ejercicio_TypedDataContext13_ForReadOnly)(cachedCompiledDataContext[17]));
                return valDataContext178.ValueType___Expr178Get();
            }
            if ((expressionId == 179)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext13_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[17] == null)) {
                    cachedCompiledDataContext[17] = new Ejercicio_TypedDataContext13_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext13_ForReadOnly valDataContext179 = ((Ejercicio_TypedDataContext13_ForReadOnly)(cachedCompiledDataContext[17]));
                return valDataContext179.ValueType___Expr179Get();
            }
            if ((expressionId == 180)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext13_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[17] == null)) {
                    cachedCompiledDataContext[17] = new Ejercicio_TypedDataContext13_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext13_ForReadOnly valDataContext180 = ((Ejercicio_TypedDataContext13_ForReadOnly)(cachedCompiledDataContext[17]));
                return valDataContext180.ValueType___Expr180Get();
            }
            if ((expressionId == 181)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext13_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[17] == null)) {
                    cachedCompiledDataContext[17] = new Ejercicio_TypedDataContext13_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext13_ForReadOnly valDataContext181 = ((Ejercicio_TypedDataContext13_ForReadOnly)(cachedCompiledDataContext[17]));
                return valDataContext181.ValueType___Expr181Get();
            }
            if ((expressionId == 182)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext14.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[19] == null)) {
                    cachedCompiledDataContext[19] = new Ejercicio_TypedDataContext14(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext14 refDataContext182 = ((Ejercicio_TypedDataContext14)(cachedCompiledDataContext[19]));
                return refDataContext182.GetLocation<string>(refDataContext182.ValueType___Expr182Get, refDataContext182.ValueType___Expr182Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 183)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[20] == null)) {
                    cachedCompiledDataContext[20] = new Ejercicio_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext14_ForReadOnly valDataContext183 = ((Ejercicio_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[20]));
                return valDataContext183.ValueType___Expr183Get();
            }
            if ((expressionId == 184)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[20] == null)) {
                    cachedCompiledDataContext[20] = new Ejercicio_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext14_ForReadOnly valDataContext184 = ((Ejercicio_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[20]));
                return valDataContext184.ValueType___Expr184Get();
            }
            if ((expressionId == 185)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext14.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[19] == null)) {
                    cachedCompiledDataContext[19] = new Ejercicio_TypedDataContext14(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext14 refDataContext185 = ((Ejercicio_TypedDataContext14)(cachedCompiledDataContext[19]));
                return refDataContext185.GetLocation<System.Drawing.PointF>(refDataContext185.ValueType___Expr185Get, refDataContext185.ValueType___Expr185Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 186)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[20] == null)) {
                    cachedCompiledDataContext[20] = new Ejercicio_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext14_ForReadOnly valDataContext186 = ((Ejercicio_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[20]));
                return valDataContext186.ValueType___Expr186Get();
            }
            if ((expressionId == 187)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[20] == null)) {
                    cachedCompiledDataContext[20] = new Ejercicio_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext14_ForReadOnly valDataContext187 = ((Ejercicio_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[20]));
                return valDataContext187.ValueType___Expr187Get();
            }
            if ((expressionId == 188)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[20] == null)) {
                    cachedCompiledDataContext[20] = new Ejercicio_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext14_ForReadOnly valDataContext188 = ((Ejercicio_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[20]));
                return valDataContext188.ValueType___Expr188Get();
            }
            if ((expressionId == 189)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Ejercicio_TypedDataContext14_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 21);
                if ((cachedCompiledDataContext[20] == null)) {
                    cachedCompiledDataContext[20] = new Ejercicio_TypedDataContext14_ForReadOnly(locations, activityContext, true);
                }
                Ejercicio_TypedDataContext14_ForReadOnly valDataContext189 = ((Ejercicio_TypedDataContext14_ForReadOnly)(cachedCompiledDataContext[20]));
                return valDataContext189.ValueType___Expr189Get();
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
                Ejercicio_TypedDataContext3_ForReadOnly valDataContext0 = new Ejercicio_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                Ejercicio_TypedDataContext3 refDataContext1 = new Ejercicio_TypedDataContext3(locations, true);
                return refDataContext1.GetLocation<System.Collections.Generic.List<string>>(refDataContext1.ValueType___Expr1Get, refDataContext1.ValueType___Expr1Set);
            }
            if ((expressionId == 2)) {
                Ejercicio_TypedDataContext3_ForReadOnly valDataContext2 = new Ejercicio_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                Ejercicio_TypedDataContext3 refDataContext3 = new Ejercicio_TypedDataContext3(locations, true);
                return refDataContext3.GetLocation<System.Collections.Generic.List<string>>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set);
            }
            if ((expressionId == 4)) {
                Ejercicio_TypedDataContext3 refDataContext4 = new Ejercicio_TypedDataContext3(locations, true);
                return refDataContext4.GetLocation<int>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set);
            }
            if ((expressionId == 5)) {
                Ejercicio_TypedDataContext3 refDataContext5 = new Ejercicio_TypedDataContext3(locations, true);
                return refDataContext5.GetLocation<int>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set);
            }
            if ((expressionId == 6)) {
                Ejercicio_TypedDataContext3_ForReadOnly valDataContext6 = new Ejercicio_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                Ejercicio_TypedDataContext3 refDataContext7 = new Ejercicio_TypedDataContext3(locations, true);
                return refDataContext7.GetLocation<int>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set);
            }
            if ((expressionId == 8)) {
                Ejercicio_TypedDataContext3 refDataContext8 = new Ejercicio_TypedDataContext3(locations, true);
                return refDataContext8.GetLocation<int>(refDataContext8.ValueType___Expr8Get, refDataContext8.ValueType___Expr8Set);
            }
            if ((expressionId == 9)) {
                Ejercicio_TypedDataContext3_ForReadOnly valDataContext9 = new Ejercicio_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                Ejercicio_TypedDataContext3 refDataContext10 = new Ejercicio_TypedDataContext3(locations, true);
                return refDataContext10.GetLocation<System.Drawing.PointF>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set);
            }
            if ((expressionId == 11)) {
                Ejercicio_TypedDataContext3_ForReadOnly valDataContext11 = new Ejercicio_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                Ejercicio_TypedDataContext3_ForReadOnly valDataContext12 = new Ejercicio_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                Ejercicio_TypedDataContext3_ForReadOnly valDataContext13 = new Ejercicio_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                Ejercicio_TypedDataContext3_ForReadOnly valDataContext14 = new Ejercicio_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                Ejercicio_TypedDataContext3_ForReadOnly valDataContext15 = new Ejercicio_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                Ejercicio_TypedDataContext3_ForReadOnly valDataContext16 = new Ejercicio_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                Ejercicio_TypedDataContext3 refDataContext17 = new Ejercicio_TypedDataContext3(locations, true);
                return refDataContext17.GetLocation<string>(refDataContext17.ValueType___Expr17Get, refDataContext17.ValueType___Expr17Set);
            }
            if ((expressionId == 18)) {
                Ejercicio_TypedDataContext3_ForReadOnly valDataContext18 = new Ejercicio_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext18.ValueType___Expr18Get();
            }
            if ((expressionId == 19)) {
                Ejercicio_TypedDataContext3_ForReadOnly valDataContext19 = new Ejercicio_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext19.ValueType___Expr19Get();
            }
            if ((expressionId == 20)) {
                Ejercicio_TypedDataContext3 refDataContext20 = new Ejercicio_TypedDataContext3(locations, true);
                return refDataContext20.GetLocation<System.Drawing.PointF>(refDataContext20.ValueType___Expr20Get, refDataContext20.ValueType___Expr20Set);
            }
            if ((expressionId == 21)) {
                Ejercicio_TypedDataContext3_ForReadOnly valDataContext21 = new Ejercicio_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext21.ValueType___Expr21Get();
            }
            if ((expressionId == 22)) {
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext22 = new Ejercicio_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext23 = new Ejercicio_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext23.ValueType___Expr23Get();
            }
            if ((expressionId == 24)) {
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext24 = new Ejercicio_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext24.ValueType___Expr24Get();
            }
            if ((expressionId == 25)) {
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext25 = new Ejercicio_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext25.ValueType___Expr25Get();
            }
            if ((expressionId == 26)) {
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext26 = new Ejercicio_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext26.ValueType___Expr26Get();
            }
            if ((expressionId == 27)) {
                Ejercicio_TypedDataContext4 refDataContext27 = new Ejercicio_TypedDataContext4(locations, true);
                return refDataContext27.GetLocation<int>(refDataContext27.ValueType___Expr27Get, refDataContext27.ValueType___Expr27Set);
            }
            if ((expressionId == 28)) {
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext28 = new Ejercicio_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext28.ValueType___Expr28Get();
            }
            if ((expressionId == 29)) {
                Ejercicio_TypedDataContext4 refDataContext29 = new Ejercicio_TypedDataContext4(locations, true);
                return refDataContext29.GetLocation<int>(refDataContext29.ValueType___Expr29Get, refDataContext29.ValueType___Expr29Set);
            }
            if ((expressionId == 30)) {
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext30 = new Ejercicio_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext30.ValueType___Expr30Get();
            }
            if ((expressionId == 31)) {
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext31 = new Ejercicio_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext31.ValueType___Expr31Get();
            }
            if ((expressionId == 32)) {
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext32 = new Ejercicio_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext32.ValueType___Expr32Get();
            }
            if ((expressionId == 33)) {
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext33 = new Ejercicio_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext33.ValueType___Expr33Get();
            }
            if ((expressionId == 34)) {
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext34 = new Ejercicio_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext34.ValueType___Expr34Get();
            }
            if ((expressionId == 35)) {
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext35 = new Ejercicio_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext35.ValueType___Expr35Get();
            }
            if ((expressionId == 36)) {
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext36 = new Ejercicio_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext36.ValueType___Expr36Get();
            }
            if ((expressionId == 37)) {
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext37 = new Ejercicio_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext37.ValueType___Expr37Get();
            }
            if ((expressionId == 38)) {
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext38 = new Ejercicio_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext38.ValueType___Expr38Get();
            }
            if ((expressionId == 39)) {
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext39 = new Ejercicio_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext39.ValueType___Expr39Get();
            }
            if ((expressionId == 40)) {
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext40 = new Ejercicio_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext40.ValueType___Expr40Get();
            }
            if ((expressionId == 41)) {
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext41 = new Ejercicio_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext41.ValueType___Expr41Get();
            }
            if ((expressionId == 42)) {
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext42 = new Ejercicio_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext42.ValueType___Expr42Get();
            }
            if ((expressionId == 43)) {
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext43 = new Ejercicio_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext43.ValueType___Expr43Get();
            }
            if ((expressionId == 44)) {
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext44 = new Ejercicio_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext44.ValueType___Expr44Get();
            }
            if ((expressionId == 45)) {
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext45 = new Ejercicio_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext45.ValueType___Expr45Get();
            }
            if ((expressionId == 46)) {
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext46 = new Ejercicio_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext46.ValueType___Expr46Get();
            }
            if ((expressionId == 47)) {
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext47 = new Ejercicio_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext47.ValueType___Expr47Get();
            }
            if ((expressionId == 48)) {
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext48 = new Ejercicio_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext48.ValueType___Expr48Get();
            }
            if ((expressionId == 49)) {
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext49 = new Ejercicio_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext49.ValueType___Expr49Get();
            }
            if ((expressionId == 50)) {
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext50 = new Ejercicio_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext50.ValueType___Expr50Get();
            }
            if ((expressionId == 51)) {
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext51 = new Ejercicio_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext51.ValueType___Expr51Get();
            }
            if ((expressionId == 52)) {
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext52 = new Ejercicio_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext52.ValueType___Expr52Get();
            }
            if ((expressionId == 53)) {
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext53 = new Ejercicio_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext53.ValueType___Expr53Get();
            }
            if ((expressionId == 54)) {
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext54 = new Ejercicio_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext54.ValueType___Expr54Get();
            }
            if ((expressionId == 55)) {
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext55 = new Ejercicio_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext55.ValueType___Expr55Get();
            }
            if ((expressionId == 56)) {
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext56 = new Ejercicio_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext56.ValueType___Expr56Get();
            }
            if ((expressionId == 57)) {
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext57 = new Ejercicio_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext57.ValueType___Expr57Get();
            }
            if ((expressionId == 58)) {
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext58 = new Ejercicio_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext58.ValueType___Expr58Get();
            }
            if ((expressionId == 59)) {
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext59 = new Ejercicio_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext59.ValueType___Expr59Get();
            }
            if ((expressionId == 60)) {
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext60 = new Ejercicio_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext60.ValueType___Expr60Get();
            }
            if ((expressionId == 61)) {
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext61 = new Ejercicio_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext61.ValueType___Expr61Get();
            }
            if ((expressionId == 62)) {
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext62 = new Ejercicio_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext62.ValueType___Expr62Get();
            }
            if ((expressionId == 63)) {
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext63 = new Ejercicio_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext63.ValueType___Expr63Get();
            }
            if ((expressionId == 64)) {
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext64 = new Ejercicio_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext64.ValueType___Expr64Get();
            }
            if ((expressionId == 65)) {
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext65 = new Ejercicio_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext65.ValueType___Expr65Get();
            }
            if ((expressionId == 66)) {
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext66 = new Ejercicio_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext66.ValueType___Expr66Get();
            }
            if ((expressionId == 67)) {
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext67 = new Ejercicio_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext67.ValueType___Expr67Get();
            }
            if ((expressionId == 68)) {
                Ejercicio_TypedDataContext5_ForReadOnly valDataContext68 = new Ejercicio_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext68.ValueType___Expr68Get();
            }
            if ((expressionId == 69)) {
                Ejercicio_TypedDataContext5 refDataContext69 = new Ejercicio_TypedDataContext5(locations, true);
                return refDataContext69.GetLocation<int>(refDataContext69.ValueType___Expr69Get, refDataContext69.ValueType___Expr69Set);
            }
            if ((expressionId == 70)) {
                Ejercicio_TypedDataContext5_ForReadOnly valDataContext70 = new Ejercicio_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext70.ValueType___Expr70Get();
            }
            if ((expressionId == 71)) {
                Ejercicio_TypedDataContext5_ForReadOnly valDataContext71 = new Ejercicio_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext71.ValueType___Expr71Get();
            }
            if ((expressionId == 72)) {
                Ejercicio_TypedDataContext5_ForReadOnly valDataContext72 = new Ejercicio_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext72.ValueType___Expr72Get();
            }
            if ((expressionId == 73)) {
                Ejercicio_TypedDataContext5_ForReadOnly valDataContext73 = new Ejercicio_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext73.ValueType___Expr73Get();
            }
            if ((expressionId == 74)) {
                Ejercicio_TypedDataContext5_ForReadOnly valDataContext74 = new Ejercicio_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext74.ValueType___Expr74Get();
            }
            if ((expressionId == 75)) {
                Ejercicio_TypedDataContext5_ForReadOnly valDataContext75 = new Ejercicio_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext75.ValueType___Expr75Get();
            }
            if ((expressionId == 76)) {
                Ejercicio_TypedDataContext4 refDataContext76 = new Ejercicio_TypedDataContext4(locations, true);
                return refDataContext76.GetLocation<string>(refDataContext76.ValueType___Expr76Get, refDataContext76.ValueType___Expr76Set);
            }
            if ((expressionId == 77)) {
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext77 = new Ejercicio_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext77.ValueType___Expr77Get();
            }
            if ((expressionId == 78)) {
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext78 = new Ejercicio_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext78.ValueType___Expr78Get();
            }
            if ((expressionId == 79)) {
                Ejercicio_TypedDataContext4 refDataContext79 = new Ejercicio_TypedDataContext4(locations, true);
                return refDataContext79.GetLocation<System.Drawing.PointF>(refDataContext79.ValueType___Expr79Get, refDataContext79.ValueType___Expr79Set);
            }
            if ((expressionId == 80)) {
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext80 = new Ejercicio_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext80.ValueType___Expr80Get();
            }
            if ((expressionId == 81)) {
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext81 = new Ejercicio_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext81.ValueType___Expr81Get();
            }
            if ((expressionId == 82)) {
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext82 = new Ejercicio_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext82.ValueType___Expr82Get();
            }
            if ((expressionId == 83)) {
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext83 = new Ejercicio_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext83.ValueType___Expr83Get();
            }
            if ((expressionId == 84)) {
                Ejercicio_TypedDataContext4 refDataContext84 = new Ejercicio_TypedDataContext4(locations, true);
                return refDataContext84.GetLocation<int[]>(refDataContext84.ValueType___Expr84Get, refDataContext84.ValueType___Expr84Set);
            }
            if ((expressionId == 85)) {
                Ejercicio_TypedDataContext4 refDataContext85 = new Ejercicio_TypedDataContext4(locations, true);
                return refDataContext85.GetLocation<int>(refDataContext85.ValueType___Expr85Get, refDataContext85.ValueType___Expr85Set);
            }
            if ((expressionId == 86)) {
                Ejercicio_TypedDataContext4 refDataContext86 = new Ejercicio_TypedDataContext4(locations, true);
                return refDataContext86.GetLocation<int>(refDataContext86.ValueType___Expr86Get, refDataContext86.ValueType___Expr86Set);
            }
            if ((expressionId == 87)) {
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext87 = new Ejercicio_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext87.ValueType___Expr87Get();
            }
            if ((expressionId == 88)) {
                Ejercicio_TypedDataContext4_ForReadOnly valDataContext88 = new Ejercicio_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext88.ValueType___Expr88Get();
            }
            if ((expressionId == 89)) {
                Ejercicio_TypedDataContext4 refDataContext89 = new Ejercicio_TypedDataContext4(locations, true);
                return refDataContext89.GetLocation<int[]>(refDataContext89.ValueType___Expr89Get, refDataContext89.ValueType___Expr89Set);
            }
            if ((expressionId == 90)) {
                Ejercicio_TypedDataContext4 refDataContext90 = new Ejercicio_TypedDataContext4(locations, true);
                return refDataContext90.GetLocation<int>(refDataContext90.ValueType___Expr90Get, refDataContext90.ValueType___Expr90Set);
            }
            if ((expressionId == 91)) {
                Ejercicio_TypedDataContext4 refDataContext91 = new Ejercicio_TypedDataContext4(locations, true);
                return refDataContext91.GetLocation<int>(refDataContext91.ValueType___Expr91Get, refDataContext91.ValueType___Expr91Set);
            }
            if ((expressionId == 92)) {
                Ejercicio_TypedDataContext6 refDataContext92 = new Ejercicio_TypedDataContext6(locations, true);
                return refDataContext92.GetLocation<string>(refDataContext92.ValueType___Expr92Get, refDataContext92.ValueType___Expr92Set);
            }
            if ((expressionId == 93)) {
                Ejercicio_TypedDataContext6_ForReadOnly valDataContext93 = new Ejercicio_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext93.ValueType___Expr93Get();
            }
            if ((expressionId == 94)) {
                Ejercicio_TypedDataContext6_ForReadOnly valDataContext94 = new Ejercicio_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext94.ValueType___Expr94Get();
            }
            if ((expressionId == 95)) {
                Ejercicio_TypedDataContext6 refDataContext95 = new Ejercicio_TypedDataContext6(locations, true);
                return refDataContext95.GetLocation<System.Drawing.PointF>(refDataContext95.ValueType___Expr95Get, refDataContext95.ValueType___Expr95Set);
            }
            if ((expressionId == 96)) {
                Ejercicio_TypedDataContext6_ForReadOnly valDataContext96 = new Ejercicio_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext96.ValueType___Expr96Get();
            }
            if ((expressionId == 97)) {
                Ejercicio_TypedDataContext6_ForReadOnly valDataContext97 = new Ejercicio_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext97.ValueType___Expr97Get();
            }
            if ((expressionId == 98)) {
                Ejercicio_TypedDataContext6 refDataContext98 = new Ejercicio_TypedDataContext6(locations, true);
                return refDataContext98.GetLocation<int>(refDataContext98.ValueType___Expr98Get, refDataContext98.ValueType___Expr98Set);
            }
            if ((expressionId == 99)) {
                Ejercicio_TypedDataContext6_ForReadOnly valDataContext99 = new Ejercicio_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext99.ValueType___Expr99Get();
            }
            if ((expressionId == 100)) {
                Ejercicio_TypedDataContext6 refDataContext100 = new Ejercicio_TypedDataContext6(locations, true);
                return refDataContext100.GetLocation<int>(refDataContext100.ValueType___Expr100Get, refDataContext100.ValueType___Expr100Set);
            }
            if ((expressionId == 101)) {
                Ejercicio_TypedDataContext6_ForReadOnly valDataContext101 = new Ejercicio_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext101.ValueType___Expr101Get();
            }
            if ((expressionId == 102)) {
                Ejercicio_TypedDataContext6_ForReadOnly valDataContext102 = new Ejercicio_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext102.ValueType___Expr102Get();
            }
            if ((expressionId == 103)) {
                Ejercicio_TypedDataContext6_ForReadOnly valDataContext103 = new Ejercicio_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext103.ValueType___Expr103Get();
            }
            if ((expressionId == 104)) {
                Ejercicio_TypedDataContext6_ForReadOnly valDataContext104 = new Ejercicio_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext104.ValueType___Expr104Get();
            }
            if ((expressionId == 105)) {
                Ejercicio_TypedDataContext6 refDataContext105 = new Ejercicio_TypedDataContext6(locations, true);
                return refDataContext105.GetLocation<int>(refDataContext105.ValueType___Expr105Get, refDataContext105.ValueType___Expr105Set);
            }
            if ((expressionId == 106)) {
                Ejercicio_TypedDataContext6_ForReadOnly valDataContext106 = new Ejercicio_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext106.ValueType___Expr106Get();
            }
            if ((expressionId == 107)) {
                Ejercicio_TypedDataContext6_ForReadOnly valDataContext107 = new Ejercicio_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext107.ValueType___Expr107Get();
            }
            if ((expressionId == 108)) {
                Ejercicio_TypedDataContext6_ForReadOnly valDataContext108 = new Ejercicio_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext108.ValueType___Expr108Get();
            }
            if ((expressionId == 109)) {
                Ejercicio_TypedDataContext6_ForReadOnly valDataContext109 = new Ejercicio_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext109.ValueType___Expr109Get();
            }
            if ((expressionId == 110)) {
                Ejercicio_TypedDataContext7_ForReadOnly valDataContext110 = new Ejercicio_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext110.ValueType___Expr110Get();
            }
            if ((expressionId == 111)) {
                Ejercicio_TypedDataContext7 refDataContext111 = new Ejercicio_TypedDataContext7(locations, true);
                return refDataContext111.GetLocation<string>(refDataContext111.ValueType___Expr111Get, refDataContext111.ValueType___Expr111Set);
            }
            if ((expressionId == 112)) {
                Ejercicio_TypedDataContext7_ForReadOnly valDataContext112 = new Ejercicio_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext112.ValueType___Expr112Get();
            }
            if ((expressionId == 113)) {
                Ejercicio_TypedDataContext7_ForReadOnly valDataContext113 = new Ejercicio_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext113.ValueType___Expr113Get();
            }
            if ((expressionId == 114)) {
                Ejercicio_TypedDataContext7 refDataContext114 = new Ejercicio_TypedDataContext7(locations, true);
                return refDataContext114.GetLocation<System.Drawing.PointF>(refDataContext114.ValueType___Expr114Get, refDataContext114.ValueType___Expr114Set);
            }
            if ((expressionId == 115)) {
                Ejercicio_TypedDataContext7_ForReadOnly valDataContext115 = new Ejercicio_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext115.ValueType___Expr115Get();
            }
            if ((expressionId == 116)) {
                Ejercicio_TypedDataContext7 refDataContext116 = new Ejercicio_TypedDataContext7(locations, true);
                return refDataContext116.GetLocation<int>(refDataContext116.ValueType___Expr116Get, refDataContext116.ValueType___Expr116Set);
            }
            if ((expressionId == 117)) {
                Ejercicio_TypedDataContext7_ForReadOnly valDataContext117 = new Ejercicio_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext117.ValueType___Expr117Get();
            }
            if ((expressionId == 118)) {
                Ejercicio_TypedDataContext7_ForReadOnly valDataContext118 = new Ejercicio_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext118.ValueType___Expr118Get();
            }
            if ((expressionId == 119)) {
                Ejercicio_TypedDataContext7_ForReadOnly valDataContext119 = new Ejercicio_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext119.ValueType___Expr119Get();
            }
            if ((expressionId == 120)) {
                Ejercicio_TypedDataContext7_ForReadOnly valDataContext120 = new Ejercicio_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext120.ValueType___Expr120Get();
            }
            if ((expressionId == 121)) {
                Ejercicio_TypedDataContext7_ForReadOnly valDataContext121 = new Ejercicio_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext121.ValueType___Expr121Get();
            }
            if ((expressionId == 122)) {
                Ejercicio_TypedDataContext7_ForReadOnly valDataContext122 = new Ejercicio_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext122.ValueType___Expr122Get();
            }
            if ((expressionId == 123)) {
                Ejercicio_TypedDataContext7_ForReadOnly valDataContext123 = new Ejercicio_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext123.ValueType___Expr123Get();
            }
            if ((expressionId == 124)) {
                Ejercicio_TypedDataContext7 refDataContext124 = new Ejercicio_TypedDataContext7(locations, true);
                return refDataContext124.GetLocation<int>(refDataContext124.ValueType___Expr124Get, refDataContext124.ValueType___Expr124Set);
            }
            if ((expressionId == 125)) {
                Ejercicio_TypedDataContext7_ForReadOnly valDataContext125 = new Ejercicio_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext125.ValueType___Expr125Get();
            }
            if ((expressionId == 126)) {
                Ejercicio_TypedDataContext8 refDataContext126 = new Ejercicio_TypedDataContext8(locations, true);
                return refDataContext126.GetLocation<string>(refDataContext126.ValueType___Expr126Get, refDataContext126.ValueType___Expr126Set);
            }
            if ((expressionId == 127)) {
                Ejercicio_TypedDataContext8_ForReadOnly valDataContext127 = new Ejercicio_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext127.ValueType___Expr127Get();
            }
            if ((expressionId == 128)) {
                Ejercicio_TypedDataContext8_ForReadOnly valDataContext128 = new Ejercicio_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext128.ValueType___Expr128Get();
            }
            if ((expressionId == 129)) {
                Ejercicio_TypedDataContext8 refDataContext129 = new Ejercicio_TypedDataContext8(locations, true);
                return refDataContext129.GetLocation<System.Drawing.PointF>(refDataContext129.ValueType___Expr129Get, refDataContext129.ValueType___Expr129Set);
            }
            if ((expressionId == 130)) {
                Ejercicio_TypedDataContext8_ForReadOnly valDataContext130 = new Ejercicio_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext130.ValueType___Expr130Get();
            }
            if ((expressionId == 131)) {
                Ejercicio_TypedDataContext8_ForReadOnly valDataContext131 = new Ejercicio_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext131.ValueType___Expr131Get();
            }
            if ((expressionId == 132)) {
                Ejercicio_TypedDataContext8 refDataContext132 = new Ejercicio_TypedDataContext8(locations, true);
                return refDataContext132.GetLocation<int>(refDataContext132.ValueType___Expr132Get, refDataContext132.ValueType___Expr132Set);
            }
            if ((expressionId == 133)) {
                Ejercicio_TypedDataContext8_ForReadOnly valDataContext133 = new Ejercicio_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext133.ValueType___Expr133Get();
            }
            if ((expressionId == 134)) {
                Ejercicio_TypedDataContext8_ForReadOnly valDataContext134 = new Ejercicio_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext134.ValueType___Expr134Get();
            }
            if ((expressionId == 135)) {
                Ejercicio_TypedDataContext8_ForReadOnly valDataContext135 = new Ejercicio_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext135.ValueType___Expr135Get();
            }
            if ((expressionId == 136)) {
                Ejercicio_TypedDataContext8_ForReadOnly valDataContext136 = new Ejercicio_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext136.ValueType___Expr136Get();
            }
            if ((expressionId == 137)) {
                Ejercicio_TypedDataContext8_ForReadOnly valDataContext137 = new Ejercicio_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext137.ValueType___Expr137Get();
            }
            if ((expressionId == 138)) {
                Ejercicio_TypedDataContext8_ForReadOnly valDataContext138 = new Ejercicio_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext138.ValueType___Expr138Get();
            }
            if ((expressionId == 139)) {
                Ejercicio_TypedDataContext8_ForReadOnly valDataContext139 = new Ejercicio_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext139.ValueType___Expr139Get();
            }
            if ((expressionId == 140)) {
                Ejercicio_TypedDataContext8_ForReadOnly valDataContext140 = new Ejercicio_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext140.ValueType___Expr140Get();
            }
            if ((expressionId == 141)) {
                Ejercicio_TypedDataContext9_ForReadOnly valDataContext141 = new Ejercicio_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext141.ValueType___Expr141Get();
            }
            if ((expressionId == 142)) {
                Ejercicio_TypedDataContext9_ForReadOnly valDataContext142 = new Ejercicio_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext142.ValueType___Expr142Get();
            }
            if ((expressionId == 143)) {
                Ejercicio_TypedDataContext11_ForReadOnly valDataContext143 = new Ejercicio_TypedDataContext11_ForReadOnly(locations, true);
                return valDataContext143.ValueType___Expr143Get();
            }
            if ((expressionId == 144)) {
                Ejercicio_TypedDataContext11 refDataContext144 = new Ejercicio_TypedDataContext11(locations, true);
                return refDataContext144.GetLocation<string>(refDataContext144.ValueType___Expr144Get, refDataContext144.ValueType___Expr144Set);
            }
            if ((expressionId == 145)) {
                Ejercicio_TypedDataContext11_ForReadOnly valDataContext145 = new Ejercicio_TypedDataContext11_ForReadOnly(locations, true);
                return valDataContext145.ValueType___Expr145Get();
            }
            if ((expressionId == 146)) {
                Ejercicio_TypedDataContext11_ForReadOnly valDataContext146 = new Ejercicio_TypedDataContext11_ForReadOnly(locations, true);
                return valDataContext146.ValueType___Expr146Get();
            }
            if ((expressionId == 147)) {
                Ejercicio_TypedDataContext11 refDataContext147 = new Ejercicio_TypedDataContext11(locations, true);
                return refDataContext147.GetLocation<System.Drawing.PointF>(refDataContext147.ValueType___Expr147Get, refDataContext147.ValueType___Expr147Set);
            }
            if ((expressionId == 148)) {
                Ejercicio_TypedDataContext11_ForReadOnly valDataContext148 = new Ejercicio_TypedDataContext11_ForReadOnly(locations, true);
                return valDataContext148.ValueType___Expr148Get();
            }
            if ((expressionId == 149)) {
                Ejercicio_TypedDataContext11_ForReadOnly valDataContext149 = new Ejercicio_TypedDataContext11_ForReadOnly(locations, true);
                return valDataContext149.ValueType___Expr149Get();
            }
            if ((expressionId == 150)) {
                Ejercicio_TypedDataContext11_ForReadOnly valDataContext150 = new Ejercicio_TypedDataContext11_ForReadOnly(locations, true);
                return valDataContext150.ValueType___Expr150Get();
            }
            if ((expressionId == 151)) {
                Ejercicio_TypedDataContext11_ForReadOnly valDataContext151 = new Ejercicio_TypedDataContext11_ForReadOnly(locations, true);
                return valDataContext151.ValueType___Expr151Get();
            }
            if ((expressionId == 152)) {
                Ejercicio_TypedDataContext11 refDataContext152 = new Ejercicio_TypedDataContext11(locations, true);
                return refDataContext152.GetLocation<int>(refDataContext152.ValueType___Expr152Get, refDataContext152.ValueType___Expr152Set);
            }
            if ((expressionId == 153)) {
                Ejercicio_TypedDataContext11_ForReadOnly valDataContext153 = new Ejercicio_TypedDataContext11_ForReadOnly(locations, true);
                return valDataContext153.ValueType___Expr153Get();
            }
            if ((expressionId == 154)) {
                Ejercicio_TypedDataContext11_ForReadOnly valDataContext154 = new Ejercicio_TypedDataContext11_ForReadOnly(locations, true);
                return valDataContext154.ValueType___Expr154Get();
            }
            if ((expressionId == 155)) {
                Ejercicio_TypedDataContext11 refDataContext155 = new Ejercicio_TypedDataContext11(locations, true);
                return refDataContext155.GetLocation<int>(refDataContext155.ValueType___Expr155Get, refDataContext155.ValueType___Expr155Set);
            }
            if ((expressionId == 156)) {
                Ejercicio_TypedDataContext11_ForReadOnly valDataContext156 = new Ejercicio_TypedDataContext11_ForReadOnly(locations, true);
                return valDataContext156.ValueType___Expr156Get();
            }
            if ((expressionId == 157)) {
                Ejercicio_TypedDataContext11 refDataContext157 = new Ejercicio_TypedDataContext11(locations, true);
                return refDataContext157.GetLocation<int>(refDataContext157.ValueType___Expr157Get, refDataContext157.ValueType___Expr157Set);
            }
            if ((expressionId == 158)) {
                Ejercicio_TypedDataContext11_ForReadOnly valDataContext158 = new Ejercicio_TypedDataContext11_ForReadOnly(locations, true);
                return valDataContext158.ValueType___Expr158Get();
            }
            if ((expressionId == 159)) {
                Ejercicio_TypedDataContext11_ForReadOnly valDataContext159 = new Ejercicio_TypedDataContext11_ForReadOnly(locations, true);
                return valDataContext159.ValueType___Expr159Get();
            }
            if ((expressionId == 160)) {
                Ejercicio_TypedDataContext11_ForReadOnly valDataContext160 = new Ejercicio_TypedDataContext11_ForReadOnly(locations, true);
                return valDataContext160.ValueType___Expr160Get();
            }
            if ((expressionId == 161)) {
                Ejercicio_TypedDataContext12_ForReadOnly valDataContext161 = new Ejercicio_TypedDataContext12_ForReadOnly(locations, true);
                return valDataContext161.ValueType___Expr161Get();
            }
            if ((expressionId == 162)) {
                Ejercicio_TypedDataContext12 refDataContext162 = new Ejercicio_TypedDataContext12(locations, true);
                return refDataContext162.GetLocation<int>(refDataContext162.ValueType___Expr162Get, refDataContext162.ValueType___Expr162Set);
            }
            if ((expressionId == 163)) {
                Ejercicio_TypedDataContext12 refDataContext163 = new Ejercicio_TypedDataContext12(locations, true);
                return refDataContext163.GetLocation<string>(refDataContext163.ValueType___Expr163Get, refDataContext163.ValueType___Expr163Set);
            }
            if ((expressionId == 164)) {
                Ejercicio_TypedDataContext12_ForReadOnly valDataContext164 = new Ejercicio_TypedDataContext12_ForReadOnly(locations, true);
                return valDataContext164.ValueType___Expr164Get();
            }
            if ((expressionId == 165)) {
                Ejercicio_TypedDataContext12_ForReadOnly valDataContext165 = new Ejercicio_TypedDataContext12_ForReadOnly(locations, true);
                return valDataContext165.ValueType___Expr165Get();
            }
            if ((expressionId == 166)) {
                Ejercicio_TypedDataContext12 refDataContext166 = new Ejercicio_TypedDataContext12(locations, true);
                return refDataContext166.GetLocation<System.Drawing.PointF>(refDataContext166.ValueType___Expr166Get, refDataContext166.ValueType___Expr166Set);
            }
            if ((expressionId == 167)) {
                Ejercicio_TypedDataContext12_ForReadOnly valDataContext167 = new Ejercicio_TypedDataContext12_ForReadOnly(locations, true);
                return valDataContext167.ValueType___Expr167Get();
            }
            if ((expressionId == 168)) {
                Ejercicio_TypedDataContext12_ForReadOnly valDataContext168 = new Ejercicio_TypedDataContext12_ForReadOnly(locations, true);
                return valDataContext168.ValueType___Expr168Get();
            }
            if ((expressionId == 169)) {
                Ejercicio_TypedDataContext12_ForReadOnly valDataContext169 = new Ejercicio_TypedDataContext12_ForReadOnly(locations, true);
                return valDataContext169.ValueType___Expr169Get();
            }
            if ((expressionId == 170)) {
                Ejercicio_TypedDataContext12 refDataContext170 = new Ejercicio_TypedDataContext12(locations, true);
                return refDataContext170.GetLocation<int>(refDataContext170.ValueType___Expr170Get, refDataContext170.ValueType___Expr170Set);
            }
            if ((expressionId == 171)) {
                Ejercicio_TypedDataContext12_ForReadOnly valDataContext171 = new Ejercicio_TypedDataContext12_ForReadOnly(locations, true);
                return valDataContext171.ValueType___Expr171Get();
            }
            if ((expressionId == 172)) {
                Ejercicio_TypedDataContext12_ForReadOnly valDataContext172 = new Ejercicio_TypedDataContext12_ForReadOnly(locations, true);
                return valDataContext172.ValueType___Expr172Get();
            }
            if ((expressionId == 173)) {
                Ejercicio_TypedDataContext12_ForReadOnly valDataContext173 = new Ejercicio_TypedDataContext12_ForReadOnly(locations, true);
                return valDataContext173.ValueType___Expr173Get();
            }
            if ((expressionId == 174)) {
                Ejercicio_TypedDataContext12_ForReadOnly valDataContext174 = new Ejercicio_TypedDataContext12_ForReadOnly(locations, true);
                return valDataContext174.ValueType___Expr174Get();
            }
            if ((expressionId == 175)) {
                Ejercicio_TypedDataContext12_ForReadOnly valDataContext175 = new Ejercicio_TypedDataContext12_ForReadOnly(locations, true);
                return valDataContext175.ValueType___Expr175Get();
            }
            if ((expressionId == 176)) {
                Ejercicio_TypedDataContext13_ForReadOnly valDataContext176 = new Ejercicio_TypedDataContext13_ForReadOnly(locations, true);
                return valDataContext176.ValueType___Expr176Get();
            }
            if ((expressionId == 177)) {
                Ejercicio_TypedDataContext13 refDataContext177 = new Ejercicio_TypedDataContext13(locations, true);
                return refDataContext177.GetLocation<int>(refDataContext177.ValueType___Expr177Get, refDataContext177.ValueType___Expr177Set);
            }
            if ((expressionId == 178)) {
                Ejercicio_TypedDataContext13_ForReadOnly valDataContext178 = new Ejercicio_TypedDataContext13_ForReadOnly(locations, true);
                return valDataContext178.ValueType___Expr178Get();
            }
            if ((expressionId == 179)) {
                Ejercicio_TypedDataContext13_ForReadOnly valDataContext179 = new Ejercicio_TypedDataContext13_ForReadOnly(locations, true);
                return valDataContext179.ValueType___Expr179Get();
            }
            if ((expressionId == 180)) {
                Ejercicio_TypedDataContext13_ForReadOnly valDataContext180 = new Ejercicio_TypedDataContext13_ForReadOnly(locations, true);
                return valDataContext180.ValueType___Expr180Get();
            }
            if ((expressionId == 181)) {
                Ejercicio_TypedDataContext13_ForReadOnly valDataContext181 = new Ejercicio_TypedDataContext13_ForReadOnly(locations, true);
                return valDataContext181.ValueType___Expr181Get();
            }
            if ((expressionId == 182)) {
                Ejercicio_TypedDataContext14 refDataContext182 = new Ejercicio_TypedDataContext14(locations, true);
                return refDataContext182.GetLocation<string>(refDataContext182.ValueType___Expr182Get, refDataContext182.ValueType___Expr182Set);
            }
            if ((expressionId == 183)) {
                Ejercicio_TypedDataContext14_ForReadOnly valDataContext183 = new Ejercicio_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext183.ValueType___Expr183Get();
            }
            if ((expressionId == 184)) {
                Ejercicio_TypedDataContext14_ForReadOnly valDataContext184 = new Ejercicio_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext184.ValueType___Expr184Get();
            }
            if ((expressionId == 185)) {
                Ejercicio_TypedDataContext14 refDataContext185 = new Ejercicio_TypedDataContext14(locations, true);
                return refDataContext185.GetLocation<System.Drawing.PointF>(refDataContext185.ValueType___Expr185Get, refDataContext185.ValueType___Expr185Set);
            }
            if ((expressionId == 186)) {
                Ejercicio_TypedDataContext14_ForReadOnly valDataContext186 = new Ejercicio_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext186.ValueType___Expr186Get();
            }
            if ((expressionId == 187)) {
                Ejercicio_TypedDataContext14_ForReadOnly valDataContext187 = new Ejercicio_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext187.ValueType___Expr187Get();
            }
            if ((expressionId == 188)) {
                Ejercicio_TypedDataContext14_ForReadOnly valDataContext188 = new Ejercicio_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext188.ValueType___Expr188Get();
            }
            if ((expressionId == 189)) {
                Ejercicio_TypedDataContext14_ForReadOnly valDataContext189 = new Ejercicio_TypedDataContext14_ForReadOnly(locations, true);
                return valDataContext189.ValueType___Expr189Get();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == false) 
                        && ((expressionText == "new List<string>()") 
                        && (Ejercicio_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Reporte") 
                        && (Ejercicio_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new List<string>()") 
                        && (Ejercicio_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Recorrido") 
                        && (Ejercicio_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IRecoleccion") 
                        && (Ejercicio_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Iteracion") 
                        && (Ejercicio_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Angulo.Length") 
                        && (Ejercicio_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "MaxIteracion") 
                        && (Ejercicio_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Cercania") 
                        && (Ejercicio_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new PointF(0,0)") 
                        && (Ejercicio_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Cruz") 
                        && (Ejercicio_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Reporte") 
                        && (Ejercicio_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Sujeto;\"+Sujeto") 
                        && (Ejercicio_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Reporte") 
                        && (Ejercicio_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Radio;\"+Radio.ToString()") 
                        && (Ejercicio_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Reporte") 
                        && (Ejercicio_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 15;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Hora Inicio;\"+DateTime.Now.ToString()") 
                        && (Ejercicio_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 16;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "RtaCave") 
                        && (Ejercicio_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 17;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RtaCave.Split(\';\').Length>1") 
                        && (Ejercicio_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 18;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new PointF(Single.Parse(RtaCave.Split(\';\')[0].Replace(\".\", \",\")), Single.Parse(Rt" +
                            "aCave.Split(\';\')[1].Replace(\".\", \",\")))") 
                        && (Ejercicio_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 19;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Coordenadas") 
                        && (Ejercicio_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 20;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Agregar180") 
                        && (Ejercicio_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 21;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Escenario[Iteracion].Equals(0)") 
                        && (Ejercicio_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 22;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"L{ \\\"id\\\":\\\"null\\\" }\"") 
                        && (Ejercicio_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 23;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"L{ \\\"id\\\":\\\"\"+Escenario[Iteracion]+\"\\\" }\"") 
                        && (Ejercicio_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 24;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TimeSpan.FromSeconds(1)") 
                        && (Ejercicio_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 25;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(new Random()).Next(0,BanderasCircunferencia.Count-1)") 
                        && (Ejercicio_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 26;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "idIzquierda") 
                        && (Ejercicio_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 27;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(idIzquierda+(Angulo[Iteracion]/Separacion))%BanderasCircunferencia.Count") 
                        && (Ejercicio_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 28;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "idDerecha") 
                        && (Ejercicio_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 29;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Reporte") 
                        && (Ejercicio_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 30;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"NroIteracion;\"+Iteracion") 
                        && (Ejercicio_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 31;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Reporte") 
                        && (Ejercicio_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 32;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Angulo;\"+Angulo[Iteracion]") 
                        && (Ejercicio_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 33;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Reporte") 
                        && (Ejercicio_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 34;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"A Seleccionar;\"+Lateral[Iteracion]") 
                        && (Ejercicio_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 35;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Reporte") 
                        && (Ejercicio_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 36;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Protocolo;\"+Protocolo[Iteracion]") 
                        && (Ejercicio_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 37;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Reporte") 
                        && (Ejercicio_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 38;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Escenario;\"+Escenario[Iteracion]") 
                        && (Ejercicio_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 39;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Reporte") 
                        && (Ejercicio_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 40;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"AparecerDeAUna;\" + AparecePar[Iteracion]") 
                        && (Ejercicio_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 41;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Reporte") 
                        && (Ejercicio_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 42;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"IdIzquierda;\"+idIzquierda") 
                        && (Ejercicio_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 43;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Reporte") 
                        && (Ejercicio_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 44;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"IzquierdaX;\" + BanderasCircunferencia.ElementAt(idIzquierda).X") 
                        && (Ejercicio_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 45;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Reporte") 
                        && (Ejercicio_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 46;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"IzquierdaY;\" + BanderasCircunferencia.ElementAt(idIzquierda).Y") 
                        && (Ejercicio_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 47;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Reporte") 
                        && (Ejercicio_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 48;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"IdDerecha;\"+idDerecha") 
                        && (Ejercicio_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 49;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Reporte") 
                        && (Ejercicio_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 50;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"DerechaX;\" + BanderasCircunferencia.ElementAt(idDerecha).X") 
                        && (Ejercicio_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 51;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Reporte") 
                        && (Ejercicio_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 52;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"DerechaY;\" + BanderasCircunferencia.ElementAt(idDerecha).Y") 
                        && (Ejercicio_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 53;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Lateral[Iteracion].Equals(\"I\")") 
                        && (Ejercicio_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 54;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Reporte") 
                        && (Ejercicio_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 55;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"IdCorrecta;\"+idIzquierda") 
                        && (Ejercicio_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 56;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Reporte") 
                        && (Ejercicio_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 57;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"CorrectaX;\" + BanderasCircunferencia.ElementAt(idIzquierda).X") 
                        && (Ejercicio_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 58;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Reporte") 
                        && (Ejercicio_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 59;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"CorrectaY;\" + BanderasCircunferencia.ElementAt(idIzquierda).Y") 
                        && (Ejercicio_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 60;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Lateral[Iteracion].Equals(\"D\")") 
                        && (Ejercicio_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 61;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Reporte") 
                        && (Ejercicio_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 62;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"IdCorrecta;\"+idDerecha") 
                        && (Ejercicio_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 63;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Reporte") 
                        && (Ejercicio_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 64;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"CorrectaX;\" + BanderasCircunferencia.ElementAt(idDerecha).X") 
                        && (Ejercicio_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 65;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Reporte") 
                        && (Ejercicio_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 66;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"CorrectaY;\" + BanderasCircunferencia.ElementAt(idDerecha).Y") 
                        && (Ejercicio_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 67;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(idIzquierda + Angulo[Iteracion]/2)%BanderasCircunferencia.Count") 
                        && (Ejercicio_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 68;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "idMedio") 
                        && (Ejercicio_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 69;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Reporte") 
                        && (Ejercicio_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 70;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"IdCorrecta;\" + idMedio") 
                        && (Ejercicio_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 71;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Reporte") 
                        && (Ejercicio_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 72;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"CorrectaX;\" + BanderasCircunferencia.ElementAt(idMedio).X") 
                        && (Ejercicio_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 73;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Reporte") 
                        && (Ejercicio_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 74;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"CorrectaY;\" + BanderasCircunferencia.ElementAt(idMedio).Y") 
                        && (Ejercicio_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 75;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "RtaCave") 
                        && (Ejercicio_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 76;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RtaCave.Split(\';\').Length>1") 
                        && (Ejercicio_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 77;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new PointF(Single.Parse(RtaCave.Split(\';\')[0].Replace(\".\", \",\")), Single.Parse(Rt" +
                            "aCave.Split(\';\')[1].Replace(\".\", \",\")))") 
                        && (Ejercicio_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 78;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Coordenadas") 
                        && (Ejercicio_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 79;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "AparecePar[Iteracion].Equals(1)") 
                        && (Ejercicio_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 80;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"H{ \\\"id\\\":\\\"\" + idIzquierda + \"\\\", \\\"visible\\\":\\\"true\\\" }\"") 
                        && (Ejercicio_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 81;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"H{ \\\"id\\\":\\\"\" + idDerecha + \"\\\", \\\"visible\\\":\\\"true\\\" }\"") 
                        && (Ejercicio_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 82;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new int [2]") 
                        && (Ejercicio_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 83;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ParBanderasVisible") 
                        && (Ejercicio_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 84;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ParBanderasVisible[0]") 
                        && (Ejercicio_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 85;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ParBanderasVisible[1]") 
                        && (Ejercicio_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 86;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"H{ \\\"id\\\":\\\"\" + idIzquierda + \"\\\", \\\"visible\\\":\\\"true\\\" }\"") 
                        && (Ejercicio_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 87;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new int [2]") 
                        && (Ejercicio_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 88;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ParBanderasVisible") 
                        && (Ejercicio_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 89;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ParBanderasVisible[0]") 
                        && (Ejercicio_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 90;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ParBanderasVisible[1]") 
                        && (Ejercicio_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 91;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "RtaCave") 
                        && (Ejercicio_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 92;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RtaCave.Split(\';\').Length>1") 
                        && (Ejercicio_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 93;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new PointF(Single.Parse(RtaCave.Split(\';\')[0].Replace(\".\", \",\")), Single.Parse(Rt" +
                            "aCave.Split(\';\')[1].Replace(\".\", \",\")))") 
                        && (Ejercicio_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 94;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Coordenadas") 
                        && (Ejercicio_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 95;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == @"(ParBanderasVisible[0].Equals(1) && ((Math.Sqrt(Math.Pow(Coordenadas.X - BanderasCircunferencia.ElementAt(idIzquierda).X, 2) - Math.Pow(Coordenadas.Y - BanderasCircunferencia.ElementAt(idIzquierda).Y, 2))) < Cercania)) || (ParBanderasVisible[1].Equals(1) && (Math.Sqrt(Math.Pow(Coordenadas.X - BanderasCircunferencia.ElementAt(idDerecha).X, 2) + Math.Pow(Coordenadas.Y - BanderasCircunferencia.ElementAt(idDerecha).Y, 2))) < Cercania)") 
                        && (Ejercicio_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 96;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "IRecoleccion+1") 
                        && (Ejercicio_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 97;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IRecoleccion") 
                        && (Ejercicio_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 98;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(ParBanderasVisible[0].Equals(1) && ((Math.Sqrt(Math.Pow(Coordenadas.X - Banderas" +
                            "Circunferencia.ElementAt(idIzquierda).X, 2) + Math.Pow(Coordenadas.Y - BanderasC" +
                            "ircunferencia.ElementAt(idIzquierda).Y, 2))) < Cercania))") 
                        && (Ejercicio_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 99;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ParBanderasVisible[0]") 
                        && (Ejercicio_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 100;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"H{ \\\"id\\\":\\\"\" + idIzquierda + \"\\\", \\\"visible\\\":\\\"false\\\" }\"") 
                        && (Ejercicio_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 101;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Reporte") 
                        && (Ejercicio_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 102;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Captura Bandera;\" + idIzquierda + \"/n\"\n                + \"Hora;\" + TimeZone.Curr" +
                            "entTimeZone.ToString()") 
                        && (Ejercicio_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 103;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(ParBanderasVisible[1].Equals(1) && (Math.Sqrt(Math.Pow(Coordenadas.X - BanderasC" +
                            "ircunferencia.ElementAt(idDerecha).X, 2)+ Math.Pow(Coordenadas.Y - BanderasCircu" +
                            "nferencia.ElementAt(idDerecha).Y, 2))) < Cercania)") 
                        && (Ejercicio_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 104;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ParBanderasVisible[1]") 
                        && (Ejercicio_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 105;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"H{ \\\"id\\\":\\\"\" + idDerecha + \"\\\", \\\"visible\\\":\\\"false\\\" }\"") 
                        && (Ejercicio_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 106;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Reporte") 
                        && (Ejercicio_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 107;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Captura Bandera;\" + idDerecha + \"/n\"\n                + \"Hora;\" + TimeZone.Curren" +
                            "tTimeZone.ToString()") 
                        && (Ejercicio_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 108;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == @"!((ParBanderasVisible[0].Equals(1) && ((Math.Sqrt(Math.Pow(Coordenadas.X - BanderasCircunferencia.ElementAt(idIzquierda).X, 2) - Math.Pow(Coordenadas.Y - BanderasCircunferencia.ElementAt(idIzquierda).Y, 2))) < Cercania)) || (ParBanderasVisible[1].Equals(1) && (Math.Sqrt(Math.Pow(Coordenadas.X - BanderasCircunferencia.ElementAt(idDerecha).X, 2) - Math.Pow(Coordenadas.Y - BanderasCircunferencia.ElementAt(idDerecha).Y, 2))) < Cercania))") 
                        && (Ejercicio_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 109;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ParBanderasVisible[0].Equals(1)") 
                        && (Ejercicio_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 110;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "RtaCave") 
                        && (Ejercicio_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 111;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RtaCave.Split(\';\').Length>1") 
                        && (Ejercicio_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 112;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new PointF(Single.Parse(RtaCave.Split(\';\')[0].Replace(\".\", \",\")), Single.Parse(Rt" +
                            "aCave.Split(\';\')[1].Replace(\".\", \",\")))") 
                        && (Ejercicio_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 113;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Coordenadas") 
                        && (Ejercicio_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 114;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "((Math.Sqrt(Math.Pow(Coordenadas.X - Cruz.X, 2) + Math.Pow(Coordenadas.Y - Cruz.Y" +
                            ", 2))) < Cercania) && (IRecoleccion.Equals(2)) && (Evaluar.Equals(1))") 
                        && (Ejercicio_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 115;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IRecoleccion") 
                        && (Ejercicio_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 116;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Reporte") 
                        && (Ejercicio_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 117;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Inicio test memoria;\" + TimeZone.CurrentTimeZone.ToString()") 
                        && (Ejercicio_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 118;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "((Math.Sqrt(Math.Pow(Coordenadas.X - Cruz.X, 2) + Math.Pow(Coordenadas.Y - Cruz.Y" +
                            ", 2))) < Cercania) && (IRecoleccion.CompareTo(2)<0)") 
                        && (Ejercicio_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 119;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Reporte") 
                        && (Ejercicio_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 120;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Hora Centro;\" + TimeZone.CurrentTimeZone.ToString()") 
                        && (Ejercicio_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 121;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "AparecePar[Iteracion].Equals(0)") 
                        && (Ejercicio_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 122;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"H{ \\\"id\\\":\\\"\" + idDerecha + \"\\\", \\\"visible\\\":\\\"true\\\" }\"") 
                        && (Ejercicio_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 123;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ParBanderasVisible[1]") 
                        && (Ejercicio_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 124;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "!((Math.Sqrt(Math.Pow(Coordenadas.X - Cruz.X, 2) + Math.Pow(Coordenadas.Y - Cruz." +
                            "Y, 2))) < Cercania)") 
                        && (Ejercicio_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 125;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "RtaCave") 
                        && (Ejercicio_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 126;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RtaCave.Split(\';\').Length>1") 
                        && (Ejercicio_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 127;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new PointF(Single.Parse(RtaCave.Split(\';\')[0].Replace(\".\", \",\")), Single.Parse(Rt" +
                            "aCave.Split(\';\')[1].Replace(\".\", \",\")))") 
                        && (Ejercicio_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 128;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Coordenadas") 
                        && (Ejercicio_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 129;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Protocolo[Iteracion].Equals(1)") 
                        && (Ejercicio_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 130;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Protocolo[Iteracion].Equals(2)") 
                        && (Ejercicio_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 131;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Cursor") 
                        && (Ejercicio_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 132;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Q{ \\\"text\\\":\\\"Escucha la consigna\\\" }\"") 
                        && (Ejercicio_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 133;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TimeSpan.FromSeconds(4)") 
                        && (Ejercicio_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 134;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Q{ \\\"text\\\":\\\" \\\" }\"") 
                        && (Ejercicio_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 135;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Mostrar180") 
                        && (Ejercicio_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 136;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Protocolo[Iteracion].Equals(3)") 
                        && (Ejercicio_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 137;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Q{ \\\"text\\\":\\\"Coloca la bandera\\\" }\"") 
                        && (Ejercicio_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 138;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TimeSpan.FromSeconds(4)") 
                        && (Ejercicio_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 139;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Q{ \\\"text\\\":\\\" \\\" }\"") 
                        && (Ejercicio_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 140;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Q{ \\\"text\\\":\\\"Fin del experimento\\\" }\"") 
                        && (Ejercicio_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 141;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TimeSpan.FromSeconds(2)") 
                        && (Ejercicio_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 142;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"C{ \\\"id\\\":\\\"\" + (int)(Cursor) + \"\\\", \\\"color\\\":\\\"azul\\\" }\"") 
                        && (Ejercicio_TypedDataContext11_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 143;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "RtaCave") 
                        && (Ejercicio_TypedDataContext11.Validate(locations, true, 0) == true)))) {
                expressionId = 144;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RtaCave.Split(\';\').Length>1") 
                        && (Ejercicio_TypedDataContext11_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 145;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new PointF(Single.Parse(RtaCave.Split(\';\')[0].Replace(\".\", \",\")), Single.Parse(Rt" +
                            "aCave.Split(\';\')[1].Replace(\".\", \",\")))") 
                        && (Ejercicio_TypedDataContext11_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 146;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Coordenadas") 
                        && (Ejercicio_TypedDataContext11.Validate(locations, true, 0) == true)))) {
                expressionId = 147;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RtaCave.Equals(\"1\") || RtaCave.Equals(\"3\")") 
                        && (Ejercicio_TypedDataContext11_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 148;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"C{ \\\"id\\\":\\\"\" + (int)(Cursor) + \"\\\", \\\"color\\\":\\\"\" + Color[Iteracion] + \"\\\" }\"") 
                        && (Ejercicio_TypedDataContext11_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 149;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RtaCave.Equals(\"1\")") 
                        && (Ejercicio_TypedDataContext11_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 150;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Cursor - 1) % BanderasCircunferencia.Count") 
                        && (Ejercicio_TypedDataContext11_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 151;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Cursor") 
                        && (Ejercicio_TypedDataContext11.Validate(locations, true, 0) == true)))) {
                expressionId = 152;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Cursor<0") 
                        && (Ejercicio_TypedDataContext11_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 153;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "BanderasCircunferencia.Count-1") 
                        && (Ejercicio_TypedDataContext11_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 154;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Cursor") 
                        && (Ejercicio_TypedDataContext11.Validate(locations, true, 0) == true)))) {
                expressionId = 155;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(Cursor + 1) % BanderasCircunferencia.Count") 
                        && (Ejercicio_TypedDataContext11_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 156;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Cursor") 
                        && (Ejercicio_TypedDataContext11.Validate(locations, true, 0) == true)))) {
                expressionId = 157;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RtaCave.Equals(\"2\")&&(Iteracion<(Angulo.Length-1))") 
                        && (Ejercicio_TypedDataContext11_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 158;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"C{ \\\"id\\\":\\\"\" + (int)(Cursor) + \"\\\", \\\"color\\\":\\\"\" + Color[Iteracion] + \"\\\" }\"") 
                        && (Ejercicio_TypedDataContext11_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 159;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Mostrar180.Replace(\"true\", \"false\")") 
                        && (Ejercicio_TypedDataContext11_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 160;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "BanderasCircunferencia.Count + Iteracion") 
                        && (Ejercicio_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 161;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Cursor") 
                        && (Ejercicio_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 162;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "RtaCave") 
                        && (Ejercicio_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 163;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RtaCave.Split(\';\').Length>1") 
                        && (Ejercicio_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 164;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new PointF(Single.Parse(RtaCave.Split(\';\')[0].Replace(\".\", \",\")), Single.Parse(Rt" +
                            "aCave.Split(\';\')[1].Replace(\".\", \",\")))") 
                        && (Ejercicio_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 165;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Coordenadas") 
                        && (Ejercicio_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 166;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RtaCave.Equals(\"2\")") 
                        && (Ejercicio_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 167;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == @"""A{ \""id\"":\"""" + Cursor + ""\"", \""color\"":\"""" + Color[Iteracion] + ""\"", \""x\"":\"""" + Coordenadas.X.ToString(System.Globalization.CultureInfo.InvariantCulture).Replace("","", ""."") + ""\"", \""y\"":\"""" + Coordenadas.Y.ToString(System.Globalization.CultureInfo.InvariantCulture).Replace("","", ""."") + ""\"", \""visible\"":\""true\"" }""") 
                        && (Ejercicio_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 168;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Cursor+1") 
                        && (Ejercicio_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 169;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Cursor") 
                        && (Ejercicio_TypedDataContext12.Validate(locations, true, 0) == true)))) {
                expressionId = 170;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TimeSpan.FromSeconds(2)") 
                        && (Ejercicio_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 171;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Q{ \\\"text\\\":\\\"Confirma la posicion (Y)\\\" }\"") 
                        && (Ejercicio_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 172;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "TimeSpan.FromSeconds(2)") 
                        && (Ejercicio_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 173;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Q{ \\\"text\\\":\\\" \\\" }\"") 
                        && (Ejercicio_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 174;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "!RtaCave.Equals(\"2\")") 
                        && (Ejercicio_TypedDataContext12_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 175;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Iteracion+1") 
                        && (Ejercicio_TypedDataContext13_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 176;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Iteracion") 
                        && (Ejercicio_TypedDataContext13.Validate(locations, true, 0) == true)))) {
                expressionId = 177;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Reporte") 
                        && (Ejercicio_TypedDataContext13_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 178;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == @"""Hora Fin Seleccion;"" + TimeZone.CurrentTimeZone.ToString() + ""/n""+
                ""Bandera Seleccionada [id];""+Cursor+""/n""+
                    ""Bandera Seleccionada [X];""+BanderasCircunferencia.ElementAt(Cursor).X+""\n""+
                    ""Bandera Seleccionada [Y];""+BanderasCircunferencia.ElementAt(Cursor).Y") 
                        && (Ejercicio_TypedDataContext13_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 179;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Iteracion<Angulo.Length") 
                        && (Ejercicio_TypedDataContext13_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 180;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Iteracion.Equals(Angulo.Length)") 
                        && (Ejercicio_TypedDataContext13_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 181;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "RtaCave") 
                        && (Ejercicio_TypedDataContext14.Validate(locations, true, 0) == true)))) {
                expressionId = 182;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RtaCave.Split(\';\').Length>1") 
                        && (Ejercicio_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 183;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new PointF(Single.Parse(RtaCave.Split(\';\')[0].Replace(\".\", \",\")), Single.Parse(Rt" +
                            "aCave.Split(\';\')[1].Replace(\".\", \",\")))") 
                        && (Ejercicio_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 184;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Coordenadas") 
                        && (Ejercicio_TypedDataContext14.Validate(locations, true, 0) == true)))) {
                expressionId = 185;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RtaCave.Equals(\"2\")") 
                        && (Ejercicio_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 186;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"H{ \\\"id\\\":\\\"\" + (int)(Cursor-1) + \"\\\", \\\"visible\\\":\\\"false\\\" }\"") 
                        && (Ejercicio_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 187;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RtaCave.Equals(\"1\")") 
                        && (Ejercicio_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 188;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"H{ \\\"id\\\":\\\"\" + (int)(Cursor-1) + \"\\\", \\\"visible\\\":\\\"false\\\" }\"") 
                        && (Ejercicio_TypedDataContext14_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 189;
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
                return new Ejercicio_TypedDataContext3_ForReadOnly(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new Ejercicio_TypedDataContext3(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new Ejercicio_TypedDataContext3_ForReadOnly(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new Ejercicio_TypedDataContext3(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new Ejercicio_TypedDataContext3(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new Ejercicio_TypedDataContext3(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new Ejercicio_TypedDataContext3_ForReadOnly(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new Ejercicio_TypedDataContext3(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new Ejercicio_TypedDataContext3(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new Ejercicio_TypedDataContext3_ForReadOnly(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new Ejercicio_TypedDataContext3(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new Ejercicio_TypedDataContext3_ForReadOnly(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new Ejercicio_TypedDataContext3_ForReadOnly(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new Ejercicio_TypedDataContext3_ForReadOnly(locationReferences).@__Expr13GetTree();
            }
            if ((expressionId == 14)) {
                return new Ejercicio_TypedDataContext3_ForReadOnly(locationReferences).@__Expr14GetTree();
            }
            if ((expressionId == 15)) {
                return new Ejercicio_TypedDataContext3_ForReadOnly(locationReferences).@__Expr15GetTree();
            }
            if ((expressionId == 16)) {
                return new Ejercicio_TypedDataContext3_ForReadOnly(locationReferences).@__Expr16GetTree();
            }
            if ((expressionId == 17)) {
                return new Ejercicio_TypedDataContext3(locationReferences).@__Expr17GetTree();
            }
            if ((expressionId == 18)) {
                return new Ejercicio_TypedDataContext3_ForReadOnly(locationReferences).@__Expr18GetTree();
            }
            if ((expressionId == 19)) {
                return new Ejercicio_TypedDataContext3_ForReadOnly(locationReferences).@__Expr19GetTree();
            }
            if ((expressionId == 20)) {
                return new Ejercicio_TypedDataContext3(locationReferences).@__Expr20GetTree();
            }
            if ((expressionId == 21)) {
                return new Ejercicio_TypedDataContext3_ForReadOnly(locationReferences).@__Expr21GetTree();
            }
            if ((expressionId == 22)) {
                return new Ejercicio_TypedDataContext4_ForReadOnly(locationReferences).@__Expr22GetTree();
            }
            if ((expressionId == 23)) {
                return new Ejercicio_TypedDataContext4_ForReadOnly(locationReferences).@__Expr23GetTree();
            }
            if ((expressionId == 24)) {
                return new Ejercicio_TypedDataContext4_ForReadOnly(locationReferences).@__Expr24GetTree();
            }
            if ((expressionId == 25)) {
                return new Ejercicio_TypedDataContext4_ForReadOnly(locationReferences).@__Expr25GetTree();
            }
            if ((expressionId == 26)) {
                return new Ejercicio_TypedDataContext4_ForReadOnly(locationReferences).@__Expr26GetTree();
            }
            if ((expressionId == 27)) {
                return new Ejercicio_TypedDataContext4(locationReferences).@__Expr27GetTree();
            }
            if ((expressionId == 28)) {
                return new Ejercicio_TypedDataContext4_ForReadOnly(locationReferences).@__Expr28GetTree();
            }
            if ((expressionId == 29)) {
                return new Ejercicio_TypedDataContext4(locationReferences).@__Expr29GetTree();
            }
            if ((expressionId == 30)) {
                return new Ejercicio_TypedDataContext4_ForReadOnly(locationReferences).@__Expr30GetTree();
            }
            if ((expressionId == 31)) {
                return new Ejercicio_TypedDataContext4_ForReadOnly(locationReferences).@__Expr31GetTree();
            }
            if ((expressionId == 32)) {
                return new Ejercicio_TypedDataContext4_ForReadOnly(locationReferences).@__Expr32GetTree();
            }
            if ((expressionId == 33)) {
                return new Ejercicio_TypedDataContext4_ForReadOnly(locationReferences).@__Expr33GetTree();
            }
            if ((expressionId == 34)) {
                return new Ejercicio_TypedDataContext4_ForReadOnly(locationReferences).@__Expr34GetTree();
            }
            if ((expressionId == 35)) {
                return new Ejercicio_TypedDataContext4_ForReadOnly(locationReferences).@__Expr35GetTree();
            }
            if ((expressionId == 36)) {
                return new Ejercicio_TypedDataContext4_ForReadOnly(locationReferences).@__Expr36GetTree();
            }
            if ((expressionId == 37)) {
                return new Ejercicio_TypedDataContext4_ForReadOnly(locationReferences).@__Expr37GetTree();
            }
            if ((expressionId == 38)) {
                return new Ejercicio_TypedDataContext4_ForReadOnly(locationReferences).@__Expr38GetTree();
            }
            if ((expressionId == 39)) {
                return new Ejercicio_TypedDataContext4_ForReadOnly(locationReferences).@__Expr39GetTree();
            }
            if ((expressionId == 40)) {
                return new Ejercicio_TypedDataContext4_ForReadOnly(locationReferences).@__Expr40GetTree();
            }
            if ((expressionId == 41)) {
                return new Ejercicio_TypedDataContext4_ForReadOnly(locationReferences).@__Expr41GetTree();
            }
            if ((expressionId == 42)) {
                return new Ejercicio_TypedDataContext4_ForReadOnly(locationReferences).@__Expr42GetTree();
            }
            if ((expressionId == 43)) {
                return new Ejercicio_TypedDataContext4_ForReadOnly(locationReferences).@__Expr43GetTree();
            }
            if ((expressionId == 44)) {
                return new Ejercicio_TypedDataContext4_ForReadOnly(locationReferences).@__Expr44GetTree();
            }
            if ((expressionId == 45)) {
                return new Ejercicio_TypedDataContext4_ForReadOnly(locationReferences).@__Expr45GetTree();
            }
            if ((expressionId == 46)) {
                return new Ejercicio_TypedDataContext4_ForReadOnly(locationReferences).@__Expr46GetTree();
            }
            if ((expressionId == 47)) {
                return new Ejercicio_TypedDataContext4_ForReadOnly(locationReferences).@__Expr47GetTree();
            }
            if ((expressionId == 48)) {
                return new Ejercicio_TypedDataContext4_ForReadOnly(locationReferences).@__Expr48GetTree();
            }
            if ((expressionId == 49)) {
                return new Ejercicio_TypedDataContext4_ForReadOnly(locationReferences).@__Expr49GetTree();
            }
            if ((expressionId == 50)) {
                return new Ejercicio_TypedDataContext4_ForReadOnly(locationReferences).@__Expr50GetTree();
            }
            if ((expressionId == 51)) {
                return new Ejercicio_TypedDataContext4_ForReadOnly(locationReferences).@__Expr51GetTree();
            }
            if ((expressionId == 52)) {
                return new Ejercicio_TypedDataContext4_ForReadOnly(locationReferences).@__Expr52GetTree();
            }
            if ((expressionId == 53)) {
                return new Ejercicio_TypedDataContext4_ForReadOnly(locationReferences).@__Expr53GetTree();
            }
            if ((expressionId == 54)) {
                return new Ejercicio_TypedDataContext4_ForReadOnly(locationReferences).@__Expr54GetTree();
            }
            if ((expressionId == 55)) {
                return new Ejercicio_TypedDataContext4_ForReadOnly(locationReferences).@__Expr55GetTree();
            }
            if ((expressionId == 56)) {
                return new Ejercicio_TypedDataContext4_ForReadOnly(locationReferences).@__Expr56GetTree();
            }
            if ((expressionId == 57)) {
                return new Ejercicio_TypedDataContext4_ForReadOnly(locationReferences).@__Expr57GetTree();
            }
            if ((expressionId == 58)) {
                return new Ejercicio_TypedDataContext4_ForReadOnly(locationReferences).@__Expr58GetTree();
            }
            if ((expressionId == 59)) {
                return new Ejercicio_TypedDataContext4_ForReadOnly(locationReferences).@__Expr59GetTree();
            }
            if ((expressionId == 60)) {
                return new Ejercicio_TypedDataContext4_ForReadOnly(locationReferences).@__Expr60GetTree();
            }
            if ((expressionId == 61)) {
                return new Ejercicio_TypedDataContext4_ForReadOnly(locationReferences).@__Expr61GetTree();
            }
            if ((expressionId == 62)) {
                return new Ejercicio_TypedDataContext4_ForReadOnly(locationReferences).@__Expr62GetTree();
            }
            if ((expressionId == 63)) {
                return new Ejercicio_TypedDataContext4_ForReadOnly(locationReferences).@__Expr63GetTree();
            }
            if ((expressionId == 64)) {
                return new Ejercicio_TypedDataContext4_ForReadOnly(locationReferences).@__Expr64GetTree();
            }
            if ((expressionId == 65)) {
                return new Ejercicio_TypedDataContext4_ForReadOnly(locationReferences).@__Expr65GetTree();
            }
            if ((expressionId == 66)) {
                return new Ejercicio_TypedDataContext4_ForReadOnly(locationReferences).@__Expr66GetTree();
            }
            if ((expressionId == 67)) {
                return new Ejercicio_TypedDataContext4_ForReadOnly(locationReferences).@__Expr67GetTree();
            }
            if ((expressionId == 68)) {
                return new Ejercicio_TypedDataContext5_ForReadOnly(locationReferences).@__Expr68GetTree();
            }
            if ((expressionId == 69)) {
                return new Ejercicio_TypedDataContext5(locationReferences).@__Expr69GetTree();
            }
            if ((expressionId == 70)) {
                return new Ejercicio_TypedDataContext5_ForReadOnly(locationReferences).@__Expr70GetTree();
            }
            if ((expressionId == 71)) {
                return new Ejercicio_TypedDataContext5_ForReadOnly(locationReferences).@__Expr71GetTree();
            }
            if ((expressionId == 72)) {
                return new Ejercicio_TypedDataContext5_ForReadOnly(locationReferences).@__Expr72GetTree();
            }
            if ((expressionId == 73)) {
                return new Ejercicio_TypedDataContext5_ForReadOnly(locationReferences).@__Expr73GetTree();
            }
            if ((expressionId == 74)) {
                return new Ejercicio_TypedDataContext5_ForReadOnly(locationReferences).@__Expr74GetTree();
            }
            if ((expressionId == 75)) {
                return new Ejercicio_TypedDataContext5_ForReadOnly(locationReferences).@__Expr75GetTree();
            }
            if ((expressionId == 76)) {
                return new Ejercicio_TypedDataContext4(locationReferences).@__Expr76GetTree();
            }
            if ((expressionId == 77)) {
                return new Ejercicio_TypedDataContext4_ForReadOnly(locationReferences).@__Expr77GetTree();
            }
            if ((expressionId == 78)) {
                return new Ejercicio_TypedDataContext4_ForReadOnly(locationReferences).@__Expr78GetTree();
            }
            if ((expressionId == 79)) {
                return new Ejercicio_TypedDataContext4(locationReferences).@__Expr79GetTree();
            }
            if ((expressionId == 80)) {
                return new Ejercicio_TypedDataContext4_ForReadOnly(locationReferences).@__Expr80GetTree();
            }
            if ((expressionId == 81)) {
                return new Ejercicio_TypedDataContext4_ForReadOnly(locationReferences).@__Expr81GetTree();
            }
            if ((expressionId == 82)) {
                return new Ejercicio_TypedDataContext4_ForReadOnly(locationReferences).@__Expr82GetTree();
            }
            if ((expressionId == 83)) {
                return new Ejercicio_TypedDataContext4_ForReadOnly(locationReferences).@__Expr83GetTree();
            }
            if ((expressionId == 84)) {
                return new Ejercicio_TypedDataContext4(locationReferences).@__Expr84GetTree();
            }
            if ((expressionId == 85)) {
                return new Ejercicio_TypedDataContext4(locationReferences).@__Expr85GetTree();
            }
            if ((expressionId == 86)) {
                return new Ejercicio_TypedDataContext4(locationReferences).@__Expr86GetTree();
            }
            if ((expressionId == 87)) {
                return new Ejercicio_TypedDataContext4_ForReadOnly(locationReferences).@__Expr87GetTree();
            }
            if ((expressionId == 88)) {
                return new Ejercicio_TypedDataContext4_ForReadOnly(locationReferences).@__Expr88GetTree();
            }
            if ((expressionId == 89)) {
                return new Ejercicio_TypedDataContext4(locationReferences).@__Expr89GetTree();
            }
            if ((expressionId == 90)) {
                return new Ejercicio_TypedDataContext4(locationReferences).@__Expr90GetTree();
            }
            if ((expressionId == 91)) {
                return new Ejercicio_TypedDataContext4(locationReferences).@__Expr91GetTree();
            }
            if ((expressionId == 92)) {
                return new Ejercicio_TypedDataContext6(locationReferences).@__Expr92GetTree();
            }
            if ((expressionId == 93)) {
                return new Ejercicio_TypedDataContext6_ForReadOnly(locationReferences).@__Expr93GetTree();
            }
            if ((expressionId == 94)) {
                return new Ejercicio_TypedDataContext6_ForReadOnly(locationReferences).@__Expr94GetTree();
            }
            if ((expressionId == 95)) {
                return new Ejercicio_TypedDataContext6(locationReferences).@__Expr95GetTree();
            }
            if ((expressionId == 96)) {
                return new Ejercicio_TypedDataContext6_ForReadOnly(locationReferences).@__Expr96GetTree();
            }
            if ((expressionId == 97)) {
                return new Ejercicio_TypedDataContext6_ForReadOnly(locationReferences).@__Expr97GetTree();
            }
            if ((expressionId == 98)) {
                return new Ejercicio_TypedDataContext6(locationReferences).@__Expr98GetTree();
            }
            if ((expressionId == 99)) {
                return new Ejercicio_TypedDataContext6_ForReadOnly(locationReferences).@__Expr99GetTree();
            }
            if ((expressionId == 100)) {
                return new Ejercicio_TypedDataContext6(locationReferences).@__Expr100GetTree();
            }
            if ((expressionId == 101)) {
                return new Ejercicio_TypedDataContext6_ForReadOnly(locationReferences).@__Expr101GetTree();
            }
            if ((expressionId == 102)) {
                return new Ejercicio_TypedDataContext6_ForReadOnly(locationReferences).@__Expr102GetTree();
            }
            if ((expressionId == 103)) {
                return new Ejercicio_TypedDataContext6_ForReadOnly(locationReferences).@__Expr103GetTree();
            }
            if ((expressionId == 104)) {
                return new Ejercicio_TypedDataContext6_ForReadOnly(locationReferences).@__Expr104GetTree();
            }
            if ((expressionId == 105)) {
                return new Ejercicio_TypedDataContext6(locationReferences).@__Expr105GetTree();
            }
            if ((expressionId == 106)) {
                return new Ejercicio_TypedDataContext6_ForReadOnly(locationReferences).@__Expr106GetTree();
            }
            if ((expressionId == 107)) {
                return new Ejercicio_TypedDataContext6_ForReadOnly(locationReferences).@__Expr107GetTree();
            }
            if ((expressionId == 108)) {
                return new Ejercicio_TypedDataContext6_ForReadOnly(locationReferences).@__Expr108GetTree();
            }
            if ((expressionId == 109)) {
                return new Ejercicio_TypedDataContext6_ForReadOnly(locationReferences).@__Expr109GetTree();
            }
            if ((expressionId == 110)) {
                return new Ejercicio_TypedDataContext7_ForReadOnly(locationReferences).@__Expr110GetTree();
            }
            if ((expressionId == 111)) {
                return new Ejercicio_TypedDataContext7(locationReferences).@__Expr111GetTree();
            }
            if ((expressionId == 112)) {
                return new Ejercicio_TypedDataContext7_ForReadOnly(locationReferences).@__Expr112GetTree();
            }
            if ((expressionId == 113)) {
                return new Ejercicio_TypedDataContext7_ForReadOnly(locationReferences).@__Expr113GetTree();
            }
            if ((expressionId == 114)) {
                return new Ejercicio_TypedDataContext7(locationReferences).@__Expr114GetTree();
            }
            if ((expressionId == 115)) {
                return new Ejercicio_TypedDataContext7_ForReadOnly(locationReferences).@__Expr115GetTree();
            }
            if ((expressionId == 116)) {
                return new Ejercicio_TypedDataContext7(locationReferences).@__Expr116GetTree();
            }
            if ((expressionId == 117)) {
                return new Ejercicio_TypedDataContext7_ForReadOnly(locationReferences).@__Expr117GetTree();
            }
            if ((expressionId == 118)) {
                return new Ejercicio_TypedDataContext7_ForReadOnly(locationReferences).@__Expr118GetTree();
            }
            if ((expressionId == 119)) {
                return new Ejercicio_TypedDataContext7_ForReadOnly(locationReferences).@__Expr119GetTree();
            }
            if ((expressionId == 120)) {
                return new Ejercicio_TypedDataContext7_ForReadOnly(locationReferences).@__Expr120GetTree();
            }
            if ((expressionId == 121)) {
                return new Ejercicio_TypedDataContext7_ForReadOnly(locationReferences).@__Expr121GetTree();
            }
            if ((expressionId == 122)) {
                return new Ejercicio_TypedDataContext7_ForReadOnly(locationReferences).@__Expr122GetTree();
            }
            if ((expressionId == 123)) {
                return new Ejercicio_TypedDataContext7_ForReadOnly(locationReferences).@__Expr123GetTree();
            }
            if ((expressionId == 124)) {
                return new Ejercicio_TypedDataContext7(locationReferences).@__Expr124GetTree();
            }
            if ((expressionId == 125)) {
                return new Ejercicio_TypedDataContext7_ForReadOnly(locationReferences).@__Expr125GetTree();
            }
            if ((expressionId == 126)) {
                return new Ejercicio_TypedDataContext8(locationReferences).@__Expr126GetTree();
            }
            if ((expressionId == 127)) {
                return new Ejercicio_TypedDataContext8_ForReadOnly(locationReferences).@__Expr127GetTree();
            }
            if ((expressionId == 128)) {
                return new Ejercicio_TypedDataContext8_ForReadOnly(locationReferences).@__Expr128GetTree();
            }
            if ((expressionId == 129)) {
                return new Ejercicio_TypedDataContext8(locationReferences).@__Expr129GetTree();
            }
            if ((expressionId == 130)) {
                return new Ejercicio_TypedDataContext8_ForReadOnly(locationReferences).@__Expr130GetTree();
            }
            if ((expressionId == 131)) {
                return new Ejercicio_TypedDataContext8_ForReadOnly(locationReferences).@__Expr131GetTree();
            }
            if ((expressionId == 132)) {
                return new Ejercicio_TypedDataContext8(locationReferences).@__Expr132GetTree();
            }
            if ((expressionId == 133)) {
                return new Ejercicio_TypedDataContext8_ForReadOnly(locationReferences).@__Expr133GetTree();
            }
            if ((expressionId == 134)) {
                return new Ejercicio_TypedDataContext8_ForReadOnly(locationReferences).@__Expr134GetTree();
            }
            if ((expressionId == 135)) {
                return new Ejercicio_TypedDataContext8_ForReadOnly(locationReferences).@__Expr135GetTree();
            }
            if ((expressionId == 136)) {
                return new Ejercicio_TypedDataContext8_ForReadOnly(locationReferences).@__Expr136GetTree();
            }
            if ((expressionId == 137)) {
                return new Ejercicio_TypedDataContext8_ForReadOnly(locationReferences).@__Expr137GetTree();
            }
            if ((expressionId == 138)) {
                return new Ejercicio_TypedDataContext8_ForReadOnly(locationReferences).@__Expr138GetTree();
            }
            if ((expressionId == 139)) {
                return new Ejercicio_TypedDataContext8_ForReadOnly(locationReferences).@__Expr139GetTree();
            }
            if ((expressionId == 140)) {
                return new Ejercicio_TypedDataContext8_ForReadOnly(locationReferences).@__Expr140GetTree();
            }
            if ((expressionId == 141)) {
                return new Ejercicio_TypedDataContext9_ForReadOnly(locationReferences).@__Expr141GetTree();
            }
            if ((expressionId == 142)) {
                return new Ejercicio_TypedDataContext9_ForReadOnly(locationReferences).@__Expr142GetTree();
            }
            if ((expressionId == 143)) {
                return new Ejercicio_TypedDataContext11_ForReadOnly(locationReferences).@__Expr143GetTree();
            }
            if ((expressionId == 144)) {
                return new Ejercicio_TypedDataContext11(locationReferences).@__Expr144GetTree();
            }
            if ((expressionId == 145)) {
                return new Ejercicio_TypedDataContext11_ForReadOnly(locationReferences).@__Expr145GetTree();
            }
            if ((expressionId == 146)) {
                return new Ejercicio_TypedDataContext11_ForReadOnly(locationReferences).@__Expr146GetTree();
            }
            if ((expressionId == 147)) {
                return new Ejercicio_TypedDataContext11(locationReferences).@__Expr147GetTree();
            }
            if ((expressionId == 148)) {
                return new Ejercicio_TypedDataContext11_ForReadOnly(locationReferences).@__Expr148GetTree();
            }
            if ((expressionId == 149)) {
                return new Ejercicio_TypedDataContext11_ForReadOnly(locationReferences).@__Expr149GetTree();
            }
            if ((expressionId == 150)) {
                return new Ejercicio_TypedDataContext11_ForReadOnly(locationReferences).@__Expr150GetTree();
            }
            if ((expressionId == 151)) {
                return new Ejercicio_TypedDataContext11_ForReadOnly(locationReferences).@__Expr151GetTree();
            }
            if ((expressionId == 152)) {
                return new Ejercicio_TypedDataContext11(locationReferences).@__Expr152GetTree();
            }
            if ((expressionId == 153)) {
                return new Ejercicio_TypedDataContext11_ForReadOnly(locationReferences).@__Expr153GetTree();
            }
            if ((expressionId == 154)) {
                return new Ejercicio_TypedDataContext11_ForReadOnly(locationReferences).@__Expr154GetTree();
            }
            if ((expressionId == 155)) {
                return new Ejercicio_TypedDataContext11(locationReferences).@__Expr155GetTree();
            }
            if ((expressionId == 156)) {
                return new Ejercicio_TypedDataContext11_ForReadOnly(locationReferences).@__Expr156GetTree();
            }
            if ((expressionId == 157)) {
                return new Ejercicio_TypedDataContext11(locationReferences).@__Expr157GetTree();
            }
            if ((expressionId == 158)) {
                return new Ejercicio_TypedDataContext11_ForReadOnly(locationReferences).@__Expr158GetTree();
            }
            if ((expressionId == 159)) {
                return new Ejercicio_TypedDataContext11_ForReadOnly(locationReferences).@__Expr159GetTree();
            }
            if ((expressionId == 160)) {
                return new Ejercicio_TypedDataContext11_ForReadOnly(locationReferences).@__Expr160GetTree();
            }
            if ((expressionId == 161)) {
                return new Ejercicio_TypedDataContext12_ForReadOnly(locationReferences).@__Expr161GetTree();
            }
            if ((expressionId == 162)) {
                return new Ejercicio_TypedDataContext12(locationReferences).@__Expr162GetTree();
            }
            if ((expressionId == 163)) {
                return new Ejercicio_TypedDataContext12(locationReferences).@__Expr163GetTree();
            }
            if ((expressionId == 164)) {
                return new Ejercicio_TypedDataContext12_ForReadOnly(locationReferences).@__Expr164GetTree();
            }
            if ((expressionId == 165)) {
                return new Ejercicio_TypedDataContext12_ForReadOnly(locationReferences).@__Expr165GetTree();
            }
            if ((expressionId == 166)) {
                return new Ejercicio_TypedDataContext12(locationReferences).@__Expr166GetTree();
            }
            if ((expressionId == 167)) {
                return new Ejercicio_TypedDataContext12_ForReadOnly(locationReferences).@__Expr167GetTree();
            }
            if ((expressionId == 168)) {
                return new Ejercicio_TypedDataContext12_ForReadOnly(locationReferences).@__Expr168GetTree();
            }
            if ((expressionId == 169)) {
                return new Ejercicio_TypedDataContext12_ForReadOnly(locationReferences).@__Expr169GetTree();
            }
            if ((expressionId == 170)) {
                return new Ejercicio_TypedDataContext12(locationReferences).@__Expr170GetTree();
            }
            if ((expressionId == 171)) {
                return new Ejercicio_TypedDataContext12_ForReadOnly(locationReferences).@__Expr171GetTree();
            }
            if ((expressionId == 172)) {
                return new Ejercicio_TypedDataContext12_ForReadOnly(locationReferences).@__Expr172GetTree();
            }
            if ((expressionId == 173)) {
                return new Ejercicio_TypedDataContext12_ForReadOnly(locationReferences).@__Expr173GetTree();
            }
            if ((expressionId == 174)) {
                return new Ejercicio_TypedDataContext12_ForReadOnly(locationReferences).@__Expr174GetTree();
            }
            if ((expressionId == 175)) {
                return new Ejercicio_TypedDataContext12_ForReadOnly(locationReferences).@__Expr175GetTree();
            }
            if ((expressionId == 176)) {
                return new Ejercicio_TypedDataContext13_ForReadOnly(locationReferences).@__Expr176GetTree();
            }
            if ((expressionId == 177)) {
                return new Ejercicio_TypedDataContext13(locationReferences).@__Expr177GetTree();
            }
            if ((expressionId == 178)) {
                return new Ejercicio_TypedDataContext13_ForReadOnly(locationReferences).@__Expr178GetTree();
            }
            if ((expressionId == 179)) {
                return new Ejercicio_TypedDataContext13_ForReadOnly(locationReferences).@__Expr179GetTree();
            }
            if ((expressionId == 180)) {
                return new Ejercicio_TypedDataContext13_ForReadOnly(locationReferences).@__Expr180GetTree();
            }
            if ((expressionId == 181)) {
                return new Ejercicio_TypedDataContext13_ForReadOnly(locationReferences).@__Expr181GetTree();
            }
            if ((expressionId == 182)) {
                return new Ejercicio_TypedDataContext14(locationReferences).@__Expr182GetTree();
            }
            if ((expressionId == 183)) {
                return new Ejercicio_TypedDataContext14_ForReadOnly(locationReferences).@__Expr183GetTree();
            }
            if ((expressionId == 184)) {
                return new Ejercicio_TypedDataContext14_ForReadOnly(locationReferences).@__Expr184GetTree();
            }
            if ((expressionId == 185)) {
                return new Ejercicio_TypedDataContext14(locationReferences).@__Expr185GetTree();
            }
            if ((expressionId == 186)) {
                return new Ejercicio_TypedDataContext14_ForReadOnly(locationReferences).@__Expr186GetTree();
            }
            if ((expressionId == 187)) {
                return new Ejercicio_TypedDataContext14_ForReadOnly(locationReferences).@__Expr187GetTree();
            }
            if ((expressionId == 188)) {
                return new Ejercicio_TypedDataContext14_ForReadOnly(locationReferences).@__Expr188GetTree();
            }
            if ((expressionId == 189)) {
                return new Ejercicio_TypedDataContext14_ForReadOnly(locationReferences).@__Expr189GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Ejercicio_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Ejercicio_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class Ejercicio_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Ejercicio_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class Ejercicio_TypedDataContext1 : Ejercicio_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int Separacion;
            
            protected int Evaluar;
            
            protected int Radio;
            
            public Ejercicio_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
            
            protected string[] Lateral {
                get {
                    return ((string[])(this.GetVariableValue((4 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((4 + locationsOffset), value);
                }
            }
            
            protected int[] AparecePar {
                get {
                    return ((int[])(this.GetVariableValue((7 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((7 + locationsOffset), value);
                }
            }
            
            protected string[] Color {
                get {
                    return ((string[])(this.GetVariableValue((8 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((8 + locationsOffset), value);
                }
            }
            
            protected System.Collections.Generic.List<string> Recorrido {
                get {
                    return ((System.Collections.Generic.List<string>)(this.GetVariableValue((10 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((10 + locationsOffset), value);
                }
            }
            
            protected System.Collections.Generic.List<string> Reporte {
                get {
                    return ((System.Collections.Generic.List<string>)(this.GetVariableValue((11 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((11 + locationsOffset), value);
                }
            }
            
            protected int[] Escenario {
                get {
                    return ((int[])(this.GetVariableValue((12 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((12 + locationsOffset), value);
                }
            }
            
            protected int[] Angulo {
                get {
                    return ((int[])(this.GetVariableValue((13 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((13 + locationsOffset), value);
                }
            }
            
            protected string Sujeto {
                get {
                    return ((string)(this.GetVariableValue((14 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((14 + locationsOffset), value);
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
                this.Separacion = ((int)(this.GetVariableValue((5 + locationsOffset))));
                this.Evaluar = ((int)(this.GetVariableValue((6 + locationsOffset))));
                this.Radio = ((int)(this.GetVariableValue((9 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((5 + locationsOffset), this.Separacion);
                this.SetVariableValue((6 + locationsOffset), this.Evaluar);
                this.SetVariableValue((9 + locationsOffset), this.Radio);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 15))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 15);
                }
                expectedLocationsCount = 15;
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
                if (((locationReferences[(offset + 4)].Name != "Lateral") 
                            || (locationReferences[(offset + 4)].Type != typeof(string[])))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "AparecePar") 
                            || (locationReferences[(offset + 7)].Type != typeof(int[])))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "Color") 
                            || (locationReferences[(offset + 8)].Type != typeof(string[])))) {
                    return false;
                }
                if (((locationReferences[(offset + 10)].Name != "Recorrido") 
                            || (locationReferences[(offset + 10)].Type != typeof(System.Collections.Generic.List<string>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 11)].Name != "Reporte") 
                            || (locationReferences[(offset + 11)].Type != typeof(System.Collections.Generic.List<string>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 12)].Name != "Escenario") 
                            || (locationReferences[(offset + 12)].Type != typeof(int[])))) {
                    return false;
                }
                if (((locationReferences[(offset + 13)].Name != "Angulo") 
                            || (locationReferences[(offset + 13)].Type != typeof(int[])))) {
                    return false;
                }
                if (((locationReferences[(offset + 14)].Name != "Sujeto") 
                            || (locationReferences[(offset + 14)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "Separacion") 
                            || (locationReferences[(offset + 5)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "Evaluar") 
                            || (locationReferences[(offset + 6)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "Radio") 
                            || (locationReferences[(offset + 9)].Type != typeof(int)))) {
                    return false;
                }
                return Ejercicio_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Ejercicio_TypedDataContext1_ForReadOnly : Ejercicio_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int Separacion;
            
            protected int Evaluar;
            
            protected int Radio;
            
            public Ejercicio_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
            
            protected string[] Lateral {
                get {
                    return ((string[])(this.GetVariableValue((4 + locationsOffset))));
                }
            }
            
            protected int[] AparecePar {
                get {
                    return ((int[])(this.GetVariableValue((7 + locationsOffset))));
                }
            }
            
            protected string[] Color {
                get {
                    return ((string[])(this.GetVariableValue((8 + locationsOffset))));
                }
            }
            
            protected System.Collections.Generic.List<string> Recorrido {
                get {
                    return ((System.Collections.Generic.List<string>)(this.GetVariableValue((10 + locationsOffset))));
                }
            }
            
            protected System.Collections.Generic.List<string> Reporte {
                get {
                    return ((System.Collections.Generic.List<string>)(this.GetVariableValue((11 + locationsOffset))));
                }
            }
            
            protected int[] Escenario {
                get {
                    return ((int[])(this.GetVariableValue((12 + locationsOffset))));
                }
            }
            
            protected int[] Angulo {
                get {
                    return ((int[])(this.GetVariableValue((13 + locationsOffset))));
                }
            }
            
            protected string Sujeto {
                get {
                    return ((string)(this.GetVariableValue((14 + locationsOffset))));
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
                this.Separacion = ((int)(this.GetVariableValue((5 + locationsOffset))));
                this.Evaluar = ((int)(this.GetVariableValue((6 + locationsOffset))));
                this.Radio = ((int)(this.GetVariableValue((9 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 15))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 15);
                }
                expectedLocationsCount = 15;
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
                if (((locationReferences[(offset + 4)].Name != "Lateral") 
                            || (locationReferences[(offset + 4)].Type != typeof(string[])))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "AparecePar") 
                            || (locationReferences[(offset + 7)].Type != typeof(int[])))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "Color") 
                            || (locationReferences[(offset + 8)].Type != typeof(string[])))) {
                    return false;
                }
                if (((locationReferences[(offset + 10)].Name != "Recorrido") 
                            || (locationReferences[(offset + 10)].Type != typeof(System.Collections.Generic.List<string>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 11)].Name != "Reporte") 
                            || (locationReferences[(offset + 11)].Type != typeof(System.Collections.Generic.List<string>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 12)].Name != "Escenario") 
                            || (locationReferences[(offset + 12)].Type != typeof(int[])))) {
                    return false;
                }
                if (((locationReferences[(offset + 13)].Name != "Angulo") 
                            || (locationReferences[(offset + 13)].Type != typeof(int[])))) {
                    return false;
                }
                if (((locationReferences[(offset + 14)].Name != "Sujeto") 
                            || (locationReferences[(offset + 14)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "Separacion") 
                            || (locationReferences[(offset + 5)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "Evaluar") 
                            || (locationReferences[(offset + 6)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "Radio") 
                            || (locationReferences[(offset + 9)].Type != typeof(int)))) {
                    return false;
                }
                return Ejercicio_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Ejercicio_TypedDataContext2 : Ejercicio_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int IRecoleccion;
            
            protected int Iteracion;
            
            protected int MaxIteracion;
            
            protected System.Drawing.PointF Coordenadas;
            
            protected int idIzquierda;
            
            protected int idDerecha;
            
            protected int Cercania;
            
            protected System.Drawing.PointF Cruz;
            
            protected int Cursor;
            
            public Ejercicio_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string RtaCave {
                get {
                    return ((string)(this.GetVariableValue((18 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((18 + locationsOffset), value);
                }
            }
            
            protected int[] ParBanderasVisible {
                get {
                    return ((int[])(this.GetVariableValue((20 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((20 + locationsOffset), value);
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
                this.IRecoleccion = ((int)(this.GetVariableValue((15 + locationsOffset))));
                this.Iteracion = ((int)(this.GetVariableValue((16 + locationsOffset))));
                this.MaxIteracion = ((int)(this.GetVariableValue((17 + locationsOffset))));
                this.Coordenadas = ((System.Drawing.PointF)(this.GetVariableValue((19 + locationsOffset))));
                this.idIzquierda = ((int)(this.GetVariableValue((21 + locationsOffset))));
                this.idDerecha = ((int)(this.GetVariableValue((22 + locationsOffset))));
                this.Cercania = ((int)(this.GetVariableValue((23 + locationsOffset))));
                this.Cruz = ((System.Drawing.PointF)(this.GetVariableValue((24 + locationsOffset))));
                this.Cursor = ((int)(this.GetVariableValue((25 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((15 + locationsOffset), this.IRecoleccion);
                this.SetVariableValue((16 + locationsOffset), this.Iteracion);
                this.SetVariableValue((17 + locationsOffset), this.MaxIteracion);
                this.SetVariableValue((19 + locationsOffset), this.Coordenadas);
                this.SetVariableValue((21 + locationsOffset), this.idIzquierda);
                this.SetVariableValue((22 + locationsOffset), this.idDerecha);
                this.SetVariableValue((23 + locationsOffset), this.Cercania);
                this.SetVariableValue((24 + locationsOffset), this.Cruz);
                this.SetVariableValue((25 + locationsOffset), this.Cursor);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 26))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 26);
                }
                expectedLocationsCount = 26;
                if (((locationReferences[(offset + 18)].Name != "RtaCave") 
                            || (locationReferences[(offset + 18)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 20)].Name != "ParBanderasVisible") 
                            || (locationReferences[(offset + 20)].Type != typeof(int[])))) {
                    return false;
                }
                if (((locationReferences[(offset + 15)].Name != "IRecoleccion") 
                            || (locationReferences[(offset + 15)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 16)].Name != "Iteracion") 
                            || (locationReferences[(offset + 16)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 17)].Name != "MaxIteracion") 
                            || (locationReferences[(offset + 17)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 19)].Name != "Coordenadas") 
                            || (locationReferences[(offset + 19)].Type != typeof(System.Drawing.PointF)))) {
                    return false;
                }
                if (((locationReferences[(offset + 21)].Name != "idIzquierda") 
                            || (locationReferences[(offset + 21)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 22)].Name != "idDerecha") 
                            || (locationReferences[(offset + 22)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 23)].Name != "Cercania") 
                            || (locationReferences[(offset + 23)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 24)].Name != "Cruz") 
                            || (locationReferences[(offset + 24)].Type != typeof(System.Drawing.PointF)))) {
                    return false;
                }
                if (((locationReferences[(offset + 25)].Name != "Cursor") 
                            || (locationReferences[(offset + 25)].Type != typeof(int)))) {
                    return false;
                }
                return Ejercicio_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Ejercicio_TypedDataContext2_ForReadOnly : Ejercicio_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int IRecoleccion;
            
            protected int Iteracion;
            
            protected int MaxIteracion;
            
            protected System.Drawing.PointF Coordenadas;
            
            protected int idIzquierda;
            
            protected int idDerecha;
            
            protected int Cercania;
            
            protected System.Drawing.PointF Cruz;
            
            protected int Cursor;
            
            public Ejercicio_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string RtaCave {
                get {
                    return ((string)(this.GetVariableValue((18 + locationsOffset))));
                }
            }
            
            protected int[] ParBanderasVisible {
                get {
                    return ((int[])(this.GetVariableValue((20 + locationsOffset))));
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
                this.IRecoleccion = ((int)(this.GetVariableValue((15 + locationsOffset))));
                this.Iteracion = ((int)(this.GetVariableValue((16 + locationsOffset))));
                this.MaxIteracion = ((int)(this.GetVariableValue((17 + locationsOffset))));
                this.Coordenadas = ((System.Drawing.PointF)(this.GetVariableValue((19 + locationsOffset))));
                this.idIzquierda = ((int)(this.GetVariableValue((21 + locationsOffset))));
                this.idDerecha = ((int)(this.GetVariableValue((22 + locationsOffset))));
                this.Cercania = ((int)(this.GetVariableValue((23 + locationsOffset))));
                this.Cruz = ((System.Drawing.PointF)(this.GetVariableValue((24 + locationsOffset))));
                this.Cursor = ((int)(this.GetVariableValue((25 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 26))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 26);
                }
                expectedLocationsCount = 26;
                if (((locationReferences[(offset + 18)].Name != "RtaCave") 
                            || (locationReferences[(offset + 18)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 20)].Name != "ParBanderasVisible") 
                            || (locationReferences[(offset + 20)].Type != typeof(int[])))) {
                    return false;
                }
                if (((locationReferences[(offset + 15)].Name != "IRecoleccion") 
                            || (locationReferences[(offset + 15)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 16)].Name != "Iteracion") 
                            || (locationReferences[(offset + 16)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 17)].Name != "MaxIteracion") 
                            || (locationReferences[(offset + 17)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 19)].Name != "Coordenadas") 
                            || (locationReferences[(offset + 19)].Type != typeof(System.Drawing.PointF)))) {
                    return false;
                }
                if (((locationReferences[(offset + 21)].Name != "idIzquierda") 
                            || (locationReferences[(offset + 21)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 22)].Name != "idDerecha") 
                            || (locationReferences[(offset + 22)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 23)].Name != "Cercania") 
                            || (locationReferences[(offset + 23)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 24)].Name != "Cruz") 
                            || (locationReferences[(offset + 24)].Type != typeof(System.Drawing.PointF)))) {
                    return false;
                }
                if (((locationReferences[(offset + 25)].Name != "Cursor") 
                            || (locationReferences[(offset + 25)].Type != typeof(int)))) {
                    return false;
                }
                return Ejercicio_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Ejercicio_TypedDataContext3 : Ejercicio_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Ejercicio_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext3(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                
                #line 71 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<string>>> expression = () => 
                    Reporte;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<string> @__Expr1Get() {
                
                #line 71 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
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
                
                #line 71 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                
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
                
                #line 83 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<string>>> expression = () => 
                    Recorrido;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<string> @__Expr3Get() {
                
                #line 83 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
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
                
                #line 83 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                
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
                
                #line 97 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                    IRecoleccion;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr4Get() {
                
                #line 97 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                    IRecoleccion;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr4Set(int value) {
                
                #line 97 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                
                    IRecoleccion = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr4Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr4Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 107 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                    Iteracion;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr5Get() {
                
                #line 107 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                    Iteracion;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr5Set(int value) {
                
                #line 107 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                
                    Iteracion = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr5Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr5Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 117 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                    MaxIteracion;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr7Get() {
                
                #line 117 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                    MaxIteracion;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr7Set(int value) {
                
                #line 117 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                
                    MaxIteracion = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr7Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr7Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 129 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                    Cercania;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr8Get() {
                
                #line 129 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                    Cercania;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr8Set(int value) {
                
                #line 129 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                
                    Cercania = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr8Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr8Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 139 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                    Cruz;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr10Get() {
                
                #line 139 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
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
                
                #line 139 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                
                    Cruz = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr10Set(System.Drawing.PointF value) {
                this.GetValueTypeValues();
                this.@__Expr10Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr17GetTree() {
                
                #line 192 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                      RtaCave;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr17Get() {
                
                #line 192 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
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
                
                #line 192 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                
                      RtaCave = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr17Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr17Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr20GetTree() {
                
                #line 206 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                          Coordenadas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr20Get() {
                
                #line 206 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                          Coordenadas;
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr20Get() {
                this.GetValueTypeValues();
                return this.@__Expr20Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr20Set(System.Drawing.PointF value) {
                
                #line 206 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                
                          Coordenadas = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr20Set(System.Drawing.PointF value) {
                this.GetValueTypeValues();
                this.@__Expr20Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 26))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 26);
                }
                expectedLocationsCount = 26;
                return Ejercicio_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Ejercicio_TypedDataContext3_ForReadOnly : Ejercicio_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Ejercicio_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                
                #line 76 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<string>>> expression = () => 
                    new List<string>();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<string> @__Expr0Get() {
                
                #line 76 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                    new List<string>();
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<string> ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 88 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<string>>> expression = () => 
                    new List<string>();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<string> @__Expr2Get() {
                
                #line 88 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                    new List<string>();
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<string> ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 122 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                    Angulo.Length;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr6Get() {
                
                #line 122 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                    Angulo.Length;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 144 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                    new PointF(0,0);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr9Get() {
                
                #line 144 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                    new PointF(0,0);
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 160 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                Reporte;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr11Get() {
                
                #line 160 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                Reporte;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 156 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                  "Sujeto;"+Sujeto;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr12Get() {
                
                #line 156 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                  "Sujeto;"+Sujeto;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 170 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                Reporte;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr13Get() {
                
                #line 170 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                Reporte;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 166 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                  "Radio;"+Radio.ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr14Get() {
                
                #line 166 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                  "Radio;"+Radio.ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr15GetTree() {
                
                #line 180 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                Reporte;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr15Get() {
                
                #line 180 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                Reporte;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr15Get() {
                this.GetValueTypeValues();
                return this.@__Expr15Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr16GetTree() {
                
                #line 176 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                  "Hora Inicio;"+DateTime.Now.ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr16Get() {
                
                #line 176 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                  "Hora Inicio;"+DateTime.Now.ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr16Get() {
                this.GetValueTypeValues();
                return this.@__Expr16Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr18GetTree() {
                
                #line 199 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      RtaCave.Split(';').Length>1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr18Get() {
                
                #line 199 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                      RtaCave.Split(';').Length>1;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr18Get() {
                this.GetValueTypeValues();
                return this.@__Expr18Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr19GetTree() {
                
                #line 211 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                          new PointF(Single.Parse(RtaCave.Split(';')[0].Replace(".", ",")), Single.Parse(RtaCave.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr19Get() {
                
                #line 211 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                          new PointF(Single.Parse(RtaCave.Split(';')[0].Replace(".", ",")), Single.Parse(RtaCave.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr19Get() {
                this.GetValueTypeValues();
                return this.@__Expr19Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr21GetTree() {
                
                #line 1453 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                  Agregar180;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr21Get() {
                
                #line 1453 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                  Agregar180;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr21Get() {
                this.GetValueTypeValues();
                return this.@__Expr21Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 26))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 26);
                }
                expectedLocationsCount = 26;
                return Ejercicio_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Ejercicio_TypedDataContext4 : Ejercicio_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Ejercicio_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext4(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr27GetTree() {
                
                #line 255 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                            idIzquierda;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr27Get() {
                
                #line 255 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                            idIzquierda;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr27Get() {
                this.GetValueTypeValues();
                return this.@__Expr27Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr27Set(int value) {
                
                #line 255 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                
                            idIzquierda = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr27Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr27Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr29GetTree() {
                
                #line 267 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                            idDerecha;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr29Get() {
                
                #line 267 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                            idDerecha;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr29Get() {
                this.GetValueTypeValues();
                return this.@__Expr29Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr29Set(int value) {
                
                #line 267 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                
                            idDerecha = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr29Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr29Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr76GetTree() {
                
                #line 541 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                              RtaCave;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr76Get() {
                
                #line 541 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                              RtaCave;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr76Get() {
                this.GetValueTypeValues();
                return this.@__Expr76Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr76Set(string value) {
                
                #line 541 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                
                              RtaCave = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr76Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr76Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr79GetTree() {
                
                #line 555 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                                  Coordenadas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr79Get() {
                
                #line 555 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                  Coordenadas;
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr79Get() {
                this.GetValueTypeValues();
                return this.@__Expr79Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr79Set(System.Drawing.PointF value) {
                
                #line 555 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                
                                  Coordenadas = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr79Set(System.Drawing.PointF value) {
                this.GetValueTypeValues();
                this.@__Expr79Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr84GetTree() {
                
                #line 1368 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<int[]>> expression = () => 
                                      ParBanderasVisible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int[] @__Expr84Get() {
                
                #line 1368 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                      ParBanderasVisible;
                
                #line default
                #line hidden
            }
            
            public int[] ValueType___Expr84Get() {
                this.GetValueTypeValues();
                return this.@__Expr84Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr84Set(int[] value) {
                
                #line 1368 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                
                                      ParBanderasVisible = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr84Set(int[] value) {
                this.GetValueTypeValues();
                this.@__Expr84Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr85GetTree() {
                
                #line 1380 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                      ParBanderasVisible[0];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr85Get() {
                
                #line 1380 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                      ParBanderasVisible[0];
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr85Get() {
                this.GetValueTypeValues();
                return this.@__Expr85Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr85Set(int value) {
                
                #line 1380 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                
                                      ParBanderasVisible[0] = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr85Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr85Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr86GetTree() {
                
                #line 1390 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                      ParBanderasVisible[1];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr86Get() {
                
                #line 1390 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                      ParBanderasVisible[1];
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr86Get() {
                this.GetValueTypeValues();
                return this.@__Expr86Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr86Set(int value) {
                
                #line 1390 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                
                                      ParBanderasVisible[1] = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr86Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr86Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr89GetTree() {
                
                #line 1411 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<int[]>> expression = () => 
                                      ParBanderasVisible;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int[] @__Expr89Get() {
                
                #line 1411 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                      ParBanderasVisible;
                
                #line default
                #line hidden
            }
            
            public int[] ValueType___Expr89Get() {
                this.GetValueTypeValues();
                return this.@__Expr89Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr89Set(int[] value) {
                
                #line 1411 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                
                                      ParBanderasVisible = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr89Set(int[] value) {
                this.GetValueTypeValues();
                this.@__Expr89Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr90GetTree() {
                
                #line 1423 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                      ParBanderasVisible[0];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr90Get() {
                
                #line 1423 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                      ParBanderasVisible[0];
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr90Get() {
                this.GetValueTypeValues();
                return this.@__Expr90Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr90Set(int value) {
                
                #line 1423 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                
                                      ParBanderasVisible[0] = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr90Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr90Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr91GetTree() {
                
                #line 1433 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                      ParBanderasVisible[1];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr91Get() {
                
                #line 1433 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                      ParBanderasVisible[1];
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr91Get() {
                this.GetValueTypeValues();
                return this.@__Expr91Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr91Set(int value) {
                
                #line 1433 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                
                                      ParBanderasVisible[1] = value;
                
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
                            && (locationReferences.Count < 26))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 26);
                }
                expectedLocationsCount = 26;
                return Ejercicio_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Ejercicio_TypedDataContext4_ForReadOnly : Ejercicio_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Ejercicio_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                
                #line 227 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                            Escenario[Iteracion].Equals(0);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr22Get() {
                
                #line 227 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                            Escenario[Iteracion].Equals(0);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr22Get() {
                this.GetValueTypeValues();
                return this.@__Expr22Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr23GetTree() {
                
                #line 233 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                              "L{ \"id\":\"null\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr23Get() {
                
                #line 233 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                              "L{ \"id\":\"null\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr23Get() {
                this.GetValueTypeValues();
                return this.@__Expr23Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr24GetTree() {
                
                #line 240 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                              "L{ \"id\":\""+Escenario[Iteracion]+"\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr24Get() {
                
                #line 240 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                              "L{ \"id\":\""+Escenario[Iteracion]+"\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr24Get() {
                this.GetValueTypeValues();
                return this.@__Expr24Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr25GetTree() {
                
                #line 247 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.TimeSpan>> expression = () => 
                          TimeSpan.FromSeconds(1);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.TimeSpan @__Expr25Get() {
                
                #line 247 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                          TimeSpan.FromSeconds(1);
                
                #line default
                #line hidden
            }
            
            public System.TimeSpan ValueType___Expr25Get() {
                this.GetValueTypeValues();
                return this.@__Expr25Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr26GetTree() {
                
                #line 260 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                            (new Random()).Next(0,BanderasCircunferencia.Count-1);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr26Get() {
                
                #line 260 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                            (new Random()).Next(0,BanderasCircunferencia.Count-1);
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr26Get() {
                this.GetValueTypeValues();
                return this.@__Expr26Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr28GetTree() {
                
                #line 272 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                            (idIzquierda+(Angulo[Iteracion]/Separacion))%BanderasCircunferencia.Count;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr28Get() {
                
                #line 272 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                            (idIzquierda+(Angulo[Iteracion]/Separacion))%BanderasCircunferencia.Count;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr28Get() {
                this.GetValueTypeValues();
                return this.@__Expr28Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr30GetTree() {
                
                #line 284 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                            Reporte;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr30Get() {
                
                #line 284 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                            Reporte;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr30Get() {
                this.GetValueTypeValues();
                return this.@__Expr30Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr31GetTree() {
                
                #line 280 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                              "NroIteracion;"+Iteracion;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr31Get() {
                
                #line 280 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                              "NroIteracion;"+Iteracion;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr31Get() {
                this.GetValueTypeValues();
                return this.@__Expr31Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr32GetTree() {
                
                #line 294 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                            Reporte;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr32Get() {
                
                #line 294 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                            Reporte;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr32Get() {
                this.GetValueTypeValues();
                return this.@__Expr32Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr33GetTree() {
                
                #line 290 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                              "Angulo;"+Angulo[Iteracion];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr33Get() {
                
                #line 290 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                              "Angulo;"+Angulo[Iteracion];
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr33Get() {
                this.GetValueTypeValues();
                return this.@__Expr33Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr34GetTree() {
                
                #line 304 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                            Reporte;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr34Get() {
                
                #line 304 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
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
                
                #line 300 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                              "A Seleccionar;"+Lateral[Iteracion];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr35Get() {
                
                #line 300 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                              "A Seleccionar;"+Lateral[Iteracion];
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr35Get() {
                this.GetValueTypeValues();
                return this.@__Expr35Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr36GetTree() {
                
                #line 314 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                            Reporte;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr36Get() {
                
                #line 314 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                            Reporte;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr36Get() {
                this.GetValueTypeValues();
                return this.@__Expr36Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr37GetTree() {
                
                #line 310 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                              "Protocolo;"+Protocolo[Iteracion];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr37Get() {
                
                #line 310 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                              "Protocolo;"+Protocolo[Iteracion];
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr37Get() {
                this.GetValueTypeValues();
                return this.@__Expr37Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr38GetTree() {
                
                #line 324 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                            Reporte;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr38Get() {
                
                #line 324 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                            Reporte;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr38Get() {
                this.GetValueTypeValues();
                return this.@__Expr38Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr39GetTree() {
                
                #line 320 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                              "Escenario;"+Escenario[Iteracion];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr39Get() {
                
                #line 320 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                              "Escenario;"+Escenario[Iteracion];
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr39Get() {
                this.GetValueTypeValues();
                return this.@__Expr39Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr40GetTree() {
                
                #line 334 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                            Reporte;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr40Get() {
                
                #line 334 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                            Reporte;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr40Get() {
                this.GetValueTypeValues();
                return this.@__Expr40Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr41GetTree() {
                
                #line 330 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                              "AparecerDeAUna;" + AparecePar[Iteracion];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr41Get() {
                
                #line 330 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                              "AparecerDeAUna;" + AparecePar[Iteracion];
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr41Get() {
                this.GetValueTypeValues();
                return this.@__Expr41Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr42GetTree() {
                
                #line 344 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                            Reporte;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr42Get() {
                
                #line 344 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                            Reporte;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr42Get() {
                this.GetValueTypeValues();
                return this.@__Expr42Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr43GetTree() {
                
                #line 340 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                              "IdIzquierda;"+idIzquierda;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr43Get() {
                
                #line 340 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                              "IdIzquierda;"+idIzquierda;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr43Get() {
                this.GetValueTypeValues();
                return this.@__Expr43Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr44GetTree() {
                
                #line 354 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                            Reporte;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr44Get() {
                
                #line 354 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                            Reporte;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr44Get() {
                this.GetValueTypeValues();
                return this.@__Expr44Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr45GetTree() {
                
                #line 350 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                              "IzquierdaX;" + BanderasCircunferencia.ElementAt(idIzquierda).X;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr45Get() {
                
                #line 350 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                              "IzquierdaX;" + BanderasCircunferencia.ElementAt(idIzquierda).X;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr45Get() {
                this.GetValueTypeValues();
                return this.@__Expr45Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr46GetTree() {
                
                #line 364 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                            Reporte;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr46Get() {
                
                #line 364 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                            Reporte;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr46Get() {
                this.GetValueTypeValues();
                return this.@__Expr46Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr47GetTree() {
                
                #line 360 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                              "IzquierdaY;" + BanderasCircunferencia.ElementAt(idIzquierda).Y;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr47Get() {
                
                #line 360 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                              "IzquierdaY;" + BanderasCircunferencia.ElementAt(idIzquierda).Y;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr47Get() {
                this.GetValueTypeValues();
                return this.@__Expr47Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr48GetTree() {
                
                #line 374 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                            Reporte;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr48Get() {
                
                #line 374 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                            Reporte;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr48Get() {
                this.GetValueTypeValues();
                return this.@__Expr48Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr49GetTree() {
                
                #line 370 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                              "IdDerecha;"+idDerecha;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr49Get() {
                
                #line 370 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                              "IdDerecha;"+idDerecha;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr49Get() {
                this.GetValueTypeValues();
                return this.@__Expr49Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr50GetTree() {
                
                #line 384 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                            Reporte;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr50Get() {
                
                #line 384 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                            Reporte;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr50Get() {
                this.GetValueTypeValues();
                return this.@__Expr50Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr51GetTree() {
                
                #line 380 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                              "DerechaX;" + BanderasCircunferencia.ElementAt(idDerecha).X;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr51Get() {
                
                #line 380 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                              "DerechaX;" + BanderasCircunferencia.ElementAt(idDerecha).X;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr51Get() {
                this.GetValueTypeValues();
                return this.@__Expr51Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr52GetTree() {
                
                #line 394 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                            Reporte;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr52Get() {
                
                #line 394 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                            Reporte;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr52Get() {
                this.GetValueTypeValues();
                return this.@__Expr52Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr53GetTree() {
                
                #line 390 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                              "DerechaY;" + BanderasCircunferencia.ElementAt(idDerecha).Y;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr53Get() {
                
                #line 390 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                              "DerechaY;" + BanderasCircunferencia.ElementAt(idDerecha).Y;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr53Get() {
                this.GetValueTypeValues();
                return this.@__Expr53Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr54GetTree() {
                
                #line 401 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                            Lateral[Iteracion].Equals("I");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr54Get() {
                
                #line 401 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                            Lateral[Iteracion].Equals("I");
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr54Get() {
                this.GetValueTypeValues();
                return this.@__Expr54Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr55GetTree() {
                
                #line 413 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                                Reporte;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr55Get() {
                
                #line 413 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                Reporte;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr55Get() {
                this.GetValueTypeValues();
                return this.@__Expr55Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr56GetTree() {
                
                #line 409 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  "IdCorrecta;"+idIzquierda;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr56Get() {
                
                #line 409 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                  "IdCorrecta;"+idIzquierda;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr56Get() {
                this.GetValueTypeValues();
                return this.@__Expr56Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr57GetTree() {
                
                #line 423 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                                Reporte;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr57Get() {
                
                #line 423 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                Reporte;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr57Get() {
                this.GetValueTypeValues();
                return this.@__Expr57Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr58GetTree() {
                
                #line 419 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  "CorrectaX;" + BanderasCircunferencia.ElementAt(idIzquierda).X;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr58Get() {
                
                #line 419 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                  "CorrectaX;" + BanderasCircunferencia.ElementAt(idIzquierda).X;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr58Get() {
                this.GetValueTypeValues();
                return this.@__Expr58Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr59GetTree() {
                
                #line 433 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                                Reporte;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr59Get() {
                
                #line 433 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                Reporte;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr59Get() {
                this.GetValueTypeValues();
                return this.@__Expr59Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr60GetTree() {
                
                #line 429 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  "CorrectaY;" + BanderasCircunferencia.ElementAt(idIzquierda).Y;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr60Get() {
                
                #line 429 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                  "CorrectaY;" + BanderasCircunferencia.ElementAt(idIzquierda).Y;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr60Get() {
                this.GetValueTypeValues();
                return this.@__Expr60Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr61GetTree() {
                
                #line 442 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                Lateral[Iteracion].Equals("D");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr61Get() {
                
                #line 442 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                Lateral[Iteracion].Equals("D");
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr61Get() {
                this.GetValueTypeValues();
                return this.@__Expr61Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr62GetTree() {
                
                #line 454 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                                    Reporte;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr62Get() {
                
                #line 454 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                    Reporte;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr62Get() {
                this.GetValueTypeValues();
                return this.@__Expr62Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr63GetTree() {
                
                #line 450 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                      "IdCorrecta;"+idDerecha;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr63Get() {
                
                #line 450 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                      "IdCorrecta;"+idDerecha;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr63Get() {
                this.GetValueTypeValues();
                return this.@__Expr63Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr64GetTree() {
                
                #line 464 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                                    Reporte;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr64Get() {
                
                #line 464 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                    Reporte;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr64Get() {
                this.GetValueTypeValues();
                return this.@__Expr64Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr65GetTree() {
                
                #line 460 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                      "CorrectaX;" + BanderasCircunferencia.ElementAt(idDerecha).X;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr65Get() {
                
                #line 460 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                      "CorrectaX;" + BanderasCircunferencia.ElementAt(idDerecha).X;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr65Get() {
                this.GetValueTypeValues();
                return this.@__Expr65Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr66GetTree() {
                
                #line 474 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                                    Reporte;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr66Get() {
                
                #line 474 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                    Reporte;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr66Get() {
                this.GetValueTypeValues();
                return this.@__Expr66Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr67GetTree() {
                
                #line 470 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                      "CorrectaY;" + BanderasCircunferencia.ElementAt(idDerecha).Y;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr67Get() {
                
                #line 470 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                      "CorrectaY;" + BanderasCircunferencia.ElementAt(idDerecha).Y;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr67Get() {
                this.GetValueTypeValues();
                return this.@__Expr67Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr77GetTree() {
                
                #line 548 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              RtaCave.Split(';').Length>1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr77Get() {
                
                #line 548 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                              RtaCave.Split(';').Length>1;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr77Get() {
                this.GetValueTypeValues();
                return this.@__Expr77Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr78GetTree() {
                
                #line 560 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                                  new PointF(Single.Parse(RtaCave.Split(';')[0].Replace(".", ",")), Single.Parse(RtaCave.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr78Get() {
                
                #line 560 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                  new PointF(Single.Parse(RtaCave.Split(';')[0].Replace(".", ",")), Single.Parse(RtaCave.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr78Get() {
                this.GetValueTypeValues();
                return this.@__Expr78Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr80GetTree() {
                
                #line 1349 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              AparecePar[Iteracion].Equals(1);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr80Get() {
                
                #line 1349 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                              AparecePar[Iteracion].Equals(1);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr80Get() {
                this.GetValueTypeValues();
                return this.@__Expr80Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr81GetTree() {
                
                #line 1356 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  "H{ \"id\":\"" + idIzquierda + "\", \"visible\":\"true\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr81Get() {
                
                #line 1356 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                  "H{ \"id\":\"" + idIzquierda + "\", \"visible\":\"true\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr81Get() {
                this.GetValueTypeValues();
                return this.@__Expr81Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr82GetTree() {
                
                #line 1361 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  "H{ \"id\":\"" + idDerecha + "\", \"visible\":\"true\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr82Get() {
                
                #line 1361 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                  "H{ \"id\":\"" + idDerecha + "\", \"visible\":\"true\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr82Get() {
                this.GetValueTypeValues();
                return this.@__Expr82Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr83GetTree() {
                
                #line 1373 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<int[]>> expression = () => 
                                      new int [2];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int[] @__Expr83Get() {
                
                #line 1373 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                      new int [2];
                
                #line default
                #line hidden
            }
            
            public int[] ValueType___Expr83Get() {
                this.GetValueTypeValues();
                return this.@__Expr83Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr87GetTree() {
                
                #line 1404 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  "H{ \"id\":\"" + idIzquierda + "\", \"visible\":\"true\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr87Get() {
                
                #line 1404 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                  "H{ \"id\":\"" + idIzquierda + "\", \"visible\":\"true\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr87Get() {
                this.GetValueTypeValues();
                return this.@__Expr87Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr88GetTree() {
                
                #line 1416 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<int[]>> expression = () => 
                                      new int [2];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int[] @__Expr88Get() {
                
                #line 1416 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                      new int [2];
                
                #line default
                #line hidden
            }
            
            public int[] ValueType___Expr88Get() {
                this.GetValueTypeValues();
                return this.@__Expr88Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 26))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 26);
                }
                expectedLocationsCount = 26;
                return Ejercicio_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Ejercicio_TypedDataContext5 : Ejercicio_TypedDataContext4 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int idMedio;
            
            public Ejercicio_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext5(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr69GetTree() {
                
                #line 487 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                      idMedio;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr69Get() {
                
                #line 487 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                      idMedio;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr69Get() {
                this.GetValueTypeValues();
                return this.@__Expr69Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr69Set(int value) {
                
                #line 487 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                
                                      idMedio = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr69Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr69Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.idMedio = ((int)(this.GetVariableValue((26 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((26 + locationsOffset), this.idMedio);
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
                if (((locationReferences[(offset + 26)].Name != "idMedio") 
                            || (locationReferences[(offset + 26)].Type != typeof(int)))) {
                    return false;
                }
                return Ejercicio_TypedDataContext4.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Ejercicio_TypedDataContext5_ForReadOnly : Ejercicio_TypedDataContext4_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int idMedio;
            
            public Ejercicio_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr68GetTree() {
                
                #line 492 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                      (idIzquierda + Angulo[Iteracion]/2)%BanderasCircunferencia.Count;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr68Get() {
                
                #line 492 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                      (idIzquierda + Angulo[Iteracion]/2)%BanderasCircunferencia.Count;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr68Get() {
                this.GetValueTypeValues();
                return this.@__Expr68Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr70GetTree() {
                
                #line 503 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                                    Reporte;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr70Get() {
                
                #line 503 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                    Reporte;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr70Get() {
                this.GetValueTypeValues();
                return this.@__Expr70Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr71GetTree() {
                
                #line 499 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                      "IdCorrecta;" + idMedio;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr71Get() {
                
                #line 499 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                      "IdCorrecta;" + idMedio;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr71Get() {
                this.GetValueTypeValues();
                return this.@__Expr71Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr72GetTree() {
                
                #line 513 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                                    Reporte;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr72Get() {
                
                #line 513 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                    Reporte;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr72Get() {
                this.GetValueTypeValues();
                return this.@__Expr72Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr73GetTree() {
                
                #line 509 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                      "CorrectaX;" + BanderasCircunferencia.ElementAt(idMedio).X;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr73Get() {
                
                #line 509 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                      "CorrectaX;" + BanderasCircunferencia.ElementAt(idMedio).X;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr73Get() {
                this.GetValueTypeValues();
                return this.@__Expr73Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr74GetTree() {
                
                #line 523 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                                    Reporte;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr74Get() {
                
                #line 523 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                    Reporte;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr74Get() {
                this.GetValueTypeValues();
                return this.@__Expr74Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr75GetTree() {
                
                #line 519 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                      "CorrectaY;" + BanderasCircunferencia.ElementAt(idMedio).Y;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr75Get() {
                
                #line 519 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                      "CorrectaY;" + BanderasCircunferencia.ElementAt(idMedio).Y;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr75Get() {
                this.GetValueTypeValues();
                return this.@__Expr75Get();
            }
            
            protected override void GetValueTypeValues() {
                this.idMedio = ((int)(this.GetVariableValue((26 + locationsOffset))));
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
                if (((locationReferences[(offset + 26)].Name != "idMedio") 
                            || (locationReferences[(offset + 26)].Type != typeof(int)))) {
                    return false;
                }
                return Ejercicio_TypedDataContext4_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Ejercicio_TypedDataContext6 : Ejercicio_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Ejercicio_TypedDataContext6(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext6(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext6(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr92GetTree() {
                
                #line 580 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                      RtaCave;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr92Get() {
                
                #line 580 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
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
                
                #line 580 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                
                                      RtaCave = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr92Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr92Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr95GetTree() {
                
                #line 594 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                                          Coordenadas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr95Get() {
                
                #line 594 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                          Coordenadas;
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr95Get() {
                this.GetValueTypeValues();
                return this.@__Expr95Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr95Set(System.Drawing.PointF value) {
                
                #line 594 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                
                                          Coordenadas = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr95Set(System.Drawing.PointF value) {
                this.GetValueTypeValues();
                this.@__Expr95Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr98GetTree() {
                
                #line 1241 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                      IRecoleccion;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr98Get() {
                
                #line 1241 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                      IRecoleccion;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr98Get() {
                this.GetValueTypeValues();
                return this.@__Expr98Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr98Set(int value) {
                
                #line 1241 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                
                                      IRecoleccion = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr98Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr98Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr100GetTree() {
                
                #line 1261 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                            ParBanderasVisible[0];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr100Get() {
                
                #line 1261 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                            ParBanderasVisible[0];
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr100Get() {
                this.GetValueTypeValues();
                return this.@__Expr100Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr100Set(int value) {
                
                #line 1261 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                
                                            ParBanderasVisible[0] = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr100Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr100Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr105GetTree() {
                
                #line 1300 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                ParBanderasVisible[1];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr105Get() {
                
                #line 1300 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                ParBanderasVisible[1];
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr105Get() {
                this.GetValueTypeValues();
                return this.@__Expr105Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr105Set(int value) {
                
                #line 1300 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                
                                                ParBanderasVisible[1] = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr105Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr105Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 26))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 26);
                }
                expectedLocationsCount = 26;
                return Ejercicio_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Ejercicio_TypedDataContext6_ForReadOnly : Ejercicio_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Ejercicio_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr93GetTree() {
                
                #line 587 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                      RtaCave.Split(';').Length>1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr93Get() {
                
                #line 587 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                      RtaCave.Split(';').Length>1;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr93Get() {
                this.GetValueTypeValues();
                return this.@__Expr93Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr94GetTree() {
                
                #line 599 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                                          new PointF(Single.Parse(RtaCave.Split(';')[0].Replace(".", ",")), Single.Parse(RtaCave.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr94Get() {
                
                #line 599 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                          new PointF(Single.Parse(RtaCave.Split(';')[0].Replace(".", ",")), Single.Parse(RtaCave.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr94Get() {
                this.GetValueTypeValues();
                return this.@__Expr94Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr96GetTree() {
                
                #line 1333 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              (ParBanderasVisible[0].Equals(1) && ((Math.Sqrt(Math.Pow(Coordenadas.X - BanderasCircunferencia.ElementAt(idIzquierda).X, 2) - Math.Pow(Coordenadas.Y - BanderasCircunferencia.ElementAt(idIzquierda).Y, 2))) < Cercania)) || (ParBanderasVisible[1].Equals(1) && (Math.Sqrt(Math.Pow(Coordenadas.X - BanderasCircunferencia.ElementAt(idDerecha).X, 2) + Math.Pow(Coordenadas.Y - BanderasCircunferencia.ElementAt(idDerecha).Y, 2))) < Cercania);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr96Get() {
                
                #line 1333 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                              (ParBanderasVisible[0].Equals(1) && ((Math.Sqrt(Math.Pow(Coordenadas.X - BanderasCircunferencia.ElementAt(idIzquierda).X, 2) - Math.Pow(Coordenadas.Y - BanderasCircunferencia.ElementAt(idIzquierda).Y, 2))) < Cercania)) || (ParBanderasVisible[1].Equals(1) && (Math.Sqrt(Math.Pow(Coordenadas.X - BanderasCircunferencia.ElementAt(idDerecha).X, 2) + Math.Pow(Coordenadas.Y - BanderasCircunferencia.ElementAt(idDerecha).Y, 2))) < Cercania);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr96Get() {
                this.GetValueTypeValues();
                return this.@__Expr96Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr97GetTree() {
                
                #line 1246 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                      IRecoleccion+1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr97Get() {
                
                #line 1246 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                      IRecoleccion+1;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr97Get() {
                this.GetValueTypeValues();
                return this.@__Expr97Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr99GetTree() {
                
                #line 1253 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                      (ParBanderasVisible[0].Equals(1) && ((Math.Sqrt(Math.Pow(Coordenadas.X - BanderasCircunferencia.ElementAt(idIzquierda).X, 2) + Math.Pow(Coordenadas.Y - BanderasCircunferencia.ElementAt(idIzquierda).Y, 2))) < Cercania));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr99Get() {
                
                #line 1253 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                      (ParBanderasVisible[0].Equals(1) && ((Math.Sqrt(Math.Pow(Coordenadas.X - BanderasCircunferencia.ElementAt(idIzquierda).X, 2) + Math.Pow(Coordenadas.Y - BanderasCircunferencia.ElementAt(idIzquierda).Y, 2))) < Cercania));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr99Get() {
                this.GetValueTypeValues();
                return this.@__Expr99Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr101GetTree() {
                
                #line 1270 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                          "H{ \"id\":\"" + idIzquierda + "\", \"visible\":\"false\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr101Get() {
                
                #line 1270 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                          "H{ \"id\":\"" + idIzquierda + "\", \"visible\":\"false\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr101Get() {
                this.GetValueTypeValues();
                return this.@__Expr101Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr102GetTree() {
                
                #line 1282 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                                            Reporte;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr102Get() {
                
                #line 1282 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                            Reporte;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr102Get() {
                this.GetValueTypeValues();
                return this.@__Expr102Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr103GetTree() {
                
                #line 1277 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                              "Captura Bandera;" + idIzquierda + "/n"
                + "Hora;" + TimeZone.CurrentTimeZone.ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr103Get() {
                
                #line 1277 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                              "Captura Bandera;" + idIzquierda + "/n"
                + "Hora;" + TimeZone.CurrentTimeZone.ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr103Get() {
                this.GetValueTypeValues();
                return this.@__Expr103Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr104GetTree() {
                
                #line 1292 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                          (ParBanderasVisible[1].Equals(1) && (Math.Sqrt(Math.Pow(Coordenadas.X - BanderasCircunferencia.ElementAt(idDerecha).X, 2)+ Math.Pow(Coordenadas.Y - BanderasCircunferencia.ElementAt(idDerecha).Y, 2))) < Cercania);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr104Get() {
                
                #line 1292 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                          (ParBanderasVisible[1].Equals(1) && (Math.Sqrt(Math.Pow(Coordenadas.X - BanderasCircunferencia.ElementAt(idDerecha).X, 2)+ Math.Pow(Coordenadas.Y - BanderasCircunferencia.ElementAt(idDerecha).Y, 2))) < Cercania);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr104Get() {
                this.GetValueTypeValues();
                return this.@__Expr104Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr106GetTree() {
                
                #line 1309 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                              "H{ \"id\":\"" + idDerecha + "\", \"visible\":\"false\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr106Get() {
                
                #line 1309 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                              "H{ \"id\":\"" + idDerecha + "\", \"visible\":\"false\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr106Get() {
                this.GetValueTypeValues();
                return this.@__Expr106Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr107GetTree() {
                
                #line 1321 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                                                Reporte;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr107Get() {
                
                #line 1321 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                Reporte;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr107Get() {
                this.GetValueTypeValues();
                return this.@__Expr107Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr108GetTree() {
                
                #line 1316 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                  "Captura Bandera;" + idDerecha + "/n"
                + "Hora;" + TimeZone.CurrentTimeZone.ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr108Get() {
                
                #line 1316 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                  "Captura Bandera;" + idDerecha + "/n"
                + "Hora;" + TimeZone.CurrentTimeZone.ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr108Get() {
                this.GetValueTypeValues();
                return this.@__Expr108Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr109GetTree() {
                
                #line 1338 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              !((ParBanderasVisible[0].Equals(1) && ((Math.Sqrt(Math.Pow(Coordenadas.X - BanderasCircunferencia.ElementAt(idIzquierda).X, 2) - Math.Pow(Coordenadas.Y - BanderasCircunferencia.ElementAt(idIzquierda).Y, 2))) < Cercania)) || (ParBanderasVisible[1].Equals(1) && (Math.Sqrt(Math.Pow(Coordenadas.X - BanderasCircunferencia.ElementAt(idDerecha).X, 2) - Math.Pow(Coordenadas.Y - BanderasCircunferencia.ElementAt(idDerecha).Y, 2))) < Cercania));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr109Get() {
                
                #line 1338 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                              !((ParBanderasVisible[0].Equals(1) && ((Math.Sqrt(Math.Pow(Coordenadas.X - BanderasCircunferencia.ElementAt(idIzquierda).X, 2) - Math.Pow(Coordenadas.Y - BanderasCircunferencia.ElementAt(idIzquierda).Y, 2))) < Cercania)) || (ParBanderasVisible[1].Equals(1) && (Math.Sqrt(Math.Pow(Coordenadas.X - BanderasCircunferencia.ElementAt(idDerecha).X, 2) - Math.Pow(Coordenadas.Y - BanderasCircunferencia.ElementAt(idDerecha).Y, 2))) < Cercania));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr109Get() {
                this.GetValueTypeValues();
                return this.@__Expr109Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 26))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 26);
                }
                expectedLocationsCount = 26;
                return Ejercicio_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Ejercicio_TypedDataContext7 : Ejercicio_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Ejercicio_TypedDataContext7(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext7(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext7(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                
                #line 630 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                              RtaCave;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr111Get() {
                
                #line 630 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
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
                
                #line 630 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                
                                              RtaCave = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr111Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr111Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr114GetTree() {
                
                #line 644 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                                                  Coordenadas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr114Get() {
                
                #line 644 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                  Coordenadas;
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr114Get() {
                this.GetValueTypeValues();
                return this.@__Expr114Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr114Set(System.Drawing.PointF value) {
                
                #line 644 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                
                                                  Coordenadas = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr114Set(System.Drawing.PointF value) {
                this.GetValueTypeValues();
                this.@__Expr114Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr116GetTree() {
                
                #line 1156 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                              IRecoleccion;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr116Get() {
                
                #line 1156 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                              IRecoleccion;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr116Get() {
                this.GetValueTypeValues();
                return this.@__Expr116Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr116Set(int value) {
                
                #line 1156 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                
                                              IRecoleccion = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr116Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr116Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr124GetTree() {
                
                #line 1212 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                    ParBanderasVisible[1];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr124Get() {
                
                #line 1212 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                    ParBanderasVisible[1];
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr124Get() {
                this.GetValueTypeValues();
                return this.@__Expr124Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr124Set(int value) {
                
                #line 1212 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                
                                                    ParBanderasVisible[1] = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr124Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr124Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 26))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 26);
                }
                expectedLocationsCount = 26;
                return Ejercicio_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Ejercicio_TypedDataContext7_ForReadOnly : Ejercicio_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Ejercicio_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr110GetTree() {
                
                #line 614 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                          ParBanderasVisible[0].Equals(1);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr110Get() {
                
                #line 614 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                          ParBanderasVisible[0].Equals(1);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr110Get() {
                this.GetValueTypeValues();
                return this.@__Expr110Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr112GetTree() {
                
                #line 637 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                              RtaCave.Split(';').Length>1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr112Get() {
                
                #line 637 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                              RtaCave.Split(';').Length>1;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr112Get() {
                this.GetValueTypeValues();
                return this.@__Expr112Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr113GetTree() {
                
                #line 649 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                                                  new PointF(Single.Parse(RtaCave.Split(';')[0].Replace(".", ",")), Single.Parse(RtaCave.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr113Get() {
                
                #line 649 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                  new PointF(Single.Parse(RtaCave.Split(';')[0].Replace(".", ",")), Single.Parse(RtaCave.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr113Get() {
                this.GetValueTypeValues();
                return this.@__Expr113Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr115GetTree() {
                
                #line 1178 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                      ((Math.Sqrt(Math.Pow(Coordenadas.X - Cruz.X, 2) + Math.Pow(Coordenadas.Y - Cruz.Y, 2))) < Cercania) && (IRecoleccion.Equals(2)) && (Evaluar.Equals(1));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr115Get() {
                
                #line 1178 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                      ((Math.Sqrt(Math.Pow(Coordenadas.X - Cruz.X, 2) + Math.Pow(Coordenadas.Y - Cruz.Y, 2))) < Cercania) && (IRecoleccion.Equals(2)) && (Evaluar.Equals(1));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr115Get() {
                this.GetValueTypeValues();
                return this.@__Expr115Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr117GetTree() {
                
                #line 1171 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                                              Reporte;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr117Get() {
                
                #line 1171 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                              Reporte;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr117Get() {
                this.GetValueTypeValues();
                return this.@__Expr117Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr118GetTree() {
                
                #line 1167 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                "Inicio test memoria;" + TimeZone.CurrentTimeZone.ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr118Get() {
                
                #line 1167 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                "Inicio test memoria;" + TimeZone.CurrentTimeZone.ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr118Get() {
                this.GetValueTypeValues();
                return this.@__Expr118Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr119GetTree() {
                
                #line 1225 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                      ((Math.Sqrt(Math.Pow(Coordenadas.X - Cruz.X, 2) + Math.Pow(Coordenadas.Y - Cruz.Y, 2))) < Cercania) && (IRecoleccion.CompareTo(2)<0);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr119Get() {
                
                #line 1225 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                      ((Math.Sqrt(Math.Pow(Coordenadas.X - Cruz.X, 2) + Math.Pow(Coordenadas.Y - Cruz.Y, 2))) < Cercania) && (IRecoleccion.CompareTo(2)<0);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr119Get() {
                this.GetValueTypeValues();
                return this.@__Expr119Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr120GetTree() {
                
                #line 1192 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                                              Reporte;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr120Get() {
                
                #line 1192 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                              Reporte;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr120Get() {
                this.GetValueTypeValues();
                return this.@__Expr120Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr121GetTree() {
                
                #line 1188 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                "Hora Centro;" + TimeZone.CurrentTimeZone.ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr121Get() {
                
                #line 1188 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                "Hora Centro;" + TimeZone.CurrentTimeZone.ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr121Get() {
                this.GetValueTypeValues();
                return this.@__Expr121Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr122GetTree() {
                
                #line 1199 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                              AparecePar[Iteracion].Equals(0);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr122Get() {
                
                #line 1199 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                              AparecePar[Iteracion].Equals(0);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr122Get() {
                this.GetValueTypeValues();
                return this.@__Expr122Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr123GetTree() {
                
                #line 1206 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                  "H{ \"id\":\"" + idDerecha + "\", \"visible\":\"true\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr123Get() {
                
                #line 1206 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                  "H{ \"id\":\"" + idDerecha + "\", \"visible\":\"true\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr123Get() {
                this.GetValueTypeValues();
                return this.@__Expr123Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr125GetTree() {
                
                #line 1230 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                      !((Math.Sqrt(Math.Pow(Coordenadas.X - Cruz.X, 2) + Math.Pow(Coordenadas.Y - Cruz.Y, 2))) < Cercania);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr125Get() {
                
                #line 1230 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                      !((Math.Sqrt(Math.Pow(Coordenadas.X - Cruz.X, 2) + Math.Pow(Coordenadas.Y - Cruz.Y, 2))) < Cercania);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr125Get() {
                this.GetValueTypeValues();
                return this.@__Expr125Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 26))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 26);
                }
                expectedLocationsCount = 26;
                return Ejercicio_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Ejercicio_TypedDataContext8 : Ejercicio_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Ejercicio_TypedDataContext8(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext8(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext8(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr126GetTree() {
                
                #line 666 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                      RtaCave;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr126Get() {
                
                #line 666 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                      RtaCave;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr126Get() {
                this.GetValueTypeValues();
                return this.@__Expr126Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr126Set(string value) {
                
                #line 666 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                
                                                      RtaCave = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr126Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr126Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr129GetTree() {
                
                #line 680 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                                                          Coordenadas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr129Get() {
                
                #line 680 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                          Coordenadas;
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr129Get() {
                this.GetValueTypeValues();
                return this.@__Expr129Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr129Set(System.Drawing.PointF value) {
                
                #line 680 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                
                                                          Coordenadas = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr129Set(System.Drawing.PointF value) {
                this.GetValueTypeValues();
                this.@__Expr129Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr132GetTree() {
                
                #line 919 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                      Cursor;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr132Get() {
                
                #line 919 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
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
                
                #line 919 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                
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
                            && (locationReferences.Count < 26))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 26);
                }
                expectedLocationsCount = 26;
                return Ejercicio_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Ejercicio_TypedDataContext8_ForReadOnly : Ejercicio_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Ejercicio_TypedDataContext8_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext8_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext8_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                
                #line 673 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                      RtaCave.Split(';').Length>1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr127Get() {
                
                #line 673 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                      RtaCave.Split(';').Length>1;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr127Get() {
                this.GetValueTypeValues();
                return this.@__Expr127Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr128GetTree() {
                
                #line 685 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                                                          new PointF(Single.Parse(RtaCave.Split(';')[0].Replace(".", ",")), Single.Parse(RtaCave.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr128Get() {
                
                #line 685 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                          new PointF(Single.Parse(RtaCave.Split(';')[0].Replace(".", ",")), Single.Parse(RtaCave.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr128Get() {
                this.GetValueTypeValues();
                return this.@__Expr128Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr130GetTree() {
                
                #line 694 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                              Protocolo[Iteracion].Equals(1);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr130Get() {
                
                #line 694 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                              Protocolo[Iteracion].Equals(1);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr130Get() {
                this.GetValueTypeValues();
                return this.@__Expr130Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr131GetTree() {
                
                #line 950 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                              Protocolo[Iteracion].Equals(2);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr131Get() {
                
                #line 950 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                              Protocolo[Iteracion].Equals(2);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr131Get() {
                this.GetValueTypeValues();
                return this.@__Expr131Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr133GetTree() {
                
                #line 928 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    "Q{ \"text\":\"Escucha la consigna\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr133Get() {
                
                #line 928 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                    "Q{ \"text\":\"Escucha la consigna\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr133Get() {
                this.GetValueTypeValues();
                return this.@__Expr133Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr134GetTree() {
                
                #line 933 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.TimeSpan>> expression = () => 
                                                    TimeSpan.FromSeconds(4);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.TimeSpan @__Expr134Get() {
                
                #line 933 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                    TimeSpan.FromSeconds(4);
                
                #line default
                #line hidden
            }
            
            public System.TimeSpan ValueType___Expr134Get() {
                this.GetValueTypeValues();
                return this.@__Expr134Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr135GetTree() {
                
                #line 939 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    "Q{ \"text\":\" \" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr135Get() {
                
                #line 939 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                    "Q{ \"text\":\" \" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr135Get() {
                this.GetValueTypeValues();
                return this.@__Expr135Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr136GetTree() {
                
                #line 944 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    Mostrar180;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr136Get() {
                
                #line 944 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                    Mostrar180;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr136Get() {
                this.GetValueTypeValues();
                return this.@__Expr136Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr137GetTree() {
                
                #line 1145 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                              Protocolo[Iteracion].Equals(3);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr137Get() {
                
                #line 1145 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                              Protocolo[Iteracion].Equals(3);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr137Get() {
                this.GetValueTypeValues();
                return this.@__Expr137Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr138GetTree() {
                
                #line 1128 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    "Q{ \"text\":\"Coloca la bandera\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr138Get() {
                
                #line 1128 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                    "Q{ \"text\":\"Coloca la bandera\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr138Get() {
                this.GetValueTypeValues();
                return this.@__Expr138Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr139GetTree() {
                
                #line 1133 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.TimeSpan>> expression = () => 
                                                    TimeSpan.FromSeconds(4);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.TimeSpan @__Expr139Get() {
                
                #line 1133 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                    TimeSpan.FromSeconds(4);
                
                #line default
                #line hidden
            }
            
            public System.TimeSpan ValueType___Expr139Get() {
                this.GetValueTypeValues();
                return this.@__Expr139Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr140GetTree() {
                
                #line 1139 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    "Q{ \"text\":\" \" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr140Get() {
                
                #line 1139 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                    "Q{ \"text\":\" \" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr140Get() {
                this.GetValueTypeValues();
                return this.@__Expr140Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 26))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 26);
                }
                expectedLocationsCount = 26;
                return Ejercicio_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Ejercicio_TypedDataContext9 : Ejercicio_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Ejercicio_TypedDataContext9(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext9(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext9(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                            && (locationReferences.Count < 26))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 26);
                }
                expectedLocationsCount = 26;
                return Ejercicio_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Ejercicio_TypedDataContext9_ForReadOnly : Ejercicio_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Ejercicio_TypedDataContext9_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext9_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext9_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                
                #line 706 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                "Q{ \"text\":\"Fin del experimento\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr141Get() {
                
                #line 706 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                                "Q{ \"text\":\"Fin del experimento\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr141Get() {
                this.GetValueTypeValues();
                return this.@__Expr141Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr142GetTree() {
                
                #line 711 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.TimeSpan>> expression = () => 
                                                                TimeSpan.FromSeconds(2);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.TimeSpan @__Expr142Get() {
                
                #line 711 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                                TimeSpan.FromSeconds(2);
                
                #line default
                #line hidden
            }
            
            public System.TimeSpan ValueType___Expr142Get() {
                this.GetValueTypeValues();
                return this.@__Expr142Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 26))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 26);
                }
                expectedLocationsCount = 26;
                return Ejercicio_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Ejercicio_TypedDataContext10 : Ejercicio_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Ejercicio_TypedDataContext10(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext10(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext10(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                            && (locationReferences.Count < 26))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 26);
                }
                expectedLocationsCount = 26;
                return Ejercicio_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Ejercicio_TypedDataContext10_ForReadOnly : Ejercicio_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Ejercicio_TypedDataContext10_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext10_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext10_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                            && (locationReferences.Count < 26))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 26);
                }
                expectedLocationsCount = 26;
                return Ejercicio_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Ejercicio_TypedDataContext11 : Ejercicio_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Ejercicio_TypedDataContext11(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext11(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext11(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                
                #line 743 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                              RtaCave;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr144Get() {
                
                #line 743 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                              RtaCave;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr144Get() {
                this.GetValueTypeValues();
                return this.@__Expr144Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr144Set(string value) {
                
                #line 743 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                
                                                              RtaCave = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr144Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr144Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr147GetTree() {
                
                #line 757 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                                                                  Coordenadas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr147Get() {
                
                #line 757 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                                  Coordenadas;
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr147Get() {
                this.GetValueTypeValues();
                return this.@__Expr147Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr147Set(System.Drawing.PointF value) {
                
                #line 757 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                
                                                                  Coordenadas = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr147Set(System.Drawing.PointF value) {
                this.GetValueTypeValues();
                this.@__Expr147Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr152GetTree() {
                
                #line 791 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                    Cursor;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr152Get() {
                
                #line 791 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
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
                
                #line 791 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                
                                                                    Cursor = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr152Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr152Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr155GetTree() {
                
                #line 810 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                        Cursor;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr155Get() {
                
                #line 810 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                                        Cursor;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr155Get() {
                this.GetValueTypeValues();
                return this.@__Expr155Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr155Set(int value) {
                
                #line 810 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                
                                                                        Cursor = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr155Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr155Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr157GetTree() {
                
                #line 827 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                  Cursor;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr157Get() {
                
                #line 827 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                                  Cursor;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr157Get() {
                this.GetValueTypeValues();
                return this.@__Expr157Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr157Set(int value) {
                
                #line 827 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                
                                                                  Cursor = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr157Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr157Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 26))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 26);
                }
                expectedLocationsCount = 26;
                return Ejercicio_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Ejercicio_TypedDataContext11_ForReadOnly : Ejercicio_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Ejercicio_TypedDataContext11_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext11_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext11_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr143GetTree() {
                
                #line 731 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                        "C{ \"id\":\"" + (int)(Cursor) + "\", \"color\":\"azul\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr143Get() {
                
                #line 731 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                        "C{ \"id\":\"" + (int)(Cursor) + "\", \"color\":\"azul\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr143Get() {
                this.GetValueTypeValues();
                return this.@__Expr143Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr145GetTree() {
                
                #line 750 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                              RtaCave.Split(';').Length>1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr145Get() {
                
                #line 750 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                              RtaCave.Split(';').Length>1;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr145Get() {
                this.GetValueTypeValues();
                return this.@__Expr145Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr146GetTree() {
                
                #line 762 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                                                                  new PointF(Single.Parse(RtaCave.Split(';')[0].Replace(".", ",")), Single.Parse(RtaCave.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr146Get() {
                
                #line 762 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                                  new PointF(Single.Parse(RtaCave.Split(';')[0].Replace(".", ",")), Single.Parse(RtaCave.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr146Get() {
                this.GetValueTypeValues();
                return this.@__Expr146Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr148GetTree() {
                
                #line 841 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                      RtaCave.Equals("1") || RtaCave.Equals("3");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr148Get() {
                
                #line 841 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                      RtaCave.Equals("1") || RtaCave.Equals("3");
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr148Get() {
                this.GetValueTypeValues();
                return this.@__Expr148Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr149GetTree() {
                
                #line 777 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                            "C{ \"id\":\"" + (int)(Cursor) + "\", \"color\":\"" + Color[Iteracion] + "\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr149Get() {
                
                #line 777 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                            "C{ \"id\":\"" + (int)(Cursor) + "\", \"color\":\"" + Color[Iteracion] + "\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr149Get() {
                this.GetValueTypeValues();
                return this.@__Expr149Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr150GetTree() {
                
                #line 783 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                              RtaCave.Equals("1");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr150Get() {
                
                #line 783 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                              RtaCave.Equals("1");
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr150Get() {
                this.GetValueTypeValues();
                return this.@__Expr150Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr151GetTree() {
                
                #line 796 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                    (Cursor - 1) % BanderasCircunferencia.Count;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr151Get() {
                
                #line 796 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                                    (Cursor - 1) % BanderasCircunferencia.Count;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr151Get() {
                this.GetValueTypeValues();
                return this.@__Expr151Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr153GetTree() {
                
                #line 803 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                    Cursor<0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr153Get() {
                
                #line 803 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                                    Cursor<0;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr153Get() {
                this.GetValueTypeValues();
                return this.@__Expr153Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr154GetTree() {
                
                #line 815 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                        BanderasCircunferencia.Count-1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr154Get() {
                
                #line 815 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                                        BanderasCircunferencia.Count-1;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr154Get() {
                this.GetValueTypeValues();
                return this.@__Expr154Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr156GetTree() {
                
                #line 832 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                  (Cursor + 1) % BanderasCircunferencia.Count;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr156Get() {
                
                #line 832 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                                  (Cursor + 1) % BanderasCircunferencia.Count;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr156Get() {
                this.GetValueTypeValues();
                return this.@__Expr156Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr158GetTree() {
                
                #line 908 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                      RtaCave.Equals("2")&&(Iteracion<(Angulo.Length-1));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr158Get() {
                
                #line 908 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                      RtaCave.Equals("2")&&(Iteracion<(Angulo.Length-1));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr158Get() {
                this.GetValueTypeValues();
                return this.@__Expr158Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr159GetTree() {
                
                #line 897 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                            "C{ \"id\":\"" + (int)(Cursor) + "\", \"color\":\"" + Color[Iteracion] + "\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr159Get() {
                
                #line 897 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                            "C{ \"id\":\"" + (int)(Cursor) + "\", \"color\":\"" + Color[Iteracion] + "\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr159Get() {
                this.GetValueTypeValues();
                return this.@__Expr159Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr160GetTree() {
                
                #line 902 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                            Mostrar180.Replace("true", "false");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr160Get() {
                
                #line 902 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                            Mostrar180.Replace("true", "false");
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr160Get() {
                this.GetValueTypeValues();
                return this.@__Expr160Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 26))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 26);
                }
                expectedLocationsCount = 26;
                return Ejercicio_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Ejercicio_TypedDataContext12 : Ejercicio_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Ejercicio_TypedDataContext12(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext12(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext12(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                
                #line 960 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                        Cursor;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr162Get() {
                
                #line 960 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                        Cursor;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr162Get() {
                this.GetValueTypeValues();
                return this.@__Expr162Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr162Set(int value) {
                
                #line 960 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                
                                                        Cursor = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr162Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr162Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr163GetTree() {
                
                #line 977 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                              RtaCave;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr163Get() {
                
                #line 977 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                              RtaCave;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr163Get() {
                this.GetValueTypeValues();
                return this.@__Expr163Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr163Set(string value) {
                
                #line 977 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                
                                                              RtaCave = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr163Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr163Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr166GetTree() {
                
                #line 991 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                                                                  Coordenadas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr166Get() {
                
                #line 991 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                                  Coordenadas;
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr166Get() {
                this.GetValueTypeValues();
                return this.@__Expr166Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr166Set(System.Drawing.PointF value) {
                
                #line 991 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                
                                                                  Coordenadas = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr166Set(System.Drawing.PointF value) {
                this.GetValueTypeValues();
                this.@__Expr166Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr170GetTree() {
                
                #line 1079 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                              Cursor;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr170Get() {
                
                #line 1079 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                              Cursor;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr170Get() {
                this.GetValueTypeValues();
                return this.@__Expr170Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr170Set(int value) {
                
                #line 1079 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                
                                                              Cursor = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr170Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr170Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 26))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 26);
                }
                expectedLocationsCount = 26;
                return Ejercicio_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Ejercicio_TypedDataContext12_ForReadOnly : Ejercicio_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Ejercicio_TypedDataContext12_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext12_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext12_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                
                #line 965 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                        BanderasCircunferencia.Count + Iteracion;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr161Get() {
                
                #line 965 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                        BanderasCircunferencia.Count + Iteracion;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr161Get() {
                this.GetValueTypeValues();
                return this.@__Expr161Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr164GetTree() {
                
                #line 984 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                              RtaCave.Split(';').Length>1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr164Get() {
                
                #line 984 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                              RtaCave.Split(';').Length>1;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr164Get() {
                this.GetValueTypeValues();
                return this.@__Expr164Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr165GetTree() {
                
                #line 996 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                                                                  new PointF(Single.Parse(RtaCave.Split(';')[0].Replace(".", ",")), Single.Parse(RtaCave.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr165Get() {
                
                #line 996 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                                  new PointF(Single.Parse(RtaCave.Split(';')[0].Replace(".", ",")), Single.Parse(RtaCave.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr165Get() {
                this.GetValueTypeValues();
                return this.@__Expr165Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr167GetTree() {
                
                #line 1113 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                      RtaCave.Equals("2");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr167Get() {
                
                #line 1113 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                      RtaCave.Equals("2");
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr167Get() {
                this.GetValueTypeValues();
                return this.@__Expr167Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr168GetTree() {
                
                #line 1073 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                            "A{ \"id\":\"" + Cursor + "\", \"color\":\"" + Color[Iteracion] + "\", \"x\":\"" + Coordenadas.X.ToString(System.Globalization.CultureInfo.InvariantCulture).Replace(",", ".") + "\", \"y\":\"" + Coordenadas.Y.ToString(System.Globalization.CultureInfo.InvariantCulture).Replace(",", ".") + "\", \"visible\":\"true\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr168Get() {
                
                #line 1073 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                            "A{ \"id\":\"" + Cursor + "\", \"color\":\"" + Color[Iteracion] + "\", \"x\":\"" + Coordenadas.X.ToString(System.Globalization.CultureInfo.InvariantCulture).Replace(",", ".") + "\", \"y\":\"" + Coordenadas.Y.ToString(System.Globalization.CultureInfo.InvariantCulture).Replace(",", ".") + "\", \"visible\":\"true\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr168Get() {
                this.GetValueTypeValues();
                return this.@__Expr168Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr169GetTree() {
                
                #line 1084 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                              Cursor+1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr169Get() {
                
                #line 1084 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                              Cursor+1;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr169Get() {
                this.GetValueTypeValues();
                return this.@__Expr169Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr171GetTree() {
                
                #line 1091 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.TimeSpan>> expression = () => 
                                                            TimeSpan.FromSeconds(2);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.TimeSpan @__Expr171Get() {
                
                #line 1091 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                            TimeSpan.FromSeconds(2);
                
                #line default
                #line hidden
            }
            
            public System.TimeSpan ValueType___Expr171Get() {
                this.GetValueTypeValues();
                return this.@__Expr171Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr172GetTree() {
                
                #line 1096 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                            "Q{ \"text\":\"Confirma la posicion (Y)\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr172Get() {
                
                #line 1096 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                            "Q{ \"text\":\"Confirma la posicion (Y)\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr172Get() {
                this.GetValueTypeValues();
                return this.@__Expr172Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr173GetTree() {
                
                #line 1101 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.TimeSpan>> expression = () => 
                                                            TimeSpan.FromSeconds(2);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.TimeSpan @__Expr173Get() {
                
                #line 1101 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                            TimeSpan.FromSeconds(2);
                
                #line default
                #line hidden
            }
            
            public System.TimeSpan ValueType___Expr173Get() {
                this.GetValueTypeValues();
                return this.@__Expr173Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr174GetTree() {
                
                #line 1107 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                            "Q{ \"text\":\" \" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr174Get() {
                
                #line 1107 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                            "Q{ \"text\":\" \" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr174Get() {
                this.GetValueTypeValues();
                return this.@__Expr174Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr175GetTree() {
                
                #line 1118 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                      !RtaCave.Equals("2");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr175Get() {
                
                #line 1118 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                      !RtaCave.Equals("2");
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr175Get() {
                this.GetValueTypeValues();
                return this.@__Expr175Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 26))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 26);
                }
                expectedLocationsCount = 26;
                return Ejercicio_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Ejercicio_TypedDataContext13 : Ejercicio_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Ejercicio_TypedDataContext13(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext13(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext13(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr177GetTree() {
                
                #line 852 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                  Iteracion;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr177Get() {
                
                #line 852 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                                  Iteracion;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr177Get() {
                this.GetValueTypeValues();
                return this.@__Expr177Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr177Set(int value) {
                
                #line 852 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                
                                                                  Iteracion = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr177Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr177Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 26))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 26);
                }
                expectedLocationsCount = 26;
                return Ejercicio_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Ejercicio_TypedDataContext13_ForReadOnly : Ejercicio_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Ejercicio_TypedDataContext13_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext13_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext13_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                
                #line 857 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                  Iteracion+1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr176Get() {
                
                #line 857 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                                  Iteracion+1;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr176Get() {
                this.GetValueTypeValues();
                return this.@__Expr176Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr178GetTree() {
                
                #line 872 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<string>>> expression = () => 
                                                                  Reporte;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<string> @__Expr178Get() {
                
                #line 872 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                                  Reporte;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<string> ValueType___Expr178Get() {
                this.GetValueTypeValues();
                return this.@__Expr178Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr179GetTree() {
                
                #line 865 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                    "Hora Fin Seleccion;" + TimeZone.CurrentTimeZone.ToString() + "/n"+
                "Bandera Seleccionada [id];"+Cursor+"/n"+
                    "Bandera Seleccionada [X];"+BanderasCircunferencia.ElementAt(Cursor).X+"\n"+
                    "Bandera Seleccionada [Y];"+BanderasCircunferencia.ElementAt(Cursor).Y;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr179Get() {
                
                #line 865 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                                    "Hora Fin Seleccion;" + TimeZone.CurrentTimeZone.ToString() + "/n"+
                "Bandera Seleccionada [id];"+Cursor+"/n"+
                    "Bandera Seleccionada [X];"+BanderasCircunferencia.ElementAt(Cursor).X+"\n"+
                    "Bandera Seleccionada [Y];"+BanderasCircunferencia.ElementAt(Cursor).Y;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr179Get() {
                this.GetValueTypeValues();
                return this.@__Expr179Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr180GetTree() {
                
                #line 882 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                              Iteracion<Angulo.Length;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr180Get() {
                
                #line 882 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                              Iteracion<Angulo.Length;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr180Get() {
                this.GetValueTypeValues();
                return this.@__Expr180Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr181GetTree() {
                
                #line 887 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                              Iteracion.Equals(Angulo.Length);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr181Get() {
                
                #line 887 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                              Iteracion.Equals(Angulo.Length);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr181Get() {
                this.GetValueTypeValues();
                return this.@__Expr181Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 26))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 26);
                }
                expectedLocationsCount = 26;
                return Ejercicio_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Ejercicio_TypedDataContext14 : Ejercicio_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Ejercicio_TypedDataContext14(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext14(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext14(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr182GetTree() {
                
                #line 1013 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                      RtaCave;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr182Get() {
                
                #line 1013 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                                      RtaCave;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr182Get() {
                this.GetValueTypeValues();
                return this.@__Expr182Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr182Set(string value) {
                
                #line 1013 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                
                                                                      RtaCave = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr182Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr182Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr185GetTree() {
                
                #line 1027 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                                                                          Coordenadas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr185Get() {
                
                #line 1027 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                                          Coordenadas;
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr185Get() {
                this.GetValueTypeValues();
                return this.@__Expr185Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr185Set(System.Drawing.PointF value) {
                
                #line 1027 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                
                                                                          Coordenadas = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr185Set(System.Drawing.PointF value) {
                this.GetValueTypeValues();
                this.@__Expr185Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 26))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 26);
                }
                expectedLocationsCount = 26;
                return Ejercicio_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Ejercicio_TypedDataContext14_ForReadOnly : Ejercicio_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Ejercicio_TypedDataContext14_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext14_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Ejercicio_TypedDataContext14_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr183GetTree() {
                
                #line 1020 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                      RtaCave.Split(';').Length>1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr183Get() {
                
                #line 1020 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                                      RtaCave.Split(';').Length>1;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr183Get() {
                this.GetValueTypeValues();
                return this.@__Expr183Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr184GetTree() {
                
                #line 1032 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Drawing.PointF>> expression = () => 
                                                                          new PointF(Single.Parse(RtaCave.Split(';')[0].Replace(".", ",")), Single.Parse(RtaCave.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Drawing.PointF @__Expr184Get() {
                
                #line 1032 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                                          new PointF(Single.Parse(RtaCave.Split(';')[0].Replace(".", ",")), Single.Parse(RtaCave.Split(';')[1].Replace(".", ",")));
                
                #line default
                #line hidden
            }
            
            public System.Drawing.PointF ValueType___Expr184Get() {
                this.GetValueTypeValues();
                return this.@__Expr184Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr186GetTree() {
                
                #line 1051 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                              RtaCave.Equals("2");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr186Get() {
                
                #line 1051 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                              RtaCave.Equals("2");
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr186Get() {
                this.GetValueTypeValues();
                return this.@__Expr186Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr187GetTree() {
                
                #line 1046 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                  "H{ \"id\":\"" + (int)(Cursor-1) + "\", \"visible\":\"false\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr187Get() {
                
                #line 1046 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                                  "H{ \"id\":\"" + (int)(Cursor-1) + "\", \"visible\":\"false\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr187Get() {
                this.GetValueTypeValues();
                return this.@__Expr187Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr188GetTree() {
                
                #line 1063 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                              RtaCave.Equals("1");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr188Get() {
                
                #line 1063 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                              RtaCave.Equals("1");
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr188Get() {
                this.GetValueTypeValues();
                return this.@__Expr188Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr189GetTree() {
                
                #line 1058 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                  "H{ \"id\":\"" + (int)(Cursor-1) + "\", \"visible\":\"false\" }";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr189Get() {
                
                #line 1058 "C:\USERS\DELLPLADEMA\DESKTOP\NUEVA CARPETA (2)\VFINAL\WFFLAGCOLLECTOR\FLAGCOLLECTOR\EJERCICIO\EJERCICIO.XAML"
                return 
                                                                  "H{ \"id\":\"" + (int)(Cursor-1) + "\", \"visible\":\"false\" }";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr189Get() {
                this.GetValueTypeValues();
                return this.@__Expr189Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 26))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 26);
                }
                expectedLocationsCount = 26;
                return Ejercicio_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
