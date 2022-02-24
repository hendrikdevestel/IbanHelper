namespace IbanHelper.Validators
{
    internal class France : BaseCountry, ICountry
    {
        public string CountryCode => "FR";

        public int Length => 27;

        /// <summary>
        /// Get the bank name by the code
        /// Source: https://www.quellebanquechoisir.fr/banques/codes.html
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public override string GetBankName(string input)
        {
            var bankCode = input.Substring(4, 5);
            var code = int.Parse(bankCode);
            switch (code)
            {
                case 10008:
                    return "GE Capital équipement finance";
                case 10038:
                    return "Financière immobilière Calyon";
                case 10050:
                    return "Société réunionnaise de financement -Sorefi";
                case 10057:
                    return "Société bordelaise de crédit industriel et commercial - Société bordelaise de C.I.C.";
                case 10088:
                    return "Société de promotion et de participation pour la coopération économique-Proparco";
                case 10096:
                    return "Lyonnaise de banque \"L.B.\"";
                case 10107:
                    return "BRED - Banque populaire";
                case 10108:
                    return "Bayerische landesbank";
                case 10128:
                    return "Intesa Sanpaolo SpA";
                case 10140:
                    return "Caisse de crédit municipal de Marseille";
                case 10160:
                    return "Crédit mobilier de Monaco";
                case 10178:
                    return "Banque Chaix";
                case 10188:
                    return "Banque Chalus";
                case 10206:
                    return "Caisse régionale de crédit agricole mutuel du Nord Est";
                case 10207:
                    return "Banque populaire Rives de Paris";
                case 10218:
                    return "Rabobank Nederland -Rabobank international";
                case 10228:
                    return "Banque Laydernier";
                case 10268:
                    return "Banque Courtois -successeurs de l'ancienne maison Courtois et Cie depuis 1760";
                case 10278:
                    return "Caisse fédérale du crédit mutuel Centre Est Europe";
                case 10323:
                    return "Merrill Lynch international bank limited";
                case 10423:
                    return "The royal bank of Scotland plc";
                case 10468:
                    return "Banque Rhône-Alpes - Groupe Crédit du Nord";
                case 10548:
                    return "Banque de Savoie";
                case 10550:
                    return "Mercedes - Benz financial services France S.A.";
                case 10558:
                    return "Banque Tarneaud";
                case 10638:
                    return "Crédit commercial du Sud-Ouest";
                case 10800:
                    return "Locam - Location automobiles matériels";
                case 10807:
                    return "Banque populaire Bourgogne Franche-Comté";
                case 10820:
                    return "Fructibail";
                case 10890:
                    return "Factobail";
                case 10900:
                    return "Diffuco";
                case 10907:
                    return "Banque populaire du Sud-Ouest";
                case 10918:
                    return "Cholet Dupont";
                case 10920:
                    return "Sodelem";
                case 10930:
                    return "Fonds régional de garantie du Nord-Pas - de - Calais - F.R.G.- Nord - Pas - de - Calais";
                case 10968:
                    return "Banque AIG";
                case 11006:
                    return "Caisse régionale de crédit agricole mutuel de Champagne-Bourgogne";
                case 11008:
                    return "S E B - Skandinaviska enskilda banken AB(publ)";
                case 11018:
                    return "BSI Monaco SAM";
                case 11078:
                    return "Bail immo Nord";
                case 11088:
                    return "UCB Locabail immobilier";
                case 11128:
                    return "Natixis lease";
                case 11138:
                    return "Natixis factor";
                case 11140:
                    return "SEDEF(société européenne de développement du financement)";
                case 11188:
                    return "RCI Banque";
                case 11190:
                    return "Caisse de garantie du logement locatif social";
                case 11206:
                    return "Caisse régionale de crédit agricole mutuel Nord Midi-Pyrénées";
                case 11210:
                    return "Banque de réalisations de gestion et de financement -Régéfi";
                case 11230:
                    return "Laser cofinoga";
                case 11238:
                    return "SwissLife banque privée";
                case 11248:
                    return "ING Lease France S.A.";
                case 11298:
                    return "Sinopia financial services";
                case 11306:
                    return "Caisse régionale de crédit agricole mutuel d'Alpes-Provence";
                case 11307:
                    return "CASDEN Banque Populaire";
                case 11315:
                    return "Caisse d'épargne et de prévoyance Provence-Alpes-Corse";
                case 11378:
                    return "BPN - Banco portugues de negocios, S.A.";
                case 11380:
                    return "C.R.H. - Caisse de refinancement de l'habitat";
                case 11408:
                    return "Banque de Wallis et Futuna";
                case 11425:
                    return "Caisse d'épargne et de prévoyance Normandie";
                case 11438:
                    return "Banque Jean-Philippe Hottinguer et Cie";
                case 11449:
                    return "Banque Thémis";
                case 11468:
                    return "Banque patrimoine et immobilier(B.P.I.)";
                case 11470:
                    return "Natixis coficiné";
                case 11490:
                    return "Interfimo";
                case 11498:
                    return "BNP Paribas wealth management Monaco";
                case 11518:
                    return "State street banque S.A.";
                case 11550:
                    return "Caisse de crédit municipal de Toulouse";
                case 11600:
                    return "CMCIC Lease";
                case 11628:
                    return "Banque du crédit mutuel Ile - de - France - BCMI";
                case 11668:
                    return "Banque de gestion Edmond de Rothschild -Monaco";
                case 11678:
                    return "De Lage Landen leasing S.A.S.";
                case 11689:
                    return "Citibank international plc - Citigroup";
                case 11706:
                    return "Caisse régionale de crédit agricole mutuel Charente - Maritime Deux - Sèvres";
                case 11720:
                    return "HSBC Epargne entreprise(France)";
                case 11729:
                    return "BNP Paribas Guyane";
                case 11748:
                    return "Caixa d'Estalvis de Catalunya";
                case 11749:
                    return "Banque de Saint - Pierre et Miquelon";
                case 11778:
                    return "Crédit du Maroc";
                case 11790:
                    return "Cofacrédit";
                case 11808:
                    return "Banque fédérative du crédit mutuel";
                case 11818:
                    return "GE Commercial distribution finance S.A.";
                case 11830:
                    return "Inter - Coop(2ème du nom)";
                case 11899:
                    return "Banque de l'économie du commerce et de la monétique";
                case 11907:
                    return "Banque populaire du Massif central";
                case 11938:
                    return "AGCO finance SNC";
                case 11960:
                    return "CIT(France) S.A.S.";
                case 11978:
                    return "Factocic";
                case 11989:
                    return "Banque Pouyanne";
                case 11998:
                    return "Bayerische Hypo und Vereinsbank AG - Hypovereinsbank";
                case 11999:
                    return "UBS(Monaco) S.A.";
                case 12006:
                    return "Caisse régionale de crédit agricole mutuel de la Corse";
                case 12008:
                    return "Sofiscop Sud-Est";
                case 12050:
                    return "Crédit moderne Océan Indien";
                case 12088:
                    return "Banca Carige S.p.A - Cassa di risparmio di Genova e Imperia";
                case 12110:
                    return "CMV Médiforce";
                case 12128:
                    return "Société centrale pour le financement de l'immobilier - Socfim";
                case 12135:
                    return "Caisse d'épargne et de prévoyance de Bourgogne Franche-Comté";
                case 12138:
                    return "Caterpillar finance France S.A.";
                case 12149:
                    return "Banque de Polynésie";
                case 12169:
                    return "Banque de la Réunion";
                case 12179:
                    return "Banque BIA";
                case 12198:
                    return "Newedge group";
                case 12206:
                    return "Caisse régionale de crédit agricole mutuel des Côtes-d'Armor";
                case 12239:
                    return "Banque de Tahiti \"B.D.T.\"";
                case 12240:
                    return "Allianz banque";
                case 12248:
                    return "Financière de crédit immobilier de Picardie-Champagne - Ardenne";
                case 12249:
                    return "MediCapital bank plc";
                case 12258:
                    return "Crédit immobilier de France Sud Ouest";
                case 12280:
                    return "Socram banque";
                case 12298:
                    return "Financière régionale de crédit immobilier de Bretagne";
                case 12308:
                    return "Financière régionale de crédit immobilier du Nord / Pas - de - Calais";
                case 12328:
                    return "Crédit immobilier de France Rhône Alpes Auvergne";
                case 12338:
                    return "Crédit Immobilier de France Centre Est";
                case 12348:
                    return "Crédit immobilier de France Bretagne Atlantique";
                case 12368:
                    return "Crédit immobilier de France Sud";
                case 12378:
                    return "Crédit immobilier de France Midi - Pyrénées, financière régionale";
                case 12398:
                    return "Crédit immobilier de France Centre Ouest";
                case 12406:
                    return "Caisse régionale de crédit agricole mutuel Charente - Périgord(Crédit agricole CharentePérigord)";
                case 12418:
                    return "Crédit immobilier de France -Ouest";
                case 12420:
                    return "Caisse de crédit municipal de Reims";
                case 12428:
                    return "Crédit immobilier de France Méditerranée";
                case 12438:
                    return "SOFIAP(Société financière pour l'accession à la propriété)";
                case 12448:
                    return "Barclays bank plc Monaco";
                case 12468:
                    return "Banque cantonale de Genève(France) S.A.";
                case 12478:
                    return "FCE bank plc - Ford credit Europe Ford credit-Jaguar financial services-Volvo car financePRIMUS-Land Rover financial services - Ford financial - Mazda bank";
                case 12489:
                    return "Alfabanque";
                case 12500:
                    return "Société de financement de la meunerie";
                case 12506:
                    return "Caisse régionale de crédit agricole mutuel de Franche-Comté";
                case 12508:
                    return "Banco Guipuzcoano S.A.";
                case 12518:
                    return "Caja de ahorros y Monte de Piedad de Guipuzcoa y San Sebastian -Kutxa";
                case 12548:
                    return "Axa banque";
                case 12549:
                    return "Locindus S.A.";
                case 12558:
                    return "VFS Finance France";
                case 12568:
                    return "Paribas dérivés garantis S.N.C. (PDG)";
                case 12579:
                    return "Banque BCP";
                case 12589:
                    return "Banco BPI";
                case 12619:
                    return "Caixa geral de depositos S.A.";
                case 12658:
                    return "Euler Hermès sfac crédit";
                case 12668:
                    return "Sofrafi";
                case 12670:
                    return "Société financière et mobilière";
                case 12739:
                    return "Crédit foncier de Monaco";
                case 12748:
                    return "Sogefinancement";
                case 12749:
                    return "Natixis bail";
                case 12779:
                    return "BRED Cofilease";
                case 12798:
                    return "UBS";
                case 12818:
                    return "Institut pour le financement du cinéma et des industries culturelles -I.F.C.I.C.";
                case 12828:
                    return "Société financière des entreprises du Gard -Sofigard";
                case 12860:
                    return "Médiatis";
                case 12869:
                    return "Banque Accord";
                case 12879:
                    return "Banque Delubac et Cie";
                case 12898:
                    return "Arca, Banque du Pays basque S.A.";
                case 12906:
                    return "Caisse régionale de crédit agricole mutuel du Finistère";
                case 12938:
                    return "Sud - ouest bail";
                case 12939:
                    return "Banque Dupuy de Parseval";
                case 12978:
                    return "JCB Finance";
                case 13018:
                    return "Batiroc Bretagne -Pays de Loire";
                case 13020:
                    return "Union industrielle et commerciale de France -Unincofra";
                case 13028:
                    return "Société de gestion des fonds de garantie d'outre-mer (Sogefom)";
                case 13038:
                    return "Fidem";
                case 13070:
                    return "CM - CIC Bail";
                case 13078:
                    return "BNP Paribas Guadeloupe";
                case 13088:
                    return "BNP Paribas Martinique";
                case 13098:
                    return "Société financière monégasque de crédit - Cogenec";
                case 13106:
                    return "Caisse régionale de crédit agricole mutuel de Toulouse et du Midi toulousain";
                case 13128:
                    return "Cofica bail";
                case 13135:
                    return "Caisse d'épargne et de prévoyance de Midi-Pyrénées";
                case 13148:
                    return "Dexia CLF Banque";
                case 13149:
                    return "Banque Edel SNC";
                case 13150:
                    return "LixxBail";
                case 13158:
                    return "France active garantie FAG S.A.";
                case 13168:
                    return "Banque PSA finance";
                case 13179:
                    return "Banque Fiducial";
                case 13210:
                    return "Crédit agricole leasing";
                case 13220:
                    return "Société coopérative pour la rénovation et l'équipement du commerce - Socorec";
                case 13248:
                    return "Sofracem";
                case 13259:
                    return "Banque Kolb";
                case 13279:
                    return "Affine";
                case 13298:
                    return "Banque commerciale du marché nord Europe-BCMNE";
                case 13306:
                    return "Caisse régionale de crédit agricole mutuel d'Aquitaine";
                case 13335:
                    return "Caisse d'épargne et de prévoyance Aquitaine Poitou-Charentes";
                case 13338:
                    return "KBL Monaco private bankers";
                case 13360:
                    return "Compagnie générale de garantie";
                case 13368:
                    return "SG private banking(Monaco)";
                case 13369:
                    return "Banque Martin - Maurel";
                case 13379:
                    return "Banque Marze";
                case 13390:
                    return "Union financière pour le développement de l'économie céréalière - Unigrains";
                case 13400:
                    return "FC France";
                case 13408:
                    return "Européenne de cautionnement S.A.";
                case 13428:
                    return "Crédit suisse";
                case 13485:
                    return "Caisse d'épargne et de prévoyance du Languedoc Roussillon";
                case 13488:
                    return "HSBC Private bank(Monaco) S.A.";
                case 13489:
                    return "Banque Nuger";
                case 13490:
                    return "Central expansion";
                case 13506:
                    return "Caisse régionale de crédit agricole mutuel du Languedoc";
                case 13507:
                    return "Banque populaire du Nord";
                case 13528:
                    return "Unicredit SpA";
                case 13529:
                    return "Banque Pelletier";
                case 13538:
                    return "Finifac";
                case 13539:
                    return "Banque Solfea";
                case 13540:
                    return "Financière du Marché Saint-Honoré";
                case 13558:
                    return "Auxifip";
                case 13579:
                    return "Banque Saint-Olive";
                case 13580:
                    return "GE Factofrance";
                case 13606:
                    return "Caisse régionale de crédit agricole mutuel d'Ille-et-Vilaine";
                case 13607:
                    return "Banque populaire Centre Atlantique(2ème du nom)";
                case 13648:
                    return "Bank of Scotland plc";
                case 13678:
                    return "IFN Finance";
                case 13688:
                    return "Isbank GmbH";
                case 13698:
                    return "Ester finance titrisation";
                case 13728:
                    return "Cofiplan S.A.";
                case 13758:
                    return "Prêts et services";
                case 13769:
                    return "Société générale pour le développement des opérations de crédit-bail immobilierSogebail";
                case 13788:
                    return "Idifine";
                case 13798:
                    return "Caisse solidaire";
                case 13807:
                    return "Banque populaire Atlantique";
                case 13825:
                    return "Caisse d'épargne et de prévoyance de Rhône Alpes";
                case 13838:
                    return "CNH Capital Europe";
                case 13858:
                    return "Loisirs finance";
                case 13878:
                    return "Toyota kreditbank GmbH - Toyota France financement";
                case 13880:
                    return "OSEO bretagne";
                case 13888:
                    return "HSBC Factoring(France)";
                case 13906:
                    return "Caisse régionale de crédit agricole mutuel Sud Rhône-Alpes";
                case 13907:
                    return "Banque populaire Loire et Lyonnais";
                case 13928:
                    return "GE Capital financements immobiliers d'entreprise";
                case 13959:
                    return "Agrifigest-Alma - Société financière et agricole de gestion";
                case 13968:
                    return "UCB-Entreprises";
                case 13998:
                    return "Same Deutz-Fahr finance";
                case 13999:
                    return "Banque de Vizille";
                case 14006:
                    return "Caisse régionale de crédit agricole mutuel de la Guadeloupe";
                case 14008:
                    return "Fimipar";
                case 14018:
                    return "Norrsken finance";
                case 14020:
                    return "FL Auto";
                case 14040:
                    return "Goldman Sachs Paris Inc et Cie";
                case 14048:
                    return "Crédit suisse(Monaco)";
                case 14078:
                    return "Caisse de crédit municipal de Lille";
                case 14108:
                    return "John Deere crédit";
                case 14120:
                    return "Legal & general bank(France)";
                case 14139:
                    return "National bank of Pakistan";
                case 14148:
                    return "Eurohypo AG";
                case 14150:
                    return "Banque Robeco";
                case 14178:
                    return "Dexia bail";
                case 14188:
                    return "KBC bail France";
                case 14198:
                    return "Sogelease France";
                case 14206:
                    return "Europay France";
                case 14218:
                    return "Claas financial services";
                case 14228:
                    return "SGB Finance";
                case 14238:
                    return "Nouméa crédit";
                case 14265:
                    return "Caisse d'épargne et de prévoyance Loire Drôme Ardèche";
                case 14288:
                    return "RBS Factor S.A.";
                case 14318:
                    return "BRED Gestion";
                case 14328:
                    return "Segespar finance";
                case 14358:
                    return "Standard chartered Bank(Switzerland) SA";
                case 14378:
                    return "Société financière du porte-monnaie électronique interbancaire";
                case 14380:
                    return "Facet";
                case 14388:
                    return "Dexia Municipal Agency";
                case 14398:
                    return "HSBC Leasing(France)";
                case 14406:
                    return "Caisse régionale de crédit agricole mutuel Val de France";
                case 14408:
                    return "HSBC Real Estate Leasing(France)";
                case 14410:
                    return "Dexia Flobail";
                case 14445:
                    return "Caisse d'épargne et de prévoyance Bretagne-Pays de Loire";
                case 14448:
                    return "Crédit foncier et communal d'Alsace et de Lorraine-Société de crédit foncier \"CFCALSCF\"";
                case 14478:
                    return "Martin Maurel Sella Banque privée - Monaco S.A.M.";
                case 14505:
                    return "Caisse d'épargne et de prévoyance Loire-Centre";
                case 14506:
                    return "Caisse régionale de crédit agricole mutuel Loire - Haute-Loire";
                case 14508:
                    return "ING bank(Monaco) S.A.M.";
                case 14518:
                    return "Fortuneo";
                case 14559:
                    return "ING Direct N.V.";
                case 14568:
                    return "Svenska handelsbanken AB(publ)";
                case 14578:
                    return "Alsolia";
                case 14588:
                    return "Compagnie financière de Bourbon";
                case 14590:
                    return "Cogera société anonyme";
                case 14607:
                    return "Banque populaire provençale et Corse";
                case 14608:
                    return "Banque Safra France SA";
                case 14628:
                    return "Banque du groupe Casino";
                case 14648:
                    return "Capitole Finance - Tofinso";
                case 14649:
                    return "Société financière pour le financement de bureaux et d'usines - Sofibus";
                case 14658:
                    return "CIF EUROMORTGAGE";
                case 14670:
                    return "BMW Finance";
                case 14680:
                    return "BMW Lease";
                case 14688:
                    return "Star Lease";
                case 14690:
                    return "Monabanq.";
                case 14698:
                    return "Coutts & co(Monaco)";
                case 14706:
                    return "Caisse régionale de crédit agricole mutuel Atlantique Vendée";
                case 14707:
                    return "Banque populaire Lorraine Champagne";
                case 14738:
                    return "w-HA S.A.";
                case 14749:
                    return "Société financière de banque - Sofib";
                case 14758:
                    return "Creelia";
                case 14768:
                    return "Natixis financement";
                case 14798:
                    return "Camefi banque";
                case 14800:
                    return "Union notariale financière de crédit - Unofi crédit";
                case 14806:
                    return "Caisse régionale de crédit agricole mutuel Centre Loire";
                case 14818:
                    return "Banca regionale Europea S.p.A.";
                case 14828:
                    return "Caixa Geral de Depositos";
                case 14848:
                    return "General electric financement pacifique S.A.S.";
                case 14868:
                    return "France télécom encaissements";
                case 14869:
                    return "Société Générale asset management banque(SGAM banque)";
                case 14878:
                    return "Groupama banque";
                case 14879:
                    return "Bank of India";
                case 14888:
                    return "Financière Océor";
                case 14889:
                    return "Banque de Nouvelle Calédonie";
                case 14898:
                    return "Banque nationale de Paris Intercontinentale";
                case 14900:
                    return "Caisse de mutualisation des financements - Camufi";
                case 14908:
                    return "Banca popolare di Sondrio(Suisse)";
                case 14918:
                    return "DePfa bank plc";
                case 14928:
                    return "Société financière de paiements";
                case 14940:
                    return "Cofidis";
                case 14948:
                    return "Natixis interépargne";
                case 14958:
                    return "Siemens financial services SAS";
                case 14978:
                    return "Neuflize OBC entreprises";
                case 14988:
                    return "Créfidis";
                case 14989:
                    return "Korea exchange bank";
                case 14998:
                    return "Domofinance";
                case 15000:
                    return "Euronext Paris S.A.";
                case 15008:
                    return "Jyske bank A/S";
                case 15068:
                    return "Pictet & Cie(Europe) SA";
                case 15078:
                    return "MFF";
                case 15128:
                    return "Volkswagen bank GmbH";
                case 15135:
                    return "Caisse d'épargne et de prévoyance de Lorraine Champagne-Ardenne";
                case 15138:
                    return "Océanienne de financement(OFINA)";
                case 15148:
                    return "Mediobanca - banca di credito finanziario S.p.A.";
                case 15149:
                    return "Crédit foncier et communal d'Alsace et de Lorraine-Banque";
                case 15168:
                    return "GE Corporate finance bank S.A.S.";
                case 15178:
                    return "Sogelease BDP";
                case 15208:
                    return "Crédit municipal de Paris";
                case 15218:
                    return "Bibby factor France";
                case 15228:
                    return "Société financière Antilles Guyane - SOFIAG";
                case 15238:
                    return "Eole finance";
                case 15250:
                    return "Sumitomo Mitsui banking corporation Europe limited";
                case 15258:
                    return "The Governor and company of the bank of Ireland(Bank of Ireland)";
                case 15278:
                    return "Créalfi";
                case 15298:
                    return "RBC Dexia investor services bank France SA";
                case 15318:
                    return "Allied irish banks plc(AIB) - AIB Corporate banking France";
                case 15338:
                    return "Disponis";
                case 15348:
                    return "Caisse régionale de crédit maritime mutuel de la région Nord";
                case 15358:
                    return "Caisse régionale de crédit maritime mutuel d'outre mer";
                case 15378:
                    return "Komatsu financial France";
                case 15380:
                    return "Conservateur finance";
                case 15398:
                    return "JP Morgan bank Dublin plc";
                case 15408:
                    return "BNP Paribas Fin'AMS";
                case 15409:
                    return "SOFIRIF - Coopérative financière de la région Ile de France";
                case 15428:
                    return "KBC bail immobilier France SAS";
                case 15429:
                    return "Caisse agricole Crédit Mutuel";
                case 15438:
                    return "Multi accès banque";
                case 15448:
                    return "CNH Financial services";
                case 15449:
                    return "Caisse de Bretagne de crédit agricole mutuel";
                case 15458:
                    return "Joh.Berenberg, Gossler & Co.KG";
                case 15459:
                    return "Caisse fédérale de crédit mutuel du Centre";
                case 15488:
                    return "Projeo";
                case 15489:
                    return "Caisse fédérale du crédit mutuel de Maine-Anjou et Basse-Normandie";
                case 15498:
                    return "MAN financial services SAS";
                case 15508:
                    return "Dresdner bank Monaco";
                case 15518:
                    return "ING real estate finance(France)";
                case 15519:
                    return "Caisse fédérale du crédit mutuel Océan";
                case 15528:
                    return "Lloyds TSB bank plc";
                case 15548:
                    return "Prioris";
                case 15549:
                    return "Crédit mutuel agricole et rural Océan \"C.M.A.R.Océan\"";
                case 15558:
                    return "Fortis mediacom finance";
                case 15568:
                    return "Crédit lift";
                case 15578:
                    return "Hoist kredit AB";
                case 15589:
                    return "Crédit mutuel Arkéa";
                case 15590:
                    return "Fortis commercial finance S.A.S.";
                case 15607:
                    return "Banque populaire Côte d'Azur";
                case 15608:
                    return "Philippine national bank(Europe) PLC";
                case 15610:
                    return "Société anonyme de gestion et de financement - Sagefi";
                case 15618:
                    return "SNS property finance(SNSPF)";
                case 15628:
                    return "CheBanca! SpA - Micos";
                case 15629:
                    return "Caisse fédérale du crédit mutuel Nord Europe";
                case 15638:
                    return "Monte Paschi Monaco S.A.M.";
                case 15648:
                    return "Deutsche leasing France";
                case 15658:
                    return "MoneyGram France";
                case 15668:
                    return "BNP Paribas home loan covered bonds";
                case 15708:
                    return "Ria France";
                case 15728:
                    return "Sefia";
                case 15749:
                    return "Caisse fédérale de crédit mutuel de Loire-Atlantique et du Centre-Ouest";
                case 15778:
                    return "Citibank, N.A.";
                case 15788:
                    return "Veolia P.P.P.Finance";
                case 15798:
                    return "FBN bank(UK) Ltd";
                case 15808:
                    return "Sal Oppenheim JR & Cie KGaA";
                case 15818:
                    return "Binckbank NV";
                case 15828:
                    return "Fortis banque Monaco S.A.M.";
                case 15829:
                    return "Caisse fédérale du crédit mutuel d'Anjou";
                case 15830:
                    return "Novacrédit";
                case 15848:
                    return "CM-CIC covered bonds";
                case 15858:
                    return "Coinstar money transfer SAS";
                case 15868:
                    return "Saxo banque(France)";
                case 15898:
                    return "Crédit Agricole covered bonds";
                case 15899:
                    return "Caisse interfédérale du crédit mutuel sud Europe Méditerranée";
                case 15900:
                    return "Fédéral finance banque";
                case 15908:
                    return "Royal bank of Canada Europe limited";
                case 15918:
                    return "Standard chartered bank";
                case 15920:
                    return "Merrill Lynch capital markets(France) SAS";
                case 15928:
                    return "UBS limited";
                case 15930:
                    return "Natixis paiements";
                case 15938:
                    return "Orange - BNP Paribas services";
                case 15958:
                    return "Banques Populaires covered bonds";
                case 15959:
                    return "Caisse fédérale de crédit mutuel de Normandie";
                case 15960:
                    return "MACSF Financement";
                case 15968:
                    return "Société Générale SCF";
                case 15970:
                    return "Bail-Actea";
                case 15980:
                    return "Bail Entreprises";
                case 15988:
                    return "Cafineo";
                case 15998:
                    return "GCE COVERED BONDS";
                case 16000:
                    return "Diac";
                case 16006:
                    return "Caisse régionale de crédit agricole mutuel du Morbihan";
                case 16008:
                    return "HSH Nordbank AG";
                case 16020:
                    return "Batimap";
                case 16028:
                    return "Key equipment finance nordic AB";
                case 16030:
                    return "IBM France financement";
                case 16038:
                    return "Dexia private bank Monaco S.A.M.";
                case 16048:
                    return "Ebi SA";
                case 16050:
                    return "Bati Lease";
                case 16058:
                    return "HSBC COVERED BONDS(FRANCE)";
                case 16068:
                    return "Landesbank Hessen-Thüringen Girozentrale(Helaba)";
                case 16078:
                    return "BNP Paribas Public Sector SCF";
                case 16088:
                    return "CREDIT MUTUEL ARKEA COVERED BONDS";
                case 16098:
                    return "Banca IFIS";
                case 16100:
                    return "Caisse de crédit municipal de Rouen";
                case 16106:
                    return "Caisse régionale de crédit agricole mutuel de Lorraine";
                case 16108:
                    return "Fideuram bank(Monaco) SAM";
                case 16130:
                    return "S.I.R.C.A.M.";
                case 16159:
                    return "Caisse fédérale du crédit mutuel Antilles-Guyane";
                case 16160:
                    return "Alsabail - Alsacienne de crédit bail immobilier";
                case 16170:
                    return "Caisse de crédit municipal de Boulogne-sur-Mer";
                case 16178:
                    return "La Banque Postale Financement";
                case 16179:
                    return "Crédit mutuel agricole et rural de Loire-Atlantique et du Centre-Ouest";
                case 16180:
                    return "Batiroc Normandie";
                case 16188:
                    return "BPCE";
                case 16190:
                    return "Fructicomi";
                case 16198:
                    return "EFG banque privée";
                case 16200:
                    return "Caisse de crédit municipal de Nice";
                case 16208:
                    return "GE SCF";
                case 16218:
                    return "Spécialiste de l'épargne en ligne";
                case 16238:
                    return "Banques populaires participations";
                case 16248:
                    return "Caisses d'épargne participations";
                case 16270:
                    return "Comptoir financier de garantie - CFG";
                case 16275:
                    return "Caisse d'épargne et de prévoyance Nord France Europe";
                case 16560:
                    return "Caisse de crédit municipal de Bordeaux";
                case 16600:
                    return "Crédit calédonien et tahitien Credical";
                case 16606:
                    return "Caisse régionale de crédit agricole mutuel de Normandie";
                case 16607:
                    return "Banque populaire du Sud";
                case 16640:
                    return "Crédit financier lillois";
                case 16700:
                    return "Cicobail";
                case 16705:
                    return "Caisse d'épargne et de prévoyance d'Alsace";
                case 16706:
                    return "Caisse régionale de crédit agricole mutuel Nord de France";
                case 16707:
                    return "Banque populaire de l'Ouest";
                case 16750:
                    return "Unimat";
                case 16760:
                    return "Franfinance";
                case 16780:
                    return "Natixis funding";
                case 16806:
                    return "Caisse régionale de crédit agricole mutuel de Centre France - Crédit agricole Centre France(3ème du nom)";
                case 16807:
                    return "Banque populaire des Alpes";
                case 16820:
                    return "American Express carte France";
                case 16830:
                    return "Genecal";
                case 16839:
                    return "Financo";
                case 16840:
                    return "Banque Pasche Monaco SAM";
                case 16850:
                    return "Eurofactor";
                case 16870:
                    return "Nord Financement";
                case 16906:
                    return "Caisse régionale de crédit agricole mutuel Pyrénées-Gascogne";
                case 16960:
                    return "Finaref";
                case 16989:
                    return "Cavabanque";
                case 17060:
                    return "Compagnie générale d'affacturage - C.G.A.";
                case 17070:
                    return "Inter Europe conseil";
                case 17100:
                    return "Caisse de crédit municipal de Strasbourg";
                case 17106:
                    return "Caisse régionale de crédit agricole mutuel Sud-Méditerranée(Ariège et PyrénéesOrientales)";
                case 17123:
                    return "IKB deutsche industriebank AG";
                case 17149:
                    return "Caisse régionale de crédit maritime mutuel de Bretagne-Normandie";
                case 17150:
                    return "Caisse de crédit municipal de Toulon";
                case 17169:
                    return "Caisse régionale de crédit maritime mutuel du littoral du sud ouest";
                case 17179:
                    return "Caisse régionale de crédit maritime mutuel de la Méditerranée";
                case 17206:
                    return "Caisse régionale de crédit agricole mutuel Alsace Vosges";
                case 17219:
                    return "Caisse régionale de crédit maritime mutuel Atlantique";
                case 17230:
                    return "CM-CIC Laviolette financement";
                case 17279:
                    return "Société centrale de crédit maritime mutuel";
                case 17290:
                    return "Dexia crédit local";
                case 17429:
                    return "Caisse de crédit agricole mutuel de la Nouvelle-Calédonie et dépendances";
                case 17439:
                    return "Société financière pour le développement de la Réunion(S.O.F.I.D.E.R.)";
                case 17469:
                    return "Banque Socrédo";
                case 17479:
                    return "Coopérative immobilière des îles Saint-Pierre-et-Miquelon(C.I.S.P.M.)";
                case 17499:
                    return "Banque calédonienne d'investissement - B.C.I.";
                case 17510:
                    return "Créatis";
                case 17515:
                    return "Caisse d'épargne et de prévoyance Ile-de-France";
                case 17519:
                    return "Banque centrale de compensation";
                case 17529:
                    return "Francetel - Société française de financement des télécommunications";
                case 17549:
                    return "Natiocrédibail";
                case 17569:
                    return "Compagnie monégasque de banque";
                case 17579:
                    return "Bank Tejarat";
                case 17580:
                    return "Société financière des pays de l'Adour - Sebadour";
                case 17599:
                    return "Blom bank France";
                case 17607:
                    return "Banque populaire d'Alsace";
                case 17619:
                    return "Banque de l'Europe méridionale - Bemo";
                case 17620:
                    return "Caisse de crédit municipal de Nîmes";
                case 17629:
                    return "Commerzbank AG";
                case 17649:
                    return "Banque Revillon";
                case 17660:
                    return "Généfim";
                case 17679:
                    return "Société de banque et d'expansion - S.B.E. (2ème du nom)";
                case 17730:
                    return "Société auxiliaire des industries alimentaires(Auxindal)";
                case 17779:
                    return "Banque SBA";
                case 17789:
                    return "Deutsche bank AG";
                case 17799:
                    return "Bank Sepah";
                case 17806:
                    return "Caisse régionale de crédit agricole mutuel Centre-Est";
                case 17807:
                    return "Banque populaire Occitane";
                case 17839:
                    return "GMAC Banque";
                case 17863:
                    return "Hypo real estate bank AG";
                case 17869:
                    return "Compagnie de banques internationales de Paris";
                case 17906:
                    return "Caisse régionale de crédit agricole mutuel de l'Anjou et du Maine";
                case 17919:
                    return "Qatar national bank";
                case 17939:
                    return "BNP Paribas Nouvelle-Calédonie";
                case 17959:
                    return "Banque Michel Inchauspé - BAMI";
                case 17973:
                    return "Exane derivatives";
                case 17979:
                    return "Europe arab bank PLC";
                case 17989:
                    return "National bank of Abu Dhabi";
                case 18000:
                    return "Cofitem-Cofimur";
                case 18020:
                    return "BNP Paribas Factor";
                case 18025:
                    return "Caisse d'épargne et de prévoyance de Picardie";
                case 18029:
                    return "BNP Paribas Personal Finance";
                case 18040:
                    return "Batifranc";
                case 18049:
                    return "BSI-Ifabanque SA";
                case 18050:
                    return "Caisse de crédit municipal de Lyon";
                case 18053:
                    return "Fortis investment finance";
                case 18059:
                    return "HSBC bank plc";
                case 18079:
                    return "Société générale de banque aux Antilles";
                case 18089:
                    return "Bank Audi Saradar France";
                case 18106:
                    return "Caisse régionale de crédit agricole mutuel des Savoie - Crédit agricole des Savoie";
                case 18129:
                    return "CACEIS Bank";
                case 18160:
                    return "Caisse de crédit municipal de Nancy";
                case 18169:
                    return "Crédit suisse(France)";
                case 18179:
                    return "Dresdner bank gestions France";
                case 18189:
                    return "Compagnie générale de crédit aux particuliers - Crédipar";
                case 18190:
                    return "OSEO garantie";
                case 18206:
                    return "Caisse régionale de crédit agricole mutuel de Paris et d'Ile-de-France";
                case 18209:
                    return "Exane finance";
                case 18230:
                    return "Sofiprotéol";
                case 18280:
                    return "Unifergie - Union pour le financement des économies d'énergie";
                case 18289:
                    return "Habib bank limited";
                case 18306:
                    return "Caisse régionale de crédit agricole mutuel Normandie-Seine";
                case 18315:
                    return "Caisse d'épargne et de prévoyance Côte d'Azur";
                case 18319:
                    return "Société générale calédonienne de banque SGCB";
                case 18320:
                    return "UCB Bail";
                case 18329:
                    return "State bank of India";
                case 18359:
                    return "OSEO financement";
                case 18370:
                    return "Banque Finama";
                case 18429:
                    return "Norbail Sofergie";
                case 18439:
                    return "Natioénergie - Société pour le financement des économies d'énergie (Sofergie)";
                case 18450:
                    return "Caisse de crédit municipal de Roubaix";
                case 18470:
                    return "Caisse de crédit municipal de Nantes";
                case 18520:
                    return "Groupe Sofemo";
                case 18529:
                    return "Mizuho corporate bank limited Paris branch";
                case 18530:
                    return "Natiocredimurs, société en nom collectif";
                case 18540:
                    return "Corsabail";
                case 18569:
                    return "Banque Misr";
                case 18589:
                    return "Caisse française de développement industriel - C.F.D.I.";
                case 18590:
                    return "Bull finance";
                case 18609:
                    return "Caisse centrale du crédit immobilier de France-3CIF";
                case 18610:
                    return "Compagnie pour la location de véhicules - CLV";
                case 18629:
                    return "HSBC Private bank France";
                case 18640:
                    return "W Finance";
                case 18650:
                    return "SOFISCOP";
                case 18660:
                    return "Cofiloisirs - Compagnie pour le financement des loisirs";
                case 18669:
                    return "Rothschild et compagnie banque";
                case 18689:
                    return "Fransabank France S.A.";
                case 18706:
                    return "Caisse régionale de crédit agricole mutuel Brie Picardie";
                case 18707:
                    return "Banque populaire Val de France(2ème du nom)";
                case 18709:
                    return "Crédit immobilier de France Ile de France";
                case 18715:
                    return "Caisse d'épargne et de prévoyance d'Auvergne et du Limousin";
                case 18719:
                    return "Banque française commerciale Océan Indien - B.F.C.Océan Indien";
                case 18729:
                    return "Banque française commerciale Antilles-Guyane - B.F.C.Antilles-Guyane";
                case 18730:
                    return "Océor lease Nouméa";
                case 18739:
                    return "ABN Amro bank N.V.";
                case 18750:
                    return "Monacrédit";
                case 18759:
                    return "EFG Bank(Monaco)";
                case 18769:
                    return "Bank of China limited";
                case 18780:
                    return "Sofid - Société financière de développement";
                case 18789:
                    return "Mega international commercial bank Co, Ltd";
                case 18809:
                    return "Soficarte";
                case 18829:
                    return "Banque commerciale pour le marché de l'entreprise - BCME";
                case 18839:
                    return "B.F.T. - Banque de financement et de trésorerie";
                case 18869:
                    return "Banque fédérale mutualiste -B.F.M.";
                case 18879:
                    return "Banque monétaire et financière - B.M.F.";
                case 18889:
                    return "Cortal Consors";
                case 18890:
                    return "Société martiniquaise de financement - Somafi";
                case 18900:
                    return "Société guadeloupéenne de financement - Soguafi";
                case 18919:
                    return "Banque privée 1818";
                case 18930:
                    return "Compagnie financière du littoral - Cofilit";
                case 18950:
                    return "Caisse de crédit municipal d'Avignon";
                case 18979:
                    return "ABC international bank plc";
                case 18989:
                    return "Aareal Bank France";
                case 19000:
                    return "Société auxiliaire d'études et d'investissements mobiliers - Investimo";
                case 19020:
                    return "Crédit moderne Antilles Guyane";
                case 19063:
                    return "Landesbank Saar(SAARLB)";
                case 19069:
                    return "KBL Richelieu banque privée";
                case 19089:
                    return "Banque d'Orsay";
                case 19106:
                    return "Caisse régionale de crédit agricole mutuel Provence-Côte d'Azur (Alpes de HauteProvence-Alpes-maritimes-Var)";
                case 19110:
                    return "Océor lease Tahiti";
                case 19139:
                    return "Ménafinance";
                case 19150:
                    return "Crédit et services financiers - Creserfi";
                case 19169:
                    return "Finamur";
                case 19189:
                    return "Société de crédit à la consommation Camif - C2C";
                case 19190:
                    return "Oceor lease Réunion";
                case 19229:
                    return "Banco de Sabadell";
                case 19230:
                    return "Crédit logement";
                case 19239:
                    return "Natixis transport finance";
                case 19249:
                    return "Généfimmo";
                case 19250:
                    return "Compagnie générale de location d'équipements \"C.G.L.\"";
                case 19259:
                    return "Sogefimur";
                case 19269:
                    return "Génébanque";
                case 19300:
                    return "Barclays bail";
                case 19339:
                    return "GCE bail";
                case 19340:
                    return "Société financière pour l'expansion de la distribution - Sofinedis";
                case 19389:
                    return "Paricomi";
                case 19399:
                    return "Antin-Bail";
                case 19406:
                    return "Caisse régionale de crédit agricole mutuel de la Touraine et du Poitou";
                case 19460:
                    return "Sofax banque";
                case 19479:
                    return "Société coopérative et mutuelle de la région P.A.C.A. - \"S.O.M.U.P.A.C.A.\"";
                case 19506:
                    return "Caisse régionale de crédit agricole mutuel du Centre Ouest";
                case 19519:
                    return "Gedex distribution";
                case 19530:
                    return "Crédit agricole asset management group - CAAM GROUP";
                case 19560:
                    return "Société de garantie coopérative et mutuelle des industries métallurgiques,électriques et connexes de la région Rhône-Alpes - Somudimec";
                case 19570:
                    return "Union financière de France banque";
                case 19649:
                    return "OSEO garantie regions";
                case 19730:
                    return "Banque Nomura France";
                case 19806:
                    return "Caisse régionale de crédit agricole mutuel de la Martinique et de la Guyane";
                case 19825:
                    return "Caisse d'épargne et de prévoyance de Nouvelle-Calédonie";
                case 19850:
                    return "Compagnie de gestion et de prêts - C.D.G.P.";
                case 19870:
                    return "Société des paiements Pass - S2P";
                case 19906:
                    return "Caisse régionale de crédit agricole mutuel de la Réunion";
                case 19930:
                    return "Cinergie";
                case 19940:
                    return "Natixis Energéco";
                case 19990:
                    return "Sogefinerg-Société générale pour le financement des investissements économisant l'énergie";
                case 20019:
                    return "Société pour le financement du développement industriel en Poitou-Charentes \"Sofindi\"";
                case 20041:
                    return "La Banque Postale";
                case 20280:
                    return "Société de caution mutuelle des professions immobilières et foncières \"Socaf\"";
                case 20290:
                    return "Caution mutuelle du crédit immobilier de France - CM-CIF";
                case 20380:
                    return "Société de caution mutuelle des négociants en céréales/oléagineux et protéagineux - Caution Grainol";
                case 21120:
                    return "Lloyds TSB bank plc";
                case 21339:
                    return "Fortis lease";
                case 21349:
                    return "Parilease";
                case 21570:
                    return "Société financière de la N.E.F.";
                case 21619:
                    return "Sophia-Bail";
                case 21670:
                    return "CP Or devises";
                case 21859:
                    return "Bourgogne garantie";
                case 21990:
                    return "Banque Leonardo";
                case 22840:
                    return "Scania finance France";
                case 22910:
                    return "Transolver finance S.A.";
                case 22970:
                    return "Epargne crédit des militaires(E.C.M.)";
                case 23380:
                    return "Dexia C.L.F.régions bail";
                case 23779:
                    return "Byblos bank Europe";
                case 23890:
                    return "Attijariwafa bank europe";
                case 23930:
                    return "Sogama - crédit associatif";
                case 24280:
                    return "Oddo corporate finance";
                case 24349:
                    return "Banque J.Safra(Monaco) SA";
                case 24599:
                    return "Barclays France";
                case 24659:
                    return "Banque Chabrières";
                case 24850:
                    return "Sal.Oppenheim(France)";
                case 25080:
                    return "Axa banque financement";
                case 25609:
                    return "Société de caution mutuelle des entreprises de travail temporaire \"Socamett\"";
                case 25709:
                    return "Caisse de garantie de l'immobilier";
                case 25790:
                    return "Parifergie";
                case 26269:
                    return "Sogal-Société de garantie des entreprises laitières agricoles et alimentaires - SogalSocamuel";
                case 26310:
                    return "Sygma banque";
                case 26630:
                    return "Compagnie financière de Paris";
                case 26679:
                    return "Société interprofessionnelle artisanale de garantie d'investissements - S.I.A.G.I.";
                case 26819:
                    return "Caisse mutuelle de garantie des industries mécaniques et transformatrices des métaux \"CMGM\"";
                case 27180:
                    return "Norbail-Immobilier";
                case 27589:
                    return "Oudart S.A.";
                case 27800:
                    return "KBC bank";
                case 27910:
                    return "Réunibail";
                case 28310:
                    return "Genecomi";
                case 28570:
                    return "Caisse de crédit municipal de Dijon";
                case 28860:
                    return "Foncaris";
                case 29450:
                    return "Dexia CLF Immo";
                case 30002:
                    return "Crédit lyonnais";
                case 30003:
                    return "Société générale";
                case 30004:
                    return "BNP Paribas";
                case 30006:
                    return "Crédit Agricole S.A.";
                case 30007:
                    return "Natixis";
                case 30027:
                    return "Banque Scalbert Dupont - CIN";
                case 30047:
                    return "Crédit industriel de l'Ouest";
                case 30051:
                    return "Compagnie de financement foncier";
                case 30056:
                    return "HSBC France";
                case 30066:
                    return "Crédit industriel et commercial - CIC";
                case 30076:
                    return "Crédit du Nord";
                case 30077:
                    return "Société marseillaise de crédit";
                case 30087:
                    return "Banque CIC Est";
                case 30258:
                    return "Banque du bâtiment et des travaux publics - BTP banque";
                case 30438:
                    return "ING Belgium SA, succursale en France";
                case 30478:
                    return "Monte Paschi banque S.A.";
                case 30488:
                    return "Fortis banque France";
                case 30568:
                    return "Banque Transatlantique S.A.";
                case 30588:
                    return "Barclays bank plc";
                case 30628:
                    return "JPMorgan Chase bank, National Association";
                case 30748:
                    return "Lazard frères banque";
                case 30758:
                    return "UBS(France) S.A.";
                case 30788:
                    return "Banque Neuflize OBC";
                case 30958:
                    return "BNP Paribas Lease Group";
                case 31489:
                    return "Calyon";
                case 40168:
                    return "Banque de Bretagne";
                case 40198:
                    return "BNP Paribas wealth management";
                case 40238:
                    return "VTB Bank(France) S.A.";
                case 40398:
                    return "Banque internationale de commerce - BRED";
                case 40618:
                    return "Boursorama";
                case 40978:
                    return "Banque Palatine";
                case 41139:
                    return "Banco do Brasil";
                case 41189:
                    return "Banco Bilbao Vizcaya Argentaria(BBVA)";
                case 41199:
                    return "CIC Iberbanco";
                case 41219:
                    return "Bank of America national association";
                case 41239:
                    return "Bank Polska Kasa Opieki Spolka Akcyjna";
                case 41249:
                    return "The bank of Tokyo - Mitsubishi UFJ Ltd";
                case 41259:
                    return "Bank Melli Iran";
                case 41329:
                    return "BNP Paribas securities services";
                case 41439:
                    return "Banque Chaabi du Maroc";
                case 41539:
                    return "Sofinco";
                case 41599:
                    return "Banque française";
                case 41629:
                    return "WestLB AG";
                case 41639:
                    return "National bank of Kuwait(International) plc";
                case 41829:
                    return "Al Khaliji France";
                case 41839:
                    return "Banque des Antilles françaises \"B.D.A.F.\"";
                case 41919:
                    return "BNP Paribas Réunion";
                case 42349:
                    return "Caisse centrale de réescompte";
                case 42529:
                    return "La Compagnie financière Edmond de Rothschild banque";
                case 42559:
                    return "Crédit coopératif";
                case 42649:
                    return "Banque Travelex S.A.";
                case 42799:
                    return "GE Money bank";
                case 42959:
                    return "Electro banque";
                case 43030:
                    return "Banque Degroof & Philippe";
                case 43199:
                    return "Crédit Foncier de France";
                case 43629:
                    return "Société anonyme de crédit à l'industrie française (C.A.L.I.F.)";
                case 43659:
                    return "Banque Espirito Santo et de la Vénétie";
                case 43789:
                    return "Quilvest banque privée";
                case 43799:
                    return "Banque de gestion privée Indosuez - BGPI";
                case 43849:
                    return "Union tunisienne de banques";
                case 43899:
                    return "Union de banques arabes et françaises - U.B.A.F.";
                case 44149:
                    return "Banque d'escompte";
                case 44269:
                    return "Bank Saderat Iran";
                case 44319:
                    return "Banque privée européenne";
                case 44449:
                    return "LixxCrédit";
                case 44729:
                    return "Banco Santander SA";
                case 45129:
                    return "Agence française de développement";
                case 45539:
                    return "Caisse centrale du crédit mutuel";
                case 45720:
                    return "Fortis banque - Fortis bank, succursale en France";
                case 45850:
                    return "Oddo et cie";
                case 50140:
                    return "CMP-Banque";
                case 60080:
                    return "Société alsacienne de développement et d'expansion \"SADE\"";
                case 60220:
                    return "Caisse de développement de la Corse";
                case 62108:
                    return "EXPANSO - La Société pour le développement régional";
                default:
                    return "Unknown";
            }

        }
    }
}

