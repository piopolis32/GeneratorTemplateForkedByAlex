﻿using PROTv0._1;


var mas = new MyData[]{
    new("элементами дороги",0,false,false),
    new("Какие из перечисленных элементов являются элементами дороги?",1,false,false),
    new("Какие из перечисленных элементов(при их наличии) являются элементами дороги?",1,false,false),
    new("Что является элементом дороги?",1,false,false),
    new("Что входит в элементы дороги?",1,false,false),
    new("Какие из перечисленных элементов не являются элементами дороги?",1,true,false),
    new("Какие из перечисленных элементов(при их наличии) не являются элементами дороги?",1,true,false),
    new("Что не является элементом дороги?",1,true,false),
    new("Что не входит в элементы дороги?",1,true,false),
    new("Разделительные полосы",2,false,true),
    new("Разделительные зоны",2,false,true),
    new("Трамвайные пути",2,false,true),
    new("Островки безопасности",2,false,true),
    new("Островки, выделенные только разметкой",2,false,false),
    new("Проезжие части",2,false,true),
    new("Тротуары",2,false,true),
    new("Обочины",2,false,true),
    new("Пешеходные дорожки",2,false,true),
    new("Велосипедные дорожки",2,false,true),
    new("Обособленные велосипедные дорожки",2,false,false),
    new("Пешеходные переходы",2,false,false),
    new("Велосипедные переезды",2,false,false),
    new("Перекрестки",2,false,false),
    new("Кюветы", 2, false, false),
    new("Обрезы", 2, false, false),
    new("Придорожные насаждения", 2, false, false),
    new("Кустарник при дороге", 2, false, false),
    new("Дорожки для всадников", 2, false, false),

    };
Random n = new Random();
Generator.GenerateGroup(mas,5,8);






