<template>
    <header class=" mx-auto">
        <div class="headerContainer h-[210px] w-full ">
            <div class="w-full max-w-6xl mx-auto  h-[138px] flex ">
                <!--logo-->
                <div class="haaderLogo flex flex-wrap w-full">
                    <div>
                        <img src='@/assets/logo.svg' alt='Logo'>
                    </div>
                    <div class="p-2 flex items-center">
                        <div class="">
                            <span class="text-[#333] text-3xl font-medium mb-5 block tracking-[0.2em]">Volunteer</span>
                            <span class="text-[#FF993A] text-4xl font-semibold">doctors</span>
                        </div>
                    </div>
                </div>
                <!--login-->
                <div class="w-full flex justify-end flex-wrap  mr-2 ">
                    <div class="w-full self-center flex justify-end items-center py-2">
                        <div class=" ml-6 h-6 flex items-center justify-end" v-for="(item, index) in a" :key="index">
                            <span class="w-5 h-5"><img :src=item.icon_url alt=''></span>
                            <span class="ml-1 text-2xl font-medium">
                                {{ item.title }}
                            </span>
                        </div>
                    </div>

                    <div class="w-full mb-3 flex justify-end items-end space-x-6">
                        <div v-for="(item, index) in  social_network_icons " :key="index"><img :src=item.icon_url alt=''>
                        </div>
                    </div>
                </div>

            </div>
            <div class="w-full h-[72px] border-[3px] border-y-[#333]">
                <nav class="h-full flex items-center">
                    <div class="container mx-auto px-4">
                        <ul class="flex justify-around items-center h-full">
                            <li><router-link class="text-black text-3xl font-medium" to="/">
                                Thông tin
                            </router-link></li>
                            <li><router-link class="text-black text-3xl font-medium" to="/mission">
                                Nhiệm vụ
                            </router-link></li>
                            <li><router-link class="text-black text-3xl font-medium" to="/demo1">
                                Tình nguyện viên
                            </router-link></li>
                            <li><router-link class="text-black text-3xl font-medium" to="/demo2">
                                Tin tức
                            </router-link></li>
                        </ul>
                    </div>
                </nav>
            </div>

        </div>


    </header>
</template>

<script>
export default {
    setup() {
        var a = [
            {
                icon_url: "src/assets/icons/PhoneIcon.svg",
                title: "0987654321"
            },
            {
                icon_url: "src/assets/icons/EmailIcon.svg",
                title: "Email"
            }, {
                icon_url: "src/assets/icons/Login.svg",
                title: "Login"
            }
        ];
        const social_network_icons = [
        {
                icon_url: "src/assets/icons/facebookIcon.svg",

            },
            
            {
                icon_url: "src/assets/icons/InstaIcon.svg",

            },
            {
                icon_url: "src/assets/icons/inIcon.svg",

            }, 
            {
                icon_url: "src/assets/icons/YoutubeIcon.svg",

            }
        ]
        return {
            a, social_network_icons
        }
    }
}
</script>

<style scoped></style>