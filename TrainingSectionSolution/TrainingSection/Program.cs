using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Model.Core;
using Model.Data;

namespace TrainingSection;

static class Program
{
    public static List<Trainer> Trainers = [];
    public static List<Model.Core.Group> Groups = [];
    public static AbstractSerializer Serializer = new JsonSerializer();
    public static List<Athlete> AllAthletes = [];

    [STAThread]
    static void Main()
    {
        var t1 = new Trainer("������ ����", 35, Gender.Male);
        var t2 = new Trainer("�������� �����", 29, Gender.Female);
        var t3 = new Trainer("������ ����", 42, Gender.Male);
        Trainers.AddRange([t1, t2, t3]);

        var a1 = new Athlete("�������� �����", 20, Gender.Male);
        var a2 = new Athlete("��������� ����", 21, Gender.Female);
        var a3 = new Athlete("����� �������", 19, Gender.Male);
        var a4 = new Athlete("������� ��������", 22, Gender.Female);
        var a5 = new Athlete("������� ������", 18, Gender.Male);
        AllAthletes.AddRange([a1, a2, a3, a4, a5]);

        var g1 = new Model.Core.Group("������ 1", t1); g1.AddAthlete(a1); g1.AddAthlete(a2);
        var g2 = new Model.Core.Group("������ 2", t1); g2.AddAthlete(a3);
        var g3 = new Model.Core.Group("������ 3", t2); g3.AddAthlete(a4);
        var g4 = new Model.Core.Group("������ 4", t3); g4.AddAthlete(a5);
        var g5 = new Model.Core.Group("������ 5", t3);

        Groups.AddRange([g1, g2, g3, g4, g5]);

        ApplicationConfiguration.Initialize();
        Application.Run(new Hello_form());
    }
}