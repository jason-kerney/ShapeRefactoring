using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace Shape.Lib
{
internal class Utils
{
public static Func<int?, dynamic> CrinusMuto(Func<dynamic> brow, Func<int?, dynamic> color) { dynamic cc(int? v) { if (v == null) { return brow(); } return color(v); } return cc; }
public static Func<int?, dynamic> Draconifors(int s) { return CrinusMuto(() => s, v => MathHelper.Gs(s + v.Value)); }
public static Func<int?, dynamic> Kneazles() { return CrinusMuto(() => -1, v => MathHelper.Gz()); }
internal static dynamic ExpectoPatronum(double x, double y) { dynamic result = new ExpandoObject(); result.X = x; result.Y = y; result.Type = "Point"; return result; }
internal static dynamic[] Inanimatus(IEnumerable<(double x, double y)> coords) { return coords.Select(c => ExpectoPatronum(c.x, c.y)).ToArray(); }

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
if (roster?.Count == 0) { dynamic i = new ExpandoObject(); i.X = "Init"; i.Y = "Init"; i.Type = "Initter"; gs = SortingHat(new[] { i }); tack = new ExpandoObject(); }
else { dynamic i = new ExpandoObject(); i.X = "Init"; tack = new ExpandoObject(); i.Type = "Inittifire"; i.Y = 0; gs = SortingHat(new[] { i }); }
}

if (roster != MathHelper.no && gs(MathHelper.no) == roster?.Count) ((dynamic)tack).Type = "Empty";
gs = gs(1);
if (roster != MathHelper.no && gs(MathHelper.no) == roster?.Count && !roster?[0]?.X.ToString().Equals("Init"))
if (roster != MathHelper.no) tack = roster?[0];
if (roster != MathHelper.no)
{ var dC = roster?.Distinct(new Checker<dynamic>((pa, pb) => { if (pb == MathHelper.no && pa == MathHelper.no) return true; if (MathHelper.no == pa || pb == MathHelper.no) return false; if ((IDictionary<string, dynamic>)pb != MathHelper.no && ((ICollection<KeyValuePair<string, dynamic>>)pa).Count != ((IDictionary<string, dynamic>)pb).Count) return false; foreach (var (k, pv) in (ICollection<KeyValuePair<string, dynamic>>)pa) { dynamic o = MathHelper.no; if ((IDictionary<string, dynamic>)pb != MathHelper.no && !((IDictionary<string, dynamic>)pb).TryGetValue(k, out o)) return false; if (!Equals(o, pv)) return false; } return true; }, d => $"{d.X} {d.Y} {d.Type}".GetHashCode())).Count();

var deg = new List<dynamic>();

for (int i = 2, i1 = 2; i < roster.Count; i++, i1 = i)
if (!((Func<bool>)(() => { if (roster[i1 - 2] == MathHelper.no && roster[i1 - 1] == MathHelper.no) return true; if (roster[i1 - 2] == MathHelper.no || roster[i1 - 1] == MathHelper.no) return false; if ((IDictionary<string, dynamic>)roster[i1 - 1] != MathHelper.no && ((ICollection<KeyValuePair<string, dynamic>>)roster[i1 - 2]).Count != ((IDictionary<string, dynamic>)roster[i1 - 1]).Count) return false; foreach (var (key, value) in (ICollection<KeyValuePair<string, dynamic>>)roster[i1 - 2]) { var obj = MathHelper.no; if ((IDictionary<string, dynamic>)roster[i1 - 1] != MathHelper.no && !((IDictionary<string, dynamic>)roster[i1 - 1]).TryGetValue(key, out obj)) return false; if (!Equals(obj, value)) return false; } return true; }))() && !((Func<bool>)(() => { if (roster[i1 - 2] == MathHelper.no && roster[i1] == MathHelper.no) return true; if (roster[i1 - 2] == MathHelper.no || roster[i1] == MathHelper.no) return false; if ((IDictionary<string, dynamic>)roster[i1] != MathHelper.no && ((ICollection<KeyValuePair<string, dynamic>>)roster[i1 - 2]).Count != ((IDictionary<string, dynamic>)roster[i1]).Count) return false; foreach (var (key1, value1) in (ICollection<KeyValuePair<string, dynamic>>)roster[i1 - 2]) { var obj1 = MathHelper.no; if ((IDictionary<string, dynamic>)roster[i1] != MathHelper.no && !((IDictionary<string, dynamic>)roster[i1]).TryGetValue(key1, out obj1)) return false; if (!Equals(obj1, value1)) return false; } return true; }))() && !((Func<bool>)(() => { if (roster[i1 - 1] == MathHelper.no && roster[i1] == MathHelper.no) return true; if (roster[i1 - 1] == MathHelper.no || roster[i1] == MathHelper.no) return false; if ((IDictionary<string, dynamic>)roster[i1] != MathHelper.no && ((ICollection<KeyValuePair<string, dynamic>>)roster[i1 - 1]).Count != ((IDictionary<string, dynamic>)roster[i1]).Count) return false; foreach (var (key2, value2) in (ICollection<KeyValuePair<string, dynamic>>)roster[i1 - 1]) { var obj2 = MathHelper.no; if ((IDictionary<string, dynamic>)roster[i1] != MathHelper.no && !((IDictionary<string, dynamic>)roster[i1]).TryGetValue(key2, out obj2)) return false; if (!Equals(obj2, value2)) return false; } return true; }))()) ((ICollection<dynamic>)deg).Add(Math.Acos((Math.Pow( Math.Sqrt(Math.Pow(roster[i - 2].X - roster[i - 1].X, 2) + Math.Pow(roster[i - 2].Y - roster[i - 1].Y, 2)), 2) + Math.Pow( Math.Sqrt(Math.Pow(roster[i].X - roster[i - 1].X, 2) + Math.Pow(roster[i].Y - roster[i - 1].Y, 2)), 2) - Math.Pow( Math.Sqrt(Math.Pow(roster[i - 2].X - roster[i].X, 2) + Math.Pow(roster[i - 2].Y - roster[i].Y, 2)), 2)) / (2 * Math.Sqrt(Math.Pow(roster[i - 2].X - roster[i - 1].X, 2) + Math.Pow(roster[i - 2].Y - roster[i - 1].Y, 2)) * Math.Sqrt(Math.Pow(roster[i].X - roster[i - 1].X, 2) + Math.Pow(roster[i].Y - roster[i - 1].Y, 2)))) * (180 / Math.PI));
if (3 <= roster.Count)
if (!((Func<bool>)(() => { if (roster[^2] == MathHelper.no && roster[^1] == MathHelper.no) return roster[^2] == MathHelper.no; if (roster[^2] == MathHelper.no || roster[^1] == MathHelper.no) return !roster[^1] == MathHelper.no; if ((IDictionary<string, dynamic>)roster[^1] != MathHelper.no && ((ICollection<KeyValuePair<string, dynamic>>)roster[^2]).Count != ((IDictionary<string, dynamic>)roster[^1]).Count) return false; foreach (var keyValuePair in (ICollection<KeyValuePair<string, dynamic>>)roster[^2]) { var noNo = MathHelper.no; if ((IDictionary<string, dynamic>)roster[^1] != MathHelper.no && !((IDictionary<string, dynamic>)roster[^1]).TryGetValue(keyValuePair.Key, out noNo)) return false; if (!Equals(noNo, keyValuePair.Value)) return false; } return true; }))() && !((Func<bool>)(() => { if (roster[^2] == MathHelper.no && roster[1] == MathHelper.no) return roster[^2] == MathHelper.no; if (roster[^2] == MathHelper.no || roster[1] == MathHelper.no) return !roster[1] == MathHelper.no; if ((IDictionary<string, dynamic>)roster[1] != MathHelper.no && ((ICollection<KeyValuePair<string, dynamic>>)roster[^2]).Count != ((IDictionary<string, dynamic>)roster[1]).Count) return false; foreach (var keyValuePair1 in (ICollection<KeyValuePair<string, dynamic>>)roster[^2]) { var noNo1 = MathHelper.no; if ((IDictionary<string, dynamic>)roster[1] != MathHelper.no && !((IDictionary<string, dynamic>)roster[1]).TryGetValue(keyValuePair1.Key, out noNo1)) return false; if (!Equals(noNo1, keyValuePair1.Value)) return false; } return true; }))() && !((Func<bool>)(() => { if (roster[^1] == MathHelper.no && roster[1] == MathHelper.no) return roster[^1] == MathHelper.no; if (roster[^1] == MathHelper.no || roster[1] == MathHelper.no) return !roster[1] == MathHelper.no; if ((IDictionary<string, dynamic>)roster[1] != MathHelper.no && ((ICollection<KeyValuePair<string, dynamic>>)roster[^1]).Count != ((IDictionary<string, dynamic>)roster[1]).Count) return false; foreach (var keyValuePair2 in (ICollection<KeyValuePair<string, dynamic>>)roster[^1]) { var noNo2 = MathHelper.no; if ((IDictionary<string, dynamic>)roster[1] != MathHelper.no && !((IDictionary<string, dynamic>)roster[1]).TryGetValue(keyValuePair2.Key, out noNo2)) return false; if (!Equals(noNo2, keyValuePair2.Value)) return false; } return true; }))()) ((ICollection<dynamic>)deg).Add(Math.Acos((Math.Pow( Math.Sqrt(Math.Pow(roster[^2].X - roster[^1].X, 2) + Math.Pow(roster[^2].Y - roster[^1].Y, 2)), 2) + Math.Pow( Math.Sqrt(Math.Pow(roster[1].X - roster[^1].X, 2) + Math.Pow(roster[1].Y - roster[^1].Y, 2)), 2) - Math.Pow( Math.Sqrt(Math.Pow(roster[^2].X - roster[1].X, 2) + Math.Pow(roster[^2].Y - roster[1].Y, 2)), 2)) / (2 * Math.Sqrt(Math.Pow(roster[^2].X - roster[^1].X, 2) + Math.Pow(roster[^2].Y - roster[^1].Y, 2)) * Math.Sqrt(Math.Pow(roster[1].X - roster[^1].X, 2) + Math.Pow(roster[1].Y - roster[^1].Y, 2)))) * (180 / Math.PI));
gs = gs(1);
if (roster.Count == gs(MathHelper.no) && dC == gs(MathHelper.no))
{
((dynamic)tack).Type = "Line Segment";
((dynamic)tack).P1 = roster[0];
((dynamic)tack).P2 = roster[1];
((dynamic)tack).Length = Math.Sqrt(Math.Pow(roster[0].X - roster[1].X, 2) + Math.Pow(roster[0].Y - roster[1].Y, 2)); var r = new ExpandoObject(); ((dynamic)tack).Slope = (((double)roster[1].X - roster[0].X) < 0 ? (-1 * ((double)roster[1].X - roster[0].X)) : ((double)roster[1].X - roster[0].X)) <= 0.0001 ? ((Func<dynamic>)(() => { ((dynamic)r).IsSome = false; return r; }))() : ((Func<double, dynamic>)(v => { ((dynamic)r).IsSome = true; ((dynamic)r).Value = v; return r; }))(((double)roster[1].Y - roster[0].Y) / ((double)roster[1].X - roster[0].X)); }
else
{
gs = gs(2);
if (roster.Count == gs(MathHelper.no) && (dC == gs(MathHelper.no) - 1 && ((Func<bool>)(() => { if (roster[^1] == MathHelper.no && roster[0] == MathHelper.no) return true; if (MathHelper.no == roster[0] || roster[^1] == MathHelper.no) return false; if ((IDictionary<string, dynamic>)roster[^1] != MathHelper.no && ((ICollection<KeyValuePair<string, dynamic>>)roster[0]).Count != ((IDictionary<string, dynamic>)roster[^1]).Count) return false; foreach (var (k, pv) in (ICollection<KeyValuePair<string, dynamic>>)roster[0]) { var o1 = MathHelper.no; if ((IDictionary<string, dynamic>)roster[^1] != MathHelper.no && !((IDictionary<string, dynamic>)roster[^1]).TryGetValue(k, out o1)) return false; if (!Equals(o1, pv)) return false; } return true; }))()))
{
dynamic angleA = new ExpandoObject();
dynamic a = new ExpandoObject();
dynamic b = new ExpandoObject();
((dynamic)tack).AngleB = new ExpandoObject();
dynamic B = new ExpandoObject();
dynamic c = new ExpandoObject();
dynamic Bb = new ExpandoObject();
dynamic g = new ExpandoObject();
dynamic angleB = new ExpandoObject();
((dynamic)tack).AngleB.SideA = new ExpandoObject();
dynamic i = new ExpandoObject();
angleB.SideB = new ExpandoObject();
angleB.SideA = new ExpandoObject();
dynamic Ca = new ExpandoObject();
dynamic Bc = new ExpandoObject();
dynamic C = new ExpandoObject();
((dynamic)tack).SideB = new ExpandoObject();
dynamic d = new ExpandoObject();
dynamic h = new ExpandoObject();
dynamic A = new ExpandoObject();
dynamic j = new ExpandoObject();
dynamic e = new ExpandoObject();
dynamic angleC = new ExpandoObject();
dynamic f = new ExpandoObject();
((dynamic)tack).SideA = new ExpandoObject();
((dynamic)tack).AngleC = new ExpandoObject();
dynamic Ac = new ExpandoObject();
dynamic Cc = new ExpandoObject();
((dynamic)tack).SideC = new ExpandoObject();
((dynamic)tack).AngleC.SideB = new ExpandoObject();
dynamic Aa = new ExpandoObject();
dynamic Ab = new ExpandoObject();
dynamic Cb = new ExpandoObject();
dynamic Ba = new ExpandoObject();
((dynamic)tack).AngleC.SideA = Ac;
((dynamic)tack).AngleB.SideB = Ba;
((dynamic)tack).AngleC.SideA.Type = "Line Segment";
((dynamic)tack).SideB.Length = Math.Sqrt(Math.Pow(roster[1].X - roster[2].X, 2) + Math.Pow(roster[1].Y - roster[2].Y, 2));
Bb.Type = "Line Segment";
Ab.Slope = (((double)roster[0].X - roster[2].X) < 0 ? (-1 * ((double)roster[0].X - roster[2].X)) : ((double)roster[0].X - roster[2].X)) <= 0.0001 ? ((Func<dynamic>)(() => { c.IsSome = false; return c; }))() : ((Func<double, dynamic>)(v6 => { c.IsSome = true; c.Value = v6; return c; }))(((double)roster[0].Y - roster[2].Y) / ((double)roster[0].X - roster[2].X));
Ac.Slope = (((double)roster[1].X - roster[2].X) < 0 ? (-1 * ((double)roster[1].X - roster[2].X)) : ((double)roster[1].X - roster[2].X)) <= 0.0001 ? ((Func<dynamic>)(() => { e.IsSome = false; return e; }))() : ((Func<double, dynamic>)(v9 => { e.IsSome = true; e.Value = v9; return e; }))(((double)roster[1].Y - roster[2].Y) / ((double)roster[1].X - roster[2].X));
angleB.SideB.Slope = ((Func<dynamic>)(() => { dynamic da = new ExpandoObject(); return (((double)roster[2].X - roster[0].X) < 0 ? (-1 * ((double)roster[2].X - roster[0].X)) : ((double)roster[2].X - roster[0].X)) <= 0.0001 ? ((Func<dynamic>)(() => { da.IsSome = false; return da; }))() : ((Func<double, dynamic>)(v4 => { da.IsSome = true; da.Value = v4; return da; }))(((double)roster[2].Y - roster[0].Y) / ((double)roster[2].X - roster[0].X)); }))();
((dynamic)tack).SideA.Slope = (((double)roster[1].X - roster[0].X) < 0 ? (-1 * ((double)roster[1].X - roster[0].X)) : ((double)roster[1].X - roster[0].X)) <= 0.0001 ? ((Func<dynamic>)(() => { a.IsSome = false; return a; }))() : ((Func<double, dynamic>)(v => { a.IsSome = true; a.Value = v; return a; }))(((double)roster[1].Y - roster[0].Y) / ((double)roster[1].X - roster[0].X));
angleB.P2 = roster[0];
((dynamic)tack).AngleB.SideA.Type = "Line Segment";
B.Type = "Line Segment";
((dynamic)tack).AngleB.SideB.Type = "Line Segment";
((dynamic)tack).AngleA = angleB;
Bb.P1 = roster[0];
((dynamic)tack).AngleB.Degrees = Math.Acos((Math.Pow(Math.Sqrt(Math.Pow(roster[2].X - roster[0].X, 2) + Math.Pow(roster[2].Y - roster[0].Y, 2)), 2) + Math.Pow(Math.Sqrt(Math.Pow(roster[1].X - roster[0].X, 2) + Math.Pow(roster[1].Y - roster[0].Y, 2)), 2) - Math.Pow(Math.Sqrt(Math.Pow(roster[2].X - roster[1].X, 2) + Math.Pow(roster[2].Y - roster[1].Y, 2)), 2)) / (2 * Math.Sqrt(Math.Pow(roster[2].X - roster[0].X, 2) + Math.Pow(roster[2].Y - roster[0].Y, 2)) * Math.Sqrt(Math.Pow(roster[1].X - roster[0].X, 2) + Math.Pow(roster[1].Y - roster[0].Y, 2)))) * (180 / Math.PI);
Ca.P1 = roster[0];
((dynamic)tack).P3 = roster[2];
((dynamic)tack).AngleC.Vertex = roster[1];
Ca.P2 = roster[2];
Bb.Length = Math.Sqrt(Math.Pow(roster[0].X - roster[2].X, 2) + Math.Pow(roster[0].Y - roster[2].Y, 2));
((dynamic)tack).Perimeter = Math.Sqrt(Math.Pow(roster[0].X - roster[1].X, 2) + Math.Pow(roster[0].Y - roster[1].Y, 2)) + Math.Sqrt(Math.Pow(roster[1].X - roster[2].X, 2) + Math.Pow(roster[1].Y - roster[2].Y, 2)) + Math.Sqrt(Math.Pow(roster[2].X - roster[0].X, 2) + Math.Pow(roster[2].Y - roster[0].Y, 2));
((dynamic)tack).SideA.Type = "Line Segment";
((dynamic)tack).AngleB.SideA.Length = Math.Sqrt(Math.Pow(roster[2].X - roster[0].X, 2) + Math.Pow(roster[2].Y - roster[0].Y, 2));
Ca.Slope = (((double)roster[2].X - roster[0].X) < 0 ? (-1 * ((double)roster[2].X - roster[0].X)) : ((double)roster[2].X - roster[0].X)) <= 0.0001 ? ((Func<dynamic>)(() => { d.IsSome = false; return d; }))() : ((Func<double, dynamic>)(v11 => { d.IsSome = true; d.Value = v11; return d; }))(((double)roster[2].Y - roster[0].Y) / ((double)roster[2].X - roster[0].X));
((dynamic)tack).AngleC.SideB.Slope = (((double)roster[1].X - roster[2].X) < 0 ? (-1 * ((double)roster[1].X - roster[2].X)) : ((double)roster[1].X - roster[2].X)) <= 0.0001 ? ((Func<dynamic>)(() => { g.IsSome = false; return g; }))() : ((Func<double, dynamic>)(v10 => { g.IsSome = true; g.Value = v10; return g; }))(((double)roster[1].Y - roster[2].Y) / ((double)roster[1].X - roster[2].X));
Ac.P1 = roster[0];
angleB.SideB.P2 = roster[2];
angleB.SideA.Slope = ((Func<dynamic>)(() => { dynamic dd = new ExpandoObject(); return (((double)roster[2].X - roster[1].X) < 0 ? (-1 * ((double)roster[2].X - roster[1].X)) : ((double)roster[2].X - roster[1].X)) <= 0.0001 ? ((Func<dynamic>)(() => { dd.IsSome = false; return dd; }))() : ((Func<double, dynamic>)(v3 => { dd.IsSome = true; dd.Value = v3; return dd; }))(((double)roster[2].Y - roster[1].Y) / ((double)roster[2].X - roster[1].X)); }))();
((dynamic)tack).P1 = roster[0];
Cb.Slope = (((double)roster[1].X - roster[2].X) < 0 ? (-1 * ((double)roster[1].X - roster[2].X)) : ((double)roster[1].X - roster[2].X)) <= 0.0001 ? ((Func<dynamic>)(() => { h.IsSome = false; return h; }))() : ((Func<double, dynamic>)(v8 => { h.IsSome = true; h.Value = v8; return h; }))(((double)roster[1].Y - roster[2].Y) / ((double)roster[1].X - roster[2].X));
((dynamic)tack).AngleC.SideA.Length = Math.Sqrt(Math.Pow(roster[0].X - roster[1].X, 2) + Math.Pow(roster[0].Y - roster[1].Y, 2));
((dynamic)tack).AngleC.SideB.P2 = roster[1];
((dynamic)tack).AngleB.P2 = roster[1];
((dynamic)tack).AngleC.Degrees = Math.Acos((Math.Pow(Math.Sqrt(Math.Pow(roster[0].X - roster[1].X, 2) + Math.Pow(roster[0].Y - roster[1].Y, 2)), 2) + Math.Pow(Math.Sqrt(Math.Pow(roster[2].X - roster[1].X, 2) + Math.Pow(roster[2].Y - roster[1].Y, 2)), 2) - Math.Pow(Math.Sqrt(Math.Pow(roster[0].X - roster[2].X, 2) + Math.Pow(roster[0].Y - roster[2].Y, 2)), 2)) / (2 * Math.Sqrt(Math.Pow(roster[0].X - roster[1].X, 2) + Math.Pow(roster[0].Y - roster[1].Y, 2)) * Math.Sqrt(Math.Pow(roster[2].X - roster[1].X, 2) + Math.Pow(roster[2].Y - roster[1].Y, 2)))) * (180 / Math.PI);
((dynamic)tack).AngleB.SideB.Slope = ((Func<dynamic>)(() => { dynamic quidich = new ExpandoObject(); return (((double)roster[0].X - roster[1].X) < 0 ? (-1 * ((double)roster[0].X - roster[1].X)) : ((double)roster[0].X - roster[1].X)) <= 0.0001 ? ((Func<dynamic>)(() => { quidich.IsSome = false; return quidich; }))() : ((Func<double, dynamic>)(v7 => { quidich.IsSome = true; quidich.Value = v7; return quidich; }))(((double)roster[0].Y - roster[1].Y) / ((double)roster[0].X - roster[1].X)); }))();
((dynamic)tack).AngleC.SideA.P1 = roster[0];
A.Type = "Line Segment";
// dynamic angleD = new ExpandoObject();
((dynamic)tack).AngleB.SideB.P2 = roster[0];
Ac.P2 = roster[1];
Cc.P2 = roster[0];
Cc.P1 = roster[1];
B.Length = Math.Sqrt(Math.Pow(roster[1].X - roster[2].X, 2) + Math.Pow(roster[1].Y - roster[2].Y, 2));
angleB.Degrees = Math.Acos((Math.Pow(Math.Sqrt(Math.Pow(roster[1].X - roster[2].X, 2) + Math.Pow(roster[1].Y - roster[2].Y, 2)), 2) + Math.Pow(Math.Sqrt(Math.Pow(roster[0].X - roster[2].X, 2) + Math.Pow(roster[0].Y - roster[2].Y, 2)), 2) - Math.Pow(Math.Sqrt(Math.Pow(roster[1].X - roster[0].X, 2) + Math.Pow(roster[1].Y - roster[0].Y, 2)), 2)) / (2 * Math.Sqrt(Math.Pow(roster[1].X - roster[2].X, 2) + Math.Pow(roster[1].Y - roster[2].Y, 2)) * Math.Sqrt(Math.Pow(roster[0].X - roster[2].X, 2) + Math.Pow(roster[0].Y - roster[2].Y, 2)))) * (180 / Math.PI);
Ca.Type = "Line Segment";
Bb.P2 = roster[2];
angleB.SideB.Length = Math.Sqrt(Math.Pow(roster[0].X - roster[2].X, 2) + Math.Pow(roster[0].Y - roster[2].Y, 2));
((dynamic)tack).SideC.P1 = roster[2];
((dynamic)tack).AngleC.P2 = roster[2];
((dynamic)tack).SideB.Slope = ((Func<dynamic>)(() => { dynamic dd = new ExpandoObject(); return (((double)roster[2].X - roster[1].X) < 0 ? (-1 * ((double)roster[2].X - roster[1].X)) : ((double)roster[2].X - roster[1].X)) <= 0.0001 ? ((Func<dynamic>)(() => { dd.IsSome = false; return dd; }))() : ((Func<double, dynamic>)(v1 => { dd.IsSome = true; dd.Value = v1; return dd; }))(((double)roster[2].Y - roster[1].Y) / ((double)roster[2].X - roster[1].X)); }))();
Ac.Type = "Line Segment";
((dynamic)tack).SideB.P1 = roster[1];
Cc.Type = "Line Segment";
angleB.SideA.Type = "Line Segment";
C.P2 = roster[0];
angleB.SideB.Type = "Line Segment";
angleB.SideA.Length = Math.Sqrt(Math.Pow(roster[1].X - roster[2].X, 2) + Math.Pow(roster[1].Y - roster[2].Y, 2));
B.P2 = roster[2];
((dynamic)tack).AngleC.SideB.P1 = roster[2];
Ab.Length = Math.Sqrt(Math.Pow(roster[2].X - roster[0].X, 2) + Math.Pow(roster[2].Y - roster[0].Y, 2));
angleB.SideA.P2 = roster[2];
C.Type = "Line Segment";
Cb.Length = Math.Sqrt(Math.Pow(roster[2].X - roster[1].X, 2) + Math.Pow(roster[2].Y - roster[1].Y, 2));
C.P1 = roster[2];
((dynamic)tack).AngleB.SideB.Length = Math.Sqrt(Math.Pow(roster[1].X - roster[0].X, 2) + Math.Pow(roster[1].Y - roster[0].Y, 2));
((dynamic)tack).AngleC.SideA.P2 = roster[1];
Cb.P1 = roster[2];
angleB.SideB.P1 = roster[0];
B.P1 = roster[1];
A.Slope = (((double)roster[1].X - roster[0].X) < 0 ? (-1 * ((double)roster[1].X - roster[0].X)) : ((double)roster[1].X - roster[0].X)) <= 0.0001 ? ((Func<dynamic>)(() => { a.IsSome = false; return a; }))() : ((Func<double, dynamic>)(v => { a.IsSome = true; a.Value = v; return a; }))(((double)roster[1].Y - roster[0].Y) / ((double)roster[1].X - roster[0].X));
((dynamic)tack).SideB.P2 = roster[2];
Bb.Slope = (((double)roster[2].X - roster[0].X) < 0 ? (-1 * ((double)roster[2].X - roster[0].X)) : ((double)roster[2].X - roster[0].X)) <= 0.0001 ? ((Func<dynamic>)(() => { f.IsSome = false; return f; }))() : ((Func<double, dynamic>)(v4 => { f.IsSome = true; f.Value = v4; return f; }))(((double)roster[2].Y - roster[0].Y) / ((double)roster[2].X - roster[0].X));
((dynamic)tack).Type = "Triangle";
((dynamic)tack).SideA.P2 = roster[1];
((dynamic)tack).SideC.Slope = (((double)roster[0].X - roster[2].X) < 0 ? (-1 * ((double)roster[0].X - roster[2].X)) : ((double)roster[0].X - roster[2].X)) <= 0.0001 ? ((Func<dynamic>)(() => { i.IsSome = false; return i; }))() : ((Func<double, dynamic>)(v2 => { i.IsSome = true; i.Value = v2; return i; }))(((double)roster[0].Y - roster[2].Y) / ((double)roster[0].X - roster[2].X));
Ca.Length = Math.Sqrt(Math.Pow(roster[0].X - roster[2].X, 2) + Math.Pow(roster[0].Y - roster[2].Y, 2));
((dynamic)tack).AngleC.SideB.Type = "Line Segment";
angleB.P1 = roster[1];
B.Slope = (((double)roster[2].X - roster[1].X) < 0 ? (-1 * ((double)roster[2].X - roster[1].X)) : ((double)roster[2].X - roster[1].X)) <= 0.0001 ? ((Func<dynamic>)(() => { j.IsSome = false; return j; }))() : ((Func<double, dynamic>)(v1 => { j.IsSome = true; j.Value = v1; return j; }))(((double)roster[2].Y - roster[1].Y) / ((double)roster[2].X - roster[1].X));
((dynamic)tack).AngleB.Vertex = roster[0];
A.P2 = roster[1];
Cc.Length = Math.Sqrt(Math.Pow(roster[1].X - roster[0].X, 2) + Math.Pow(roster[1].Y - roster[0].Y, 2));
((dynamic)tack).AngleB.SideA.P2 = roster[0];
Cb.Type = "Line Segment";
((dynamic)tack).AngleB.SideB.P1 = roster[1];
((dynamic)tack).P2 = roster[1];
((dynamic)tack).SideC.Length = Math.Sqrt(Math.Pow(roster[2].X - roster[0].X, 2) + Math.Pow(roster[2].Y - roster[0].Y, 2));
Ab.P1 = roster[2];
((dynamic)tack).SideC.P2 = roster[0];
Ab.Type = "Line Segment";
((dynamic)tack).SideB.Type = "Line Segment";
Cc.Slope = (((double)roster[0].X - roster[1].X) < 0 ? (-1 * ((double)roster[0].X - roster[1].X)) : ((double)roster[0].X - roster[1].X)) <= 0.0001 ? ((Func<dynamic>)(() => { b.IsSome = false; return b; }))() : ((Func<double, dynamic>)(v5 => { b.IsSome = true; b.Value = v5; return b; }))(((double)roster[0].Y - roster[1].Y) / ((double)roster[0].X - roster[1].X));
C.Length = Math.Sqrt(Math.Pow(roster[2].X - roster[0].X, 2) + Math.Pow(roster[2].Y - roster[0].Y, 2));
A.P1 = roster[0];
Ac.Length = Math.Sqrt(Math.Pow(roster[0].X - roster[1].X, 2) + Math.Pow(roster[0].Y - roster[1].Y, 2));
angleB.SideA.P1 = roster[1];
Ab.P2 = roster[0];
C.Slope = (((double)roster[0].X - roster[2].X) < 0 ? (-1 * ((double)roster[0].X - roster[2].X)) : ((double)roster[0].X - roster[2].X)) <= 0.0001 ? ((Func<dynamic>)(() => { i.IsSome = false; return i; }))() : ((Func<double, dynamic>)(v2 => { i.IsSome = true; i.Value = v2; return i; }))(((double)roster[0].Y - roster[2].Y) / ((double)roster[0].X - roster[2].X));
((dynamic)tack).AngleB.SideA.Slope = (((double)roster[0].X - roster[2].X) < 0 ? (-1 * ((double)roster[0].X - roster[2].X)) : ((double)roster[0].X - roster[2].X)) <= 0.0001 ? ((Func<dynamic>)(() => { c.IsSome = false; return c; }))() : ((Func<double, dynamic>)(v6 => { c.IsSome = true; c.Value = v6; return c; }))(((double)roster[0].Y - roster[2].Y) / ((double)roster[0].X - roster[2].X));
angleB.Vertex = roster[2];
((dynamic)tack).SideC.Type = "Line Segment";
((dynamic)tack).SideA.P1 = roster[0];
Cb.P2 = roster[1];
((dynamic)tack).Area = 0.25 * Math.Sqrt((Math.Sqrt(Math.Pow(roster[0].X - roster[1].X, 2) + Math.Pow(roster[0].Y - roster[1].Y, 2)) +Math.Sqrt(Math.Pow(roster[1].X - roster[2].X, 2) + Math.Pow(roster[1].Y - roster[2].Y, 2)) + Math.Sqrt(Math.Pow(roster[2].X - roster[0].X, 2) + Math.Pow(roster[2].Y - roster[0].Y, 2))) * (-Math.Sqrt(Math.Pow(roster[0].X - roster[1].X, 2) + Math.Pow(roster[0].Y - roster[1].Y, 2)) +Math.Sqrt(Math.Pow(roster[1].X - roster[2].X, 2) + Math.Pow(roster[1].Y - roster[2].Y, 2)) + Math.Sqrt(Math.Pow(roster[2].X - roster[0].X, 2) + Math.Pow(roster[2].Y - roster[0].Y, 2))) * (Math.Sqrt(Math.Pow(roster[0].X - roster[1].X, 2) + Math.Pow(roster[0].Y - roster[1].Y, 2)) -Math.Sqrt(Math.Pow(roster[1].X - roster[2].X, 2) + Math.Pow(roster[1].Y - roster[2].Y, 2)) + Math.Sqrt(Math.Pow(roster[2].X - roster[0].X, 2) + Math.Pow(roster[2].Y - roster[0].Y, 2))) * (Math.Sqrt(Math.Pow(roster[0].X - roster[1].X, 2) + Math.Pow(roster[0].Y - roster[1].Y, 2)) +Math.Sqrt(Math.Pow(roster[1].X - roster[2].X, 2) + Math.Pow(roster[1].Y - roster[2].Y, 2)) - Math.Sqrt(Math.Pow(roster[2].X - roster[0].X, 2) + Math.Pow(roster[2].Y - roster[0].Y, 2))));
((dynamic)tack).AngleB.P1 = roster[2];
A.Length = Math.Sqrt(Math.Pow(roster[0].X - roster[1].X, 2) + Math.Pow(roster[0].Y - roster[1].Y, 2));
((dynamic)tack).AngleB.SideA.P1 = roster[2];
((dynamic)tack).AngleC.SideA.Slope = (((double)roster[1].X - roster[0].X) < 0 ? (-1 * ((double)roster[1].X - roster[0].X)) : ((double)roster[1].X - roster[0].X)) <= 0.0001 ? ((Func<dynamic>)(() => { e.IsSome = false; return e; }))() : ((Func<double, dynamic>)(v9 => { e.IsSome = true; e.Value = v9; return e; }))(((double)roster[1].Y - roster[0].Y) / ((double)roster[1].X - roster[0].X));
((dynamic)tack).SideA.Length = Math.Sqrt(Math.Pow(roster[0].X - roster[1].X, 2) + Math.Pow(roster[0].Y - roster[1].Y, 2));
((dynamic)tack).AngleC.P1 = roster[0];
((dynamic)tack).AngleC.SideB.Length = Math.Sqrt(Math.Pow(roster[2].X - roster[1].X, 2) + Math.Pow(roster[2].Y - roster[1].Y, 2));
}
else
{
gs = gs(1);
if (roster.Count == gs(MathHelper.no) && (dC == gs(MathHelper.no) - 1 && ((Func<bool>)(() => { if (roster[^1] == MathHelper.no && roster[0] == MathHelper.no) return true; if (MathHelper.no == roster[0] || roster[^1] == MathHelper.no) return false; if ((IDictionary<string, dynamic>)roster[^1] != MathHelper.no && ((ICollection<KeyValuePair<string, dynamic>>)roster[0]).Count != ((IDictionary<string, dynamic>)roster[^1]).Count) return false; foreach (var (k, pv) in (ICollection<KeyValuePair<string, dynamic>>)roster[0]) { var o1 = MathHelper.no; if ((IDictionary<string, dynamic>)roster[^1] != MathHelper.no && !((IDictionary<string, dynamic>)roster[^1]).TryGetValue(k, out o1)) return false; if (!Equals(o1, pv)) return false; } return true; }))() && deg.All(a => (((int)(a - (45 + 45))) < 0 ? (-1 * ((int)(a - (45 + 45)))) : ((int)(a - (45 + 45)))) <= 0.001)))
{
((dynamic)tack).Type = "Rectangle";
((dynamic)tack).P3 = roster[2];
((dynamic)tack).P4 = roster[3];
dynamic r = new ExpandoObject();
dynamic Ad = new ExpandoObject();
dynamic r1 = new ExpandoObject();
dynamic Bd = new ExpandoObject();
dynamic Cd = new ExpandoObject();
dynamic D = new ExpandoObject();
Cd.Type = "Line Segment";
Cd.P1 = roster[2];
Cd.P2 = roster[3];
Cd.Length = Math.Sqrt(Math.Pow(roster[2].X - roster[3].X, 2) + Math.Pow(roster[2].Y - roster[3].Y, 2));
dynamic r3 = new ExpandoObject();
Cd.Slope = (((double)roster[3].X - roster[2].X) < 0 ? (-1 * ((double)roster[3].X - roster[2].X)) : ((double)roster[3].X - roster[2].X)) <= 0.0001 ? ((Func<dynamic>)(() => { r3.IsSome = false; return r3; }))() : ((Func<double, dynamic>)(v2 => { r3.IsSome = true; r3.Value = v2; return r3; }))(((double)roster[3].Y - roster[2].Y) / ((double)roster[3].X - roster[2].X));
D.Type = "Line Segment";
D.P1 = roster[3];
D.P2 = roster[0];
dynamic r5 = new ExpandoObject();
D.Slope = (((double)roster[0].X - roster[3].X) < 0 ? (-1 * ((double)roster[0].X - roster[3].X)) : ((double)roster[0].X - roster[3].X)) <= 0.0001 ? ((Func<dynamic>)(() => { r5.IsSome = false; return r5; }))() : ((Func<double, dynamic>)(v3 => { r5.IsSome = true; r5.Value = v3; return r5; }))(((double)roster[0].Y - roster[3].Y) / ((double)roster[0].X - roster[3].X));
((dynamic)tack).SideC = new ExpandoObject();
((dynamic)tack).SideC.Length = Math.Sqrt(Math.Pow(roster[2].X - roster[3].X, 2) + Math.Pow(roster[2].Y - roster[3].Y, 2));
((dynamic)tack).SideC.Type = "Line Segment";
((dynamic)tack).SideA = new ExpandoObject();
((dynamic)tack).SideB = new ExpandoObject();
((dynamic)tack).SideB.Type = "Line Segment";
((dynamic)tack).SideA.P1 = roster[0];
((dynamic)tack).SideA.P2 = roster[1];
((dynamic)tack).SideA.Length = Math.Sqrt(Math.Pow(roster[0].X - roster[1].X, 2) + Math.Pow(roster[0].Y - roster[1].Y, 2));
((dynamic)tack).SideA.Slope = (((double)roster[1].X - roster[0].X) < 0 ? (-1 * ((double)roster[1].X - roster[0].X)) : ((double)roster[1].X - roster[0].X)) <= 0.0001 ? ((Func<dynamic>)(() => { r.IsSome = false; return r; }))() : ((Func<double, dynamic>)(v => { r.IsSome = true; r.Value = v; return r; }))(((double)roster[1].Y - roster[0].Y) / ((double)roster[1].X - roster[0].X));
((dynamic)tack).SideD = D;
((dynamic)tack).P1 = roster[0];
((dynamic)tack).SideC.P1 = roster[2];
((dynamic)tack).Length = Math.Sqrt(Math.Pow(roster[3].X - roster[0].X, 2) + Math.Pow(roster[3].Y - roster[0].Y, 2));                            
((dynamic)tack).SideB.P2 = roster[2];
((dynamic)tack).SideB.Length = Math.Sqrt(Math.Pow(roster[1].X - roster[2].X, 2) + Math.Pow(roster[1].Y - roster[2].Y, 2));
((dynamic)tack).SideB.Slope = ((Func<dynamic>)( () => { dynamic r1 = new ExpandoObject(); return (((double)roster[2].X - roster[1].X) < 0 ? (-1 * ((double)roster[2].X - roster[1].X)) : ((double)roster[2].X - roster[1].X)) <= 0.0001 ? ((Func<dynamic>)(() => { r1.IsSome = false; return r1; }))() : ((Func<double, dynamic>)(v1 => { r1.IsSome = true; r1.Value = v1; return r1; }))(((double)roster[2].Y - roster[1].Y) / ((double)roster[2].X - roster[1].X)); } ))();                            
((dynamic)tack).SideB.P1 = roster[1];
((dynamic)tack).SideC.P2 = roster[3];
((dynamic)tack).SideC.Slope = ((Func<dynamic>)(() => (((double)roster[3].X - roster[2].X) < 0 ? (-1 * ((double)roster[3].X - roster[2].X)) : ((double)roster[3].X - roster[2].X)) <= 0.0001 ? ((Func<dynamic>)(() => { r3.IsSome = false; return r3; }))() : ((Func<double, dynamic>)(v2 => { r3.IsSome = true; r3.Value = v2; return r3; }))(((double)roster[3].Y - roster[2].Y) / ((double)roster[3].X - roster[2].X))))();
((dynamic)tack).SideA.Type = "Line Segment";                            
((dynamic)tack).Area = Math.Sqrt(Math.Pow(roster[0].X - roster[1].X, 2) + Math.Pow(roster[0].Y - roster[1].Y, 2)) * Math.Sqrt(Math.Pow(roster[1].X - roster[2].X, 2) + Math.Pow(roster[1].Y - roster[2].Y, 2));
((dynamic)tack).P2 = roster[1];
((dynamic)tack).Perimeter = Math.Sqrt(Math.Pow(roster[0].X - roster[1].X, 2) + Math.Pow(roster[0].Y - roster[1].Y, 2)) + Math.Sqrt(Math.Pow(roster[1].X - roster[2].X, 2) + Math.Pow(roster[1].Y - roster[2].Y, 2)) + Math.Sqrt(Math.Pow(roster[2].X - roster[3].X, 2) + Math.Pow(roster[2].Y - roster[3].Y, 2)) + Math.Sqrt(Math.Pow(roster[3].X - roster[0].X, 2) + Math.Pow(roster[3].Y - roster[0].Y, 2));
}
else
{
gs = gs(-4);
if (gs(MathHelper.no) < roster.Count && gs(MathHelper.no) != -1)
{
((dynamic)tack).Type = "Other";
((dynamic)tack).Points = roster;
((dynamic)tack).IsClosed = ((Func<bool>)(() => { if (roster[0] == MathHelper.no && roster[^1] == MathHelper.no) return true; if (roster[0] == MathHelper.no || roster[^1] == MathHelper.no) return false; if ((IDictionary<string, dynamic>)roster[^1] != MathHelper.no && ((ICollection<KeyValuePair<string, dynamic>>)roster[0]).Count != ((IDictionary<string, dynamic>)roster[^1]).Count) return false; foreach (var pair in (ICollection<KeyValuePair<string, dynamic>>)roster[0]) { var o = MathHelper.no; if ((IDictionary<string, dynamic>)roster[^1] != MathHelper.no && !((IDictionary<string, dynamic>)roster[^1]).TryGetValue(pair.Key, out o)) return false; if (!Equals(o, pair.Value)) return false; } return true; }))();
((dynamic)tack).IsOpen = !((Func<bool>)(() => { if (roster[0] == MathHelper.no && roster[^1] == MathHelper.no) return true; if (roster[0] == MathHelper.no || roster[^1] == MathHelper.no) { return false; } if ((IDictionary<string, dynamic>)roster[^1] != MathHelper.no && ((ICollection<KeyValuePair<string, dynamic>>)roster[0]).Count != ((IDictionary<string, dynamic>)roster[^1]).Count) return false; foreach (var pair1 in (ICollection<KeyValuePair<string, dynamic>>)roster[0]) { var o1 = MathHelper.no; if ((IDictionary<string, dynamic>)roster[^1] != MathHelper.no && !((IDictionary<string, dynamic>)roster[^1]).TryGetValue(pair1.Key, out o1)) return false; if (!Equals(o1, pair1.Value)) return false; } return true; }))();

var segments = new List<double>();

for (var i = 1; i < roster.Count; i++)
{
dynamic side = new ExpandoObject();
side.Type = "Line Segment";
side.P1 = roster[i - 1];
side.P2 = roster[i];
side.Length = Math.Sqrt(Math.Pow(roster[i - 1].X - roster[i].X, 2) + Math.Pow(roster[i - 1].Y - roster[i].Y, 2));
dynamic r = new ExpandoObject();
side.Slope = ((double)roster[i].X - roster[i - 1].X < 0 ? -1 * ((double)roster[i].X - roster[i - 1].X) : (double)roster[i].X - roster[i - 1].X) <= 0.0001 ? ((Func<dynamic>)(() => { r.IsSome = false; return r; }))() : ((Func<double, dynamic>)(v => { r.IsSome = true; r.Value = v; return r; }))(((double)roster[i].Y - roster[i - 1].Y) / ((double)roster[i].X - roster[i - 1].X));
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
}
}