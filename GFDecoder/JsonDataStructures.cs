﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFDecoder
{
    public class enemy_standard_attribute_info
    {
        public int level;
        public double maxlife;
        public double dodge;
        public double pow;
        public double hit;
        public double armor_piercing;
        public double armor;
        public double shield;
        public double def;
        public double def_break;
    }

    public class enemy_team_info
    {
        public int id;
        public int enemy_leader;
        public string correction_belong;
        public string correction_turn;
        public string limit_guns;
        public string limit_equips;
        public int ai;
        public string ai_content;
        public string reward_gun_pool;
        public string equip_s_probability;

        public List<int> member_ids = new List<int>();
        public int spot_id = 0;
        public List<string> drops_limit = new List<string>();
        public int[] drops_reg_count = new int[5];
        public List<int> lv_up_array = new List<int>();
        public bool no_map = false;
        public bool is_night = false;
    }

    public class enemy_in_team_info
    {
        public int id;
        public int enemy_team_id;
        public int enemy_character_type_id;
        public int coordinator_x;
        public int coordinator_y;
        public int level;
        public int number;
        public int is_advance;
        public int def_percent;

        public static enemy_in_team_info CopyFrom(enemy_in_team_info from, int id)
        {
            enemy_in_team_info to = (enemy_in_team_info)from.MemberwiseClone();
            to.id = id;
            return to;
        }
    }

    public class enemy_character_type_info
    {
        public int id;
        public int type;
        public string name;
        public string code;
        public int maxlife;
        public int pow;
        public int hit;
        public int dodge;
        public int range;
        public int speed;
        public int number;
        public int angle;
        public int armor_piercing;
        public int armor;
        public int shield;
        public int rate;
        public int boss_hp;
        public int def;
        public int def_break;
        public float debuff_resistance;
        public int level;
        public string character;
        public int special_attack;
        public int normal_attack;
        public string passive_skill;
        public float effect_ratio;
        public string unable_buff_type;
        public string voice;
    }

    public class trial_info
    {
        public int id;
        public int enemy_team_id;
        public int enemy_level;
        public string enemy_type;
        public int is_night;
        public int reward_voucher;
        public int prize_id;
    }

    public class mission_info
    {
        public int id;
        public int duplicate_type;
        public int coin_type;
        public int campaign;
        public int sub;
        public int if_emergency;
        public int endless_mode;
        public int special_type;
        public string name;
        public int difficulty;
        public int exp_parameter;
        public string type;
        public int enemy_ai_type;
        public int win_turn;
        public string win_spot_id;
        public string special_spot_id;
        public int expect_enemy_die_num;
        public int expect_gun_die_num;
        public int expect_turn;
        public string boss_team_id;
        public int turn_duration;
        public int costbp;
        public int coin_ap;
        public int turn_limit;
        public string limit_gun_pool;
        public int limit_team;
        public string map_res_name;
        public string map_information;
        public int is_hide;
        public int is_snow;
        public string adaptive_gun;
        public string fog_length;
        public string fog_color;
        public string limit_equip_pool;
        public string draw_event_s_id;
        public int support_available;
        public int enemy_quickmove;
        public int expect_defend_line_turn;
        public string expect_hostage_num;
        public string title_logo;
        public string random_line_spot;
        public int order;
        public string reinforce_ally_team;
        public int reinforce_ally_turn;
        public string reinforce_ally_spot;
        public string ally_boss_team_id;
        public string ally_code;
        public string supply_parameter;
        public string drop_mission_key;
        public string close_missions;
        public int mission_group_id;
        public string mission_group_draw_event;
        public string open_mission_keys;
        public string mission_describe;
        public string force_type;
        public string round_config;
        public string color_change_type;
        public string color_change_number;
        public string color_change_result;
        public string spot_reset;
        public string draw_code;
        public int reset_drop_key_once;
        public string close_mission_control;
        public int limit_squad;

        public string index_text = "X-X";
        public int index_sort = 0;
        public List<int> spot_ids = new List<int>();
        public Dictionary<int, int> enemy_team_count = new Dictionary<int, int>();
        public int map_all_width = 0;
        public int map_all_height = 0;
        public int map_eff_width = 0;
        public int map_eff_height = 0;
        public int map_offset_x = 0;
        public int map_offset_y = 0;
        public List<int> win_objs = new List<int>();
        public bool has_medal_obj = false;
        public bool no_map = false;
    }

    public class spot_info
    {
        public int id;
        public int mission_id;
        public int type;
        public int special_eft;
        public string route;
        public int coordinator_x;
        public int coordinator_y;
        public int enemy_team_id;
        public int ally_team_id;
        public int belong;
        public int random_get;
        public int map_type;
        public string curve_control;
        public string active_cycle;
        public int durability;
        public string map_route;
        public string map_code;
        public string hostage_info;
        public string building_id;

        public Dictionary<int, int> route_types = new Dictionary<int, int>(); //2 = two way, 1 = one way
    }

    public class ally_team_info
    {
        public int id;
        public string code;
        public string ui_image_icon;
        public string name;
        public string guns;
        public int fairy;
        public int enemy_team_id;
        public int initial_type;
        public string ai;
        public string ai_content;
        public string betray_condition;
        public string betray_number;
        public string betray_result;
        public string transform_condition;
        public string transform_number;
        public string transform_result;
        public string icon;

        public int leader_id = 0;
    }

    public class gun_in_ally_info
    {
        public int id;
        public int gun_id;
        public int gun_level;
        public int location;
        public int position; // order (from top left):\n 3 6 9\n2 5 8\n 1 4 7
        public int life;
        public int pow;
        public int hit;
        public int dodge;
        public int rate;
        public int skill1;
        public int skill2;
        public int number;
        public int equip1;
        public int equip2;
        public int equip3;
        public int skin;
        public int eat_lv;
        public int if_modification;
    }

    public class game_config_info
    {
        public string parameter_name;
        public string parameter_type;
        public string parameter_value;
        public int client_require;
    }

    public class gun_info
    {
        public int id;
        public string name;
        public string en_name;
        public string code;
        //public string introduce;
        //public string en_introduce;
        public int rank;
    }

    public class equip_info
    {
        public int id;
        public string name;
        public int rank;
    }

    public class building_info
    {
        public int id;
        public int defender;
        public int defender_upper;
        public int belong;
        public int hold_belong;
        public string mission_skill;
        public string battle_skill;
        public string condition;
        public string is_destroy;
        public int is_rebuild;
        public int draw_event;
        public string name;
        public string code;
        public string shifting_spot;
        public string shifting_team;
        public string battle_assist_range;
        public string performance_skill;
        public int show_info;
    }

    public class operation_info
    {
        public int id;
        public int campaign;
        public string name;
        //public string description;
        public int duration;
        public int mp;
        public int ammo;
        public int mre;
        public int part;
        public string item_pool;
        public int team_leader_min_level;
        //public int guntype1_min;
        //public int guntype2_min;
        //public int guntype3_min;
        //public int guntype4_min;
        //public int guntype5_min;
        //public int guntype6_min;
        //public int guntype7_min;

        public List<int> item_list = new List<int>();
        public int total = 0;
        public double duration_h = 0;
        public double mp_h;
        public double ammo_h;
        public double mre_h;
        public double part_h;
    }

    public class theater_info
    {
        public int id;
        public string name;
        public string area;
    }

    public class theater_area_info
    {
        public int id;
        public string name;
        public string enemy_group;
        public string enemy_lv;
        public string enemy_score;
        public string occupied_enemy_lv;
        public string boss;
        public string advantage_gun;
        public int area_mission_id;
    }

    /** Custom Supplymental Data **/
    public class event_campaign_info
    {
        public int id;
        public string name;
        public int[] campaign;
    }

    public class campaign_info
    {
        public int id;
        public int type; // 0=main, 1=event, 2=simulation, 3=theater
        public string name;
        public List<int> mission_ids = new List<int>();

        public campaign_info(int id, int type, string name)
        {
            this.id = id;
            this.type = type;
            this.name = name;
        }
    }

    public class mission_extra_enemy_team_info
    {
        public int enemy_team_id_from;
        public int enemy_team_id_to;
        public int mission_id;
    }

}
