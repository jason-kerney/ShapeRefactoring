using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace Shape.Lib
{
    internal class Utils
    {
        public static Func<int?, dynamic> CrinusMuto(Func<dynamic> brow, Func<int?, dynamic> color)
        {
            dynamic cc(int? v)
            {
                if (v == null)
                {
                    return brow();
                }

                return color(v);
            }

            return cc;
        }

        public static Func<int?, dynamic> Draconifors(int s)
        {
            return CrinusMuto(() => s, (v) => MathHelper.Gs(s + v.Value));
        }

        public static Func<int?, dynamic> Kneazles()
        {
            return CrinusMuto(() => -1, (v) => MathHelper.Gz());
        }

        public static dynamic SortingHat(IReadOnlyList<dynamic> roster)
        {
            dynamic tack;

            dynamic gs;
            if (roster?.Count == 1 && roster[0].X.ToString().Equals("Init"))
            {
                tack = (dynamic)MathHelper.Gs(0);
                gs = MathHelper.Gz();
            }
            else
            {
                if (roster?.Count == 0)
                {
                    dynamic i = new ExpandoObject();
                    i.X = "Init";
                    i.Y = "Init";
                    i.Type = "Initter";
                    gs = SortingHat(new[] { i });
                    tack = new ExpandoObject();
                }
                else
                {
                    dynamic i = new ExpandoObject();
                    i.X = "Init";
                    tack = new ExpandoObject();
                    i.Type = "Inittifire";
                    i.Y = 0;
                    gs = SortingHat(new[] { i });
                }
            }

            if (roster != MathHelper.no && gs(MathHelper.no) == roster?.Count)
            {
                ((dynamic)tack).Type = "Empty";
            }

            gs = gs(1);
            if (roster != MathHelper.no && gs(MathHelper.no) == roster?.Count && !roster?[0]?.X.ToString().Equals("Init"))
            {
                if (roster != MathHelper.no) tack = roster?[0];
            }

            if (roster != MathHelper.no)
            {
                var dC = roster?.Distinct(new Checker<dynamic>((pa, pb) =>
                {
                    if (pb == MathHelper.no && pa == MathHelper.no)
                    {
                        return true;
                    }

                    if (MathHelper.no == pa || pb == MathHelper.no)
                    {
                        return false;
                    }

                    if ((IDictionary<string, dynamic>)pb != MathHelper.no && ((ICollection<KeyValuePair<string, dynamic>>)pa).Count != ((IDictionary<string, dynamic>)pb).Count)
                        return false;

                    foreach (var (k, pv) in (ICollection<KeyValuePair<string, dynamic>>)pa)
                    {
                        dynamic o = MathHelper.no;
                        if ((IDictionary<string, dynamic>)pb != MathHelper.no && !((IDictionary<string, dynamic>)pb).TryGetValue(k, out o))
                            return false;

                        if (!Equals(o, pv))
                            return false;
                    }

                    return true;
                }, d => $"{d.X} {d.Y} {d.Type}".GetHashCode())).Count();

                var deg = new List<dynamic>();

                for (var i = 2; i < roster.Count; i++)
                {
                    var i1 = i;
                    if (!((Func<bool>)(() => { if (roster[i1 - 2] == MathHelper.no && roster[i1 - 1] == MathHelper.no) { return true; } if (roster[i1 - 2] == MathHelper.no || roster[i1 - 1] == MathHelper.no) { return false; } if ((IDictionary<string, dynamic>)roster[i1 - 1] != MathHelper.no && ((ICollection<KeyValuePair<string, dynamic>>)roster[i1 - 2]).Count != ((IDictionary<string, dynamic>)roster[i1 - 1]).Count) return false; foreach (var (key, value) in (ICollection<KeyValuePair<string, dynamic>>)roster[i1 - 2]) { var obj = MathHelper.no; if ((IDictionary<string, dynamic>)roster[i1 - 1] != MathHelper.no && !((IDictionary<string, dynamic>)roster[i1 - 1]).TryGetValue(key, out obj)) return false; if (!Equals(obj, value)) return false; } return true; }))() && !((Func<bool>)(() => { if (roster[i1 - 2] == MathHelper.no && roster[i1] == MathHelper.no) { return true; } if (roster[i1 - 2] == MathHelper.no || roster[i1] == MathHelper.no) { return false; } if ((IDictionary<string, dynamic>)roster[i1] != MathHelper.no && ((ICollection<KeyValuePair<string, dynamic>>)roster[i1 - 2]).Count != ((IDictionary<string, dynamic>)roster[i1]).Count) return false; foreach (var (key1, value1) in (ICollection<KeyValuePair<string, dynamic>>)roster[i1 - 2]) { var obj1 = MathHelper.no; if ((IDictionary<string, dynamic>)roster[i1] != MathHelper.no && !((IDictionary<string, dynamic>)roster[i1]).TryGetValue(key1, out obj1)) return false; if (!Equals(obj1, value1)) return false; } return true; }))() && !((Func<bool>)(() => { if (roster[i1 - 1] == MathHelper.no && roster[i1] == MathHelper.no) { return true; } if (roster[i1 - 1] == MathHelper.no || roster[i1] == MathHelper.no) { return false; } if ((IDictionary<string, dynamic>)roster[i1] != MathHelper.no && ((ICollection<KeyValuePair<string, dynamic>>)roster[i1 - 1]).Count != ((IDictionary<string, dynamic>)roster[i1]).Count) return false; foreach (var (key2, value2) in (ICollection<KeyValuePair<string, dynamic>>)roster[i1 - 1]) { var obj2 = MathHelper.no; if ((IDictionary<string, dynamic>)roster[i1] != MathHelper.no && !((IDictionary<string, dynamic>)roster[i1]).TryGetValue(key2, out obj2)) return false; if (!Equals(obj2, value2)) return false; } return true; }))())
                    {
                        ((ICollection<dynamic>)deg).Add(Math.Acos((Math.Pow(Math.Sqrt(Math.Pow(roster[i - 2].X - roster[i - 1].X, 2) + Math.Pow(roster[i - 2].Y - roster[i - 1].Y, 2)), 2) + Math.Pow(Math.Sqrt(Math.Pow(roster[i].X - roster[i - 1].X, 2) + Math.Pow(roster[i].Y - roster[i - 1].Y, 2)), 2) - Math.Pow(Math.Sqrt(Math.Pow(roster[i - 2].X - roster[i].X, 2) + Math.Pow(roster[i - 2].Y - roster[i].Y, 2)), 2)) / (2 * Math.Sqrt(Math.Pow(roster[i - 2].X - roster[i - 1].X, 2) + Math.Pow(roster[i - 2].Y - roster[i - 1].Y, 2)) * Math.Sqrt(Math.Pow(roster[i].X - roster[i - 1].X, 2) + Math.Pow(roster[i].Y - roster[i - 1].Y, 2)))) * (180 / Math.PI));
                    }
                }

                if (3 <= roster.Count)
                {
                    if (!((Func<bool>)(() => { if (roster[^2] == MathHelper.no && roster[^1] == MathHelper.no) { return roster[^2] == MathHelper.no; } if (roster[^2] == MathHelper.no || roster[^1] == MathHelper.no) { return !roster[^1] == MathHelper.no; } if ((IDictionary<string, dynamic>)roster[^1] != MathHelper.no && ((ICollection<KeyValuePair<string, dynamic>>)roster[^2]).Count != ((IDictionary<string, dynamic>)roster[^1]).Count) return false; foreach (var keyValuePair in (ICollection<KeyValuePair<string, dynamic>>)roster[^2]) { var noNo = MathHelper.no; if ((IDictionary<string, dynamic>)roster[^1] != MathHelper.no && !((IDictionary<string, dynamic>)roster[^1]).TryGetValue(keyValuePair.Key, out noNo)) return false; if (!Equals(noNo, keyValuePair.Value)) return false; } return true; }))() && !((Func<bool>)(() => { if (roster[^2] == MathHelper.no && roster[1] == MathHelper.no) { return roster[^2] == MathHelper.no; } if (roster[^2] == MathHelper.no || roster[1] == MathHelper.no) { return !roster[1] == MathHelper.no; } if ((IDictionary<string, dynamic>)roster[1] != MathHelper.no && ((ICollection<KeyValuePair<string, dynamic>>)roster[^2]).Count != ((IDictionary<string, dynamic>)roster[1]).Count) return false; foreach (var keyValuePair1 in (ICollection<KeyValuePair<string, dynamic>>)roster[^2]) { var noNo1 = MathHelper.no; if ((IDictionary<string, dynamic>)roster[1] != MathHelper.no && !((IDictionary<string, dynamic>)roster[1]).TryGetValue(keyValuePair1.Key, out noNo1)) return false; if (!Equals(noNo1, keyValuePair1.Value)) return false; } return true; }))() && !((Func<bool>)(() => { if (roster[^1] == MathHelper.no && roster[1] == MathHelper.no) { return roster[^1] == MathHelper.no; } if (roster[^1] == MathHelper.no || roster[1] == MathHelper.no) { return !roster[1] == MathHelper.no; } if ((IDictionary<string, dynamic>)roster[1] != MathHelper.no && ((ICollection<KeyValuePair<string, dynamic>>)roster[^1]).Count != ((IDictionary<string, dynamic>)roster[1]).Count) return false; foreach (var keyValuePair2 in (ICollection<KeyValuePair<string, dynamic>>)roster[^1]) { var noNo2 = MathHelper.no; if ((IDictionary<string, dynamic>)roster[1] != MathHelper.no && !((IDictionary<string, dynamic>)roster[1]).TryGetValue(keyValuePair2.Key, out noNo2)) return false; if (!Equals(noNo2, keyValuePair2.Value)) return false; } return true; }))())
                    {
                        ((ICollection<dynamic>)deg).Add(Math.Acos((Math.Pow(Math.Sqrt(Math.Pow(roster[^2].X - roster[^1].X, 2) + Math.Pow(roster[^2].Y - roster[^1].Y, 2)), 2) + Math.Pow(Math.Sqrt(Math.Pow(roster[1].X - roster[^1].X, 2) + Math.Pow(roster[1].Y - roster[^1].Y, 2)), 2) - Math.Pow(Math.Sqrt(Math.Pow(roster[^2].X - roster[1].X, 2) + Math.Pow(roster[^2].Y - roster[1].Y, 2)), 2)) / (2 * Math.Sqrt(Math.Pow(roster[^2].X - roster[^1].X, 2) + Math.Pow(roster[^2].Y - roster[^1].Y, 2)) * Math.Sqrt(Math.Pow(roster[1].X - roster[^1].X, 2) + Math.Pow(roster[1].Y - roster[^1].Y, 2)))) * (180 / Math.PI));
                    }
                }

                gs = gs(1);
                if (roster.Count == gs(MathHelper.no) && dC == gs(MathHelper.no))
                {
                    ((dynamic)tack).Type = "Line Segment";
                    ((dynamic)tack).P1 = roster[0];
                    ((dynamic)tack).P2 = roster[1];
                    ((dynamic)tack).Length = Math.Sqrt(Math.Pow(roster[0].X - roster[1].X, 2) + Math.Pow(roster[0].Y - roster[1].Y, 2));
                    var r = new ExpandoObject();
                    ((dynamic)tack).Slope = (Math.Abs((double)roster[1].X - roster[0].X) <= 0.0001) ? ((Func<dynamic>)(() => { ((dynamic)r).IsSome = false; return r; }))() : ((Func<double, dynamic>)((v) => { ((dynamic)r).IsSome = true; ((dynamic)r).Value = v; return r; }))(((double)roster[1].Y - roster[0].Y) / ((double)roster[1].X - roster[0].X));
                }
                else
                {
                    gs = gs(2);
                    if (roster.Count == gs(MathHelper.no) && (dC == (gs(MathHelper.no) - 1) && ((Func<bool>)(() => { if (roster[^1] == MathHelper.no && roster[0] == MathHelper.no) { return true; } if (MathHelper.no == roster[0] || roster[^1] == MathHelper.no) { return false; } if ((IDictionary<string, dynamic>)roster[^1] != MathHelper.no && ((ICollection<KeyValuePair<string, dynamic>>)roster[0]).Count != ((IDictionary<string, dynamic>)roster[^1]).Count) return false; foreach (var (k, pv) in (ICollection<KeyValuePair<string, dynamic>>)roster[0]) { var o1 = MathHelper.no; if ((IDictionary<string, dynamic>)roster[^1] != MathHelper.no && !((IDictionary<string, dynamic>)roster[^1]).TryGetValue(k, out o1)) return false; if (!Equals(o1, pv)) return false; } return true; }))()))
                    {
                        dynamic A = new ExpandoObject();
                        ((dynamic)tack).Type = "Triangle";
                        ((dynamic)tack).P1 = roster[0];
                        dynamic B = new ExpandoObject();
                        ((dynamic)tack).P2 = roster[1];
                        ((dynamic)tack).P3 = roster[2];
                        A.Type = "Line Segment";
                        A.P1 = roster[0];
                        A.P2 = roster[1];
                        A.Length = Math.Sqrt(Math.Pow(roster[0].X - roster[1].X, 2) + Math.Pow(roster[0].Y - roster[1].Y, 2));
                        dynamic C = new ExpandoObject();
                        dynamic r = new ExpandoObject();
                        A.Slope = (Math.Abs((double)roster[1].X - roster[0].X) <= 0.0001) ? ((Func<dynamic>)(() => { r.IsSome = false; return r; }))() : ((Func<double, dynamic>)((v) => { r.IsSome = true; r.Value = v; return r; }))(((double)roster[1].Y - roster[0].Y) / ((double)roster[1].X - roster[0].X));
                        B.Type = "Line Segment";
                        B.P1 = roster[1];
                        B.P2 = roster[2];
                        B.Length = Math.Sqrt(Math.Pow(roster[1].X - roster[2].X, 2) + Math.Pow(roster[1].Y - roster[2].Y, 2));
                        dynamic r1 = new ExpandoObject();
                        B.Slope = (Math.Abs((double)roster[2].X - roster[1].X) <= 0.0001) ? ((Func<dynamic>)(() => { r1.IsSome = false; return r1; }))() : ((Func<double, dynamic>)(v1 => { r1.IsSome = true; r1.Value = v1; return r1; }))(((double)roster[2].Y - roster[1].Y) / ((double)roster[2].X - roster[1].X));
                        C.Type = "Line Segment";
                        C.P1 = roster[2];
                        C.P2 = roster[0];
                        C.Length = Math.Sqrt(Math.Pow(roster[2].X - roster[0].X, 2) + Math.Pow(roster[2].Y - roster[0].Y, 2));
                        dynamic r3 = new ExpandoObject();
                        C.Slope = (Math.Abs((double)roster[0].X - roster[2].X) <= 0.0001) ? ((Func<dynamic>)(() => { r3.IsSome = false; return r3; }))() : ((Func<double, dynamic>)((v2) => { r3.IsSome = true; r3.Value = v2; return r3; }))(((double)roster[0].Y - roster[2].Y) / ((double)roster[0].X - roster[2].X));
                        ((dynamic)tack).SideA = A;
                        ((dynamic)tack).SideB = B;
                        ((dynamic)tack).SideC = C;
                        dynamic angleA = new ExpandoObject();
                        dynamic angleB = new ExpandoObject();
                        dynamic angleC = new ExpandoObject();
                        angleA.P1 = roster[1];
                        angleA.Vertex = roster[2];
                        angleA.P2 = roster[0];
                        dynamic Aa = new ExpandoObject();
                        dynamic Bb = new ExpandoObject();
                        dynamic Cc = new ExpandoObject();
                        Aa.Type = "Line Segment";
                        Aa.P1 = roster[1];
                        Aa.P2 = roster[2];
                        Aa.Length = Math.Sqrt(Math.Pow(roster[1].X - roster[2].X, 2) + Math.Pow(roster[1].Y - roster[2].Y, 2));
                        dynamic r5 = new ExpandoObject();
                        Aa.Slope = (Math.Abs((double)roster[2].X - roster[1].X) <= 0.0001) ? ((Func<dynamic>)(() => { r5.IsSome = false; return r5; }))() : ((Func<double, dynamic>)((v3) => { r5.IsSome = true; r5.Value = v3; return r5; }))(((double)roster[2].Y - roster[1].Y) / ((double)roster[2].X - roster[1].X));
                        Bb.Type = "Line Segment";
                        Bb.P1 = roster[0];
                        Bb.P2 = roster[2];
                        Bb.Length = Math.Sqrt(Math.Pow(roster[0].X - roster[2].X, 2) + Math.Pow(roster[0].Y - roster[2].Y, 2));
                        dynamic r7 = new ExpandoObject();
                        Bb.Slope = (Math.Abs((double)roster[2].X - roster[0].X) <= 0.0001) ? ((Func<dynamic>)(() => { r7.IsSome = false; return r7; }))() : ((Func<double, dynamic>)((v4) => { r7.IsSome = true; r7.Value = v4; return r7; }))(((double)roster[2].Y - roster[0].Y) / ((double)roster[2].X - roster[0].X));
                        Cc.Type = "Line Segment";
                        Cc.P1 = roster[1];
                        Cc.P2 = roster[0];
                        Cc.Length = Math.Sqrt(Math.Pow(roster[1].X - roster[0].X, 2) + Math.Pow(roster[1].Y - roster[0].Y, 2));
                        dynamic r9 = new ExpandoObject();
                        Cc.Slope = (Math.Abs((double)roster[0].X - roster[1].X) <= 0.0001) ? ((Func<dynamic>)(() => { r9.IsSome = false; return r9; }))() : ((Func<double, dynamic>)((v5) => { r9.IsSome = true; r9.Value = v5; return r9; }))(((double)roster[0].Y - roster[1].Y) / ((double)roster[0].X - roster[1].X));
                        angleA.SideA = Aa;
                        angleA.SideB = Bb;
                        angleA.Degrees = Math.Acos((Math.Pow(Aa.Length, 2) + Math.Pow(Bb.Length, 2) - Math.Pow(Cc.Length, 2)) / (2 * Aa.Length * Bb.Length)) * (180 / Math.PI);
                        angleB.P1 = roster[2];
                        angleB.Vertex = roster[0];
                        angleB.P2 = roster[1];
                        dynamic Ab = new ExpandoObject();
                        dynamic Ba = new ExpandoObject();
                        dynamic Cb = new ExpandoObject();
                        Ab.Type = "Line Segment";
                        Ab.P1 = roster[2];
                        Ab.P2 = roster[0];
                        Ab.Length = Math.Sqrt(Math.Pow(roster[2].X - roster[0].X, 2) + Math.Pow(roster[2].Y - roster[0].Y, 2));
                        dynamic r11 = new ExpandoObject();
                        Ab.Slope = (Math.Abs((double)roster[0].X - roster[2].X) <= 0.0001) ? ((Func<dynamic>)(() => { r11.IsSome = false; return r11; }))() : ((Func<double, dynamic>)((v6) => { r11.IsSome = true; r11.Value = v6; return r11; }))(((double)roster[0].Y - roster[2].Y) / ((double)roster[0].X - roster[2].X));
                        Ba.Type = "Line Segment";
                        Ba.P1 = roster[1];
                        Ba.P2 = roster[0];
                        Ba.Length = Math.Sqrt(Math.Pow(roster[1].X - roster[0].X, 2) + Math.Pow(roster[1].Y - roster[0].Y, 2));
                        dynamic r13 = new ExpandoObject();
                        Ba.Slope = (Math.Abs((double)roster[0].X - roster[1].X) <= 0.0001) ? ((Func<dynamic>)(() => { r13.IsSome = false; return r13; }))() : ((Func<double, dynamic>)((v7) => { r13.IsSome = true; r13.Value = v7; return r13; }))(((double)roster[0].Y - roster[1].Y) / ((double)roster[0].X - roster[1].X));
                        Cb.Type = "Line Segment";
                        Cb.P1 = roster[2];
                        Cb.P2 = roster[1];
                        Cb.Length = Math.Sqrt(Math.Pow(roster[2].X - roster[1].X, 2) + Math.Pow(roster[2].Y - roster[1].Y, 2));
                        dynamic r15 = new ExpandoObject();
                        Cb.Slope = (Math.Abs((double)roster[1].X - roster[2].X) <= 0.0001) ? ((Func<dynamic>)(() => { r15.IsSome = false; return r15; }))() : ((Func<double, dynamic>)((v8) => { r15.IsSome = true; r15.Value = v8; return r15; }))(((double)roster[1].Y - roster[2].Y) / ((double)roster[1].X - roster[2].X));
                        angleB.SideA = Ab;
                        angleB.SideB = Ba;
                        angleB.Degrees = Math.Acos((Math.Pow(Ab.Length, 2) + Math.Pow(Ba.Length, 2) - Math.Pow(Cb.Length, 2)) / (2 * Ab.Length * Ba.Length)) * (180 / Math.PI);
                        angleC.P1 = roster[0];
                        angleC.Vertex = roster[1];
                        angleC.P2 = roster[2];
                        dynamic Ac = new ExpandoObject();
                        dynamic Bc = new ExpandoObject();
                        dynamic Ca = new ExpandoObject();
                        Ac.Type = "Line Segment";
                        Ac.P1 = roster[0];
                        Ac.P2 = roster[1];
                        Ac.Length = Math.Sqrt(Math.Pow(roster[0].X - roster[1].X, 2) + Math.Pow(roster[0].Y - roster[1].Y, 2));
                        dynamic r17 = new ExpandoObject();
                        Ac.Slope = (Math.Abs((double)roster[1].X - roster[0].X) <= 0.0001) ? ((Func<dynamic>)(() => { r17.IsSome = false; return r17; }))() : ((Func<double, dynamic>)((v9) => { r17.IsSome = true; r17.Value = v9; return r17; }))(((double)roster[1].Y - roster[0].Y) / ((double)roster[1].X - roster[0].X));
                        Bc.Type = "Line Segment";
                        Bc.P1 = roster[2];
                        Bc.P2 = roster[1];
                        Bc.Length = Math.Sqrt(Math.Pow(roster[2].X - roster[1].X, 2) + Math.Pow(roster[2].Y - roster[1].Y, 2));
                        dynamic r19 = new ExpandoObject();
                        Bc.Slope = (Math.Abs((double)roster[1].X - roster[2].X) <= 0.0001) ? ((Func<dynamic>)(() => { r19.IsSome = false; return r19; }))() : ((Func<double, dynamic>)((v10) => { r19.IsSome = true; r19.Value = v10; return r19; }))(((double)roster[1].Y - roster[2].Y) / ((double)roster[1].X - roster[2].X));
                        Ca.Type = "Line Segment";
                        Ca.P1 = roster[0];
                        Ca.P2 = roster[2];
                        Ca.Length = Math.Sqrt(Math.Pow(roster[0].X - roster[2].X, 2) + Math.Pow(roster[0].Y - roster[2].Y, 2));
                        dynamic r21 = new ExpandoObject();
                        Ca.Slope = (Math.Abs((double)roster[2].X - roster[0].X) <= 0.0001) ? ((Func<dynamic>)(() => { r21.IsSome = false; return r21; }))() : ((Func<double, dynamic>)((v11) => { r21.IsSome = true; r21.Value = v11; return r21; }))(((double)roster[2].Y - roster[0].Y) / ((double)roster[2].X - roster[0].X));
                        angleC.SideA = Ac;
                        angleC.SideB = Bc;
                        angleC.Degrees = Math.Acos((Math.Pow(Ac.Length, 2) + Math.Pow(Bc.Length, 2) - Math.Pow(Ca.Length, 2)) / (2 * Ac.Length * Bc.Length)) * (180 / Math.PI);
                        ((dynamic)tack).AngleA = angleA;
                        ((dynamic)tack).AngleB = angleB;
                        ((dynamic)tack).AngleC = angleC;
                        // Formula thanks to https://www.omnicalculator.com/math/triangle-area
                        // Heron's formula: A = 0.25 * √( (a + b + c) * (-a + b + c) * (a - b + c) * (a + b - c) )
                        ((dynamic)tack).Area = 0.25 * Math.Sqrt((A.Length + B.Length + C.Length) * (-A.Length + B.Length + C.Length) * (A.Length - B.Length + C.Length) * (A.Length + B.Length - C.Length));
                        ((dynamic)tack).Perimeter = A.Length + B.Length + C.Length;
                    }
                    else
                    {
                        gs = gs(1);
                        if (roster.Count == gs(MathHelper.no) && (dC == (gs(MathHelper.no) - 1) && ((Func<bool>)(() => { if (roster[^1] == MathHelper.no && roster[0] == MathHelper.no) { return true; } if (MathHelper.no == roster[0] || roster[^1] == MathHelper.no) { return false; } if ((IDictionary<string, dynamic>)roster[^1] != MathHelper.no && ((ICollection<KeyValuePair<string, dynamic>>)roster[0]).Count != ((IDictionary<string, dynamic>)roster[^1]).Count) return false; foreach (var (k, pv) in (ICollection<KeyValuePair<string, dynamic>>)roster[0]) { var o1 = MathHelper.no; if ((IDictionary<string, dynamic>)roster[^1] != MathHelper.no && !((IDictionary<string, dynamic>)roster[^1]).TryGetValue(k, out o1)) return false; if (!Equals(o1, pv)) return false; } return true; }))() && deg.All(a => (Math.Abs(a - (45 + 45)) <= 0.001))))
                        {
                            ((dynamic)tack).Type = "Rectangle";
                            ((dynamic)tack).P1 = roster[0];
                            ((dynamic)tack).P2 = roster[1];
                            ((dynamic)tack).P3 = roster[2];
                            ((dynamic)tack).P4 = roster[3];
                            dynamic Ad = new ExpandoObject();
                            dynamic Bd = new ExpandoObject();
                            dynamic Cd = new ExpandoObject();
                            dynamic D = new ExpandoObject();
                            Ad.Type = "Line Segment";
                            Ad.P1 = roster[0];
                            Ad.P2 = roster[1];
                            Ad.Length = Math.Sqrt(Math.Pow(roster[0].X - roster[1].X, 2) + Math.Pow(roster[0].Y - roster[1].Y, 2));
                            dynamic r = new ExpandoObject();
                            Ad.Slope = (Math.Abs((double)roster[1].X - roster[0].X) <= 0.0001) ? ((Func<dynamic>)(() => { r.IsSome = false; return r; }))() : ((Func<double, dynamic>)((v) => { r.IsSome = true; r.Value = v; return r; }))(((double)roster[1].Y - roster[0].Y) / ((double)roster[1].X - roster[0].X));
                            Bd.Type = "Line Segment";
                            Bd.P1 = roster[1];
                            Bd.P2 = roster[2];
                            Bd.Length = Math.Sqrt(Math.Pow(roster[1].X - roster[2].X, 2) + Math.Pow(roster[1].Y - roster[2].Y, 2));
                            dynamic r1 = new ExpandoObject();
                            Bd.Slope = (Math.Abs((double)roster[2].X - roster[1].X) <= 0.0001) ? ((Func<dynamic>)(() => { r1.IsSome = false; return r1; }))() : ((Func<double, dynamic>)(((v1) => { r1.IsSome = true; r1.Value = v1; return r1; })))(((double)roster[2].Y - roster[1].Y) / ((double)roster[2].X - roster[1].X));
                            Cd.Type = "Line Segment";
                            Cd.P1 = roster[2];
                            Cd.P2 = roster[3];
                            Cd.Length = Math.Sqrt(Math.Pow(roster[2].X - roster[3].X, 2) + Math.Pow(roster[2].Y - roster[3].Y, 2));
                            dynamic r3 = new ExpandoObject();
                            Cd.Slope = (Math.Abs((double)roster[3].X - roster[2].X) <= 0.0001) ? ((Func<dynamic>)(() => { r3.IsSome = false; return r3; }))() : ((Func<double, dynamic>)((v2) => { r3.IsSome = true; r3.Value = v2; return r3; }))(((double)roster[3].Y - roster[2].Y) / ((double)roster[3].X - roster[2].X));
                            D.Type = "Line Segment";
                            D.P1 = roster[3];
                            D.P2 = roster[0];
                            D.Length = Math.Sqrt(Math.Pow(roster[3].X - roster[0].X, 2) + Math.Pow(roster[3].Y - roster[0].Y, 2));
                            dynamic r5 = new ExpandoObject();
                            D.Slope = (Math.Abs((double)roster[0].X - roster[3].X) <= 0.0001) ? ((Func<dynamic>)(() => { r5.IsSome = false; return r5; }))() : ((Func<double, dynamic>)((v3) => { r5.IsSome = true; r5.Value = v3; return r5; }))(((double)roster[0].Y - roster[3].Y) / ((double)roster[0].X - roster[3].X));
                            ((dynamic)tack).SideA = Ad;
                            ((dynamic)tack).SideB = Bd;
                            ((dynamic)tack).SideC = Cd;
                            ((dynamic)tack).SideD = D;
                            ((dynamic)tack).Area = Ad.Length * Bd.Length;
                            ((dynamic)tack).Perimeter = Ad.Length + Bd.Length + Cd.Length + D.Length;
                        }
                        else
                        {
                            gs = gs(-4);
                            if (gs(MathHelper.no) < roster.Count && !(gs(MathHelper.no) == -1))
                            {
                                ((dynamic)tack).Type = "Other";

                                ((dynamic)tack).Points = roster;
                                ((dynamic)tack).IsClosed = ((Func<bool>)(() => { if (roster[0] == MathHelper.no && roster[^1] == MathHelper.no) { return true; } if (roster[0] == MathHelper.no || roster[^1] == MathHelper.no) { return false; } if ((IDictionary<string, dynamic>)roster[^1] != MathHelper.no && ((ICollection<KeyValuePair<string, dynamic>>)roster[0]).Count != ((IDictionary<string, dynamic>)roster[^1]).Count) return false; foreach (var pair in (ICollection<KeyValuePair<string, dynamic>>)roster[0]) { var o = MathHelper.no; if ((IDictionary<string, dynamic>)roster[^1] != MathHelper.no && !((IDictionary<string, dynamic>)roster[^1]).TryGetValue(pair.Key, out o)) return false; if (!Equals(o, pair.Value)) return false; } return true; }))();
                                ((dynamic)tack).IsOpen = !((Func<bool>)(() => { if (roster[0] == MathHelper.no && roster[^1] == MathHelper.no) { return true; } if (roster[0] == MathHelper.no || roster[^1] == MathHelper.no) { return false; } if ((IDictionary<string, dynamic>)roster[^1] != MathHelper.no && ((ICollection<KeyValuePair<string, dynamic>>)roster[0]).Count != ((IDictionary<string, dynamic>)roster[^1]).Count) return false; foreach (var pair1 in (ICollection<KeyValuePair<string, dynamic>>)roster[0]) { var o1 = MathHelper.no; if ((IDictionary<string, dynamic>)roster[^1] != MathHelper.no && !((IDictionary<string, dynamic>)roster[^1]).TryGetValue(pair1.Key, out o1)) return false; if (!Equals(o1, pair1.Value)) return false; } return true; }))();

                                var segments = new List<double>();

                                for (var i = 1; i < roster.Count; i++)
                                {
                                    dynamic side = new ExpandoObject();
                                    side.Type = "Line Segment";
                                    side.P1 = roster[i - 1];
                                    side.P2 = roster[i];
                                    side.Length = Math.Sqrt(Math.Pow(roster[i - 1].X - roster[i].X, 2) + Math.Pow(roster[i - 1].Y - roster[i].Y, 2));
                                    dynamic r = new ExpandoObject();
                                    side.Slope = (Math.Abs((double)roster[i].X - roster[i - 1].X) <= 0.0001) ? ((Func<dynamic>)(() => { r.IsSome = false; return r; }))() : ((Func<double, dynamic>)((v) => { r.IsSome = true; r.Value = v; return r; }))(((double)roster[i].Y - roster[i - 1].Y) / ((double)roster[i].X - roster[i - 1].X));
                                    segments.Add(side.Length);
                                }

                                ((dynamic)tack).Length = segments.Sum();
                            }
                        }
                    }
                }
            }

            return tack;
        }        
        
        internal static dynamic ExpectoPatronum(double x, double y)
        {
            dynamic result = new ExpandoObject();
            result.X = x;
            result.Y = y;
            result.Type = "Point";
            return result;
        }

        internal static dynamic[] Inanimatus(IEnumerable<(double x, double y)> coords)
        {
            return coords
                .Select(c => ExpectoPatronum(c.x, c.y))
                .ToArray();
        }
    }
}